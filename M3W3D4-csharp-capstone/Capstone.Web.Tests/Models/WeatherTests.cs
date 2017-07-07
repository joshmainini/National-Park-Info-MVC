using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.Models;
using Capstone.Web.DAL;
using System.Collections.Generic;

namespace Capstone.Web.Tests.Models
{
	[TestClass]
	public class WeatherTests
	{
		private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=NationalParkGeek;Integrated Security=True";

		[TestMethod]
		public void GetLowTempTest()
		{
			WeatherSqlDAL dal = new WeatherSqlDAL(connectionString);
			List<Weather> model = dal.GetWeather("ENP");

			Assert.AreEqual(70, model[0].LowTemp);
		}
		[TestMethod]
		public void GetHighTempTest()
		{
			WeatherSqlDAL dal = new WeatherSqlDAL(connectionString);
			List<Weather> model = dal.GetWeather("ENP");

			Assert.AreEqual(82, model[0].HighTemp);
		}
	}
}
