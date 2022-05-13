namespace StackOverflowExcersise
{ 
    class Post
    {
        // Property field
        // All private fields makes sense if we are collecting the Posts in some key, value list 
        private int _voteNumber { get; set; }
        private string _title { get; }
        private string _description { get; set; } = "";
        public DateTime creationDate { get; }
        private DateTime _updatedDate;

        public DateTime UpdateDate
        {
            get{ return _updatedDate; }
        }

        // Constructor field
        // Creating empty post, considered editing is called later
        public Post(string title)
        {
            _voteNumber = 0;
            _title = title;
            creationDate = DateTime.Now;
            _updatedDate = DateTime.Now;
        }

        // Creating a post with description together.
        public Post(string title, string description)
            :this(title)
        {
            _description = description;
        }

        // Editing and accessing fields
        // Read the post
        public string ReadPost()
        {
            return _description;
        }

        // Title can be readed, but not modified.
        public string GetTitle()
        {
            return _title;
        }

        // Option for later editing
        public void EditPost(string description)
        {
            _description = description;
            _updatedDate = DateTime.Now;
        }

        // Upvote
        public void UpVote()
        {
            _voteNumber++;
        }

        // Downvote
        public void DownVote()
        {
            _voteNumber--;
        }

        // Get votes
        public int GetVotes()
        {
            return _voteNumber;
        }
    }
}
