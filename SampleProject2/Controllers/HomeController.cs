using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleProject2.Models;

namespace SampleProject2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            using (SampleProjectEntities db = new SampleProjectEntities())
            {
                var userDetails = db.Users.Where(x => x.UserName == user.UserName && x.UserPassword == user.UserPassword).FirstOrDefault();

                if (userDetails == null)
                {

                    user.LoginErrorMsg = "you have enter an incorrect password or user name";

                    return View("index", user);
                }
                else
                {
                    Session["UserID"] = userDetails.UserID;

                    return RedirectToAction("index", "DashBoard");
                }

            }

        }

        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("index");
        }
    }
}