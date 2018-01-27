using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOdev.Entities
{

    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int SiparisId { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public bool? Nakit { get; set; }
        public bool AlinanMi { get; set; }


        public virtual List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>();



    }
}
