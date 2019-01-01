using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Models
{
    class KitapViewModel
    {

       
        public int KitapId { get; set; }

  
        //  [Index(IsUnique = true)]
        public string KitapAdi { get; set; }
        public string KitapTuru { get; set; }
        public int YazarId { get; set; }
        public virtual Yazar Yazar { get; set; }
        public decimal Adet { get; set; }

        public override string ToString() => $"Kitap Adı: {KitapAdi} - Adet: {Adet} ";

    }
}
