namespace BMS.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IGetDataFromMessage
    {
        public void GetMVTContent(string movementFromInput);

        public void GetLDMContent(string ldmFromInput);

        public void GetCPMContent(string cpmFromInput);
    }
}
