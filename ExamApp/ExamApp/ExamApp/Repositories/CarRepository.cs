using ExamApp.Entities;
using ExamApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.Repositories
{
    public class CarRepository
    {
        CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<Car> GetAllCars()
        {
            return carContext.Licence_Plates.ToList();
        }

        public List<Car> GetSearchedCars(string plate)
        {
            return carContext.Licence_Plates.Where(x => x.Plate.Contains(plate)).ToList();
        }

        public List<Car> GetPoliceCars()
        {
            return carContext.Licence_Plates.Where(x => x.Plate.StartsWith("RB")).ToList();
        }

        public List<Car> GetDiplomatCars()
        {
            return carContext.Licence_Plates.Where(x => x.Plate.StartsWith("DT")).ToList();
        }

        public List<Car> GetBrand(string brand)
        {
            string convertedBrand = brand.ToLower();
            return carContext.Licence_Plates.Where(x => x.Car_brand.Equals(convertedBrand)).ToList();
        }
    }
}
