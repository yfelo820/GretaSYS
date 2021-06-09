using Greta.BO.Api.Controllers;
using Greta.BO.Api.Entities;
using Greta.BO.Api.Sqlserver;
using Greta.BO.Api.Sqlserver.Repository;
using Greta.BO.BusinessLogic.Exceptions;
using Greta.BO.BusinessLogic.Service;
using Greta.Sdk.EFCore.Middleware;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Greta.BO.Api.Test.Service
{
    public class CategoryServiceTest
    {
        ILogger<CategoryController> logger;
        ILogger<CategoryService> loggerService;
        AuthenticateUser<string> authenticateUser = null;
        CategoryRepository repository = null;
        CategoryService service = null;
        public CategoryServiceTest()
        {
            logger = Mock.Of<ILogger<CategoryController>>();
            loggerService = Mock.Of<ILogger<CategoryService>>();

            authenticateUser = new AuthenticateUser<string>()
            {
                Name = "Greta.BO.Api",
                UserId = new Guid().ToString(),
                IsAuthenticated = true,
                IsApplication = false,
            };
            var builder = new DbContextOptionsBuilder<SqlServerContext>();
            var options = builder.UseInMemoryDatabase(nameof(CategoryServiceTest)).Options;
            var context = new SqlServerContext(options);

            repository = new CategoryRepository(authenticateUser, context);
            service = new CategoryService(repository, this.loggerService);
        }



        [Fact]
        public void Get_NormalCall_ResultOk()
        {
            // Arrange

            // Act
            var result = service.Get().Result;

            // Assert
            Assert.True(result.Count >= 0);
        }

        [Fact]
        public async Task GetId_NormalCall_ResultSameAsInsert()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Category Name ",
                Description = "Category Description "
            };
            var id = await repository.CreateAsync(category);
            // Act
            var result = await service.Get(id);

            // Assert
            Assert.Equal(id, result.Id);
        }

        [Fact]
        public async Task GetId_CallNotExist_ReturnNull()
        {
            // Arrange
            long id = 1000;
            // Act
            var result = await service.Get(id);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetId_CallNegative_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await service.Get(id);
            });

            // Assert
            Assert.Equal("Id parameter out of bounds.", exception.Message);
        }

        [Fact]
        public async Task Delete_NormalCall_ResultSucess()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Category Name ",
                Description = "Category Description "
            };
            var id = await repository.CreateAsync(category);

            // Act
            var result = await service.Delete(id);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Delete_CallWithNotFound_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await service.Delete(id);
            });

            // Assert
            Assert.Equal("Id parameter out of bounds.", exception.Message);
        }

        [Fact]
        public async Task ChangeState_CallWithNotFound_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await service.ChangeState(id, true);
            });

            // Assert
            Assert.Equal("Id parameter out of bounds.", exception.Message);
        }

        [Fact]
        public async Task ChangeState_NormalCall_ResultTrue()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Category Name ",
                Description = "Category Description "
            };
            var id = await repository.CreateAsync(category);

            // Act
            var result = await service.ChangeState(id, true);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Page_OutRange_ThrowBusinessLogicException()
        {
            // Arrange
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await service.Page(0, 0);
            });

            // Assert
            Assert.Equal("Page parameter out of bounds.", exception.Message);
        }

        [Fact]
        public async Task Page_NormalCall_ResultCorrectAndSameData()
        {
            // Arrange
            var element = await repository.GetEntity<Category>().FirstOrDefaultAsync<Category>();
            if (element != null)
            {
                await repository.DeleteAsync(element.Id);
            }
            var cats = new List<Category>();
            for (var i = 0; i < 100; i++)
            {
                var category = new Category()
                {
                    Name = "Category Name " + i,
                    Description = "Category Description " + i
                };
                cats.Add(category);
            }

            var id = await repository.CreateRangeAsync<Category>(cats);

            // Act
            var result = await service.Page(1, 10);

            // Assert
            Assert.Equal(10, result.Data.Count);
            //Assert.Equal(id[0].Id, (result as Pager<Category>).Data[0].Id);
        }


        [Fact]
        public async Task Post_NormalCall_ResultSameId()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Category Name ",
                Description = "Category Description "
            };

            // Act
            var result = await service.Post(category);

            // Assert
            Assert.Equal(category.Name, (result as Category).Name);
        }

        [Fact]
        public async Task Put_NormalCall_ChangeSuccess()
        {
            // Arrange
            var category = new Category()
            {
                Name = "Category Name ",
                Description = "Category Description "
            };
            var id = await repository.CreateAsync(category);

            var categoryUpdate = new Category()
            {
                Id = id,
                Name = "Category Name Update",
                Description = "Category Description Update",
                State = true
            };

            // Act
            var result = await service.Put(id, categoryUpdate);

            // Assert
            Assert.True((bool)result);
        }

        [Fact]
        public async Task Put_CallWithNotFound_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            var categoryUpdate = new Category()
            {
                Name = "Category Name Update",
                Description = "Category Description Update",
                State = true
            };
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await service.Put(id, categoryUpdate);
            });

            // Assert
            Assert.Equal("Id parameter out of bounds.", exception.Message);
        }
    }
}
