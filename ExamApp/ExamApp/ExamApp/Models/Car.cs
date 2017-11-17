using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        [MaxLength(7)]
        public string Plate { get; set; }
        public string Car_brand { get; set; }
        public string Car_model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }
}
