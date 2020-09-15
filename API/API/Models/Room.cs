using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("tb_room")]
    public class Room
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Booking Booking { get; set; }
    }
}
