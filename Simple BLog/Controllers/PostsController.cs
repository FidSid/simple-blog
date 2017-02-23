using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_BLog.Controllers
{
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return Content("<hr/>View");
        }
    }
}