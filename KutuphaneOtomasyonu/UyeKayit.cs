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
    public partial class UyeKayit : Form
    {
        public UyeKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyContext db = new MyContext();
            try
            {
                
                db.Uyeler.Add(new Uyeler()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TCKNO = txtTCKN.Text


                });
                db.SaveChanges();
                MessageBox.Show("Kayıt Sisteme Eklendi");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            } FormuTemizle();
        }


        private void FormuTemizle()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                if (control is ListBox lst)
                    lst.Items.Clear();
                //if (control is ComboBox cmb)
                //    cmb.Items.Clear();
            }
        }

        private void UyeKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
