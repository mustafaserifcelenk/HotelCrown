using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Models
{
    public class Reservation
    {
        //public Reservation()
        //{
        //    Customers = new HashSet<Customer>();
        //    ReservationServices = new HashSet<ReservationService>();
        //}
        public int Id { get; set; }
        public int RoomId { get; set; }

        [Required]
        public DateTime? CheckInDate { get; set; }

        [Required]
        public DateTime? CheckOutDate { get; set; }

        public DateTime? CheckedInTime { get; set; }
        public DateTime? CheckedOutTime { get; set; }
        public string CheckedIn { get; set; }
        public string CheckedOut { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<ReservationService> ReservationServices { get; set; }

    }
}
