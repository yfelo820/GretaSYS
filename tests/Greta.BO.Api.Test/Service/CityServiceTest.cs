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
    public class CityServiceTest
    {
        ILogger<CityController> logger;
        ILogger<CityService> loggerService;
        AuthenticateUser<string> authenticateUser = null;
        CityRepository repository = null;
        CityService service = null;

        public CityServiceTest()
        {
            logger = Mock.Of<ILogger<CityController>>();
            loggerService = Mock.Of<ILogger<CityService>>();

            authenticateUser = new AuthenticateUser<string>()
            {
                Name = "Greta.BO.Api",
                UserId = new Guid().ToString(),
                IsAuthenticated = true,
                IsApplication = false,
            };
            var builder = new DbContextOptionsBuilder<SqlServerContext>();
            var options = builder.UseInMemoryDatabase(nameof(CityServiceTest)).Options;
            var context = new SqlServerContext(options);

            repository = new CityRepository(authenticateUser, context);
            service = new CityService(repository, this.loggerService);
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
            var city = new City()
            {
                Name = "Category Name "
            };

            var id = await repository.CreateAsync(city);
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
            var city = new City()
            {
                Name = "City Name"                
            };
            var id = await repository.CreateAsync(city);

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
            var city = new City()
            {
                Name = "City Name "               
            };
            var id = await repository.CreateAsync(city);

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
            var element = await repository.GetEntity<City>().FirstOrDefaultAsync<City>();
            if (element != null)
            {
                await repository.DeleteAsync(element.Id);
            }
            var cities = new List<City>();
            for (var i = 0; i < 100; i++)
            {
                var city = new City()
                {
                    Name = "Category Name " + i
                };
                cities.Add(city);
            }

            var id = await repository.CreateRangeAsync<City>(cities);

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
            var city = new City()
            {
                Name = "City Name "
            };

            // Act
            var result = await service.Post(city);

            // Assert
            Assert.Equal(city.Name, (result as City).Name);
        }


        [Fact]
        public async Task Put_NormalCall_ChangeSuccess()
        {
            // Arrange
            var city = new City()
            {
                Name = "City Name "
            };
            var id = await repository.CreateAsync(city);

            var cityUpdate = new City()
            {
                Id = id,
                Name = "City Name Update",
                State = true
            };

            // Act
            var result = await service.Put(id, cityUpdate);

            // Assert
            Assert.True((bool)result);
        }

        [Fact]
        public async Task Put_CallWithNotFound_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            var cityUpdate = new City()
            {
                Name = "City Name Update",
                State = true
            };
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await service.Put(id, cityUpdate);
            });

            // Assert
            Assert.Equal("Id parameter out of bounds.", exception.Message);
        }



    }
}
