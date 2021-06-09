using AutoMapper;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.BO.BusinessLogic.Interfaces;
using Greta.Sdk.Core.Models.Pager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Greta.BO.Api.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : BaseController
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _service;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService service, IMapper mapper, ILogger<CategoryController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        /// <summary>
        /// Get all categories paginates
        /// </summary>
        /// <param name="currentPage">Current page</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>Returns the paginated categories</returns>
        [HttpGet]
        [Route("{currentPage}/{pageSize}")]
        public async Task<IActionResult> Page(int currentPage, int pageSize)
        {
            _logger.LogInformation("Page method initialization");
            var entities = await this._service.Page(currentPage, pageSize);
            var data = this._mapper.Map<Pager<CategoryDto>>(entities);
            _logger.LogInformation("Page method finish");
            return Ok(data);
        }

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <returns>Returns the categories</returns>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var entities = await this._service.Get();
            var data = this._mapper.Map<List<CategoryDto>>(entities);
            return Ok(data);
        }

        /// <summary>
        /// Get Category by Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Return Category or notfount exception</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var entity = await this._service.Get(id);
            var data = this._mapper.Map<CategoryDto>(entity);
            return Ok(data);
        }
        /// <summary>
        /// Create a Category
        /// </summary>
        /// <param name="category">Category</param>
        /// <returns>return cureent created category</returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] CategoryDto category)
        {
            var entity = this._mapper.Map<Category>(category);
            var id = await this._service.Post(entity);
            category.Id = id.Id;
            return Ok(category);
        }
        /// <summary>
        /// Updata category
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="category">Category fields to update</param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] CategoryDto category)
        {
            var entity = this._mapper.Map<Category>(category);
            var success = await this._service.Put(id, entity);
            return Ok(success);
        }

        /// <summary>
        /// Change state of category by id
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
        /// Delete Category  by id
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