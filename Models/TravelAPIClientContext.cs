using Microsoft.EntityFrameworkCore;

namespace TravelAPIClient.Models
{
    public class TravelAPIClientContext : DbContext
    {
        public DbSet<Destination> Destinations {get; set; }
        public DbSet<Review> Reviews {get; set; }

        public TravelAPIClientContext(DbContextOptions<TravelAPIClientContext> options) : base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }


    }

}