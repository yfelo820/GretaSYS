using Greta.BO.Api.Abstractions;
using Greta.BO.Api.Entities;
using Greta.BO.BusinessLogic.Exceptions;
using Greta.BO.BusinessLogic.Interfaces;
using Greta.Sdk.Core.Models.Pager;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Greta.BO.BusinessLogic.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly ILogger<CategoryService> _logger;

        public CategoryService(ICategoryRepository categoryRepository, ILogger<CategoryService> logger)
        {
            _repository = categoryRepository;
            _logger = logger;
        }
        /// <summary>
        /// Get paginate categories 
        /// </summary>
        /// <param name="currentPage">current page</param>
        /// <param name="pageSize">page size</param>
        /// <returns></returns>
        public async Task<Pager<Category>> Page(int currentPage, int pageSize)
        {
            if (currentPage < 1 || pageSize < 1)
            {
                this._logger.LogError("Page parameter (currentPage or pageSize) out of bounds.");
                throw new BusinessLogicException("Page parameter out of bounds.");
            }
            var entities = await this._repository.GetEntity<Category>().ToPageAsync(currentPage, pageSize);
            return entities;
        }
        /// <summary>
        /// Get all Categories (Deprecated) reviw if this is necesary
        /// </summary>
        /// <returns></returns>
        public async Task<List<Category>> Get()
        {
            var entities = await this._repository.GetEntity<Category>().ToListAsync();
            return entities;
        }
        /// <summary>
        /// Get category by Id
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Category</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<Category> Get(long id)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var entity = await this._repository.GetEntity<Category>().FindAsync(id);
            return entity;
        }
        /// <summary>
        /// Insert a category
        /// </summary>
        /// <param name="category">category entity to insert</param>
        /// <returns>Category entity</returns>
        public async Task<Category> Post(Category category)
        {
            var id = await this._repository.CreateAsync(category);
            category.Id = id;

            return category;
        }
        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="category">Category entity to update</param>
        /// <returns>Boolean success</returns>
        /// <exception cref="BusinessLogicException">If id is less to -1</exception>
        public async Task<bool> Put(long id, Category category)
        {
            if (id < 1)
            {
                this._logger.LogError("Id parameter out of bounds.");
                throw new BusinessLogicException("Id parameter out of bounds.");
            }

            var success = await this._repository.UpdateAsync(id, category);

            return success;
        }
        /// <summary>
        /// Change State for category 
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

            var success = await this._repository.ChangeStateAsync<Category>(id, state);

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
