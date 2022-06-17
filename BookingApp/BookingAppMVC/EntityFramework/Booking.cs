using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingAppMVC.EntityFramework
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Room Room { get; set; }

        public User User { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }



    }
}