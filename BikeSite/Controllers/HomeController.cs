using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BikeSite.Services;

namespace BikeSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlaceService _placeService;
        public HomeController(PlaceService placeService)
        {
            _placeService = placeService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destinations()
        {
            var listOfPlaces = _placeService.GetTopDestinations();
            return View(listOfPlaces);
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Blog()
        {           
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
