using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppScrapper.Models
{
    public class ChromiunFileData
    {       
        public string UserData { get; set; } = string.Empty;
        public string LogFile { get; set; } = string.Empty;
        public string CookiesFolder { get; set; } = string.Empty;
        public string ScreenFolder { get; set; } = string.Empty;
        public string DataRoot { get; set; } = string.Empty;
    }
}
