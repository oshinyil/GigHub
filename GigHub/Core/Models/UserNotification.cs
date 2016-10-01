﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigHub.Core.Models
{
    public class UserNotification
    {
        [Key]
        [Column(Order = 1)]
        public string UserId { get; private set; }

        [Key]
        [Column(Order = 2)]
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