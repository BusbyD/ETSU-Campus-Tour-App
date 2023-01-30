using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETSU.CampusTour.SharedLibrary.Models
{
    public class TourBooking
    {
        [Key]
        public int Booking_Id { get; set; }
        public int Tour_Id { get; set; }
        public int User_Id { get; set; }
        public DateTime Booking_Date { get; set; }
        public TimeSpan Booking_Time { get; set; }

    }

}
