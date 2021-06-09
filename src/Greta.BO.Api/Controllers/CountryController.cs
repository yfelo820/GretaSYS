using AutoMapper;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.BO.BusinessLogic.Interfaces;
using Greta.Sdk.Core.Models.Pager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greta.BO.Api.Controllers
{
    public class CountryController : BaseController
    {
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryService _service;
        private readonly IMapper _mapper;

        public CountryController(ICountryService service, IMapper mapper, ILogger<CountryController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }

        /// <summary>
        /// Get all countries paginates
        /// </summary>
        /// <param name="currentPage">Current page</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Returns the paginated countries</returns>
        [HttpGet]
        [Route("{currentPage}/{pageSize}")]
        public async Task<IActionResult> Page(int currentPage, int pageSize)
        {
            _logger.LogInformation("Page method initialization");
            var entities = await this._service.Page(currentPage, pageSize);
            var data = this._mapper.Map<Pager<CountryDto>>(entities);
            _logger.LogInformation("Page method finish");
            return Ok(data);
        }

        /// <summary>
        /// Get All Countries
        /// </summary>
        /// <returns>Returns the Countries</returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var entities = await this._service.Get();
            var data = this._mapper.Map<List<CountryDto>>(entities);
            return Ok(data);
        }

        /// <summary>
        /// Get Country by Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Return Country or notfount exception</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await this._service.Get(id);
            var data = this._mapper.Map<CountryDto>(entity);
            return Ok(data);
        }

        /// <summary>
        /// Get Provinces of a Country by Id
        /// </summary>
        /// <param name="Country_id">Id</param>
        /// <returns>Return Provices or notfount exception</returns>
        [HttpGet]
        [Route("country/{id}")]
        public async Task<IActionResult> GetProvinces(long Province_id)
        {
            var entity = await this._service.Get(Province_id);
            var data = this._mapper.Map<CountryDto>(entity).Provinces.ToList<ProvinceDto>();
            return Ok(data);
        }



        /// <summary>
        /// Create a Country
        /// </summary>
        /// <param name="country">Category</param>
        /// <returns>return cureent created Country</returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] CountryDto country)
        {
            var entity = this._mapper.Map<Country>(country);
            var id = await this._service.Post(entity);
            country.Id = id.Id;
            return Ok(country);
        }

        /// <summary>
        /// Update Country
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="country">Country fields to update</param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] CountryDto country)
        {
            var entity = this._mapper.Map<Country>(country);
            var success = await this._service.Put(id, entity);
            return Ok(success);
        }

        /// <summary>
        /// Change state of Country by id
        /// </summary>
        /// <param name="id">Id </param>
        /// <param name="state">New State</param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]/{id}")]
        public async Task<IActionResult> ChangeState(long id, bool state)
        {
            var success = await this._service.ChangeState(id, state);
            return Ok(success);
        }



    }
}
