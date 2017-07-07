using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Web.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
		[TestMethod()]
		public void DetailTest()
		{
		
			HomeController controller = new HomeController();

		
			ViewResult result = controller.Detail("CVNP") as ViewResult;

		
			Assert.IsNotNull(result);
			Assert.AreEqual("Detail", result.ViewName);
		}
		[TestMethod()]
		public void SurveyTest()
		{

			HomeController controller = new HomeController();


			ViewResult result = controller.Survey() as ViewResult;


			Assert.IsNotNull(result);
			Assert.AreEqual("Survey", result.ViewName);
		}
		[TestMethod()]
		public void SurveyResultTest()
		{

			HomeController controller = new HomeController();


			ViewResult result = controller.SurveyResult() as ViewResult;


			Assert.IsNotNull(result);
			Assert.AreEqual("SurveyResult", result.ViewName);
		}

	}
}