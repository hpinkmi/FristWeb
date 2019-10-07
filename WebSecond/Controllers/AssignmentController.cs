using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public class AssignmentContainer
{
    public string user { get; set; }
    public int count { get; set; }
}

namespace WebSecond.Controllers
{
    public class AssignmentController : Controller
 
    {
        // GET: Assignment
        public ActionResult assign()
        {
            return View();
        }
        public ActionResult test(AssignmentContainer data)
        {
            return View("assign", data);
        }
    }
}