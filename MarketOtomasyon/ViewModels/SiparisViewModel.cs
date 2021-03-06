﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.ViewModels
{
    public class SiparisViewModel
    {
        public int SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public DateTime? IstenenTarih { get; set; }
        public decimal KargoTutari { get; set; }
        public string Ulke { get; set; }
        public string KargoFirmasi { get; set; }
        public decimal? ToplamSiparisTutari { get; set; }
    }
}
