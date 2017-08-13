using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BikeSite.Services;
using BikeSite.Models;

namespace BikeSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlaceService _placeService;
        public HomeController(IPlaceService placeService)
        {
            _placeService = placeService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Destinations()
        {
            var listOfPlaces = await _placeService.GetTopDestinations();
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
