using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        private readonly MyContext _context;
        public ChartsController(MyContext myContext)
        {
            _context = myContext;
        }
        // GET api/values
        [HttpGet]
        [Route("pie")]
        public async Task<List<PieChartVM>> GetPie()
        {
            var data1 = await _context.Employees.Include("Department")
                           .Where(x => x.isDelete == false)
                           .GroupBy(q => q.Department.Name)
                            .Select(q => new PieChartVM
                            {
                                DepartmentName = q.Key,
                                total = q.Count()
                            }).ToListAsync();

            return data1;
        }

        [HttpGet]
        [Route("bar")]
        public async Task<List<ChartVM>> GetBar()
        {
            var data2 = await _context.Rooms.Include("Booking")
                           .Where(x => x.isDelete == false)
                           .GroupBy(q => q.Booking.Name)
                           .Select(q => new ChartVM
                           {
                               DepartmentName1 = q.Key,
                               total = q.Count()
                           }).ToListAsync();
            return data2;
        }
    }
}
