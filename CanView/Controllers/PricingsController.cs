using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CanView.Models;

namespace CanView.Controllers
{
    public class PricingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pricings
        public ActionResult Index()
        {
            return View(db.ticketPrices.ToList());
        }

        // GET: Pricings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketPricing pricing = db.ticketPrices.Find(id);
            if (pricing == null)
            {
                return HttpNotFound();
            }
            return View(pricing);
        }

        // GET: Pricings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pricings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] TicketPricing pricing)
        {
            if (ModelState.IsValid)
            {
                db.ticketPrices.Add(pricing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pricing);
        }

        // GET: Pricings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketPricing pricing = db.ticketPrices.Find(id);
            if (pricing == null)
            {
                return HttpNotFound();
            }
            return View(pricing);
        }

        // POST: Pricings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] TicketPricing pricing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pricing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pricing);
        }

        // GET: Pricings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketPricing pricing = db.ticketPrices.Find(id);
            if (pricing == null)
            {
                return HttpNotFound();
            }
            return View(pricing);
        }

        // POST: Pricings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TicketPricing pricing = db.ticketPrices.Find(id);
            db.ticketPrices.Remove(pricing);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
