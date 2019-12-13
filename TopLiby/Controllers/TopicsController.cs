using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TopLiby.Models;

namespace TopLiby.Controllers
{
    public class TopicsController : Controller
    {
        // GET: Topics
        public ActionResult Index()
        {

            using (TopicsDbContext db = new TopicsDbContext())
            {
                var topic = db.Topic.ToList();


                return View(topic);
            }

            
        }

        // GET: Topics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Topics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Topics/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public ActionResult Create(Topic topic)
        {
            using (TopicsDbContext db = new TopicsDbContext())
                if (ModelState.IsValid)
            {
                db.Topic.Add(topic);
                db.SaveChanges();
                return RedirectToAction("Index");
                }
            return View(topic);
        }
        

        // GET: Topics/Edit/5
        public ActionResult Edit(int? id)
        {
            using (TopicsDbContext db = new TopicsDbContext())
            {
                if (id == null)
                {
                    return HttpNotFoundResult("Not Found");
                }

                var topic = db.Topic.SingleOrDefault(e => e.TopicId == id);
                if (topic == null)
                {
                    return HttpNotFound();
                }
                return View(topic);
                
            }
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        private ActionResult HttpNotFoundResult(string v)
        {
            throw new NotImplementedException();
        }

        // POST: Topics/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Topic topic)
        {
            using (TopicsDbContext db = new TopicsDbContext())
            {


                if (ModelState.IsValid)
                {
                    db.Entry(topic).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(topic);
            }
        }
        public ActionResult Detail(int? id)
        {
            using (TopicsDbContext db = new TopicsDbContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    
                }

                var topic = db.Topic.SingleOrDefault(e => e.TopicId == id);
                if (topic == null)
                {
                    return HttpNotFound();
                }
                return View(topic);
            }
        }

        // GET: Topics/Delete/5


        //// POST: Topics/Delete/5
        //[HttpPost]
       
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            using (TopicsDbContext db = new TopicsDbContext())
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var topic = db.Topic.SingleOrDefault(e => e.TopicId == id);
                if (topic == null)
                {
                    return HttpNotFound();
                }
                return View(topic);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            using (TopicsDbContext db = new TopicsDbContext())
            {
                var topic = db.Topic.SingleOrDefault(x => x.TopicId == id);
                db.Topic.Remove(topic ?? throw new InvalidOperationException());
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        
    }
}