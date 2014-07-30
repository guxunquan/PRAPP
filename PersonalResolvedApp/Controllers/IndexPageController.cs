using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalResolvedApp.IBLL;
using Microsoft.Practices.Unity;

namespace PersonalResolvedApp.Controllers
{
    public class IndexPageController : Controller
    {
        //
        // GET: /IndexPage/
        [Dependency]
        public INewIndexIBLL INew_IBLL { get;set;}

        public ActionResult PRIndexPage()
        {
           ViewData["TTT"]= INew_IBLL.getstring().ToString();
            return View();
        }

    }
}
