using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class RoomVM
    {
        public string Id { get; set; }
        public string RoomName { get; set; }
        public string BookingId { get; set; }
        public string BookingName { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public bool isDelete { get; set; }
    }
}
