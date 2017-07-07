using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.Models;
using Capstone.Web.DAL;
using System.Data.SqlClient;
using System.Transactions;


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
			List<Parks> result = new List<Parks>();

			ParkSqlDAL parks = new ParkSqlDAL(connectionString);

			result = parks.GetAllParks();

			Assert.AreEqual(10, result.Count);
		}
		[TestMethod]
		public void GetParkTest_climate()
		{
			Parks result = new Parks();

			ParkSqlDAL parks = new ParkSqlDAL(connectionString);

			result = parks.GetPark("ENP");

			Assert.AreEqual("Tropical", result.Climate);
		}
		[TestMethod]
		public void GetParkTest_name()
		{
			Parks result = new Parks();

			ParkSqlDAL parks = new ParkSqlDAL(connectionString);

			result = parks.GetPark("ENP");

			Assert.AreEqual("Everglades National Park", result.Name);
		}
	}
}
