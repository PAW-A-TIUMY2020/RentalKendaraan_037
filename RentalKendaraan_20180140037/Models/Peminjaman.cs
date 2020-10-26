﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan_20180140037.Models
{
    public partial class Peminjaman
    {
        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public Customer IdCustomerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
        public Peminjaman InverseIdPeminjamanNavigation { get; set; }
    }
}
