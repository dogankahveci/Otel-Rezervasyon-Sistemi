using OtelRezarvasyon.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.DTO
{
   public class CustomerRoomDTO
    {
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Gender { get; set; }
        public Room Room { get; set; }
    }
}
