namespace BMS.Data.Models.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ContainerPalletMessage
    {
        public ContainerPalletMessage()
        {
            this.Containers = new List<Container>();
        }

        public int Id { get; set; }

        public int FlightId { get; set; }

        public virtual Flight Flight { get; set; }

        public virtual ICollection<Container> Containers { get; set; }

        public string SupplementaryInformation { get; set; }
    }
}
