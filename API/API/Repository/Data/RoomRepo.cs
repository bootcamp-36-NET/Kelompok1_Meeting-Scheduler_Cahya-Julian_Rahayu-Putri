using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class RoomRepo : GeneralRepository<Room, MyContext>
    {
        MyContext _context;
        public RoomRepo(MyContext myContext) : base(myContext)
        {
            _context = myContext;
        }

        public override async Task<List<Room>> GetAll()
        {
            var data = await _context.Rooms.Include("Booking").Where(x => x.isDelete == false).ToListAsync();
            return data;
        }

    }
}
