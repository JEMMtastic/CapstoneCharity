﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public BvLocation BvLocation { get; set; }
        public string Name { get; set; }
        public int AccessLevel { get; set; }
        public string UserEmail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
