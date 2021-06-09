using Greta.BO.Api.Abstractions;
using Greta.BO.Api.Entities;
using Greta.BO.Api.Sqlserver.Repository;
using Greta.BO.BusinessLogic.Exceptions;
using Greta.BO.BusinessLogic.Interfaces;
using Greta.Sdk.Core.Models.Pager;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Greta.BO.BusinessLogic.Service
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _repository;
        private readonly ILogger<StoreService> _logger;

        public StoreService(IStoreRepository storeRepository, ILogger<StoreService> logger)
        {
            _repository = storeRepository;
            _logger = logger;
        }


        /// <summary>
        /// Get paginate Store 
        /// </summary>
        /// <param name="currentPage">current page</param>
        /// <param name="pageSize">page size</param>
        /// <returns></returns>
        /// 

        public async Task<Pager<Store>> Page(int currentPage, int pageSize)
        {
            if (currentPage < 1 || pageSize < 1)
            {
                this._logger.LogError("Page parameter (currentPage or pageSize) out of bounds.");
                throw new BusinessLogicException("Page parameter out of bounds.");
            }
            var entities = await this._repository.GetEntity<Store>().ToPageAsync(currentPage, pageSize);
            return entities;
        }
        /// <summary>
        /// Get all Store (Deprecated) reviw if this is necesary
        /// </summary>
        /// <returns></returns>
        public async Task<List<Store>> Get()
        {
            var entities = await this._repository.GetEntity<Store>().ToListAsync();
            return entities;
        }
        /// <summary>
        /// Get Store by Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Family</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<Store> Get(long id)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var entity = await this._repository.GetEntity<Store>().FindAsync(id);
            return entity;
        }
        /// <summary>
        /// Insert a Store
        /// </summary>
        /// <param name="family">category entity to insert</param>
        /// <returns>Category entity</returns>
        public async Task<Store> Post(Store store)
        {
            var id = await this._repository.CreateAsync(store);
            store.Id = id;

            return store;
        }
        /// <summary>
        /// Update store
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="family">Category entity to update</param>
        /// <returns>Boolean success</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<bool> Put(long id, Store store)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var success = await this._repository.UpdateAsync(id, store);

            return success;
        }
        /// <summary>
        /// Change State for store 
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="state">new State</param>
        /// <returns>Boolean success</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<bool> ChangeState(long id, bool state)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var success = await this._repository.ChangeStateAsync<Store>(id, state);

            return success;
        }
        /// <summary>
        /// Delete a entity
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Boolean success</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<bool> Delete(long id)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var success = await this._repository.DeleteAsync(id);
            return success;
        }


    }
}
