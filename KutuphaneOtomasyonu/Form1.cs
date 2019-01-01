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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnYazargetir_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
           lstyazar.DataSource= db.Yazarlar
                .Select(x => new YazarViewModel
                {
                    //deneme
                    YazarAd = x.YazarAd,
                    YazarSoyad = x.YazarSoyad
                }).ToList();
        }

        private void btnUyeleriGetir_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            lstUyeler.DataSource = db.Uyeler
                .Select(x => new UyelerViewModel
                {
                    Ad = x.Ad,
                    Soyad = x.Soyad

                }).ToList();
        }

        private void üyeKayıtİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeKayit UyeKayitSayfasi = new UyeKayit();

            UyeKayitSayfasi.ShowDialog();
      
        }

        private void kitapKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapKirala KitapKiralaSayfasi = new KitapKirala();
            KitapKiralaSayfasi.ShowDialog();
        }

        private void kitapVeYazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapVeYazarEkle kitapVeYazarEkleSayfasi = new KitapVeYazarEkle();

            kitapVeYazarEkleSayfasi.ShowDialog();
        }
    }
}
