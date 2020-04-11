namespace BMS.Models.MovementsInputModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class MovementInputModel
    {
        [Required]
        public string Movement { get; set; }
    }
}
