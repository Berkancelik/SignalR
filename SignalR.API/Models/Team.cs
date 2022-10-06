﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.API.Models
{
    public class Team
    {
        public int Id{ get; set; }
        public int Name { get; set; }
        public virtual  ICollection<User> Users { get; set; }
    }
}
