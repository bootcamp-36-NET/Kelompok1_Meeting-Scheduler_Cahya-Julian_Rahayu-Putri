using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Models;
using API.Repository.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : BaseController<Division, DivisionRepo>
    {
        private readonly DivisionRepo _repo;

        public DivisionController(DivisionRepo divisionRepo) : base(divisionRepo)
        {
            this._repo = divisionRepo;
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<int>> Update(int Id, Division entity)
        {
            var getId = await _repo.GetById(Id);
            getId.Name = entity.Name;
            getId.DepartmentId = entity.DepartmentId;
            var data = await _repo.Update(getId);
            if (data.Equals(null))
            {
                return BadRequest("Data is not Update");
            }
            return Ok("Update Successfull");
        }
    }
}