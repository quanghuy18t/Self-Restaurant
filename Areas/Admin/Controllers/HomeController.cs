using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using Manage.Models;

namespace Manage.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        SelfRestaurant data = new SelfRestaurant();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            if (ModelState.IsValid)
            {
                var sUserName = f["UserName"];
                var sPassword = f["Password"];

                if (String.IsNullOrEmpty(sUserName) || String.IsNullOrEmpty(sPassword))
                {
                    if (String.IsNullOrEmpty(sUserName))
                    {
                        ViewData["err1"] = "Tài khoản không được để trống";
                    }
                    if (String.IsNullOrEmpty(sPassword))
                    {
                        ViewData["err2"] = "Mật khẩu không được để trống";
                    }
                }
                else
                {
                    USER admin = data.USERS.SingleOrDefault(n => n.userName == sUserName && n.passWord == sPassword && n.idRole == 1);
                    if (admin != null)
                    {
                        Session["Admin"] = admin;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                    }
                }
            }

            return View();
        }
    }
}