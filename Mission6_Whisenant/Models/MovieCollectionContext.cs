using Microsoft.EntityFrameworkCore;

namespace Mission6_Whisenant.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options) 
        { 
        }

        public DbSet<MovieCollection> MovieCollections { get; set; }
    }
}
