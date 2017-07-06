﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Weather
    {
        public string ParkCode { get; set; }
        public int ForcastValue { get; set; } 
        public int LowTemp { get; set; } 
        public int HighTemp { get; set; }
        public string Forecast { get; set; }
		public string TempType { get; set; }

    }
}