using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification:Notification
    {
        public CommentNotification(Guid commentByUserId) :base("Comment")
        {
            CommentByUserId = commentByUserId;
        }

        public Guid CommentByUserId { get; set; }

        public void AddComment(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, CommentByUserId: {CommentByUserId}";
        }
    }
}
