using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspAngularCP1.Models;

namespace AspAngularCP1.Controllers
{
    public class ResponsesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Responses
        public ActionResult Index()
        {
            return View(db.Responses.ToList());
        }

        // GET: Responses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responses responses = db.Responses.Find(id);
            if (responses == null)
            {
                return HttpNotFound();
            }
            return View(responses);
        }

        // GET: Responses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Responses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SurveyID,CustomerId,SavedAnswer,QuestionId")] Responses responses)
        {
            if (ModelState.IsValid)
            {
                db.Responses.Add(responses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(responses);
        }

        // GET: Responses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responses responses = db.Responses.Find(id);
            if (responses == null)
            {
                return HttpNotFound();
            }
            return View(responses);
        }

        // POST: Responses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SurveyID,CustomerId,SavedAnswer,QuestionId")] Responses responses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(responses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(responses);
        }

        // GET: Responses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Responses responses = db.Responses.Find(id);
            if (responses == null)
            {
                return HttpNotFound();
            }
            return View(responses);
        }

        // POST: Responses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Responses responses = db.Responses.Find(id);
            db.Responses.Remove(responses);
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
