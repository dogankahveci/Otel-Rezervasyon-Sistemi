using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entity
{
    public class Contact
    {
        public int ContactId{ get; set; }
        public int CustomerId{ get; set; }
        public string Adress{ get; set; }
        public string Tel{ get; set; }
        public bool IsActive{ get; set; }
        public string Email { get; set; }
    }
}
