using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using System.Configuration;
using System.Data.SqlClient;
using Capstone.Web.Models;
using Capstone.Web.DAL;

namespace Capstone.Web.Tests.DAL
{
	[TestClass]
	public class WeatherSqlDALTest
	{
		private TransactionScope tran;
		private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=NationalParkGeek;Integrated Security=True";

		[TestInitialize]
		public void Initialize()
		{
			tran = new TransactionScope();
		}


		[TestCleanup]
		public void Cleanup()
		{
			tran.Dispose();
		}

		[TestMethod]
		public void GetWeatherTest_ParkCode()
		{
			List<Weather> result = new List<Weather>();

			WeatherSqlDAL weather = new WeatherSqlDAL(connectionString);

			result = weather.GetWeather("ENP");

			Assert.AreEqual("ENP", result[1].ParkCode);
		}
	}
}
