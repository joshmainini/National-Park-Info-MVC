using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Parks
    {
        public string ParkCode { get; set; }
        public string Name { get; set; }
        public string State { get; set;}
        public int Acres { get; set; }
        public int Elevation { get; set; }
        public double TrailMiles { get; set; }
        public int NumCampSites { get; set; }
        public string Climate { get; set; }
        public int YearFounded { get; set; }
        public int AnnualVisitors { get; set; }
        public string Quote { get; set; }
        public string QuoteAuthor { get; set; }
        public string Description { get; set; }
        public int EntryFee { get; set; }
        public int AnimalSpecies { get; set; }
    }
}