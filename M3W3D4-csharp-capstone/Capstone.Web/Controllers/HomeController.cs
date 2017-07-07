﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.Models;
using Capstone.Web.DAL;


namespace Capstone.Web.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = @"Data Source = localhost\sqlexpress;Initial Catalog = NationalParkGeek; Integrated Security = True";

        // GET: Home
        public ActionResult Index()
        {
            ParkSqlDAL parkDAL = new ParkSqlDAL(connectionString);
            List<Parks> model = parkDAL.GetAllParks();

			string result = Request.QueryString["celsius"];
			if (result != null)
			{
				if (result.Contains("true"))
				{
					Session["Celsius"] = "C";
				}
				else
				{
					Session["Celsius"] = "F";
				}
			}

			return View("Index", model);
        }

        public ActionResult Detail(string id)
        {
            ParkSqlDAL dal = new ParkSqlDAL(connectionString);
            Parks parkModel = dal.GetPark(id);

            ViewBag.weather = id;
			
			return View("Detail", parkModel);
        }
		public ActionResult Preferences()
		{
			return View("Preferences");
		}

	}
}