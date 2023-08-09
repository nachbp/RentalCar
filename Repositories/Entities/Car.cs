using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Entities
{
    public class Car
    {
        public Car(int id, string brand, string model, int year, string category, decimal dailyRentalRate)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            Category = category;
            DailyRentalRate = dailyRentalRate;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength (40)]
        public string Brand { get; set; }
        [Required]
        [MaxLength(40)]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [MaxLength(40)]
        public string Category { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DailyRentalRate { get; set; }
    }

}
