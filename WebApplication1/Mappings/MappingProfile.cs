using AutoMapper;
using BMS.Data;
using BMS.Data.DTO;
using BMS.Data.DTO.FuelAndWeightDTO;
using BMS.Data.Models;
using BMS.Data.Models.Messages;
using BMS.Models;
using Microsoft.AspNetCore.Identity;
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
  

            CreateMap<FlightInputModel, InboundFlight>();

            CreateMap<FlightInputModel, OutboundFlight>();
                
            CreateMap<LDMDTO, LoadDistributionMessage>();

            CreateMap<CPMDTO, ContainerPalletMessage>();

            CreateMap<FuelFormDTO, FuelForm>();

            CreateMap<WeightFormDTO, WeightForm>();
        }
    }
}
