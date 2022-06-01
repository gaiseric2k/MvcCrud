using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrud.Models;
using System.Data.Entity;

namespace MvcCrud.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Vehicles.ToList());
            }

            
        }
       /* public ActionResult GetList()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            SelectListItem item1 = new SelectListItem() { Text = "Manama", Value = 1, Selected = true };
            return View();
        }*/
        // GET: Vehicle/Details/5
        public ActionResult Details(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Vehicles.Where(x => x.VehicleID == id).FirstOrDefault());
            }
        }

        // GET: Vehicle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicle/Create
        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            try
            {
                // TODO: Add insert logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    db.Vehicles.Add(vehicle);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Edit/5
        public ActionResult Edit(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Vehicles.Where(x => x.VehicleID == id).FirstOrDefault());
            }
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Vehicle vehicle)
        {
            try
            {
                // TODO: Add update logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    db.Entry(vehicle).State = EntityState.Modified;
                    db.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vehicle/Delete/5
        public ActionResult Delete(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Vehicles.Where(x => x.VehicleID == id).FirstOrDefault());
            }
        }

        // POST: Vehicle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Vehicle vehicle)
        {
            try
            {
                // TODO: Add delete logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    vehicle = db.Vehicles.Where((x) => x.VehicleID == id).FirstOrDefault();
                    db.Vehicles.Remove(vehicle);
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
