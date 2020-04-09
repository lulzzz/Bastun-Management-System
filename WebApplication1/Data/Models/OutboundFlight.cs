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

    public class OutboundFlight
    {
        public OutboundFlight()
        {
            this.OutboundContainers = new List<Container>();
            this.OutboundMessages = new List<Message>();
        }

        [Key]
        public int FlightId { get; set; }

        [Required]
        public string FlightNumber { get; set; }


        public int AircraftId { get; set; }
        public virtual Aircraft Aircraft { get; set; }

        public string HandlingStation { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.DestinationRequired)]
        [RegularExpression(FlightInputDataValidation.StationValidation, ErrorMessage = InvalidErrorMessages.Destination)]
        public string Destination { get; set; }

        public virtual ICollection<Message> OutboundMessages { get; set; }

        public virtual ICollection<Container> OutboundContainers { get; set; }

        public int DepartureMovementId { get; set; }

        public virtual DepartureMovement DepartureMovement { get; set; }

        [Required]
        public DateTime STD { get; set; }

        [Required(ErrorMessage = InvalidErrorMessages.BookedPAXRequired)]
        [Range(0,345, ErrorMessage = InvalidErrorMessages.BookedPax)]
        public int BookedPax { get; set; }

        


    }
}
