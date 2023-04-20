using Microsoft.AspNetCore.Mvc;
using WhatsappScrapper.Bussiness.Configuration;
using WhatsAppScrapper.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Authorization;
using PuppeteerSharp;

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

        [HttpPost("configure")]       
        [Authorize(Policy = "AdminResource")]      
        public async Task<ActionResult<ActionResult<ApiResponse<string>>>> Configure(ConfigureParams config)
        {
            await  _configuration.Configure(config);
            return Ok(new ApiResponse<string>(){ Data = "Success Configuration",StatusCode = 200,Success = true, ErrorMessage= ""});
        }

        [HttpGet("cleanbuild")]
        [Authorize(Policy = "AdminResource")]
        public async Task<ActionResult<ActionResult<ApiResponse<string>>>> CleanBuild()
        {
            await _configuration.CleanBuild();
            return Ok(new ApiResponse<string>() { Data = "Success Configuration", StatusCode = 200, Success = true, ErrorMessage = "" });
        }
    }
}
