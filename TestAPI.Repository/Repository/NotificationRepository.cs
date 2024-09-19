using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Repository.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly DBContext _context;

        public NotificationRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<List<Notification>> GetAllNotificationsAsync( DateTime start,  DateTime end, string? userId = null, int? typeId = null)
        {
            var query = _context.Notifications.AsQueryable();


            query = query.Where(n => n.SentDate >= start);
            query = query.Where(n => n.SentDate <= end);

            if (!string.IsNullOrEmpty(userId))
                query = query.Where(n => n.UserId == userId);

            if (typeId.HasValue)
                query = query.Where(n => n.NotificationTypeId == typeId);


            return await query.ToListAsync();
        }

        public async Task<Notification> GetNotificationByIdAsync(int id)
        {
            return await _context.Notifications.FindAsync(id);
        }

        public async Task<Notification> AddNotificationAsync(Notification notification)
        {
            _context.Notifications.Add(notification);
            await _context.SaveChangesAsync();
            return notification;
        }
    }
}
