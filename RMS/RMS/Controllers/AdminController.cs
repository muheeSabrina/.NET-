using RMS.Auth;
using RMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RMS.Controllers
{
    [Logged]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult RequestList()
        {
            RMSEntities context = new RMSEntities();
            var reqs = (from r in context.Requests
                        select r).ToList();
            return View(reqs);
        }
        public ActionResult Edit(int id)
        {
            RMSEntities context = new RMSEntities();
            var req = (from r in context.Requests
                       where r.Id == id
                       select r).FirstOrDefault();
            ViewBag.AssignTo = (from u in context.Users
                                where u.TypeId == 3
                                select u).ToList();
            return View(req);

        }
        [HttpPost]
        public ActionResult Edit(Request request)
        {
            RMSEntities context = new RMSEntities();
            var req = (from r in context.Requests
                       where r.Id == request.Id
                       select r).FirstOrDefault();
            req.AssignedTo = request.AssignedTo;
            req.StatusId = 2;
            context.SaveChanges();
            return RedirectToAction("RequestList");

        }
    }
}