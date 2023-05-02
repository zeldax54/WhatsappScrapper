using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
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
        private readonly string _userId;
        public ClientWhatsappController(IZoneManager zoneManager, IHttpContextAccessor httpContextAccessor)
        {
            _zoneManager = zoneManager;          
            if(httpContextAccessor.HttpContext.Request.Headers.TryGetValue("x-nameidentifier", out var userId))
              _userId = userId;
        }

        [HttpPost("addzone")]
        [Authorize(Policy = "UserResource")]
        public async Task<IActionResult> Configure(Zone zone)
        {
            try
            {
                zone.UserId = _userId;
                int zoneId = await _zoneManager.AddZone(zone);
                return Created(nameof(Configure), zoneId);
            }
            catch (DuplicateNameException)
            {
                return Conflict("Duplicate values not allowed");
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong configuring zone");
            }
        }

        [HttpGet("zones")]
        [Authorize(Policy = "UserResource")]
        public async Task<IActionResult> Zones()
        {
            try
            {
                var zones = await _zoneManager.GetZones(_userId);
                return Ok(zones);
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong fetching zones list");
            }
        }
   
        [HttpDelete("removezone/{zoneId}")]
        [Authorize(Policy = "UserResource")]
        public async Task<IActionResult> RemoveZone(int zoneId)
        {
            try
            {
                var removedId = await _zoneManager.RemoveZone(_userId,zoneId);
                return Ok(removedId);
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong removing zones list");
            }
        }
      
        [HttpDelete("bulkzonedelete")]
        [Authorize(Policy = "UserResource")]
        public async Task<IActionResult> BulkRemove(List<int> zoneIds)
        {
            try
            {
                var failedZones = await _zoneManager.BulkRemove(_userId, zoneIds);
                return Ok(failedZones);
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong removing zones list");
            }
        }
    }
}
