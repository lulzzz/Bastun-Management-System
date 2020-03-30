namespace BMS.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Suitcase
    {
        [Required]
        public int Id { get; set; }

        [Range(1,32)]
        public double Weight { get; set; }
    }
}
