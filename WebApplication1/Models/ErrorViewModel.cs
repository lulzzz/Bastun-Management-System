using System;
using Wkhtmltopdf.NetCore;
namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
      
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
