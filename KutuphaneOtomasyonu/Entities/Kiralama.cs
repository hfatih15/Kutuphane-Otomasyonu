using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    [Table("KitapKira")]
    public class Kiralama
    {
        [Key]
        [Column(Order = 1)]
        public int UyeId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int KitapId { get; set; }
        [Column("Ekleme", TypeName = "smalldatetime")]
        public DateTime AlinanTarih { get; set; } = DateTime.Now;



        [ForeignKey("UyeId")]
        public virtual Uyeler Uyeler { get; set; }
        [ForeignKey("KitapId")]
        public virtual Kitap Kitap { get; set; }
    }
}
