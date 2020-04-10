namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using BMS.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IAircraftService
    {
        public void RegisterAircraft(AircraftInputModel aircraftInputModel);

        public bool CheckAircraftRegistration(string registration);

        public Aircraft GetAicraftByRegistration(string registration);

        public bool IsAircraftGoingToBeContainerized(string aircraftType);


     
       
    }
}
