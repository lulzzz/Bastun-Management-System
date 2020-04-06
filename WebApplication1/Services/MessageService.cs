namespace BMS.Services
{
    using BMS.Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApplication1.Data;

    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext dbContext;

        public MessageService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateCPM()
        {
            throw new NotImplementedException();
        }

        public void CreateLDM()
        {
            throw new NotImplementedException();
        }

        public void CreateUCM()
        {
            throw new NotImplementedException();
        }
    }
}
