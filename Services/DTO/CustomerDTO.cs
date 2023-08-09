using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class CustomerDTO
    {
        public CustomerDTO(int id, string name, int loyaltyPoints)
        {
            Id = id;
            Name = name;
            LoyaltyPoints = loyaltyPoints;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int LoyaltyPoints { get; set; }

    }
}
