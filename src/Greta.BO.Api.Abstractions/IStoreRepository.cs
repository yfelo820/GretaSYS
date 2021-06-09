﻿using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Operations;

namespace Greta.BO.Api.Sqlserver.Repository
{
    public interface IStoreRepository : IOperationBase<long, string, Store>
    {
    }
}