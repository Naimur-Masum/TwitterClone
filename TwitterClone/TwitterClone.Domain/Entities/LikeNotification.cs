using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class LikeNotification:Notification
    {
        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
        }

        public Guid LikeByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var BaseRecord=base.DescribeRecord();
            return $"{BaseRecord}, LikeByUserId: {LikeByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with Id {UserId} liked your post";
        }
    }
}
