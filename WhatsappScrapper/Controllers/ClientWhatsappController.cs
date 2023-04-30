using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Whatsapp.Bussiness.User.Manager;
using WhatsappScrapper.Bussiness.Configuration;
using WhatsAppScrapper.Models;
using WhatsAppScrapper.Models.DataModels;

namespace WhatsappScrapper.Controllers
{
    [ApiController]
    [Route("clientactions")]
    public class ClientWhatsappController : ControllerBase
    {
        private readonly IZoneManager _zoneManager;
        public ClientWhatsappController(IZoneManager zoneManager)
        {
            _zoneManager = zoneManager;
        }

        [HttpPost("addzone")]
        [Authorize(Policy = "UserResource")]
        public async Task<IActionResult> Configure(Zone zone)
        {
            if (Request.Headers.TryGetValue("x-nameidentifier", out var userId)) 
            {
                zone.UserId = userId;
                await _zoneManager.AddZone(zone);
                return Ok(new ApiResponse<string>() { Data = "Success Configuration", StatusCode = 200, Success = true, ErrorMessage = "" });
            }
            return BadRequest();           
        }
    }
}
