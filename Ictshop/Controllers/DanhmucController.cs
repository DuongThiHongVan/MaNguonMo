using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Models
{
    public class DanhmucController : Controller
    {
        // GET: Danhmuc
        Qlbanhang db = new Qlbanhang();
        public ActionResult DanhmucPartial()
        {
            var danhmuc = db.Hangsanxuats.ToList();
            return PartialView(danhmuc);
        }
    }
}