using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Context;
using API.Models;
using API.Repository.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : BaseController<Room, RoomRepo>
    {
        private readonly RoomRepo _repo;

        public RoomController(RoomRepo roomRepo) : base(roomRepo)
        {
            this._repo = roomRepo;
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<string>> Update(string Id, Room entity)
        {
            var getId = await _repo.GetById(Id);
            //getId.Name = entity.Name;
            //var data = await _repo.Update(getId);
            //if (data.Equals(null))
            //{
            //    return BadRequest("Data is not Update");
            //}
            //return Ok("Update Successfull");
            if (getId != null)
            {
                getId.Name = entity.Name;
                getId.CreateDate = DateTimeOffset.Now;
                getId.UpdateDate = DateTimeOffset.Now;
                await _repo.Update(getId);
                return Ok("data has been updated");
            }
            return BadRequest("Failed to update data. Please try again.");
        }
    }
}