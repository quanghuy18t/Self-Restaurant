using Manage.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    public class FoodController : Controller
    {
        SelfRestaurant data = new SelfRestaurant();
        public ActionResult Index()
        {
            return View(data.FOODs.ToList().OrderBy(n => n.idFood));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new FOOD());
        }
        [HttpPost]
        public ActionResult Create(FOOD food, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                var sFileName = Path.GetFileName(image.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images/products"), sFileName);
                if (!System.IO.File.Exists(path))
                {
                    image.SaveAs(path);
                }
                food.image = sFileName;
                data.FOODs.Add(food);
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.View();
        }

        public ActionResult Detail(int id)
        {
            var food = data.FOODs.SingleOrDefault(n => n.idFood == id);
            if (food == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(food);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var food = data.FOODs.SingleOrDefault(n => n.idFood == id);
            if (food == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(food);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var food = data.FOODs.SingleOrDefault(n => n.idFood == id);
            if (food == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            var serve = data.SERVEs.SingleOrDefault(n => n.idFood == id && n.date == DateTime.Now);
            if (serve != null)
            {
                ViewBag.ThongBao = "Món ăn đang được phục vụ trong ngày hôm nay";
                return View(serve);
            }
            else
            {
                serve = data.SERVEs.SingleOrDefault(n => n.idFood == id);
                data.SERVEs.Remove(serve);
            }
            data.FOODs.Remove(food);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var food = data.FOODs.SingleOrDefault(n => n.idFood == id);
            if (food == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(food);
        }
        [HttpPost]
        public ActionResult Edit(int id, HttpPostedFileBase image)
        {
            var food = data.FOODs.SingleOrDefault(n => n.idFood == id);
            if (ModelState.IsValid)
            {
                var update = data.FOODs.Find(id);
                if (image != null)
                {
                    var sFileName = Path.GetFileName(image.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/images/products"), sFileName);
                    if (!System.IO.File.Exists(path))
                    {
                        image.SaveAs(path);
                    }
                    update.image = sFileName;
                }
                update.name = food.name;
                update.price = update.price;
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(food);
        }
    }
}