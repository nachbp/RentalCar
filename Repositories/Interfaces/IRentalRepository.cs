using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IRentalRepository
    {
        Task<Rental> GetByIdAsync(int id);
        Task<IEnumerable<Rental>> GetAllAsync();
        Task CreateAsync(Rental rental);
        Task UpdateAsync(Rental rental);
        Task DeleteAsync(Rental rental);
    }
}
