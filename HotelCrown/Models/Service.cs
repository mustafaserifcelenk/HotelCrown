using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string ServiceName { get; set; }
        [Required]
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public virtual ReservationService ReservationService { get; set; }

    }
}
