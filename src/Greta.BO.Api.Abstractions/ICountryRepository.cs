using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Greta.BO.Api.Abstractions
{
    public interface ICountryRepository : IOperationBase<long, string, Country>
    {
    }
}
