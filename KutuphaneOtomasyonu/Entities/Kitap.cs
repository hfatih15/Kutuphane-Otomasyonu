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
       
        // [Index(IsUnique = true)]
        [Required]
       
        [StringLength(60)]
        public string KitapAdi { get; set; }
        [Required]
        public string KitapTuru { get; set; }  

        public int YazarId { get; set; }

        [ForeignKey("YazarId")]
        public virtual Yazar Yazar { get; set; }


        public decimal Adet { get; set; } = 0;

        public virtual ICollection<Kiralama> Kiralamalar { get; set; } = new HashSet<Kiralama>();





    }
}
