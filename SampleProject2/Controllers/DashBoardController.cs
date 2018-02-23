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
                // return db.Members.ToList<Member>();
                int user = (int)Session["UserID"];

                return db.Members.Where(x => x.UserID == user).ToList<Member>();
            }
        }
        public ActionResult CreateMember()
        {
            Member member = new Member();

            return View(member);
        }
       
        public ActionResult Delete(int id)
        {

            try
            {

                 using (SampleProjectEntities db = new SampleProjectEntities())
                {

                    Member member = db.Members.Where(x => x.MemberID == id).FirstOrDefault<Member>();
                    db.Members.Remove(member);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

            }
            
                

            return RedirectToAction("index", "DashBoard");
        }
        [HttpPost]
        public ActionResult AddOrEdit(Models.Member member)
        {  

            using (SampleProjectEntities db = new SampleProjectEntities())
            {
                Member mem = new Member();
                mem.UserID = (int)Session["UserID"];
                mem.MemberName = member.MemberName;
                mem.MemberRelation = member.MemberRelation;
                mem.MemberAddress = member.MemberAddress;

              
                   
                db.Members.Add(mem);
                db.SaveChanges();
            }

            return RedirectToAction("index", "DashBoard");
        }
    }
}