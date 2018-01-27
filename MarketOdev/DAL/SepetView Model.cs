using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOdev.DAL
{
    class SepetView_Model
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public short Adet { get; set; } = 1;
        public decimal fiyat { get; set; }
        public decimal Indirim { get; set; } = 0;
        public decimal KdvOrani { get; set; } = 0;
        public long BarkodId { get; set; } = 0;
        public decimal Total
        {
            get => Adet * fiyat * Convert.ToDecimal(1 - Indirim);
        }
        public decimal kdvHesapla
        {
            get => Adet * fiyat * Convert.ToDecimal(1 - Indirim) * KdvOrani;
         
        }
       
        
        public override string ToString()
        {
            string u = UrunAdi;
            string a = Adet.ToString().PadLeft(10);
            string f = fiyat.ToString().PadLeft(5);
             string t = Total.ToString().PadLeft(10);
            return u + a +"*"+f+ t;
    }
    }
}
