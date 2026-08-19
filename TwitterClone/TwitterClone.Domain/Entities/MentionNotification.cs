using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification:Notification
    {
        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            MentionedByUserId = mentionedByUserId;
        }
        public Guid MentionedByUserId { get; set; }

        public override string DescribeRecord()
        {
            var baseRecord=base.DescribeRecord();
            return $"{baseRecord},MentionedByUserId:{MentionedByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with id {MentionedByUserId} mentioned in a post.";
        }
    }
}
