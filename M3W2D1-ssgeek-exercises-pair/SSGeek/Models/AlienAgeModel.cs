using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Models
{
    public class AlienAgeModel
    {
        public int EarthAge { get; set; }
        public string PlanetList { get; set; }
        public int EarthWeight { get; set; }
        public string TravelList { get; set; }


        public static List<SelectListItem> Travel { get; } = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "Walking"},
            new SelectListItem() {Text = "Car"},
            new SelectListItem() {Text = "Bullet Train"},
            new SelectListItem() {Text = "Boeing 747"},
            new SelectListItem() {Text = "Concorde"}
        };

        public static List<SelectListItem> Planets { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Mercury" },
            new SelectListItem() { Text = "Venus" },
            new SelectListItem() { Text = "Mars" },
            new SelectListItem() { Text = "Jupiter" },
            new SelectListItem() { Text = "Saturn" },
            new SelectListItem() { Text = "Neptune" },
            new SelectListItem() { Text = "Uranus" }
        };

        public double CalculateAge()
        {
            if (PlanetList == "Mercury")
            {

                double result = (EarthAge / 0.241);
                return result;
            }
            else if (PlanetList == "Venus")
            {

                double result = (EarthAge / 0.615);
                return result;
            }
            else if (PlanetList == "Mars")
            {

                double result = (EarthAge / 1.88);
                return result;
            }
            else if (PlanetList == "Jupiter")
            {

                double result = (EarthAge / 11.9);
                return result;
            }
            else if (PlanetList == "Saturn")
            {

                double result = (EarthAge / 29.5);
                return result;
            }
            else if (PlanetList == "Uranus")
            {

                double result = (EarthAge / 84.0);
                return result;
            }
            else if (PlanetList == "Neptune")
            {

                double result = (EarthAge / 164.8);
                return result;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateWeight()
        {
            if (PlanetList == "Mercury")
            {

                double result = (EarthWeight * 0.38);
                return result;
            }
            else if (PlanetList == "Venus")
            {

                double result = (EarthWeight * 0.91);
                return result;
            }
            else if (PlanetList == "Mars")
            {

                double result = (EarthWeight * 0.38);
                return result;
            }
            else if (PlanetList == "Jupiter")
            {

                double result = (EarthWeight * 2.36);
                return result;
            }
            else if (PlanetList == "Saturn")
            {

                double result = (EarthWeight * 0.91);
                return result;
            }
            else if (PlanetList == "Uranus")
            {

                double result = (EarthWeight * 0.89);
                return result;
            }
            else if (PlanetList == "Neptune")
            {

                double result = (EarthWeight * 1.12);
                return result;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateTravel()
        {
            if (PlanetList == "Mercury")
            {
                if (TravelList == "Walking")
                {
                    double result = (56974146 / 3) / 8760;
                    return result;
                }
                else if (TravelList == "Car")
                {
                    double result = (56974146 / 100) / 8760;
                    return result;
                }
                else if (TravelList == "Bullet Train")
                {
                    double result = (56974146 / 200) / 8760;
                    return result;
                }
                else if (TravelList == "Boeing 747")
                {
                    double result = (56974146 / 570) / 8760;
                    return result;
                }
                else
                {
                    double result = (56974146 / 1350) / 8760;
                    return result;
                }

            }
            else if (PlanetList == "Venus")
            {
                if (TravelList == "Walking")
                {
                    double result = (25724767 / 3) / 8760;
                    return result;
                }
                else if (TravelList == "Car")
                {
                    double result = (25724767 / 100) / 8760;
                    return result;
                }
                else if (TravelList == "Bullet Train")
                {
                    double result = (25724767 / 200) / 8760;
                    return result;
                }
                else if (TravelList == "Boeing 747")
                {
                    double result = (25724767 / 570) / 8760;
                    return result;
                }
                else
                {
                    double result = (25724767 / 1350) / 8760;
                    return result;
                }
              
            }
            else if (PlanetList == "Mars")
            {
                if (TravelList == "Walking")
                {
                    double result = (48678219 / 3) / 8760;
                    return result;
                }
                else if (TravelList == "Car")
                {
                    double result = (48678219 / 100) / 8760;
                    return result;
                }
                else if (TravelList == "Bullet Train")
                {
                    double result = (48678219 / 200) / 8760;
                    return result;
                }
                else if (TravelList == "Boeing 747")
                {
                    double result = (48678219 / 570) / 8760;
                    return result;
                }
                else
                {
                    double result = (48678219 / 1350) / 8760;
                    return result;
                }
            }
            else if (PlanetList == "Jupiter")
            {
                if (TravelList == "Walking")
                {
                    double result = (390674710 / 3) / 8760;
                    return result;
                }
                else if (TravelList == "Car")
                {
                    double result = (390674710 / 100) / 8760;
                    return result;
                }
                else if (TravelList == "Bullet Train")
                {
                    double result = (390674710 / 200) / 8760;
                    return result;
                }
                else if (TravelList == "Boeing 747")
                {
                    double result = (390674710 / 570) / 8760;
                    return result;
                }
                else
                {
                    double result = (390674710 / 1350) / 8760;
                    return result;
                }
            }
            else if (PlanetList == "Saturn")
            {
                if (TravelList == "Walking")
                {
                    double result = (792248270 / 3) / 8760;
                    return result;
                }
                else if (TravelList == "Car")
                {
                    double result = (792248270 / 100) / 8760;
                    return result;
                }
                else if (TravelList == "Bullet Train")
                {
                    double result = (792248270 / 200) / 8760;
                    return result;
                }
                else if (TravelList == "Boeing 747")
                {
                    double result = (792248270 / 570) / 8760;
                    return result;
                }
                else
                {
                    double result = (792248270 / 1350) / 8760;
                    return result;
                }
            }
            else if (PlanetList == "Uranus")
            {
                if (TravelList == "Walking")
                {
                    double result = (1692662530 / 3) / 8760;
                    return result;
                }
                else if (TravelList == "Car")
                {
                    double result = (1692662530 / 100) / 8760;
                    return result;
                }
                else if (TravelList == "Bullet Train")
                {
                    double result = (1692662530 / 200) / 8760;
                    return result;
                }
                else if (TravelList == "Boeing 747")
                {
                    double result = (1692662530 / 570) / 8760;
                    return result;
                }
                else
                {
                    double result = (1692662530 / 1350) / 8760;
                    return result;
                }
            }
            else if (PlanetList == "Neptune")
            {
                if (TravelList == "Walking")
                {
                    double result = (2703959960 / 3) / 8760;
                    return result;
                }
                else if (TravelList == "Car")
                {
                    double result = (2703959960 / 100) / 8760;
                    return result;
                }
                else if (TravelList == "Bullet Train")
                {
                    double result = (2703959960 / 200) / 8760;
                    return result;
                }
                else if (TravelList == "Boeing 747")
                {
                    double result = (2703959960 / 570) / 8760;
                    return result;
                }
                else
                {
                    double result = (2703959960 / 1350) / 8760;
                    return result;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}