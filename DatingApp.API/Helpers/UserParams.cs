namespace DatingApp.API.Helpers
{
    public class UserParams
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
        public string Gender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 99;
        public string OrderBy { get; set; }
        public bool Likers { get; set; }
        public bool Likees { get; set; }
    }
}