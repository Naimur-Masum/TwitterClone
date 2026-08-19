using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Like:BaseEntity
    {
        //private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
       // private DateTime _createdAt;
        //private DateTime _modifiedAt;
        //private Guid _createdBy;
        //private Guid _modifiedBy;

        
        public Like() : base(Guid.NewGuid()) { }
        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }

        
    }
}
