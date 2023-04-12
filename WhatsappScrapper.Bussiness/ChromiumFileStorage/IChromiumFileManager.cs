using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatsAppScrapper.Models;

namespace WhatsappScrapper.Bussiness.FileStorage
{
    public interface IChromiumFileManager
    {
        public Task<ChromiunFileData> PrepareFolder(string number);
        public Task SaveCookies(string cookieDir, string cookiesJson, string number);
        public Task<string> ReadCookies(string number, string cookieDir);
    }
}
