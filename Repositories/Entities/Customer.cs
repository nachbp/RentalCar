using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Entities
{
    public class Customer
    {
        public Customer(int id, string name, int loyaltyPoints)
        {
            Id = id;
            Name = name;
            LoyaltyPoints = loyaltyPoints;
            Rentals = new List<Rental>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int LoyaltyPoints { get; set; }
        public ICollection<Rental> Rentals { get; set; }

    }
}
