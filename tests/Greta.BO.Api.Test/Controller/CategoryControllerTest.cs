using Greta.BO.Api.Controllers;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.BO.Api.Sqlserver;
using Greta.BO.Api.Sqlserver.Repository;
using Greta.BO.Api.Test.Helpers;
using Greta.BO.BusinessLogic.Exceptions;
using Greta.BO.BusinessLogic.Service;
using Greta.Sdk.Core.Models.Pager;
using Greta.Sdk.EFCore.Middleware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Greta.BO.Api.Test.Controller
{
    public class CategoryServiceTest
    {
        ILogger<CategoryController> logger;
        ILogger<CategoryService> loggerService;
        CategoryController controller;
        AuthenticateUser<string> authenticateUser = null;
        CategoryRepository repository = null;
        CategoryService service = null;
        public CategoryServiceTest()
        {
            logger = Mock.Of<ILogger<CategoryController>>();
            loggerService = Mock.Of<ILogger<CategoryService>>();

            authenticateUser = new AuthenticateUser<string>()
            {
                Name = "Greta.Sdk",
                UserId = new Guid().ToString(),
                IsAuthenticated = true,
                IsApplication = false,
            };
            var builder = new DbContextOptionsBuilder<SqlServerContext>();
            var options = builder.UseInMemoryDatabase(nameof(CategoryServiceTest)).Options;
            var context = new SqlServerContext(options);

            repository = new CategoryRepository(authenticateUser, context);
            service = new CategoryService(repository, this.loggerService);
            controller = new CategoryController(service, AutomapperSingleton.Mapper, this.logger);
        }



        [Fact]
        public void Get_NormalCall_ResultOk()
        {
            // Arrange

            // Act
            OkObjectResult result = controller.Get().Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
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
            OkObjectResult result = controller.Get(id).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(id, (result.Value as CategoryDto).Id);
        }

        [Fact]
        public void GetId_CallNotExist_ReturnNull()
        {
            // Arrange
            long id = 1000;
            // Act
            OkObjectResult result = controller.Get(id).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.Null(result.Value);
        }

        [Fact]
        public async Task GetId_CallNegative_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await controller.Get(id);
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
            OkObjectResult result = controller.Delete(id).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task Delete_CallWithNotFound_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await controller.Delete(id);
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
                var result = await controller.ChangeState(id, true);
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
            OkObjectResult result = controller.ChangeState(id, true).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.True((bool)result.Value);
        }

        [Fact]
        public async Task Page_OutRange_ThrowBusinessLogicException()
        {
            // Arrange
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await controller.Page(0, 0);
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
            OkObjectResult result = controller.Page(1, 10).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(10, (result.Value as Pager<CategoryDto>).Data.Count);
        }


        [Fact]
        public void Post_NormalCall_ResultSameId()
        {
            // Arrange
            var category = new CategoryDto()
            {
                Name = "Category Name ",
                Description = "Category Description "
            };

            // Act
            OkObjectResult result = controller.Post(category).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(category.Name, (result.Value as CategoryDto).Name);
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

            var categoryUpdate = new CategoryDto()
            {
                Id = id,
                Name = "Category Name Update",
                Description = "Category Description Update",
                State = true
            };

            // Act
            OkObjectResult result = controller.Put(id, categoryUpdate).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.True((bool)result.Value);
        }

        [Fact]
        public async Task Put_CallWithNotFound_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            var categoryUpdate = new CategoryDto()
            {
                Name = "Category Name Update",
                Description = "Category Description Update",
                State = true
            };
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await controller.Put(id, categoryUpdate);
            });

            // Assert
            Assert.Equal("Id parameter out of bounds.", exception.Message);
        }
    }
}
