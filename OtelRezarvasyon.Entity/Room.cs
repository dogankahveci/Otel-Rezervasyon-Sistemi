using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entity
{
  public  class Room
    {
        public int RoomId{ get; set; }
        public string RoomNumber{ get; set; }
        public decimal RoomCost { get; set; }
        public byte Capacity { get; set; }
        public bool IsActive { get; set; }
       
    }
}
