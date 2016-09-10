using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalValue { get; set; }

        [Required]
        public Gig Gig { get; private set; }

        protected Notification()
        {
        }

        public Notification(NotificationType type, Gig gig)
        {
            if (Gig == null)
            {
                throw new ArgumentNullException("gig");
            }

            Type = type;
            Gig = gig;
            DateTime = DateTime.Now;
        }
    }
}