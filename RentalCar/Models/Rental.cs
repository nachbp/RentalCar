namespace RentalCarAPI.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
