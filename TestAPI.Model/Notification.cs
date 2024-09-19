using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model.Enum;

namespace TestAPI.Model
{
    public class Notification
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int NotificationTypeId { get; set; }
        public NotificationChannel Channel { get; set; }    
        public string Content { get; set; }
        public DateTime SentDate { get; set; }
        public bool Status { get; set; }
    }
}
