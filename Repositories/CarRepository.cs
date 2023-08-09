using Microsoft.EntityFrameworkCore;
using RentalCarAPI.Data;
using Repositories.Interfaces;
using Repositories.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly RentalCarAPIContext _context;

        public CarRepository(RentalCarAPIContext context)
        {
            _context = context;
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _context.Car.FindAsync(id);
        }

        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            return await _context.Car.ToListAsync();
        }

        public async Task CreateAsync(Car car)
        {
            _context.Car.Add(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Car car)
        {
            _context.Entry(car).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Car car)
        {
            _context.Car.Remove(car);
            await _context.SaveChangesAsync();
        }
    }
}