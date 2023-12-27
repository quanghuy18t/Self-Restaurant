using Manage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Manage.Areas.Admin.Controllers
{
    public class GiftCardController : Controller
    {
        SelfRestaurant data = new SelfRestaurant();
        public ActionResult Index()
        {
            return View(data.GIFTCARDs.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new GIFTCARD());
        }
        [HttpPost]
        public ActionResult Create(GIFTCARD card)
        {
            if (ModelState.IsValid)
            {
                var user = (USER)Session["Admin"];
                card.create_at = DateTime.Now;
                card.idUser = user.idUser;
                data.GIFTCARDs.Add(card);
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.View();
        }
        public ActionResult Detail(int id)
        {
            var card = data.GIFTCARDs.SingleOrDefault(n => n.idCard == id);
            if (card == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(card);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var card = data.GIFTCARDs.SingleOrDefault(n => n.idCard == id);
            if (card == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(card);
        }
        [HttpPost]
        public ActionResult Edit(GIFTCARD card)
        {
            if (ModelState.IsValid)
            {
                var update = data.GIFTCARDs.Find(card.idCard);
                update.name = card.name;
                update.phone = card.phone;
                update.point = card.point;
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(card);
        }
    }
}