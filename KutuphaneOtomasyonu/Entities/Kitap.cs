using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    [Table ("Kitaplar")]
   public class Kitap
    {

        [Key]
        public int KitapId { get; set; }
        
        [Required]
      //  [Index(IsUnique = true)]
        public string KitapAdi { get; set; }
        [Required]
        public string KitapTuru { get; set; }

        public int YazarId { get; set; }

        [ForeignKey("YazarId")]
        public virtual Yazar Yazar { get; set; }

     
        public int Adet { get; set; }


      




    }
}
