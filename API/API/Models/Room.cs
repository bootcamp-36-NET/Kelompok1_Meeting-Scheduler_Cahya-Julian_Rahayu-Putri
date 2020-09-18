using API.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_room")]
    public class Room : BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BookingId { get; set; }
        public Booking Booking { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public bool isDelete { get; set;}
        
    }
}
