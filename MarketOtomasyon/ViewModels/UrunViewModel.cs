using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.ViewModels
{
    public class UrunViewModel
    {
        
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal? AlisFiyati { get; set; }
        public decimal? SatisFiyati { get; set; }
        public string TedarikciFirma { get; set; }
        public int? Stok { get; set; }
        public string Kategori { get; set; }
        public string Barkod { get; set; }
        public byte[] Resim { get; set; }
        public override string ToString() => $"{UrunAdi}";
    }
}
