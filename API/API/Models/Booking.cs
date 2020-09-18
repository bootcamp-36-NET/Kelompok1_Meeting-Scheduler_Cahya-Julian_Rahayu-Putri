using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_m_booking")]
    public class Booking : BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public bool isDelete { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Time { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Room> Rooms { get; set; }

    }
}
