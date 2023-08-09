using Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerDTO> GetCustomerByIdAsync(int id);
        Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync();
        Task CreateCustomerAsync(CustomerDTO customerDto);
        Task UpdateCustomerAsync(int id, CustomerDTO customerDto);
        Task DeleteCustomerAsync(int id);
    }
}
