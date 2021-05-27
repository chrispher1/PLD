namespace PLD.Helper
{
    public class GridParams
    {
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize;}
            set { pageSize = value;}
        }
        





        
    }
}