using Greta.BO.Api.Entities;
using Greta.Sdk.Core.Abstractions;
using Greta.Sdk.Core.Models.Pager;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Greta.BO.BusinessLogic.Interfaces
{
    public interface IGenericBaseService<T>: IBaseService where T : IBase
    {
        Task< bool> ChangeState(long id, bool state);
        Task<bool> Delete(long id);
        Task<List<T>> Get();
        Task<T> Get(long id);
        Task<Pager<T>> Page(int currentPage, int pageSize);
        Task<T> Post(T entity);
        Task<bool> Put(long id, T entity);
    }
}
