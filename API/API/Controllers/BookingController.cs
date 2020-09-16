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
    public class BookingController : BaseController<Booking, BookingRepo>
    {
        private readonly BookingRepo _repo;

        public BookingController(BookingRepo bookingRepo) : base(bookingRepo)
        {
            this._repo = bookingRepo;
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<string>> Update(string Id, Booking entity)
        {
            var getId = await _repo.GetById(Id);
            getId.Name = entity.Name;
            getId.Time = entity.Time;
            getId.Employee = entity.Employee;
            var data = await _repo.Update(getId);
            if (data.Equals(null))
            {
                return BadRequest("Data is not Update");
            }
            return Ok("Update Successfull");
        }
    }
}