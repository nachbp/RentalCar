using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class CarDTO
    {
        public CarDTO(int id, string brand, string model, int year, string category, decimal dailyRentalRate)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Category = category;
            DailyRentalRate = dailyRentalRate;
        }
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public decimal DailyRentalRate { get; set; }
    }
}
