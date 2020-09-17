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

        [HttpGet]
        public override async Task<List<Division>> GetAll()
        {
            List<Division> list = new List<Division>();
            var data = await _context.Divisions.Include("Department").Where(x => x.isDelete == false).ToListAsync();
            if (data.Count == 0)
            {
                return null;
            }
            foreach (var division in data)
            {
                var emp = new Division()
                {
                    Id = division.Id,
                    Name = division.Name,
                    DepartmentId = division.Department.Name,
                    CreateDate = division.CreateDate,
                    UpdateDate = division.UpdateDate,
                    DeleteDate = division.DeleteDate
                };
                list.Add(emp);
            }
            return list;
        }
    }
}