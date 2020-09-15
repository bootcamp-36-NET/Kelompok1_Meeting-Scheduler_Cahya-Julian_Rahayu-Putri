using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Models;
using API.Repository.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : BaseController<Department, DepartmentRepo>
    {
        private readonly DepartmentRepo _repo;

        public DepartmentController(DepartmentRepo departmentRepo) : base(departmentRepo)
        {
            this._repo = departmentRepo;
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<string>> Update(string id, Department entity)
        {
            var getId = await _repo.GetById(id);
            getId.Name = entity.Name;
            var data = await _repo.Update(getId);
            if (data.Equals(null))
            {
                return BadRequest("Data is not Update");
            }
            return Ok("Update Successfull");
        }
    }
}