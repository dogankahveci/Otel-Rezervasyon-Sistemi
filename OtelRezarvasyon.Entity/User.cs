﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entity
{
 public  class User
    {
        public int UserId{ get; set; }
        public int CustomerId{ get; set; }
        public string UserName{ get; set; }
        public short Password{ get; set; }
        public bool IsActive { get; set; }
    }
}
