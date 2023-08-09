using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Interfaces;
using AutoMapper;
using Services.DTO;
using Repositories.Entities;

namespace Services.Mapping
{
    public class MapperConfig : Profile
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cgf =>
            {
                cgf.CreateMap<CarDTO, Car>().ReverseMap();
                cgf.CreateMap<RentalDTO, Rental>().ReverseMap();
                cgf.CreateMap<CustomerDTO, Customer>().ReverseMap();
            });
        }
    }
}

