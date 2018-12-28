using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    [Table("Yazarlar")]

   public class Yazar
    {
        [Key]
        public int YazarId { get; set; }

        [Required]
        public string YazarAd { get; set; }

        [Required]
        public string YazarSoyad { get; set; }
        public virtual ICollection<Kitap> Kitaplar { get; set; } = new HashSet<Kitap>();
    }
}
