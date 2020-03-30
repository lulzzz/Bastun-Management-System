using BMS.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Data.Models.Contracts
{
    public interface IPassenger
    {
        public string PaxId { get; set; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Nationality { get; }

        public int Age { get; set; }

        public string PassportNumber { get; set; }

        public Gender Gender { get; set; }

        public ICollection<Suitcase> Suitcases { get; set; }
    }
}
