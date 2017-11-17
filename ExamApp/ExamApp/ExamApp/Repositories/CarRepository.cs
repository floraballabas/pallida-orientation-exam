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

        public List<Car> GetAllCarsFromDb()
        {
            return carContext.Licence_Plates.ToList();
        }

        public List<Car> GetSearchedCarsFromDb(string plate)
        {
            if (CheckInputLength(plate) && CheckInputFormat(plate))
            {
                return carContext.Licence_Plates.Where(x => x.Plate.Contains(plate)).ToList();
            }
            return GetAllCarsFromDb();
        }

        private bool CheckInputFormat(string plate)
        {
            return Regex.IsMatch(plate, @"^[a-zA-Z0-9-]*$");
        }

        private bool CheckInputLength(string plate)
        {
            return (plate.Length <= 7);
        }

        public List<Car> GetPoliceCarsFromDb()
        {
            return carContext.Licence_Plates.Where(x => x.Plate.StartsWith("RB")).ToList();
        }

        public List<Car> GetDiplomatCarsFromDb()
        {
            return carContext.Licence_Plates.Where(x => x.Plate.StartsWith("DT")).ToList();
        }

        public List<Car> GetBrandFromDb(string brand)
        {
            return carContext.Licence_Plates.Where(x => x.Car_brand.Equals(brand)).ToList();
        }
    }
}
