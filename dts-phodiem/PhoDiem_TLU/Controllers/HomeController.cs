using PhoDiem_TLU.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XLT_TLU.Controllers
{
    public class HomeController:BaseController 
    {
        // GET: Home
        public ActionResult Index()
        {
            //DataCopy copy = new DataCopy();
            //copy.CopyDataInDB("","");
            return View();
        }
    }
}