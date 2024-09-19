using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Repository
{
    public interface INotificationTypeRepository
    {
        Task<List<NotificationType>> GetAllNotificationTypesAsync();
        Task<NotificationType> GetNotificationTypeByIdAsync(int id);
        Task<NotificationType> AddNotificationTypeAsync(NotificationType type);
        Task<NotificationType> UpdateNotificationTypeAsync(NotificationType type);
        Task<bool> DeleteNotificationTypeAsync(int id);
    }
}
