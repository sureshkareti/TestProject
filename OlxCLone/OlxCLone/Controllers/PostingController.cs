using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlxCLone.Controllers
{
    public class PostingController : Controller
    {
        // GET: Posting        
        public ActionResult FreeAdd()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}