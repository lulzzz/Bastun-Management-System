using AutoMapper;
using BMS.Data.Models;
using BMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FlightInputModel, Flight>();
        }
    }
}
