using Microsoft.EntityFrameworkCore;

namespace Mission06_Boody.Models
{
    // Liason from the app to the database
    public class MovieContext : DbContext    
    {
        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        //this may be movies instead of movie for the table name
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}
