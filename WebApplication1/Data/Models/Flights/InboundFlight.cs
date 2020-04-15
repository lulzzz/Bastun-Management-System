namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts.FlightContracts;
    using BMS.Data.Models.Flights;
    using BMS.Data.Models.Messages;
    using BMS.GlobalData;
    using BMS.GlobalData.ErrorMessages;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class InboundFlight : Flight,IInbound
    {
        public InboundFlight()
        {
            this.InboundMessages = new HashSet<Message>();
            this.InboundContainers = new HashSet<Container>();
        }


        public int ArrivalMovementId { get; set; }

        public virtual ArrivalMovement ArrivalMovement { get; set; }

        public virtual ICollection<Container> InboundContainers { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.OriginRequired)]
        [RegularExpression(FlightInputDataValidation.StationValidation, ErrorMessage = InvalidErrorMessages.Origin)]
        public string Origin { get; set; }

        public virtual ICollection<Message> InboundMessages { get; set; }

    }
}
