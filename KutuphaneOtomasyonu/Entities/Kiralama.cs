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
        public int KitapID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UyeID { get; set; }
        [Column("AlindigiTarih ", TypeName = "date")]
        public DateTime AlindigiTarih { get; set; } = DateTime.Now;
        [ForeignKey("KitapID")]
        public virtual Kitap Kitap { get; set; }
        [ForeignKey("UyeID")]
        public virtual Uyeler Uye { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }


    }
}
