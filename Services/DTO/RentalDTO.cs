using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class RentalDTO
    {
        public RentalDTO(int id, List<int> carId, DateTime rentalDate, DateTime returnDate, int customerId, decimal totalPrice) 
        {
            this.Id = id;
            this.CarId = carId;
            this.RentalDate = rentalDate;
            this.ReturnDate = returnDate;
            this.CustomerId = customerId;
            this.TotalPrice = totalPrice;            
        }
        public int Id { get; set; }
        public List<int> CarId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DailyRentalRate { get; set; }
    }
}
