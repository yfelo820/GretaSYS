using Greta.BO.Api.Filters;
using Greta.BO.BusinessLogic.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using Xunit;

namespace Greta.BO.Api.Test.Filters
{
    public class GlobalExceptionFilterTest
    {
        [Fact]
        public void GivenAllExceptionFilters_WhenThrowException_HandledShouldBeOnceTime()
        {
            var controllerContext = CreateEmptyControllerContext();

            var filters = new IExceptionFilter[]
            {
                new GlobalExceptionFilter()
            };

            var exceptions = new Exception[]
           {
                new BusinessLogicException("Test"),
                new Exception("Test")
           };

            var context = new ExceptionContext(controllerContext, filters);

            foreach (var filter in filters)
            {
                foreach (var exc in exceptions)
                {
                    context.Exception = exc;
                    filter.OnException(context);
                }
            }

            Assert.True(context.ExceptionHandled);
            Assert.IsType<JsonResult>(context.Result);
        }

        private static ControllerContext CreateEmptyControllerContext()
        {
            var actionContext = new ActionContext
            {
                HttpContext = new DefaultHttpContext
                {
                    //User = controller.GetMockUserContext()
                },
                RouteData = new RouteData(),
                ActionDescriptor = new ControllerActionDescriptor()
            };
            return new ControllerContext(actionContext);
        }
    }
}
