using Microsoft.AspNetCore.Mvc;
using TestAPI.Model;
using TestAPI.Repository;
using TestAPI.Service;

namespace TestAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationTypesController : ControllerBase
    {
        private readonly INotificationTypeService _notificationTypeService;

        public NotificationTypesController(INotificationTypeService notificationTypeService)
        {
            _notificationTypeService = notificationTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var types = await _notificationTypeService.GetAllNotificationTypesAsync();
            return Ok(types);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var type = await _notificationTypeService.GetNotificationTypeByIdAsync(id);
            if (type == null) return NotFound();
            return Ok(type);
        }

        [HttpPost("CreateNotificationType")]
        public async Task<IActionResult> Create(NotificationType type)
        {
            var createdType = await _notificationTypeService.CreateNotificationTypeAsync(type);
            return Ok(createdType);
        }

        [HttpPut("UpdateNotificationType/{id}")]
        public async Task<IActionResult> Update(int id, NotificationType type)
        {
            var updatedType = await _notificationTypeService.UpdateNotificationTypeAsync(id, type);
            if (updatedType == null) return NotFound();
            return Ok(updatedType);
        }

        [HttpDelete("DeleteNotificationType/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _notificationTypeService.DeleteNotificationTypeAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }

}
