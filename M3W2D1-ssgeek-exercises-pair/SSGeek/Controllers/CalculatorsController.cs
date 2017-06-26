using SSGeek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSGeek.Controllers
{
    public class CalculatorsController : Controller
    {
        // INSTRUCTIONS
        // As a part of each exercise you will need to 
        // - develop a view for AlienAge, AlienWeight, and AlienTravel that displays a form to submit data
        // - develop a model for the forms to bind to when the form request is submitted
        // - create a new action to process the form submission (e.g. AlienAgeResult, AlienWeightResult, etc.)
        // - create a view that displays the submitted form result

        // GET: Calculators/AlienAge
        public ActionResult AlienAge()
        {            
            return View("AlienAge");
        }

        public ActionResult AlienAgeResult(string planetList, int earthAge)
        {
            AlienAgeModel model = new AlienAgeModel()
            {
                PlanetList = planetList,
                EarthAge = earthAge
            };
            return View("AlienAgeResult", model);
        }
        
        public ActionResult AlienWeight()
        {
            return View("AlienWeight");
        }

        public ActionResult AlienWeightResult(string planetList, int earthWeight)
        {
            AlienAgeModel modelTwo = new AlienAgeModel()
            {
                PlanetList = planetList,
                EarthWeight = earthWeight
            };
            return View("AlienWeightResult", modelTwo);
        }

        public ActionResult AlienTravel()
        {
            return View("AlienTravel");
        }

        public ActionResult AlienTravelResult(string planetList, string travelList, int earthAge)
        {
            AlienAgeModel travelModel = new AlienAgeModel()
            {
                PlanetList = planetList,
                TravelList = travelList,
                EarthAge = earthAge
            };
            return View("AlienTravelResult", travelModel);
        }
        //TODO: Create an AlienWeight and AlienWeightResult Action
        //TODO: Create an AlienTravel and AlienTravelResult Action

        

        private List<SelectListItem> transportationModes = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Walking", Value="walking" },
            new SelectListItem() { Text = "Car", Value = "car" },
            new SelectListItem() { Text = "Bullet Train", Value = "bullet train" },
            new SelectListItem() { Text = "Boeing 747", Value = "boeing 747" },
            new SelectListItem() { Text = "Concorde", Value = "concorde" }
        };
    }
}