using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DTO
{
   public class ReservationFullDTO
    {
        public string CustomerName { get; set; }
        public string  CustomerSurname { get; set; }
        public string  TCNo { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Decimal TotalPrice { get; set; }

        public List<CustomerRoomDTO> CustomerRooms { get; set; }
    }
}
