using Manage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    public class StaffController : Controller
    {
        SelfRestaurant data = new SelfRestaurant();
        public ActionResult Index()
        {
            return View(data.USERS.ToList().OrderByDescending(n => n.idRole));
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.idRole = new SelectList(data.ROLEs.ToList().Where(n => n.idRole != 1), "idRole", "name");
            ViewBag.idBranch = new SelectList(data.BRANCHes.ToList(), "idBranch", "address");
            return View(new USER());
        }
        [HttpPost]
        public ActionResult Create(USER user)
        {
            ViewBag.idRole = new SelectList(data.ROLEs.ToList().Where(n => n.idRole != 1), "idRole", "name");
            ViewBag.idBranch = new SelectList(data.BRANCHes.ToList(), "idBranch", "address");
            if (ModelState.IsValid)
            {
                data.USERS.Add(user);
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(new USER());
        }

        public ActionResult Detail(int id)
        {
            var user = data.USERS.SingleOrDefault(n => n.idUser == id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(user);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var user = data.USERS.SingleOrDefault(n => n.idBranch == id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(user);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var user = data.USERS.SingleOrDefault(n => n.idUser == id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.USERS.Remove(user);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = data.USERS.SingleOrDefault(n => n.idUser == id);
            ViewBag.idRole = new SelectList(data.ROLEs.ToList().Where(n => n.idRole != 1), "idRole", "name");
            ViewBag.idBranch = new SelectList(data.BRANCHes.ToList(), "idBranch", "address");
            if (user == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(USER user)
        {
            ViewBag.idRole = new SelectList(data.ROLEs.ToList().Where(n => n.idRole != 1), "idRole", "name");
            ViewBag.idBranch = new SelectList(data.BRANCHes.ToList(), "idBranch", "address");
            if (ModelState.IsValid)
            {
                var update = data.USERS.Find(user.idUser);
                update.name = user.name;
                update.phone = user.phone;
                update.idRole = user.idRole;
                update.idBranch = user.idBranch;
                update.userName = user.userName;
                update.passWord = user.passWord;
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}