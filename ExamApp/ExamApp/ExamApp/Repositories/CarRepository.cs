using ExamApp.Entities;
using ExamApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (CheckInputLength(plate) && CheckInputFormat(plate))
            {
                return carContext.Licence_Plates.Where(x => x.Plate.Contains(plate)).ToList();
            }
            return GetAllCars();
        }

        private bool CheckInputFormat(string plate)
        {
            return Regex.IsMatch(plate, @"^[a-zA-Z0-9-]*$");
        }

        private bool CheckInputLength(string plate)
        {
            return (plate.Length <= 7);
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
            return carContext.Licence_Plates.Where(x => x.Car_brand.Equals(brand)).ToList();
        }
    }
}
