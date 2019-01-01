namespace KutuphaneOtomasyonu
{
    partial class KitapVeYazarEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYazarlar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlYazar = new System.Windows.Forms.Panel();
            this.pnlKitap = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.pnlYazar.SuspendLayout();
            this.pnlKitap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(153, 169);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(152, 24);
            this.txtSoyad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(153, 100);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(152, 24);
            this.txtAd.TabIndex = 8;
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Location = new System.Drawing.Point(152, 240);
            this.btnYazarEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(153, 55);
            this.btnYazarEkle.TabIndex = 7;
            this.btnYazarEkle.Text = "Kaydet";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(156, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yazar Ekle";
            // 
            // cmbYazarlar
            // 
            this.cmbYazarlar.FormattingEnabled = true;
            this.cmbYazarlar.Location = new System.Drawing.Point(22, 95);
            this.cmbYazarlar.Name = "cmbYazarlar";
            this.cmbYazarlar.Size = new System.Drawing.Size(142, 24);
            this.cmbYazarlar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yazarlar";
            // 
            // pnlYazar
            // 
            this.pnlYazar.Controls.Add(this.label3);
            this.pnlYazar.Controls.Add(this.btnYazarEkle);
            this.pnlYazar.Controls.Add(this.txtAd);
            this.pnlYazar.Controls.Add(this.label1);
            this.pnlYazar.Controls.Add(this.label2);
            this.pnlYazar.Controls.Add(this.txtSoyad);
            this.pnlYazar.Location = new System.Drawing.Point(181, 1);
            this.pnlYazar.Name = "pnlYazar";
            this.pnlYazar.Size = new System.Drawing.Size(363, 318);
            this.pnlYazar.TabIndex = 15;
            // 
            // pnlKitap
            // 
            this.pnlKitap.Controls.Add(this.label5);
            this.pnlKitap.Controls.Add(this.btnKitapKaydet);
            this.pnlKitap.Controls.Add(this.txtKitapAdi);
            this.pnlKitap.Controls.Add(this.label6);
            this.pnlKitap.Controls.Add(this.label7);
            this.pnlKitap.Controls.Add(this.txtAdet);
            this.pnlKitap.Location = new System.Drawing.Point(604, 1);
            this.pnlKitap.Name = "pnlKitap";
            this.pnlKitap.Size = new System.Drawing.Size(338, 318);
            this.pnlKitap.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(157, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kitap Ekle";
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.Location = new System.Drawing.Point(153, 228);
            this.btnKitapKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(153, 55);
            this.btnKitapKaydet.TabIndex = 13;
            this.btnKitapKaydet.Text = "Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            this.btnKitapKaydet.Click += new System.EventHandler(this.btnKitapKaydet_Click);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(154, 87);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(152, 24);
            this.txtKitapAdi.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kitap Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(154, 156);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdet.Multiline = true;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(152, 24);
            this.txtAdet.TabIndex = 16;
            // 
            // KitapVeYazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.pnlKitap);
            this.Controls.Add(this.pnlYazar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbYazarlar);
            this.Name = "KitapVeYazarEkle";
            this.Text = "KitapVeYazarEkle";
            this.Load += new System.EventHandler(this.KitapVeYazarEkle_Load);
            this.pnlYazar.ResumeLayout(false);
            this.pnlYazar.PerformLayout();
            this.pnlKitap.ResumeLayout(false);
            this.pnlKitap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYazarlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlYazar;
        private System.Windows.Forms.Panel pnlKitap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdet;
    }
}