using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Weather
    {
        public string ParkCode { get; set; }
        public List<int> ForcastValue { get; set; } 
        public List<int> LowTemp { get; set; } 
        public List<int> HighTemp { get; set; }
        public List<string> Forecast { get; set; }

    }
}