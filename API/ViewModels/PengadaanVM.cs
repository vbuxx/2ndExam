﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class PengadaanVM
    {
        public int PetugasId { get; set; }
        public string Nama { get; set; }
        public string Tgl { get; set; }
        public string Supplier { get; set; }
        public string Satuan { get; set; }
        public int Qty { get; set; }
        public int Harga { get; set; }
    }
}
