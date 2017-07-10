using System;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.DAL;
using Capstone.Web.Models;
using System.Collections.Generic;

namespace Capstone.Web.Tests.DAL
{
	[TestClass]
	public class SurveySqlDALTests
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
		public void GetAllPostsTest()
		{

			SurveySqlDAL dal = new SurveySqlDAL(connectionString);

			List<SurveyModel> result = dal.GetAllPosts();

			Assert.AreEqual(1, result.Count);
		}
		[TestMethod]
		public void SavePostTest()
		{
			SurveyModel model = new SurveyModel()
			{
				FavoritePark = "Everglades National Park",
				Email = "josh@techelevator.com",
				Residence = "OH",
				ActivityLevel = "Low"
			};

			SurveySqlDAL dal = new SurveySqlDAL(connectionString);

			bool result = dal.SaveNewPost(model);

			Assert.AreEqual(true, result);
		}
	}
	
}
