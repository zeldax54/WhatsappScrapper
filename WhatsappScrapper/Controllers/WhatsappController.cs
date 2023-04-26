using Microsoft.AspNetCore.Mvc;
using WhatsappScrapper.Bussiness.Configuration;
using WhatsAppScrapper.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Authorization;
using PuppeteerSharp;
using WhatsAppScrapper.Models.DataModels;

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

        [HttpGet("configurelist")]
       // [Authorize(Policy = "AdminResource")]
        public async Task<ActionResult<ActionResult<ApiResponse<IEnumerable<RegisterNumber>>>>> ConfigureList()
        {
            var list = await _configuration.ConfigureList();
            return Ok(new ApiResponse<IEnumerable<RegisterNumber>>() { Data = list, StatusCode = 200, Success = true, ErrorMessage = "" });
        }

        [HttpPost("removeregister")]
        [Authorize(Policy = "AdminResource")]
        public async Task<ActionResult<ActionResult<ApiResponse<string>>>> RemoveRegister(RemoveRegisterParams removeRegisterParams)
        {
            await _configuration.RemoveRegister(removeRegisterParams);
            return Ok(new ApiResponse<string>() { Data = "Removed", StatusCode = 200, Success = true, ErrorMessage = "" });
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
