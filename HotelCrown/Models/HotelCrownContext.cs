using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Models
{
    public class HotelCrownContext : DbContext
    {
        public HotelCrownContext() : base("server=.; database=HotelCrownDb; Integrated Security=true;")
        {
            Database.SetInitializer(new MyInitializationStrategy());
            this.Configuration.LazyLoadingEnabled = false;

        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Room> Rooms  { get; set; }
        public DbSet<ReservationService> ReservationServices { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Feature> Features { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
