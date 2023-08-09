using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IRentalService
    {
        Task<RentalDTO> GetRentalByIdAsync(int id);
        Task<IEnumerable<RentalDTO>> GetAllRentalsAsync();
        Task CreateRentalAsync(RentalDTO rentalDto);
        Task UpdateRentalAsync(int id, RentalDTO rentalDto);
        Task DeleteRentalAsync(int id);
        Task<decimal> ReturnCarsAsync(int id, DateTime returnDate);        
    }
}
