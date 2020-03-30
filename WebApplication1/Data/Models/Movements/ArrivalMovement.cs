namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
   
    public class ArrivalMovement : IArrMovement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FlightRef { get; set; }

        [Required]
        public Flight Flight { get; set; }


        [Required]
        public DateTime DateOfMovement { get; }

        [Required]
        public DateTime TouchdownTime { get; }

        [Required]
        public DateTime OnBlockTime { get; set; }

        
        public string SupplementaryInformation { get; set; }

      
    }
}
