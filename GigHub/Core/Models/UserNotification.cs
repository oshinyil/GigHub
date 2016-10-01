using System;

namespace GigHub.Core.Models
{
    public class UserNotification
    {
        public string UserId { get; private set; }
        public int NotificationId { get; private set; }
        public ApplicationUser User { get; private set; }
        public Notification Notification { get; private set; }
        public bool IsRead { get; set; }

        protected UserNotification()
        {
        }

        public UserNotification(ApplicationUser user, Notification notifiaction)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }

            if (notifiaction == null)
            {
                throw new ArgumentNullException("notification");
            }

            User = user;
            Notification = notifiaction;
        }

        public void Read()
        {
            IsRead = true;
        }
    }
}