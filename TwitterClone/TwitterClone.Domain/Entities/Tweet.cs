namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private string _content;
        private string _author;

        public string Author { get; }
        public string Content { get; private set; }


        public Tweet(string author,string content) { 
                
            Author= author;
            SetContent(content);
        }

        void SetContent(string content)
        {
            if (String.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentNullException("Tweet cannot be empty.");
            }

            if (content.Length > 280)
            {
                throw new ArgumentException("Tweet cannot exceed 280 characters.");
            }
            _id = Guid.NewGuid();
            Content= content;
        }
    }
}
