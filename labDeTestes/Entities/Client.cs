﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labDeTestes.Entities
{
    class Client
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public Client() { }

        public Client(string? name, string? email)
        {
            Name = name;
            Email = email;
        }
    }
        
}
