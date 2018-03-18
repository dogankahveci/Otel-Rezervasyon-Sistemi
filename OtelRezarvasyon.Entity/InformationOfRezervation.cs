using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entity
{
 public  class InformationOfRezervation
    {
        public int RezervationId{ get; set; }
        public int CustomerId{ get; set; }
        public DateTime EnteringDate{ get; set; }
        public DateTime LeavingDate { get; set; }
        public decimal MoneyCost { get; set; }
        public bool IsActive { get; set; }
    }
}
