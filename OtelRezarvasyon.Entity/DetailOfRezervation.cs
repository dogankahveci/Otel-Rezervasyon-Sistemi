using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entity
{
    public class DetailOfRezervation
    {
        public int RezervationId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public bool IsActive { get; set; }
    }
}
