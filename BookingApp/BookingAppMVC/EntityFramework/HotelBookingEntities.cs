using System;
using System.Data.Entity;
using System.Linq;

namespace BookingAppMVC.EntityFramework
{
    public class HotelBookingEntities : DbContext
    {
        // Your context has been configured to use a 'HotelBookingEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BookingAppMVC.EntityFramework.HotelBookingEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HotelBookingEntities' 
        // connection string in the application configuration file.
        public HotelBookingEntities()
            : base("name=HotelBookingEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }

    }

}