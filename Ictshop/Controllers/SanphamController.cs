using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Models
{
    public class SanphamController : Controller
    {
        // GET: Sanpham
        //Qlbanhang db = new Qlbanhang();
        public ActionResult Index()
        {
            return View();
        }
    }
}