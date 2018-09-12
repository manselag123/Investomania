using Investomania.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Investomania.Controllers
{
    public class NewsController : Controller
    {
        private InvestomaniaEntities db = new InvestomaniaEntities();
        // GET: News
        public ActionResult Index()
        {
            var news = db.News.OrderByDescending(e => e.creationDate).Take(100).ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new New());
        }
        public ActionResult addPost()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(New newObj)
        {
            newObj.creationDate = DateTime.Now;
            db.News.Add(newObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}