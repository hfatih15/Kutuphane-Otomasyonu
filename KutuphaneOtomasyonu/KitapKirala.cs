using KutuphaneOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class KitapKirala : Form
    {
        public KitapKirala()
        {
            InitializeComponent();
        }

        private void KitapKirala_Load(object sender, EventArgs e)
        {
            MyContext db = new MyContext();

            lstKitaplar.DataSource = db.Kitaplar
                 .Select(x => new KitapViewModel()
                 {

                     KitapAdi = x.KitapAdi,
                     Adet = x.Adet
                 }).ToList();
            
        }
    }
}
