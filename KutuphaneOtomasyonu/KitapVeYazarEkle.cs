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
    public partial class KitapVeYazarEkle : Form
    {
        public KitapVeYazarEkle()
        {
            InitializeComponent();
        }

        private void KitapVeYazarEkle_Load(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            cmbYazarlar.DataSource = db.Yazarlar
                .OrderBy(x => x.YazarAd)
                .ThenBy(x => x.YazarSoyad)
                .Select(x => new YazarViewModel()
                {
                    YazarAd = x.YazarAd,
                    YazarSoyad = x.YazarSoyad,
                    YazarId = x.YazarId
                }).ToList();
        }

        private void FormuTemizle(Control Parent)
        {
            foreach (Control control in Parent.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                if (control is ListBox lst)
                    lst.Items.Clear();
                
            }
        }

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
            //MyContext db = new MyContext();
            //try
            //{
            //    var kitap = new Kitap()
            //    {
            //        KitapAdi = txtKitapAdi.Text,
            //        Adet = Convert.ToDecimal(txtKitapAdi.Text),
            //        YazarId = (cmbYazarlar.SelectedItem as YazarViewModel).YazarId



            //    };
            //    db.Kitaplar.Add(kitap);
            //    db.SaveChanges();
            //    MessageBox.Show("kayıt basarılı");
            //    FormuTemizle(this.pnlKitap);

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}



             MyContext db = new MyContext();
            try
            {
                db.Kitaplar.Add(new Kitap()
                {
                    KitapAdi = txtKitapAdi.Text,
                    Adet = Convert.ToDecimal(txtAdet.Text),
                    YazarId = (cmbYazarlar.SelectedItem as YazarViewModel).YazarId
                }
                );
                db.SaveChanges();
                MessageBox.Show("Kitap Kaydı Basarılı !");
                FormuTemizle(this.pnlKitap);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            try
            {
                var yazar = new Yazar()
                {
                    YazarAd = txtAd.Text,
                    YazarSoyad = txtSoyad.Text

                };
                db.Yazarlar.Add(yazar);
                db.SaveChanges();
                MessageBox.Show("kayıt basarılı");
                FormuTemizle(this.pnlYazar);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}

