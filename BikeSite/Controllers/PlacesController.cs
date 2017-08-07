using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikeSite.Controllers
{
    public class PlacesController : Controller
    {
        // GET: Places
        public ActionResult PlacesIndex()
        {
            return View();
        }

        // GET: Places/Details/5
        public ActionResult PlaceDetails(int id)
        {
            return View();
        }

        // GET: Places/Create
        public ActionResult CreatePlace()
        {
            return View();
        }

        // POST: Places/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePlace(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Places/Edit/5
        public ActionResult EditPlace(int id)
        {
            return View();
        }

        // POST: Places/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Places/Delete/5
        public ActionResult DeletePlace(int id)
        {
            return View();
        }

        // POST: Places/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}