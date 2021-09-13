using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AirportManager.Models;

namespace AirportManager.DAL
{
    public class AirportContext : DbContext
    {
        public AirportContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Aircraft> Aircrafts { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Luggage> Luggages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
