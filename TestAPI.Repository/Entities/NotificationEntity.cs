using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Model;
using TestAPI.Model.Enum;

namespace TestAPI.Repository.Entities
{
    public class NotificationEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserId { get; set; }

        [Required]
        [ForeignKey("NotificationType")]
        public int NotificationTypeId { get; set; }
        public NotificationType NotificationType { get; set; }

        [Required]
        public NotificationChannel Channel { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        [Required]
        public DateTime SentDate { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
