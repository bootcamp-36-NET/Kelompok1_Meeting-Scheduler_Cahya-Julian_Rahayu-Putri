using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_employee")]
    public class Employee
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public bool isDelete { get; set; }
        public string Username { get; set; }

        public User User { get; set; }
        public Department Department { get; set; }
    }
}
