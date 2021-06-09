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
    public class CountryService : ICountryService
    {

        private readonly ICountryRepository _repository;
        private readonly ILogger<CountryService> _logger;

        public CountryService(ICountryRepository countryRepository, ILogger<CountryService> logger)
        {
            _repository = countryRepository;
            _logger = logger;
        }


        /// <summary>
        /// Get paginate countries 
        /// </summary>
        /// <param name="currentPage">current page</param>
        /// <param name="pageSize">page size</param>
        /// <returns></returns>
        /// 

        public async Task<Pager<Country>> Page(int currentPage, int pageSize)
        {
            if (currentPage < 1 || pageSize < 1)
            {
                this._logger.LogError("Page parameter (currentPage or pageSize) out of bounds.");
                throw new BusinessLogicException("Page parameter out of bounds.");
            }
            var entities = await this._repository.GetEntity<Country>().ToPageAsync(currentPage, pageSize);
            return entities;
        }
        /// <summary>
        /// Get all Countries (Deprecated) reviw if this is necesary
        /// </summary>
        /// <returns></returns>
        public async Task<List<Country>> Get()
        {
            var entities = await this._repository.GetEntity<Country>().ToListAsync();
            return entities;
        }
        /// <summary>
        /// Get Country by Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Family</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<Country> Get(long id)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var entity = await this._repository.GetEntity<Country>().FindAsync(id);
            return entity;
        }

        /// <summary>
        /// Get All Provinces by  countryId
        /// </summary>
        /// <param name="countryId">Country Id</param>
        /// <returns>Provinces for countryId passed by parameters</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<List<Province>> GetCities(long countryId)
        {
            if (countryId < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var entities = await this._repository.GetEntity<Province>().Where(x => x.Id == countryId).ToListAsync();
            return entities;
        }








        /// <summary>
        /// Insert a Country
        /// </summary>
        /// <param name="family">Country entity to insert</param>
        /// <returns>Country entity</returns>
        public async Task<Country> Post(Country country)
        {
            var id = await this._repository.CreateAsync(country);
            country.Id = id;

            return country;
        }
        /// <summary>
        /// Update Country
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="country">Country entity to update</param>
        /// <returns>Boolean success</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<bool> Put(long id, Country country)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var success = await this._repository.UpdateAsync(id, country);

            return success;
        }
        /// <summary>
        /// Change State for Country 
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

            var success = await this._repository.ChangeStateAsync<Country>(id, state);

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
