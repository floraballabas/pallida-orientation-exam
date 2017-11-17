using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamApp.Repositories;
using ExamApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamApp.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        CarRepository carRepository;

        public CarController(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(carRepository.GetAllCarsFromDb());
        }

        [HttpGet]
        [Route("/search")]
        public IActionResult SearchResult(string plate)
        {
            return View("Index", carRepository.GetSearchedCarsFromDb(plate));
        }

        [HttpGet]
        [Route("/search/police")]
        public IActionResult SearchPoliceCars()
        {
            return View("Index", carRepository.GetPoliceCarsFromDb());
        }

        [HttpGet]
        [Route("/search/diplomat")]
        public IActionResult SearchDiplomatCars()
        {
            return View("Index", carRepository.GetDiplomatCarsFromDb());
        }

        [HttpGet]
        [Route("/search/{brand}")]
        public IActionResult SearchForBrandWithButton(string brand)
        {
            return View("Index", carRepository.GetBrandFromDb(brand));
        }

        [HttpGet]
        [Route("/api/search/{brand}")]
        public IEnumerable<Car> SearchForBrandWithApi(string brand)
        {
            return carRepository.GetBrandFromDb(brand);
        }
    }
}
