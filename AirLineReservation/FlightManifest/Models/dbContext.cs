using Microsoft.EntityFrameworkCore;
namespace FlightManifest.Models
{
    public class flightContext : DbContext
    {

        public flightContext(DbContextOptions<flightContext> options)
         : base(options)
        {
        }
        public DbSet<flightItem> flightItems { get; set; }

    }
}