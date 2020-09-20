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
    public class RoomController : BaseController<Room, RoomRepo>
    {
        private readonly RoomRepo _repo;
        private readonly MyContext _context;
        public RoomController(RoomRepo roomRepo, MyContext myContext) : base(roomRepo)
        {
            this._repo = roomRepo;
            this._context = myContext;
        }
        //public RoomController(MyContext myContext)
        //{
        //    this._context = myContext;
        //}
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
                getId.BookingId = entity.BookingId;
                getId.CreateDate = DateTimeOffset.Now;
                getId.UpdateDate = DateTimeOffset.Now;
                getId.isBook = entity.isBook;
                await _repo.Update(getId);
                return Ok("data has been updated");
            }
            return BadRequest("Failed to update data. Please try again.");
        }
        [Route("getRoom")]
        [HttpGet]
        public async Task<List<RoomVM>> GetAllRoom()
        {
            List<RoomVM> list = new List<RoomVM>();

            var getUserRole = await _context.Rooms.Include("Booking").Where(x => x.isDelete == false).ToListAsync();
            if (getUserRole.Count == 0)
            {
                return null;
            }
            foreach (var item in getUserRole)
            {
                var user = new RoomVM()
                {
                    Id = item.Id,
                    RoomName = item.Name,
                    BookingId = item.BookingId,
                    BookingName = item.Booking.Name,
                    isDelete = item.isDelete,
                    DeleteDate = item.DeleteDate,
                    CreateDate = item.CreateDate,
                    UpdateDate = item.UpdateDate,
                    isBook = item.isBook
                };
                list.Add(user);
            }
            return list;
        }
        [Route("getRoomEmp")]
        [HttpGet]
        public async Task<List<RoomVM>> GetAllRommEmp()
        {
            List<RoomVM> list = new List<RoomVM>();

            var getUserRole = await _context.Rooms.Include("Booking").Where(x => x.isDelete == false && x.isBook == true).ToListAsync();
            if (getUserRole.Count == 0)
            {
                return null;
            }
            foreach (var item in getUserRole)
            {
                var user = new RoomVM()
                {
                    Id = item.Id,
                    RoomName = item.Name,
                    BookingId = item.BookingId,
                    BookingName = item.Booking.Name,
                    isDelete = item.isDelete,
                    DeleteDate = item.DeleteDate,
                    CreateDate = item.CreateDate,
                    UpdateDate = item.UpdateDate,
                    isBook = item.isBook,
                    Time = item.Booking.Time,
                    EndDate = item.Booking.EndDate
                    //TeamLeader = item.Booking.Employee.FullName
                };
                list.Add(user);
            }
            return list;
        }
    }
}