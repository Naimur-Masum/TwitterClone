namespace TwitterClone.Domain.Entities
{
    public class Bookmark:BaseEntity
    {
       // private Guid _id;
        private Guid _tweetId;
        private Guid _userId;
      // private DateTime _createdAt;
        //private DateTime _modifiedAt;
        //private Guid _modifiedBy;
        //private Guid _createdBy;

       public Bookmark(): base (Guid.NewGuid()) 
        { 
        
        
        }

        public Guid TweetId
        {
            get {  return _tweetId; }
            set { _tweetId= value; }
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId= value; }
        }

        public override string DescribeRecord()
        {
            string baseRecord = base.DescribeRecord();

            return $"{baseRecord}, TweetId:{TweetId}, UserId:{UserId}";
        }
    }
}
