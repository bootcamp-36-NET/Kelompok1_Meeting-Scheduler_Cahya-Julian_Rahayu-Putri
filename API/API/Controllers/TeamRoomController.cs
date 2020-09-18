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
    public class TeamRoomController : BaseController<TeamRoom, TeamRoomRepo>
    {
        private readonly TeamRoomRepo _repo;

        public TeamRoomController(TeamRoomRepo teamRoomRepo) : base(teamRoomRepo)
        {
            this._repo = teamRoomRepo;
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<string>> Update(string Id, TeamRoom entity)
        {
            var upd = await _repo.GetById(Id);
            if (upd != null)
            {
                upd.Name = entity.Name;
                upd.Room = entity.Room;
                upd.UpdateDate = DateTimeOffset.Now;
                await _repo.Update(upd);
                return Ok("data has been updated");
            }
            return BadRequest("Failed to update data. Please try again.");
        }
    }
}
