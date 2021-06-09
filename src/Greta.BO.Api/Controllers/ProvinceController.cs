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
    public class ProvinceController : BaseController
    {
        private readonly ILogger<ProvinceController> _logger;
        private readonly IProvinceService _service;
        private readonly IMapper _mapper;

        public ProvinceController(IProvinceService service, IMapper mapper, ILogger<ProvinceController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }

        /// <summary>
        /// Get all provinces paginates
        /// </summary>
        /// <param name="currentPage">Current page</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Returns the paginated provinces</returns>
        [HttpGet]
        [Route("{currentPage}/{pageSize}")]
        public async Task<IActionResult> Page(int currentPage, int pageSize)
        {
            _logger.LogInformation("Page method initialization");
            var entities = await this._service.Page(currentPage, pageSize);
            var data = this._mapper.Map<Pager<ProvinceDto>>(entities);
            _logger.LogInformation("Page method finish");
            return Ok(data);
        }

        /// <summary>
        /// Get All Provinces
        /// </summary>
        /// <returns>Returns the Provinces</returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var entities = await this._service.Get();
            var data = this._mapper.Map<List<ProvinceDto>>(entities);
            return Ok(data);
        }

        /// <summary>
        /// Get Provice by Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Return Provice or notfount exception</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await this._service.Get(id);
            var data = this._mapper.Map<ProvinceDto>(entity);
            return Ok(data);
        }

        /// <summary>
        /// Get Cities of a Provice by Id
        /// </summary>
        /// <param name="Province_id">Id</param>
        /// <returns>Return Cities or notfount exception</returns>
        [HttpGet]
        [Route("province/{id}")]
        public async Task<IActionResult> GetCities(long Province_id)
        {
            var entity = await this._service.Get(Province_id);
            var data = this._mapper.Map<ProvinceDto>(entity).Cities.ToList<CityDto>();
            return Ok(data);
        }



        /// <summary>
        /// Create a Provice
        /// </summary>
        /// <param name="province">Category</param>
        /// <returns>return cureent created Provice</returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] ProvinceDto province)
        {
            var entity = this._mapper.Map<Province>(province);
            var id = await this._service.Post(entity);
            province.Id = id.Id;
            return Ok(province);
        }

        /// <summary>
        /// Update Province
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="province">Province fields to update</param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] ProvinceDto province)
        {
            var entity = this._mapper.Map<Province>(province);
            var success = await this._service.Put(id, entity);
            return Ok(success);
        }

        /// <summary>
        /// Change state of Province by id
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
