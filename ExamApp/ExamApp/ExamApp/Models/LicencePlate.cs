using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.Models
{
    public class LicencePlate
    {
        public int Id { get; set; }
        public string plate { get; set; }
        public string car_brand { get; set; }
        public string car_model { get; set; }
        public string color { get; set; }
        public int year { get; set; }
    }
}
