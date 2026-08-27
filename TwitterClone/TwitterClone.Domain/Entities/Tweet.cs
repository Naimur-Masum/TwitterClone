namespace TwitterClone.Domain.Entities
{
    public class Tweet:BaseEntity,ILikeable
    {
        //private Guid _id;
        private Guid _userId;
        private string _content;

        public static int MaxContentLength = 200;
        

        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content= content;
        }

        public Guid UserId
        {
            get { return _userId;}
            set { _userId = value; }

        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public override string DescribeRecord()
        {
            var baseRecord=base.DescribeRecord();
            return $"{baseRecord},UserId:{UserId},Content:{Content}";
        }

        public bool CanBeLiked()
        {
            if(string.IsNullOrWhiteSpace(Content)) return false; return true;
        }
    }
}
