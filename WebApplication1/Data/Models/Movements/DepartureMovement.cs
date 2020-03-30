namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DepartureMovement : IDepMovement
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FlightNumber { get; }

        [Required]
        public Flight Flight { get; set; }

        [Required]
        public DateTime DepartureDate { get; }

        [Required]
        public DateTime OffBlockTime { get; set; }

        [Required]
        public DateTime TakeoffTime { get; set; }

        [Required]
        [Range(0,189)]
        public int TotalPAX { get; set; }
    }
}
