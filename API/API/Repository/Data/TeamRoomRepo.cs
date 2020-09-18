using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class TeamRoomRepo : GeneralRepository<TeamRoom, MyContext>
    {
        private readonly MyContext _context;
        public TeamRoomRepo(MyContext myContext) : base(myContext) 
        {
            _context = myContext;
        }
    }
}
