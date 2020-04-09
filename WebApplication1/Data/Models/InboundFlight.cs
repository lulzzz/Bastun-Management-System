namespace BMS.Data.Models
{
    using BMS.Data.Models.Messages;
    using BMS.GlobalData;
    using BMS.GlobalData.ErrorMessages;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class InboundFlight
    {
        public InboundFlight()
        {
            this.InboundMessages = new List<Message>();
        }

        [Key]
        public int FlightId { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.FlightNumberRequired)]
        [RegularExpression(FlightInputDataValidation.GeneralFlightNumberValidation, ErrorMessage = InvalidErrorMessages.InvalidFlightNumberFormat)]
        public string FlightNumber { get; set; }


        public int ArrivalMovementId { get; set; }

        public virtual ArrivalMovement ArrivalMovement { get; set; }

        [Required]
        public DateTime STA { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.OriginRequired)]
        [RegularExpression(FlightInputDataValidation.StationValidation, ErrorMessage = InvalidErrorMessages.Origin)]
        public string Origin { get; set; }

        public virtual ICollection<Message> InboundMessages { get; set; }

    }
}
