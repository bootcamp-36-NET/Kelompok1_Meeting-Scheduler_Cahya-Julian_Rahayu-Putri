using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        public RoomController(MyContext myContext)
        {
            _context = myContext;
        }
        private readonly MyContext _context;
        // GET api/values


        [HttpGet]
        public async Task<List<Room>> GetAll()
        {
            List<Room> list = new List<Room>();
            //var user = new UserVM();
            var getData = await _context.Rooms.Include("Booking").ToListAsync();
            if (getData.Count == 0)
            {
                return null;
            }
            foreach (var room in getData)
            {
                var rm = new Room()
                {
                    Id = room.Id,
                    Name = room.Name,
                    BookingId = room.Booking.Id,
                };
                list.Add(rm);
            }
            return list;
        }

        //[Authorize]
        [HttpGet("{id}")]
        public Room GetById(string id)
        {
            var getData = _context.Rooms.Include("Booking").SingleOrDefault(x => x.Id == id);
            if (getData == null || getData.Booking == null)
            {
                return null;
            }
            var rm = new Room()
            {
                Id = getData.Id,
                Name = getData.Name,
                BookingId = getData.Booking.Id
            };
            return rm;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (ModelState.IsValid)
            {
                var getData = _context.Rooms.Include("Booking").SingleOrDefault(x => x.Id == id);
                if (getData == null)
                {
                    return BadRequest("Not Successfully");
                }
                _context.Entry(getData).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok("Successfully Deleted");
            }
            return BadRequest("Not Successfully");
        }
    }
}