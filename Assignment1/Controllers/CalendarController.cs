using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEvents()
        {
            using (AssignmentMEntities dc = new AssignmentMEntities())
            {
                var events = dc.Events.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
        //public JsonResult SaveEvent(Event e)
        //{
        //    var status = false;
        //    using(AssignmentMEntities dc=new AssignmentMEntities())
        //    {
        //        if (e.EventID > 0)
        //        {
        //            var v=dc.Events.Where(a= >a.                }
        //    }
        //}
        public JsonResult SaveEvent(Event e)
        {
            var status = false;
            using (AssignmentMEntities dc = new AssignmentMEntities())
            {
                if (e.EventID > 0)
                {
                    var v = dc.Events.Where(a => a.EventID == e.EventID).FirstOrDefault();
                    if (v != null)
                    {
                        v.Subject = e.Subject;
                        v.Startdate = e.Startdate;
                        v.Enddate = e.Enddate;
                        v.Description = e.Description;
                        v.Isfullday = e.Isfullday;
                        v.Themecolor = e.Themecolor;
                    }
                }
                else
                {
                    dc.Events.Add(e);
                }
                dc.SaveChanges();
                status = true;
            }
            return new JsonResult { Data = new { status = status } };
        }

        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;
            using (AssignmentMEntities dc = new AssignmentMEntities())
            {
                var v = dc.Events.Where(a => a.EventID == eventID).FirstOrDefault();
                if (v != null)
                {
                    dc.Events.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
                else
                {

                }
                return new JsonResult { Data = new { status = status } };
            }
        }
    }
}