using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drone_Simulator_MVC.Controllers
{
    public class DroneController : Controller
    {
        // GET: DroneController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DroneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DroneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DroneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DroneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DroneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DroneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DroneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
