using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;
using Capstone.Web.Models;
using Capstone.Web.DAL;

namespace Capstone.Web.Tests.DAL
{
	[TestClass]
	public class ParkSqlDALTests
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
		public void GetAllParksTest()
		{
			List<Park> result = new List<Park>();

			ParkSqlDAL parks = new ParkSqlDAL(connectionString);

			result = parks.GetAllParks();

			Assert.AreEqual(10, result.Count);
		}
		[TestMethod]
		public void GetParkTest()
		{
			Park result = new Park();

			ParkSqlDAL parks = new ParkSqlDAL(connectionString);

			result = parks.GetPark("ENP");

			Assert.AreEqual(1, result.Count);
		}
		[TestMethod]
		public void GetParkTest_name()
		{
			Park result = new Park();

			ParkSqlDAL parks = new ParkSqlDAL(connectionString);

			result = parks.GetPark("ENP");

			Assert.AreEqual("Everglades National Park", result.Name);
		}
	}
}
