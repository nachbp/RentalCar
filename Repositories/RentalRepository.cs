using Microsoft.EntityFrameworkCore;
using RentalCarAPI.Data;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RentalRepository : IRentalRepository
    {
        private readonly RentalCarAPIContext _context;

        public RentalRepository(RentalCarAPIContext context)
        {
            _context = context;
        }

        public async Task<Rental> GetByIdAsync(int id)
        {
            return await _context.Rental.FindAsync(id);
        }

        public async Task<IEnumerable<Rental>> GetAllAsync()
        {
            return await _context.Rental.ToListAsync();
        }

        public async Task CreateAsync(Rental rental)
        {
            _context.Rental.Add(rental);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Rental rental)
        {
            _context.Entry(rental).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Rental rental)
        {
            _context.Rental.Remove(rental);
            await _context.SaveChangesAsync();
        }
    }
}
