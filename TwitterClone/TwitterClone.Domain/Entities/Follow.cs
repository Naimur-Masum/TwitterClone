using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Follow:BaseEntity
    {
        public Follow() : base(Guid.NewGuid()) { }
        //private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        //private DateTime _createdAt;
        //private DateTime _modifiedAt;
        //private Guid _createdBy;
        //private Guid _modifiedBy;

       


        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }


        public override string DescribeRecord()
        {
            var baseRecord=base.DescribeRecord();
            return $"{baseRecord}, FollowerId:{FollowerId}, FollowingId: {FollowingId}";
        }

    }
}
