using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Bases
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class
        where TRepository : IRepository<TEntity>
    {
        private IRepository<TEntity> _repo;
        public BaseController(TRepository repository)
        {
            this._repo = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> GetAll() => await _repo.GetAll();

        [HttpGet("{Id}")]
        public async Task<ActionResult<TEntity>> GetById(string Id) => await _repo.GetById(Id);

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            var date = await _repo.Create(entity);
            if (date != null)
            {
                return Ok("Data Save");
            }
            return BadRequest("Data Not Saved");
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<string>> Delete(string Id)
        {
            var deleted = await _repo.Delete(Id);
            if (deleted.Equals(null))
            {
                return NotFound("Data not found");
            }
            return deleted;
        }
    }
}