using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrud.Models;
using System.Data.Entity;

namespace MvcCrud.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Appointments.ToList());
               
            }
            
        }

        // GET: Appointment/Details/5
        public ActionResult Details(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Appointments.Where(x => x.AppointmentID == id).FirstOrDefault());
            }
        }

        // GET: Appointment/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Appointment/Create
        [HttpPost]
        public ActionResult Create(Appointment Appointment)
        {
            try
            {
                // TODO: Add insert logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    db.Appointments.Add(Appointment);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Appointment/Edit/5
        public ActionResult Edit(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Appointments.Where(x => x.AppointmentID == id).FirstOrDefault());
            }
        }

        // POST: Appointment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Appointment Appointment)
        {
            try
            {
                // TODO: Add update logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    db.Entry(Appointment).State = EntityState.Modified;
                    db.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Appointment/Delete/5
        public ActionResult Delete(int id)
        {
            using (MvcCrudEntities1 db = new MvcCrudEntities1())
            {
                return View(db.Appointments.Where(x => x.AppointmentID == id).FirstOrDefault());
            }
        }



        // POST: Appointment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Appointment Appointment)
        {
            try
            {
                // TODO: Add delete logic here
                using (MvcCrudEntities1 db = new MvcCrudEntities1())
                {
                    Appointment = db.Appointments.Where((x) => x.AppointmentID == id).FirstOrDefault();
                    db.Appointments.Remove(Appointment);
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
