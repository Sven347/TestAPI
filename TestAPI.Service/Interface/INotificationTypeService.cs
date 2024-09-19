using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Service
{
    public interface INotificationTypeService
    {
        Task<List<NotificationType>> GetAllNotificationTypesAsync();
        Task<NotificationType> GetNotificationTypeByIdAsync(int id);
        Task<NotificationType> CreateNotificationTypeAsync(NotificationType type);
        Task<NotificationType> UpdateNotificationTypeAsync(int id, NotificationType type);
        Task<bool> DeleteNotificationTypeAsync(int id);
    }
}
