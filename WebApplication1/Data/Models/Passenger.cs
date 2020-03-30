namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts;
    using BMS.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class Passenger : IPassenger
    {
        public Passenger()
        {
            this.PaxId = Guid.NewGuid().ToString();
        }

        [Required]
        [Key]
        public string PaxId { get; set; }

        [Required]
       
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        [Range(1,100)]
        public int Age { get; set; }

        [Required]
        public string PassportNumber { get; set; }

        [Required]
        public Gender Gender { get; set; }
    }
}
