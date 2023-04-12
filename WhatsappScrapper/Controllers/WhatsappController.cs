using Microsoft.AspNetCore.Mvc;
using WhatsappScrapper.Bussiness.Configuration;
using WhatsAppScrapper.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WhatsappScrapper.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WhatsappController : ControllerBase
    {
        private readonly IWhatsappConfiguration _configuration;
        public WhatsappController(IWhatsappConfiguration configuration) 
        {
            _configuration = configuration;
        }

        [HttpPost("Configure")]
        public async Task<ActionResult<ApiResponse<ConfigureResponse>>> Configure(ConfigureParams config)
        {
            await  _configuration.Configure(config);
            return Ok(new ApiResponse<string>(){ Data = "Success Configuration",StatusCode = 200,Success = true, ErrorMessage= ""});
        }       
       
    }
}
