using AutoMapper;
using Greta.BO.Api.Dto;
using Greta.BO.Api.Entities;
using Greta.BO.Api.Sqlserver.Repository;
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
    public class FamilyController : BaseController
    {
        private readonly ILogger<FamilyController> _logger;

        private readonly IFamilyRepository _repository;
        private readonly IMapper _mapper;

        public FamilyController(IFamilyRepository repository, IMapper mapper, ILogger<FamilyController> logger)
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
            _logger.LogInformation("FamilyController: Begin Page");
            if (currentPage < 1 || pageSize < 1)
                return NotFound();

            var entities = await this._repository.GetEntity<Family>().ToPageAsync(currentPage, pageSize);

            var data = this._mapper.Map<Pager<FamilyDto>>(entities);

            _logger.LogInformation("FamilyController: End Page");
            return Ok(data);
        }

        // GET: api/<FamilyController>
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var entities = await this._repository.GetEntity<Family>().ToListAsync();

            var data = this._mapper.Map<List<FamilyDto>>(entities);

            return Ok(data);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            if (id < 1)
                return NotFound();

            var entity = await this._repository.GetEntity<Category>().FindAsync(id);

            var data = this._mapper.Map<FamilyDto>(entity);

            return Ok(data);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post([FromBody] FamilyDto family)
        {
            var entity = this._mapper.Map<Category>(family);

            var id = await this._repository.CreateAsync(entity);

            family.Id = id.Id;

            return Ok(family);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] FamilyDto family)
        {
            if (id < 1)
                return NotFound();

            var entity = this._mapper.Map<Family>(family);

            var success = await this._repository.UpdateAsync(id, entity);

            return Ok(success);
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public async Task<IActionResult> ChangeState(long id, bool state)
        {
            if (id < 1)
                return NotFound();

            var success = await this._repository.ChangeStateAsync<Family>(id, state);

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
