namespace BMS.Models.LoadingInstructionInputModels
{
    using BMS.GlobalData.LoadConstants;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class DefaultLoadInstructionInputModel
    {
        [Required(ErrorMessage = LoadingInstructionConstants.RequiredFlightNumber)]
        public string FlightNumber { get; set; }
    }
}
