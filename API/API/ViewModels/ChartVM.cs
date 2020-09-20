using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class ChartVM
    {
        public string DepartmentName1 { get; set; }
        public int total { get; set; }
    }

    public class PieChartVM
    {
        public string DepartmentName { get; set; }
        public int total { get; set; }
    }
}
