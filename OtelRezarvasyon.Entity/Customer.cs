using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entity
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName{ get; set; }
        public string CustomerLastName{ get; set; }
        public string IdentityNumber{ get; set; }
        public bool IsActive { get; set; }
        public string  Gender{ get; set; }
       
    }
}
