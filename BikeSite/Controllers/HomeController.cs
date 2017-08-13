using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BikeSite.Services;
using ReflectionIT.Mvc.Paging;
using BikeSite.Models;
using System.Linq;

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

        public async Task<IActionResult> Destinations(int page = 1)
        {
            var listOfPlaces = await _placeService.GetTopDestinations();
            //var model = await PagingList<PlaceModel.Place>.CreateAsync(listOfPlaces as IOrderedQueryable<PlaceModel.Place>, 10, page);
            return View(listOfPlaces.OrderBy(o=>o.description).Reverse());
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
