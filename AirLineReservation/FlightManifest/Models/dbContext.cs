using Microsoft.EntityFrameworkCore;
namespace FlightManifest.Models
{
    public class flightContext : DbContext
    {

        public FlightContext(DbContextOptions<FlightContext> options)
         : base(options)
        {

        }
        public DbSet<flightItem> flightItems { get; set; }

    }
}