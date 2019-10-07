using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public class container
{
   public string id { get; set; }
   public string user { get; set; }
   public string pw { get; set; }
}

namespace WebSecond.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(string id)
        {
            return View((object)id);
        }

        public ActionResult Login(container data)
        {
            return View("Index",data);
        }
    }
}