using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    class UyelerViewModel
    {
        
        public int UyelerId { get; set; }  
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKNO { get; set; }
        public int CezaTutari { get; set; } = 0;

        public override string ToString() => $"{Ad} {Soyad}";
    }
}
