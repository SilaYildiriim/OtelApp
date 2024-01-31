using OtelUygulaması.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.Entities
{
    public class Booking:BaseEntity
    {
        
        public  Customer Customer { get; set; }

        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public  Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
