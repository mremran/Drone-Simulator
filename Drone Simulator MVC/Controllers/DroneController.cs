using Drone;
using Drone_Simulator_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Drone_Simulator_MVC.Controllers
{
    public class DroneController : Controller
    {
        private readonly ILogger<DroneController> _logger;
        public iDrone _drone;
        public SimulatorModel _simulator;

        public DroneController(ILogger<DroneController> logger, iDrone drone)
        {
            _logger = logger;
            _drone = drone;
            _simulator = new SimulatorModel(drone);
        }


        // GET: DroneController
        public ActionResult Index()
        {
            return View(_simulator);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Start(SimulatorModel model)
        {
            model.DroneState.state = DroneStates.Start;
            return View("Index", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Shutdown(SimulatorModel model)
        {
            model.DroneState.state = DroneStates.Shutdown;
            model.DronePosition.xBorder = model.DronePosition.yBorder = 0;
            return View("Index", model);
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
        public ActionResult Light(IFormCollection collection)
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
