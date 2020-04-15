using AutoMapper;
using BMS.Data.DTO;
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
            CreateMap<RegisterUserInputModel, IdentityUser>()
                .ForMember(dest => dest.UserName, src => src.MapFrom(x => x.UserName));

            CreateMap<FlightInputModel, InboundFlight>();

            CreateMap<FlightInputModel, OutboundFlight>();
                
            CreateMap<LDMDTO, LoadDistributionMessage>();

            CreateMap<CPMDTO, ContainerPalletMessage>();
               
        }
    }
}
