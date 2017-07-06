using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
			Weather result = new Weather();

			WeatherSqlDAL weather = new WeatherSqlDAL(connectionString);

			result = weather.GetWeather("ENP");

			Assert.AreEqual("ENP", result.ParkCode);
		}
	}
}
