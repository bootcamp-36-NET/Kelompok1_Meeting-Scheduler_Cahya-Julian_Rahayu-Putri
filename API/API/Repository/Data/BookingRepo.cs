using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class BookingRepo : GeneralRepository<Booking, MyContext>
    {
        MyContext _context;
        public BookingRepo(MyContext myContext) : base(myContext) //bisa pake SP dalam sini
        {
            _context = myContext;
        }

        public override async Task<List<Booking>> GetAll()
        {
            var data = await _context.Bookings.Include("Employee").Where(x => x.isDelete == false).ToListAsync();
            return data;
        }
    }
}