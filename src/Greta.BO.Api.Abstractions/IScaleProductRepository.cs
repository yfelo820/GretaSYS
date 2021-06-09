using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Operations;

namespace Greta.BO.Api.Abstractions
{
    public interface IScaleProductRepository : IOperationBase<long, string, ScaleProduct>
    {
    }
}
