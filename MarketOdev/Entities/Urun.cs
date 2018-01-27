using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOdev.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        [Required]
        [StringLength(40)]
        [Index(IsUnique =true)]
        public string UrunAdi { get; set; }
        public short stok { get; set; } = 0;
        public decimal AlisFiyati { get; set; } = 0;
        public decimal SatisFiyat { get; set; } = 0;
        public byte[] Resim { get; set; }
        public int KategoriId { get; set; }
        public long BarkodNumarasi { get; set; } = 0;

        public DateTime EklenmeZamani { get; set; } = DateTime.Now;

        [ForeignKey("KategoriId")]
        public virtual Kategoriler Kategori { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();

     


        public override string ToString()
        {
            
        
            string b = UrunAdi.PadRight(10);
            string c = AlisFiyati.ToString().PadRight(10);
            string d = SatisFiyat.ToString().PadRight(10);
            string e = stok.ToString();
            return b+c+d+e;
        }
        

    }
}
