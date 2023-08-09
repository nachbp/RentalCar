using AutoMapper;
using Repositories.Entities;
using Repositories.Interfaces;
using Services.DTO;
using Services.Interfaces;
using Services.Mapping;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }


        public async Task<CarDTO> GetCarByIdAsync(int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            return _mapper.Map<CarDTO>(car);
        }

        public async Task<IEnumerable<CarDTO>> GetAllCarsAsync()
        {
            var cars = await _carRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CarDTO>>(cars);
        }

        public async Task CreateCarAsync(CarDTO carDto)
        {
            var car = _mapper.Map<Car>(carDto);
            await _carRepository.CreateAsync(car);
        }

        public async Task UpdateCarAsync(int id, CarDTO carDto)
        {
            var existingCar = await _carRepository.GetByIdAsync(id);
            if (existingCar == null)
            {
                // Handle not found
                return;
            }

            _mapper.Map(carDto, existingCar);
            await _carRepository.UpdateAsync(existingCar);
        }

        public async Task DeleteCarAsync(int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if (car != null)
            {
                await _carRepository.DeleteAsync(car);
            }
        }
    }
}