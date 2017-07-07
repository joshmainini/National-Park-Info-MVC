using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Weather
    {
	

        public string ParkCode { get; set; }
        public int ForcastValue { get; set; } 
        public double LowTemp { get; set; } 
        public double HighTemp { get; set; }
        public string Forecast { get; set; }

	
		public double GetHighTemp(bool celsius)
		{
			if (celsius == true)
			{
				return (HighTemp - 32) * (5.0 / 9.0);
			}
			else
			{
				return HighTemp;
			}
		}
		public double GetLowTemp(bool celsius)
		{
			if (celsius == true)
			{
				return (LowTemp - 32) * (5.0 / 9.0);
			}
			else
			{
				return LowTemp;
			}
		}

	}
}