using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Repository.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionRepo : GeneralRepository<Division, MyContext>
    {
        MyContext _context;
        public DivisionRepo(MyContext myContext) : base(myContext) //bisa pake SP dalam sini
        {
            _context = myContext;
        }

        public override async Task<List<Division>> GetAll()
        {
            var data = await _context.Division.Include("Department").Where(x => x.isDelete == false).ToListAsync();
            return data;
        }
    }
}