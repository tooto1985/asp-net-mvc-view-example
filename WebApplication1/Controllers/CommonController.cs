using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult Index()
        {
            List<string> list = new List<string>();
            list.Add("aaaa");
            list.Add("bbbb");
            list.Add("cccc");
            TempData["cart"] = "gold";
            return View(list);
        }

        public ActionResult partial() {
            List<string> list = new List<string>();
            list.Add("xxxx");
            list.Add("yyyy");
            list.Add("zzzz");
            return PartialView(list);
        }

    }
}