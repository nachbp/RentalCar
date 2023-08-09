using AutoMapper;
using Repositories.Entities;
using Repositories.Interfaces;
using Services.DTO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RentalService : IRentalService
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IMapper _mapper;

        public RentalService(IRentalRepository rentalRepository, IMapper mapper)
        {
            _rentalRepository = rentalRepository;
            _mapper = mapper;
        }

        public async Task<RentalDTO> GetRentalByIdAsync(int id)
        {
            var rental = await _rentalRepository.GetByIdAsync(id);
            return _mapper.Map<RentalDTO>(rental);
        }

        public async Task<IEnumerable<RentalDTO>> GetAllRentalsAsync()
        {
            var rentals = await _rentalRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<RentalDTO>>(rentals);
        }

        public async Task CreateRentalAsync(RentalDTO rentalDto)
        {
            var rental = _mapper.Map<Rental>(rentalDto);
            await _rentalRepository.CreateAsync(rental);
        }

        public async Task UpdateRentalAsync(int id, RentalDTO rentalDto)
        {
            var existingRental = await _rentalRepository.GetByIdAsync(id);
            if (existingRental == null)
            {
                // Handle not found
                return;
            }

            _mapper.Map(rentalDto, existingRental);
            await _rentalRepository.UpdateAsync(existingRental);
        }

        public async Task DeleteRentalAsync(int id)
        {
            var rental = await _rentalRepository.GetByIdAsync(id);
            if (rental != null)
            {
                await _rentalRepository.DeleteAsync(rental);
            }
        }

        private decimal CalculateSurcharge(DateTime expectedReturnDate, DateTime actualReturnDate, decimal dailyRentalRate)
        {
            int extraDays = (int)(actualReturnDate - expectedReturnDate).TotalDays;
            decimal surcharge = 0;

            if (extraDays > 0)
            {
                surcharge = dailyRentalRate * extraDays;
            }

            return surcharge;
        }

        public async Task<decimal> ReturnCarsAsync(int rentalId, DateTime returnDate)
        {
            var rental = await _rentalRepository.GetByIdAsync(rentalId);

            if (rental == null)
            {
                throw new ArgumentException("Rental not found.");
            }

            // Calculate surcharges for late return
            decimal surcharge = CalculateSurcharge(rental.RentalDate, returnDate, rental.DailyRentalRate);

            // Update rental information
            rental.ReturnDate = returnDate;
            rental.TotalPrice += surcharge;

            await _rentalRepository.UpdateAsync(rental);

            return surcharge;
        }


        private decimal CalculateCarPrice(decimal dailyRentalRate, DateTime startDate, DateTime endDate)
        {
            // Implement logic to calculate price based on daily rental rate and rental duration
            int daysRented = (int)(endDate - startDate).TotalDays;
            return dailyRentalRate * daysRented;
        }
    }
}
