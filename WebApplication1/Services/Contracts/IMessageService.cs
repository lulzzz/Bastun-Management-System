namespace BMS.Services.Contracts
{
    using BMS.Data.Models.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IMessageService
    {
        public void CreateLDM();

        public void CreateCPM();

        public void CreateUCM();
    }
}
