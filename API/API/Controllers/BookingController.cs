using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Bases;
using API.Context;
using API.Models;
using API.Repository.Data;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : BaseController<Booking, BookingRepo>
    {
        private readonly BookingRepo _repo;
        private readonly MyContext myContext;

        public BookingController(BookingRepo bookingRepo, MyContext context) : base(bookingRepo)
        {
            this._repo = bookingRepo;
            this.myContext = context;
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<string>> Update(string Id, Booking entity)
        {
            //var getId = await _repo.GetById(Id);
            //getId.Name = entity.Name;
            //getId.Time = entity.Time;
            //getId.Employee = entity.Employee;
            //var data = await _repo.Update(getId);
            //if (data.Equals(null))
            //{
            //    return BadRequest("Data is not Update");
            //}
            //return Ok("Update Successfull");
            var upd = await _repo.GetById(Id);
            if (upd != null)
            {
                upd.Name = entity.Name;
                upd.Time = entity.Time;
                upd.EndDate = entity.EndDate;
                upd.EmployeeId = entity.EmployeeId;
                //upd.CreateDate = DateTimeOffset.Now;
                upd.UpdateDate = DateTimeOffset.Now;
                await _repo.Update(upd);
                return Ok("data has been updated");
            }
            return BadRequest("Failed to update data. Please try again.");
        }
        [Route("semua")]
        [HttpGet]
        public async Task<List<InterimVM>> GetAllSemua()
        {
            List<InterimVM> list = new List<InterimVM>();

            var getEmp = await myContext.Bookings.Include("Employee").Include("Rooms").Where(Q=>Q.Rooms!=null).ToListAsync();
            var getRoom = await myContext.Rooms.Where(Q=>Q.isBook == true).ToListAsync();
            foreach (var item in getEmp)
            {
                var user = new InterimVM()
                {
                    BookingId = item.Id,
                    TeamLeader = item.Employee.FullName,
                    EndDate = item.EndDate,
                    Time = item.Time,
                    BookingName = item.Name,
                    CreateDate = item.CreateDate,                    
                };
                list.Add(user);
            }
            foreach(var room in getRoom)
            {
                var user2 = new InterimVM()
                {
                    Room = room.Name
                };
                list.Add(user2);
            }            
            return list;
        }

    }
}