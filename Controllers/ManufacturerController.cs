using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrud.Models;
using System.Data.Entity;

namespace MvcCrud.Controllers
{
    public class ManufacturerController : Controller
    {
        // GET: Manufacturer
        public ActionResult Index()
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Manufacturers.ToList());
            }
        }

        // GET: Manufacturer/Details/5
        public ActionResult Details(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Manufacturers.Where(x => x.ManufacturerID == id).FirstOrDefault());
            }
        }

        // GET: Manufacturer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manufacturer/Create
        [HttpPost]
        public ActionResult Create(Manufacturer Manufacturer)
        {
            try
            {
                // TODO: Add insert logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    db.Manufacturers.Add(Manufacturer);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manufacturer/Edit/5
        public ActionResult Edit(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Manufacturers.Where(x => x.ManufacturerID == id).FirstOrDefault());
            }
        }

        // POST: Manufacturer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Manufacturer Manufacturer)
        {
            try
            {
                // TODO: Add update logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    db.Entry(Manufacturer).State = EntityState.Modified;
                    db.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manufacturer/Delete/5
        public ActionResult Delete(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Manufacturers.Where(x => x.ManufacturerID == id).FirstOrDefault());
            }
        }

        // POST: Manufacturer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Manufacturer Manufacturer)
        {
            try
            {
                // TODO: Add delete logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    Manufacturer = db.Manufacturers.Where((x) => x.ManufacturerID == id).FirstOrDefault();
                    db.Manufacturers.Remove(Manufacturer);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
