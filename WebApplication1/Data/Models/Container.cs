namespace BMS.Data.Models
{
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Container
    {
        public int Id { get; set; }

        public int FlightId { get; set; }

        public virtual Flight Flight { get; set; }

        public int ContainerPalletMessageId { get; set; }

        public virtual ContainerPalletMessage ContainerPalletMessage { get; set; }

        public string Position { get; set; }

        public string ContainerNumber { get; set; }
    }
}
