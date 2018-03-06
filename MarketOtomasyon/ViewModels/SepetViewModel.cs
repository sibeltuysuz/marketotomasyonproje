using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.ViewModels
{
    public class SepetViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public short Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; } = 0;
        public decimal SalesPrice { get; set; } = 0;
        public float Discount { get; set; } = 0;

        public decimal Total
        {
            get
            {
                return Quantity * SalesPrice/* * Convert.ToDecimal(1 - Discount)*/;
            }
        }
        public override string ToString() => $"{ProductName} {Quantity}x{SalesPrice:c2} = {Total:c2}";
    }
}
