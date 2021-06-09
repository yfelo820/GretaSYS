using Greta.BO.Api.Controllers;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.BO.Api.Sqlserver;
using Greta.BO.Api.Sqlserver.Repository;
using Greta.BO.Api.Test.Helpers;
using Greta.BO.Api.Test.Service;
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
    public class CityControllerTest
    {
        ILogger<CityController> logger;
        ILogger<CityService> loggerService;
        CityController controller;
        AuthenticateUser<string> authenticateUser = null;
        CityRepository repository = null;
        CityService service = null;

        public CityControllerTest()
        {
            logger = Mock.Of<ILogger<CityController>>();
            loggerService = Mock.Of<ILogger<CityService>>();

            authenticateUser = new AuthenticateUser<string>()
            {
                Name = "Greta.Sdk",
                UserId = new Guid().ToString(),
                IsAuthenticated = true,
                IsApplication = false,
            };
            var builder = new DbContextOptionsBuilder<SqlServerContext>();
            var options = builder.UseInMemoryDatabase(nameof(CityServiceTest)).Options;
            var context = new SqlServerContext(options);

            repository = new CityRepository(authenticateUser, context);
            service = new CityService(repository, this.loggerService);
            controller = new CityController(service, AutomapperSingleton.Mapper, this.logger);
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
            var city = new City()
            {
                Name = "City Name "
            };
            var id = await repository.CreateAsync(city);
            // Act
            OkObjectResult result = controller.Get(id).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(id, (result.Value as CityDto).Id);
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
            var city = new City()
            {
                Name = "Category Name "
            };
            var id = await repository.CreateAsync(city);

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
            var city = new City()
            {
                Name = "Category Name "
            };
            var id = await repository.CreateAsync(city);

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
                    Name = "City Name " + i
                };
                cities.Add(city);
            }

            var id = await repository.CreateRangeAsync<City>(cities);

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
            var city = new CityDto()
            {
                Name = "City Name "
            };

            // Act
            OkObjectResult result = controller.Post(city).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(city.Name, (result.Value as CityDto).Name);
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

            var cityUpdate = new CityDto()
            {
                Id = id,
                Name = "City Name Update",
                State = true
            };

            // Act
            OkObjectResult result = controller.Put(id, cityUpdate).Result as OkObjectResult;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.True((bool)result.Value);
        }

        [Fact]
        public async Task Put_CallWithNotFound_ThrowBusinessLogicException()
        {
            // Arrange
            long id = -1000;
            var cityUpdate = new CityDto()
            {
                Name = "City Name Update",
                State = true
            };
            // Act
            var exception = await Assert.ThrowsAsync<BusinessLogicException>(async () =>
            {
                var result = await controller.Put(id, cityUpdate);
            });

            // Assert
            Assert.Equal("Id parameter out of bounds.", exception.Message);
        }



    }
}
