namespace BMS.Data.Models.Messages
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public abstract class Message
    {

        protected Message()
        {

        }

        [Key]
        public int MessageId { get; set; }

  

       


    }
}
