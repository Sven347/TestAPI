using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;
using TestAPI.Repository;

namespace TestAPI.Service
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public async Task<List<Notification>> GetAllNotificationsAsync(DateTime start, DateTime end, string? userId = null, int? typeId = null)
        {
            return await _notificationRepository.GetAllNotificationsAsync( start, end, userId, typeId);
        }

        public async Task<Notification> GetNotificationStatusByIdAsync(int id)
        {
            return await _notificationRepository.GetNotificationByIdAsync(id);
        }

        public async Task<Notification> SendNotificationAsync(Notification notification)
        {
            notification.SentDate = DateTime.UtcNow;
            notification.Status = true; 
            return await _notificationRepository.AddNotificationAsync(notification);
        }
    }

}
