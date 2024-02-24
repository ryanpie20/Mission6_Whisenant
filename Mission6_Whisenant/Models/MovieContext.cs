using Microsoft.EntityFrameworkCore;

namespace Mission6_Whisenant.Models
{
    public class MovieContext : DbContext // liaiason from app to database 
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; } 
        
    }
}
