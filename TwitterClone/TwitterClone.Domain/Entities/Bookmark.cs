namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _id;
        private Guid _tweetId;
        private Guid _userId;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private Guid _modifiedBy;
        private Guid _createdBy;

        public Bookmark()
        {
            _id= Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
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

        public Guid ModifiedBy
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
        }

        public Guid CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }  

        }
        
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}
