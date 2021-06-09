using Greta.BO.Api.Responses;
using Greta.BO.BusinessLogic.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace Greta.BO.Api.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {

        public GlobalExceptionFilter()
        {

        }

        public void OnException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(BusinessLogicException))
            {
                var exception = context.Exception as BusinessLogicException;
                var json = new ApiErrorResponse("Bad request")
                {
                    Status = 400,
                    Detail = exception.Message
                };

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Result = new JsonResult(json);
            }
            else
            {
                // Unhandled errors
#if !DEBUG
                var msg = "An unhandled error occurred.";                
                string stack = null;
#else
                var msg = context.Exception.GetBaseException().Message;
                string stack = context.Exception.StackTrace;
#endif
                var json = new ApiErrorResponse(msg)
                {
                    Status = 500,
                    Detail = stack
                };

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                // handle logging here

                // always return a JSON result
                context.Result = new JsonResult(json);
            }

            context.ExceptionHandled = true;
        }
    }
}