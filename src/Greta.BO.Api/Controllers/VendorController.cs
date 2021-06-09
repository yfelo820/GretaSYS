using AutoMapper;
using Greta.BO.Api.Abstractions;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.Sdk.Core.Models.Pager;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Greta.BO.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : BaseController
    {
        private readonly ILogger<VendorController> _logger;

        private readonly IVendorRepository _repository;
        private readonly IMapper _mapper;

        public VendorController(IVendorRepository repository, IMapper mapper, ILogger<VendorController> logger)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._logger = logger;
        }

        [HttpGet]
        //[Route("[action]/{currentPage}/{pageSize}")]
        [Route("{currentPage}/{pageSize}")]
        public async Task<IActionResult> Page(int currentPage, int pageSize)
        {
            _logger.LogInformation("VendorController: Begin Page");
            if (currentPage < 1 || pageSize < 1)
                return NotFound();

            var entities = await this._repository.GetEntity<Vendor>().ToPageAsync(currentPage, pageSize);

            var data = this._mapper.Map<Pager<VendorDto>>(entities);

            _logger.LogInformation("VendorController: End Page");
            return Ok(data);
        }

        // GET: api/<VendorController>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var entities = await this._repository.GetEntity<Vendor>().ToListAsync();

            var data = this._mapper.Map<List<VendorDto>>(entities);

            return Ok(data);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            if (id < 1)
                return NotFound();

            var entity = await this._repository.GetEntity<Category>().FindAsync(id);

            var data = this._mapper.Map<VendorDto>(entity);

            return Ok(data);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] VendorDto vendor)
        {
            var entity = this._mapper.Map<Category>(vendor);

            var id = await this._repository.CreateAsync(entity);

            vendor.Id = id.Id;

            return Ok(vendor);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] VendorDto vendor)
        {
            if (id < 1)
                return NotFound();

            var entity = this._mapper.Map<Vendor>(vendor);

            var success = await this._repository.UpdateAsync(id, entity);

            return Ok(success);
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public async Task<IActionResult> ChangeState(long id, bool state)
        {
            if (id < 1)
                return NotFound();

            var success = await this._repository.ChangeStateAsync<Vendor>(id, state);

            return Ok(success);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            if (id < 1)
                return NotFound();

            var success = await this._repository.DeleteAsync(id);

            return Ok(success);
        }
    }
}
