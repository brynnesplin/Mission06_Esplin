using Microsoft.EntityFrameworkCore;

namespace Mission06_Esplin.Models
{
    public class MovieRatingContext : DbContext
    {
        public MovieRatingContext(DbContextOptions<MovieRatingContext>options) :base(options) { }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
