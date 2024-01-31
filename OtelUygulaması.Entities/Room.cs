using OtelUygulaması.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.Entities
{
    public  class Room:BaseEntity
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsBooked { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }

        
    }
}
