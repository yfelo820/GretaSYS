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
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Greta.BO.BusinessLogic.Service
{
    public class ProvinceService : IProvinceService
    {
        private readonly IProvinceRepository _repository;
        private readonly ILogger<ProvinceService> _logger;

        public ProvinceService(IProvinceRepository provinceRepository, ILogger<ProvinceService> logger)
        {
            _repository = provinceRepository;
            _logger = logger;
        }


        /// <summary>
        /// Get paginate provinces 
        /// </summary>
        /// <param name="currentPage">current page</param>
        /// <param name="pageSize">page size</param>
        /// <returns></returns>
        /// 

        public async Task<Pager<Province>> Page(int currentPage, int pageSize)
        {
            if (currentPage < 1 || pageSize < 1)
            {
                this._logger.LogError("Page parameter (currentPage or pageSize) out of bounds.");
                throw new BusinessLogicException("Page parameter out of bounds.");
            }
            var entities = await this._repository.GetEntity<Province>().ToPageAsync(currentPage, pageSize);
            return entities;
        }
        /// <summary>
        /// Get all Provinces (Deprecated) reviw if this is necesary
        /// </summary>
        /// <returns></returns>
        public async Task<List<Province>> Get()
        {
            var entities = await this._repository.GetEntity<Province>().ToListAsync();
            return entities;
        }
        /// <summary>
        /// Get Province by Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Family</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<Province> Get(long id)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var entity = await this._repository.GetEntity<Province>().FindAsync(id);
            return entity;
        }


        /// <summary>
        /// Get All City by  provinceId
        /// </summary>
        /// <param name="provinceId">Province Id</param>
        /// <returns>Cities for provinceId passed by parameters</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<List<City>> GetCities(long provinceId)
        {
            if (provinceId < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var entities = await this._repository.GetEntity<City>().Where(x => x.Id == provinceId).ToListAsync();
            return entities;
        }

        /// <summary>
        /// Insert a Province
        /// </summary>
        /// <param name="family">category entity to insert</param>
        /// <returns>Category entity</returns>
        public async Task<Province> Post(Province province)
        {
            var id = await this._repository.CreateAsync(province);
            province.Id = id;

            return province;
        }
        /// <summary>
        /// Update Province
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="family">Category entity to update</param>
        /// <returns>Boolean success</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<bool> Put(long id, Province province)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var success = await this._repository.UpdateAsync(id, province);

            return success;
        }
        /// <summary>
        /// Change State for Province 
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

            var success = await this._repository.ChangeStateAsync<Province>(id, state);

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
