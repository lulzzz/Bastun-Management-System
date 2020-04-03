namespace BMS.Data.Models
{
    using BMS.Data.Models.Contracts;
    using BMS.Data.Models.Enums;
    using BMS.GlobalData.ErrorMessages;
    using BMS.GlobalData.Validation;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Passenger : IPassenger
    {
        public Passenger()
        {
            this.Suitcases = new List<Suitcase>();
        }

        [Key]
        public int PaxId { get; set; }

        [Required(ErrorMessage = InvalidPAXErrorMessages.PAXFirstNameIsRequired)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = InvalidPAXErrorMessages.PAXLastNameIsRequired)]
        public string LastName { get; set; }

        [Required(ErrorMessage = InvalidPAXErrorMessages.PAXNationalityIsRequired)]
        public string Nationality { get; set; }

        [Required(ErrorMessage = InvalidPAXErrorMessages.PAXAgeIsRequired)]
        [Range(1,100,ErrorMessage = InvalidPAXErrorMessages.PAXAgeIsInvalid)]
        public int Age { get; set; }

        [Required(ErrorMessage = InvalidPAXErrorMessages.PAXGenderIsRequired)]
        [RegularExpression(PAXInputDataValidation.PAXGenderValidation, ErrorMessage = InvalidPAXErrorMessages.PAXGenderIsInvalid)]
        public Gender Gender { get; set; }

        public PAXWeight Weight { get; set; }

        [Required(ErrorMessage = InvalidPAXErrorMessages.PAXPassportNumberIsRequired)]
        public string PassportNumber { get; set; }

        public ICollection<Suitcase> Suitcases { get; set; }


        [Required]
        public int FlightId { get; set; }

        [Required]
        public Flight Flight { get; set; }


    }
}
