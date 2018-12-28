using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    [Table("Uyeler")]
   public class Uyeler
    {
        [Key]
        public int UyelerId { get; set; }

        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }

        [Required]
        [StringLength(11) , MaxLength(11) , MinLength(11)]
        public string TCKNO { get; set; }
        
        public int CezaTutari { get; set; } = 0;

    }
}
