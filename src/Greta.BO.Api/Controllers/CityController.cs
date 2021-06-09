using AutoMapper;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.BO.BusinessLogic.Interfaces;
using Greta.Sdk.Core.Models.Pager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Greta.BO.Api.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : BaseController
    {
        private readonly ILogger<CityController> _logger;
        private readonly ICityService _service;
        private readonly IMapper _mapper;

        public CityController(ICityService service, IMapper mapper, ILogger<CityController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }

        /// <summary>
        /// Get all cities paginates
        /// </summary>
        /// <param name="currentPage">Current page</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Returns the paginated cities</returns>
        [HttpGet]
        [Route("{currentPage}/{pageSize}")]
        public async Task<IActionResult> Page(int currentPage, int pageSize)
        {
            _logger.LogInformation("Page method initialization");
            var entities = await this._service.Page(currentPage, pageSize);
            var data = this._mapper.Map<Pager<CityDto>>(entities);
            _logger.LogInformation("Page method finish");
            return Ok(data);
        }

        /// <summary>
        /// Get All Cities
        /// </summary>
        /// <returns>Returns the Cities</returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var entities = await this._service.Get();
            var data = this._mapper.Map<List<CityDto>>(entities);
            return Ok(data);
        }

        /// <summary>
        /// Get City by Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Return City or notfount exception</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await this._service.Get(id);
            var data = this._mapper.Map<CityDto>(entity);
            return Ok(data);
        }

        /// <summary>
        /// Create a City
        /// </summary>
        /// <param name="city">Category</param>
        /// <returns>return cureent created city</returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] CityDto city)
        {
            var entity = this._mapper.Map<City>(city);
            var id = await this._service.Post(entity);
            city.Id = id.Id;
            return Ok(city);
        }

        /// <summary>
        /// Update city
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="city">City fields to update</param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] CityDto city)
        {
            var entity = this._mapper.Map<City>(city);
            var success = await this._service.Put(id, entity);
            return Ok(success);
        }

        /// <summary>
        /// Change state of city by id
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

        /// <summary>
        /// Delete City  by id
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Return boolean success</returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var success = await this._service.Delete(id);
            return Ok(success);
        }







    }
}
