using Microsoft.AspNetCore.Mvc;
using TravelAPIClient.Models;

namespace TravelAPIClient.Controllers
{
    public class DestinationsController : Controller
    {
        public IActionResult Index()
        {
            var allDestinations = Destination.GetDestinations();
            return View(allDestinations);
        }

        public IActionResult Details(int id)
        {
            var thisDestination = Destination.GetDetails(id);
            return View(thisDestination);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Destination destination)
        {
            Destination.Post(destination);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisDestination = Destination.GetDetails(id);
            return View(thisDestination);
        }

        [HttpPost]
        public IActionResult Edit(Destination destination)
        {
            Destination.Put(destination);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisDestination = Destination.GetDetails(id);
            return View(thisDestination);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Destination.Delete(id);
            return RedirectToAction("Index");
        }
    }
}