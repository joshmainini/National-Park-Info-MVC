using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace Capstone.Web.Models
{
    public class SurveyModel
    {
        
        public int Total { get; set; }
        [Required]
        public string FavoritePark { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        public string Residence { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Please select an Activity Level")]
        public string ActivityLevel { get; set; }


        public static List<SelectListItem> ParkName { get; } = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "Cuyahoga Valley National Park"},
            new SelectListItem() {Text = "Everglades National Park"},
            new SelectListItem() {Text = "Grand Canyon National Park"},
            new SelectListItem() {Text = "Glacier National Park"},
            new SelectListItem() {Text = "Great Smoky Mountains National Park"},
            new SelectListItem() {Text = "Grand Teton National Park"},
            new SelectListItem() {Text = "Mount Rainier National Park"},
            new SelectListItem() {Text = "Rocky Mountain National Park"},
            new SelectListItem() {Text = "Yellowstone National Park"},
            new SelectListItem() {Text = "Yosemite National Park"}
        };

        public static List<SelectListItem> State { get; } = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "AL"},
            new SelectListItem() {Text = "AK"},
            new SelectListItem() {Text = "AZ"},
            new SelectListItem() {Text = "AR"},
            new SelectListItem() {Text = "CA"},
            new SelectListItem() {Text = "CO"},
            new SelectListItem() {Text = "CT"},
            new SelectListItem() {Text = "DE"},
            new SelectListItem() {Text = "FL"},
            new SelectListItem() {Text = "GA"},
            new SelectListItem() {Text = "HI"},
            new SelectListItem() {Text = "ID"},
            new SelectListItem() {Text = "IL"},
            new SelectListItem() {Text = "IN"},
            new SelectListItem() {Text = "IA"},
            new SelectListItem() {Text = "KS"},
            new SelectListItem() {Text = "KY"},
            new SelectListItem() {Text = "LA"},
            new SelectListItem() {Text = "ME"},
            new SelectListItem() {Text = "MD"},
            new SelectListItem() {Text = "MA"},
            new SelectListItem() {Text = "MI"},
            new SelectListItem() {Text = "MN"},
            new SelectListItem() {Text = "MS"},
            new SelectListItem() {Text = "MO"},
            new SelectListItem() {Text = "MT"},
            new SelectListItem() {Text = "NE"},
            new SelectListItem() {Text = "NV"},
            new SelectListItem() {Text = "NH"},
            new SelectListItem() {Text = "NJ"},
            new SelectListItem() {Text = "NM"},
            new SelectListItem() {Text = "NY"},
            new SelectListItem() {Text = "NC"},
            new SelectListItem() {Text = "ND"},
            new SelectListItem() {Text = "OH"},
            new SelectListItem() {Text = "OK"},
            new SelectListItem() {Text = "OR"},
            new SelectListItem() {Text = "PA"},
            new SelectListItem() {Text = "RI"},
            new SelectListItem() {Text = "SC"},
            new SelectListItem() {Text = "SD"},
            new SelectListItem() {Text = "TN"},
            new SelectListItem() {Text = "TX"},
            new SelectListItem() {Text = "UT"},
            new SelectListItem() {Text = "VT"},
            new SelectListItem() {Text = "VA"},
            new SelectListItem() {Text = "WA"},
            new SelectListItem() {Text = "WV"},
            new SelectListItem() {Text = "WI"},
            new SelectListItem() {Text = "WY"}

        };
    }
}