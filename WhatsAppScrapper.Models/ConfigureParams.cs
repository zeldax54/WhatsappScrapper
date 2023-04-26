using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppScrapper.Models
{
    public class ConfigureParams
    {
        public string Number { get; set; } = string.Empty;
        public string WaitforQRTime { get; set; } = string.Empty;
        public string WaitforEndTime { get; set; } = string.Empty;
    }
}
