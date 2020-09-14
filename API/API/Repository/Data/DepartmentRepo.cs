using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class DepartmentRepo : GeneralRepository<Department, MyContext>
    {
        public DepartmentRepo (MyContext myContext) : base(myContext)
        {

        }
    }
}
