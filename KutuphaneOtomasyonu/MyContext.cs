using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KutuphaneOtomasyonu
{
  public  class MyContext : DbContext
    {
        public MyContext()
          : base("name=MyCon")
        {

        }
        public virtual DbSet<Uyeler> Uyeler { get; set; }
        public virtual DbSet<Kitap> Kitaplar { get; set; }
        public virtual DbSet<Yazar> Yazarlar { get; set; }
        public virtual DbSet<Kiralama> Kiralama { get; set; }
    }
}
