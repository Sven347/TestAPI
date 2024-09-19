using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Service
{
    public interface INotificationService
    {
        Task<List<Notification>> GetAllNotificationsAsync( DateTime start , DateTime end , string? userId = null, int? typeId = null);
        Task<Notification> GetNotificationStatusByIdAsync(int id);
        Task<Notification> SendNotificationAsync(Notification notification);
    }

}
