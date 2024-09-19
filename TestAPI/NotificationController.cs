using Microsoft.AspNetCore.Mvc;
using System;
using TestAPI.Model;
using TestAPI.Repository;
using TestAPI.Service;

namespace TestAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll( [FromQuery] DateTime start, [FromQuery] DateTime end, [FromQuery] string? userId, [FromQuery] int? typeId)
        {
            try
            {
                var notifications = await _notificationService.GetAllNotificationsAsync( start, end, userId, typeId);
                return Ok(notifications);
            }
            catch(Exception ex) { 
                //log exception
                return BadRequest(ex.Message);
            }
           
          
        }

        [HttpGet("GetStatus/{id}")]
        public async Task<IActionResult> GetStatus(int id)
        {
            var notification = await _notificationService.GetNotificationStatusByIdAsync(id);
            if (notification == null) return NotFound();
            return Ok(new { notification });
        }

        [HttpPost("SendNotification")]
        public async Task<IActionResult> SendNotification(Notification notification)
        {
            try
            {
                var sentNotification = await _notificationService.SendNotificationAsync(notification);
                return Ok(sentNotification.Status);
            }
            catch(Exception ex) { 
                //log exception
                return BadRequest(ex.Message);
            }
        }
    }

}
