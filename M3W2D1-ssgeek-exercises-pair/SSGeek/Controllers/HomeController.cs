using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSGeek.Models;
using SSGeek.DAL;
using System.Web.Configuration;

namespace SSGeek.Controllers
{
    public class HomeController : Controller
    {
		string connectionString = WebConfigurationManager.ConnectionStrings["SSGeek"].ToString();
		ForumPostSqlDAL forumDAL;

		// GET: Home
		public HomeController()
		{
			forumDAL = new ForumPostSqlDAL(connectionString);
		}
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Planets"); //<-- if user goes to .com/ this redirects to .com/planets/index
        }
		public ActionResult SpaceForum()
		{
			return View("SpaceForumResult");
		}

		public ActionResult SpaceForumResult(string username, string subject, string message)
		{
			ForumPost model = new ForumPost()
			{
				Username = username,
				Subject = subject,
				Message = message
			};
			return View("SpaceForum", model);
		}
		[HttpPost]
		public ActionResult SpaceForumResult(ForumPost post)
		{
			forumDAL.SaveNewPost(post);

			return View("SpaceForum");
		}
		public ActionResult GiftShop()
		{
            return View("GiftShop");
		}
        public ActionResult Detail(int id)
        {

            ProductSqlDAL dal = new ProductSqlDAL(connectionString);
            Product product = dal.GetProduct(id);

            return View("Detail", product);
        }

    }
}