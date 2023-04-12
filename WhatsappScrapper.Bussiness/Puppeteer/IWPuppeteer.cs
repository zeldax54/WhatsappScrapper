using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappScrapper.Bussiness.Puppeteer
{
    public interface IWPuppeteer
    {
        Task Configure(string number);
        Task<string> LoadPage(string number); 
    }
}
