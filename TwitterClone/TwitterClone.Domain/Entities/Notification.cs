using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public abstract class Notification:BaseEntity
    {
        //private Guid _id;
        private string _type;
        private Guid _userId;
        private string _message;
        private bool _isRead;
        //private DateTime _createdAt;
        //private DateTime _modifiedAt;
        //private Guid _modifiedBy;
        //private Guid _createdBy;

        public Notification(string notificationType) : base(Guid.NewGuid()) {
        
                _type= notificationType;
        }

        

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        
        protected string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public override string DescribeRecord()
        {
            var baseRecord=base.DescribeRecord();
            return $"{baseRecord}, Type: {Type}, UserId: {Message}, IsRead: {IsRead}";
        }

        public string GetNotificationInfo()
        {
            return $"UserId: {UserId}, Type:{Type}";
        }

        public abstract string GetMessage();
    }
}
