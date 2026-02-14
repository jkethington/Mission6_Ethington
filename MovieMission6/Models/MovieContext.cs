using Microsoft.EntityFrameworkCore;

namespace MovieMission6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<NewMovie> MovieCollection { get; set; }
    }
}
