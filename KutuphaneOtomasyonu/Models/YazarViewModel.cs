using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Models
{
   public  class YazarViewModel
    {
        public int YazarId { get; set; }     
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }

        public override string ToString() => $"{YazarAd} {YazarSoyad}";
      
    }
}
