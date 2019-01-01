using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Models
{
    class KitapKiralaViewModel
    {

        
        public int KitapID { get; set; }
    
        public int UyeID { get; set; }
      
        public DateTime AlindigiTarih { get; set; } = DateTime.Now;
      
        public virtual Kitap Kitap { get; set; }
      
        public virtual Uyeler Uye { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }

        //  public override string ToString() => $"{Kitap.KitapAdi} {Yazar.YazarAd} {Yazar.YazarSoyad} {Kitap.Adet} ";
    }
}
