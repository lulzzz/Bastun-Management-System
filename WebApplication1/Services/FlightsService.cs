namespace BMS.Services
{
    using BMS.Models;
    using BMS.Services.Contracts;
    using AutoMapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;
    using BMS.Data.Models;
    using BMS.Data.Models.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class FlightsService : IFlightService
    {
        private readonly ApplicationDbContext dbContext;
        public FlightsService(ApplicationDbContext dbContext)
        {
        
            this.dbContext = dbContext;
        }



        public bool CheckIfFlightIsInbound(string flightNumber)
        {
            return this.dbContext.InboundFlights.Any(x => x.FlightNumber == flightNumber);
        }

        public bool CheckIfFlightIsOutbound(string flightNumber)
        {
            return this.dbContext.OutboundFlights.Any(x => x.FlightNumber == flightNumber);
        }

        public void GetAllFlights()
        {
            throw new NotImplementedException();
        }

        public InboundFlight GetInboundFlightByFlightNumber(string inboundFlightNumber)
        {
            var inboundFlightToReturn = this.dbContext.InboundFlights.FirstOrDefault(x => x.FlightNumber == inboundFlightNumber);

            if (inboundFlightToReturn != null)
            {
                return inboundFlightToReturn;
            }
            else
            {
                return null;
            }
        }

        public OutboundFlight GetOutboundFlightByFlightNumber(string outboundFlightNumber)
        {
            var outboundFlightToReturn = this.dbContext.OutboundFlights.FirstOrDefault(x => x.FlightNumber == outboundFlightNumber);

            if (outboundFlightToReturn != null)
            {
                return outboundFlightToReturn;
            }
            else
            {
                return null;
            }
        }

        public void RegisterInboundFlight(FlightInputModel inboundFlightInputModel)
        {
            string[] splitFlightNumbers =
                inboundFlightInputModel
                .FlightNumber
                .Split("/", StringSplitOptions.RemoveEmptyEntries);

            string inboundFlightNumber = splitFlightNumbers[0];
            var newInboundFlight = new InboundFlight
            {
                FlightNumber = inboundFlightNumber,
                Origin = inboundFlightInputModel.Origin,
                STA = inboundFlightInputModel.STA,
            };
            this.dbContext.InboundFlights.Add(newInboundFlight);
            this.dbContext.SaveChanges();
        }

        public void RegisterOutboundFlight(FlightInputModel outboundFlightInputModel)
        {
            string[] splitFlightNumbers =
                outboundFlightInputModel
                .FlightNumber
                .Split("/", StringSplitOptions.RemoveEmptyEntries);

            string outboundFlightNumber = splitFlightNumbers[1];

            var newOutboundFlight = new OutboundFlight
            {
                FlightNumber = outboundFlightNumber,
                HandlingStation = outboundFlightInputModel.HandlingStation,
                BookedPAX = outboundFlightInputModel.BookedPax,
                STD = outboundFlightInputModel.STD,
                Destination = outboundFlightInputModel.Destination
            };

            this.dbContext.OutboundFlights.Add(newOutboundFlight);
            this.dbContext.SaveChanges();
        }
    }
}
