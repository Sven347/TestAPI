using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;
using TestAPI.Repository;

namespace TestAPI.Service
{
    public class NotificationTypeService : INotificationTypeService
    {
        private readonly INotificationTypeRepository _notificationTypeRepository;

        public NotificationTypeService(INotificationTypeRepository notificationTypeRepository)
        {
            _notificationTypeRepository = notificationTypeRepository;
        }

        public async Task<List<NotificationType>> GetAllNotificationTypesAsync()
        {
            return await _notificationTypeRepository.GetAllNotificationTypesAsync();
        }

        public async Task<NotificationType> GetNotificationTypeByIdAsync(int id)
        {
            return await _notificationTypeRepository.GetNotificationTypeByIdAsync(id);
        }

        public async Task<NotificationType> CreateNotificationTypeAsync(NotificationType type)
        {
            return await _notificationTypeRepository.AddNotificationTypeAsync(type);
        }

        public async Task<NotificationType> UpdateNotificationTypeAsync(int id, NotificationType type)
        {
            return await _notificationTypeRepository.UpdateNotificationTypeAsync(type);
        }

        public async Task<bool> DeleteNotificationTypeAsync(int id)
        {
            return await _notificationTypeRepository.DeleteNotificationTypeAsync(id);
        }
    }
}
