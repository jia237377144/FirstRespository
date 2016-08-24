using mvc.Redis_Comm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            RedisHelper rh = new RedisHelper();
            string ss= rh.Str();
            ViewBag.Message = Session["testRedisSession"];
            return View(); 
        }

    }
}
