using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private bool _isRead;
        private DateTime _sentAt;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;
    }
}
