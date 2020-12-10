using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Models
{
    [Table("Rooms")]
    public class Room
    {
        public Room()
        {
            this.Features = new HashSet<Feature>();
        }
        public int RoomId { get; set; }

        [Required, Index(IsUnique = true)]
        public int RoomNo { get; set; }
        
        [Required]
        public string Capacity { get; set; }
        
        [Required]
        public int Price { get; set; }
        public string AllFeatures 
        { 
            get { return $"{Features.Select(x => x.FeatureName).AddComma()}"; }
        }

        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
