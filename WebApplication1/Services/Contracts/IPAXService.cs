namespace BMS.Services.Contracts
{
    using BMS.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IPAXService
    {
        string GetPaxZoneBySeatNumber(string paxSeatNumber);

        void AddPAXToZoneAlpha(PAXInputModel paxInputModel);

        void AddPAXToZoneBravo(PAXInputModel paxInputModel);

        void AddPAXToZoneCharlie(PAXInputModel pAXInputModel);
    }
}
