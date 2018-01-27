using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOdev.Entities
{
    [Table("Kategoriler")]
   public class Kategoriler
    {
        [Key]
        public int KategoriId { get; set; }
        [Required]
        [StringLength(25)]
        [Column(TypeName ="varchar")]
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public decimal? KdvOrani { get; set; } = 0;

        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();

      //  public override string ToString() => $"{KategoriId} - {KategoriAdi} ";

    }
}
