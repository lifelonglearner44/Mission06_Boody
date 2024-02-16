namespace Mission06_Boody.Models
{

    public class Movie
    {
        public int MovieID { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }

        
        public int Year { get; set; }

        public string Director { get; set; }

        public double Rating { get; set; }

        public bool Edited { get; set; }
        public string LentTo { get; set; }

        public string Notes { get; set; }
    }


}
