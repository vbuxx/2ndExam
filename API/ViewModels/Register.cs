﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class Register
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string Password { get; set; }
        public string Alamat { get; set; }

        public string Telp { get; set; }
    }
}
