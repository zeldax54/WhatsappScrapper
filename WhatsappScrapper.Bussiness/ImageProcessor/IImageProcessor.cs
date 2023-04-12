using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappScrapper.Bussiness.ImageProcessor
{
    public interface IImageProcessor
    {
        public Task<string> LoadScreenShootAsBase64(string fullPath);
    }
}
