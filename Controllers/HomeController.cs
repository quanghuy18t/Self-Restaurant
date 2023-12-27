using Manage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manage.Controllers
{
    public class HomeController : Controller
    {
        SelfRestaurant data = new SelfRestaurant();
        public ActionResult Index(int idBranch)
        {
            var query = from a in data.USERS
                        join b in data.SERVEs on a.idUser equals b.idUser
                        join c in data.FOODs on b.idFood equals c.idFood
                        where a.idBranch == idBranch
                        select c;
            var result = query.ToList();
            return View(result);
        }
        public ActionResult HeaderPartial()
        {
            ViewBag.state = int.Parse(Request.QueryString["idBranch"]);
            return PartialView(data.BRANCHes.ToList());
        }
    }
}