using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Models
{
    class KitapKiralaViewModel
    {   
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public DateTime AlinanTarih { get; set; } = DateTime.Now;
        public virtual Uyeler Uyeler { get; set; }
        public virtual Kitap Kitap { get; set; }
        public virtual Yazar Yazar { get; set; }

      //  public override string ToString() => $"{Kitap.KitapAdi} {Yazar.YazarAd} {Yazar.YazarSoyad} {Kitap.Adet} ";
    }
}
