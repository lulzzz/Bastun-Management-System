namespace BMS.Services
{
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class LoadControlService : ILoadControlService
    {
        private readonly IFlightService flightService;
        private readonly IAircraftService aircraftService;

        public LoadControlService(IFlightService flightService, IAircraftService aircraftService)
        {
            this.flightService = flightService;
            this.aircraftService = aircraftService;
        }

        public void CalculatePAXWeightByGender()
        {
            throw new NotImplementedException();
        }

        public string GetCorrectLoadingInstruction(string aircraftType)
        {
            string correctLoadingInstructionName = string.Empty;

            if (aircraftType == "B763" || aircraftType == "B788")
            {
                aircraftType = aircraftType.Remove(0, 1);
                correctLoadingInstructionName = $"_{aircraftType}ContainerLoadingPartial.cshtml";
            } 
            else
            {
                correctLoadingInstructionName = "DefaultLoadingInstruction";
            }

            return correctLoadingInstructionName;
        }

        public void GetPassengersByZoneDistribution()
        {
            throw new NotImplementedException();
        }
    }
}
