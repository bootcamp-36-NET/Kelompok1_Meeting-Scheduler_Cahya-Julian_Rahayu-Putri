using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class InterimVM
    {
        public string BookingId { get; set; }
        public string BookingName { get; set; }
        public string TeamLeader { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string Time { get; set; }
        public string Room { get; set; }
        public DateTimeOffset CreateDate { get; set; }
    }
}
