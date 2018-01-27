using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOdev.ViewModel
{
  public  class UrunView
    {

      
        public int UrunId { get; set; }
         
        public string UrunAdi { get; set; }

        public short stok { get; set; } = 0;

        public decimal AlisFiyati { get; set; } = 0;

        public decimal SatisFiyat { get; set; } = 0;

        public string kategoriAdi { get; set; }

    }
}
