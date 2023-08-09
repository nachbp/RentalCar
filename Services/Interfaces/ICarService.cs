using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.DTO;

namespace Services.Interfaces
{
    public interface ICarService
    {
        Task<CarDTO> GetCarByIdAsync(int id);
        Task<IEnumerable<CarDTO>> GetAllCarsAsync();
        Task CreateCarAsync(CarDTO car);
        Task UpdateCarAsync(int id, CarDTO car);
        Task DeleteCarAsync(int id);                 
    }
}

