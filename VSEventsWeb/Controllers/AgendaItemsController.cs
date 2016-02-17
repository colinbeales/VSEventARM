using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VSEventsWeb.Models;

namespace VSEventsWeb
{
    public class AgendaItemsController : Controller
    {
        private VSEventsWebContext db = new VSEventsWebContext();

        // GET: AgendaItems
        public ActionResult Index()
        {
            return View(db.AgendaItems.ToList());
        }

        // GET: AgendaItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendaItem agendaItem = db.AgendaItems.Find(id);
            if (agendaItem == null)
            {
                return HttpNotFound();
            }
            return View(agendaItem);
        }

        // GET: AgendaItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgendaItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Timeslot,Description")] AgendaItem agendaItem)
        {
            if (ModelState.IsValid)
            {
                db.AgendaItems.Add(agendaItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agendaItem);
        }

        // GET: AgendaItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendaItem agendaItem = db.AgendaItems.Find(id);
            if (agendaItem == null)
            {
                return HttpNotFound();
            }
            return View(agendaItem);
        }

        // POST: AgendaItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Timeslot,Description")] AgendaItem agendaItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agendaItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agendaItem);
        }

        // GET: AgendaItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendaItem agendaItem = db.AgendaItems.Find(id);
            if (agendaItem == null)
            {
                return HttpNotFound();
            }
            return View(agendaItem);
        }

        // POST: AgendaItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgendaItem agendaItem = db.AgendaItems.Find(id);
            db.AgendaItems.Remove(agendaItem);
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
