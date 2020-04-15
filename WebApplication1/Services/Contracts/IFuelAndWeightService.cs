namespace BMS.Services.Contracts
{
    using BMS.Data.Models;
    using BMS.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IFuelAndWeightService
    {
        void AddFuelForm(FuelFormInputModel fuelFormInputModel);

        void AddWeightForm(WeightFormInputModel weightInputModel);
    }
}
