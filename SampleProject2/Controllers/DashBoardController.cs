using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleProject2.Models;

namespace SampleProject2.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            return View(GetAllMember());
        }

        IEnumerable<Member> GetAllMember()
        {
            using (SampleProjectEntities db = new SampleProjectEntities())
            {
                return db.Members.ToList<Member>();


            }


        }

    }
}