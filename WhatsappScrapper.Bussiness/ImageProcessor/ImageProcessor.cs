using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappScrapper.Bussiness.ImageProcessor
{
    public class ImageProcessor : IImageProcessor
    {
        public Task<string> LoadScreenShootAsBase64(string fullPath) 
        {           
            byte[] fileBytes = File.ReadAllBytes(fullPath);      
            string base64String = Convert.ToBase64String(fileBytes);     
            return Task.FromResult("data:image/png;base64," + base64String);
        }
    }
}
