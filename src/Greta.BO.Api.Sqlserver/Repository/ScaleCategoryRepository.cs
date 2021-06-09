using Greta.BO.Api.Abstractions;
using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Middleware;
using Greta.Sdk.EFCore.Operations;

namespace Greta.BO.Api.Sqlserver.Repository
{
    public class ScaleCategoryRepository : OperationBase<long, string, ScaleCategory>, IScaleCategoryRepository
    {
        public ScaleCategoryRepository(IAuthenticateUser<string> authenticatetUser, SqlServerContext context)
           : base(authenticatetUser, context)
        {
        }
    }
}
