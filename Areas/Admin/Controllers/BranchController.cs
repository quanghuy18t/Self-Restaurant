using Manage.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    public class BranchController : Controller
    {
        SelfRestaurant data = new SelfRestaurant();
        public ActionResult Index()
        {
            return View(data.BRANCHes.ToList().OrderBy(n => n.idBranch));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new BRANCH());
        }
        [HttpPost]
        public ActionResult Create(BRANCH branch)
        {
            if (ModelState.IsValid)
            {
                data.BRANCHes.Add(branch);
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.View();
        }

        public ActionResult Detail(int id)
        {
            var branch = data.BRANCHes.SingleOrDefault(n => n.idBranch == id);
            if (branch == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(branch);
        }
        [HttpGet] 
        public ActionResult Delete(int id)
        {
            var branch = data.BRANCHes.SingleOrDefault(n => n.idBranch == id);
            if (branch == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(branch);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var branch = data.BRANCHes.SingleOrDefault(n => n.idBranch == id);
            if (branch == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            var user = data.USERS.Where(n => n.idBranch == id);
            if (user.Count() > 0)
            {
                ViewBag.ThongBao = "Chi nhánh đang có nhân viên làm việc. Vui lòng xóa nhân viên tại chi nhánh trước khi xóa chi nhánh này";
                return View(branch);
            }
            data.BRANCHes.Remove(branch);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var branch = data.BRANCHes.SingleOrDefault(n => n.idBranch == id);
            if (branch == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(branch);
        }
        [HttpPost]
        public ActionResult Edit(BRANCH branch)
        {
            if (ModelState.IsValid)
            {
                var update = data.BRANCHes.Find(branch.idBranch);
                update.address = branch.address;
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(branch);
        }
    }
}