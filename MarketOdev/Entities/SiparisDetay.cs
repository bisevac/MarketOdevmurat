﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOdev.Entities
{
    [Table("SiparisDetaylar")]
    public class SiparisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SiparisId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Indirim { get; set; } = 0;


        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }
        [ForeignKey("SiparisId")]
        public virtual Siparis Siparis { get; set; }

      


    }
}
