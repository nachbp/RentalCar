namespace RentalCarAPI.Models
{
    public class Customer
    {
        public Customer(int id, string name, int loyaltyPoints)
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
