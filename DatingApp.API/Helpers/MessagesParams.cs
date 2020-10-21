namespace DatingApp.API.Helpers
{
    public class MessagesParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pagSize = 10; 
        public int PageSize
        {
            get { return pagSize; }
            set { pagSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        
        public int UserId { get; set; } 

        public string MessageContainer { get; set; } = "Unread";
    }
}