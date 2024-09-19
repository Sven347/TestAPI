using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;

namespace TestAPI.Repository.Repository
{
    public class NotificationTypeRepository : INotificationTypeRepository
    {
        private readonly DBContext _context;

        public NotificationTypeRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<List<NotificationType>> GetAllNotificationTypesAsync()
        {
            return await _context.NotificationTypes.ToListAsync();
        }

        public async Task<NotificationType> GetNotificationTypeByIdAsync(int id)
        {
            return await _context.NotificationTypes.FindAsync(id);
        }

        public async Task<NotificationType> AddNotificationTypeAsync(NotificationType type)
        {
            _context.NotificationTypes.Add(type);
            await _context.SaveChangesAsync();
            return type;
        }

        public async Task<NotificationType> UpdateNotificationTypeAsync(NotificationType type)
        {
            _context.NotificationTypes.Update(type);
            await _context.SaveChangesAsync();
            return type;
        }

        public async Task<bool> DeleteNotificationTypeAsync(int id)
        {
            var type = await _context.NotificationTypes.FindAsync(id);
            if (type == null) return false;

            _context.NotificationTypes.Remove(type);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
