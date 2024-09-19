using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Repository
{
    public interface INotificationRepository
    {
        Task<List<Notification>> GetAllNotificationsAsync(DateTime start, DateTime end, string? userId = null, int? typeId = null);
        Task<Notification> GetNotificationByIdAsync(int id);
        Task<Notification> AddNotificationAsync(Notification notification);
    }
}
