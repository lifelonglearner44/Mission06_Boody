namespace Mission06_Boody.Models
{

    public class Movie
    {
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public double Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters")]
        public string Notes { get; set; }

        // Constructor to set default values
        public Movie()
        {
            Edited = false; // Default value for Edited field
        }
    }

}
