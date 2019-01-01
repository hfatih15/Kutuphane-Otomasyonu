namespace KutuphaneOtomasyonu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyeKayıtİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstyazar = new System.Windows.Forms.ListBox();
            this.lstUyeler = new System.Windows.Forms.ListBox();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.btnYazargetir = new System.Windows.Forms.Button();
            this.btnUyeleriGetir = new System.Windows.Forms.Button();
            this.kitapVeYazarEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKitaplariGetir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeKayıtİşlemleriToolStripMenuItem,
            this.kitapVeYazarEkleToolStripMenuItem,
            this.kitapKiralaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyeKayıtİşlemleriToolStripMenuItem
            // 
            this.üyeKayıtİşlemleriToolStripMenuItem.Name = "üyeKayıtİşlemleriToolStripMenuItem";
            this.üyeKayıtİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.üyeKayıtİşlemleriToolStripMenuItem.Text = "Üye Kayıt İşlemleri";
            this.üyeKayıtİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.üyeKayıtİşlemleriToolStripMenuItem_Click);
            // 
            // kitapKiralaToolStripMenuItem
            // 
            this.kitapKiralaToolStripMenuItem.Name = "kitapKiralaToolStripMenuItem";
            this.kitapKiralaToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.kitapKiralaToolStripMenuItem.Text = "Kitap Kirala";
            this.kitapKiralaToolStripMenuItem.Click += new System.EventHandler(this.kitapKiralaToolStripMenuItem_Click);
            // 
            // lstyazar
            // 
            this.lstyazar.FormattingEnabled = true;
            this.lstyazar.ItemHeight = 16;
            this.lstyazar.Location = new System.Drawing.Point(76, 91);
            this.lstyazar.Margin = new System.Windows.Forms.Padding(4);
            this.lstyazar.Name = "lstyazar";
            this.lstyazar.Size = new System.Drawing.Size(159, 244);
            this.lstyazar.TabIndex = 2;
            this.lstyazar.SelectedIndexChanged += new System.EventHandler(this.lstyazar_SelectedIndexChanged);
            // 
            // lstUyeler
            // 
            this.lstUyeler.FormattingEnabled = true;
            this.lstUyeler.ItemHeight = 16;
            this.lstUyeler.Location = new System.Drawing.Point(356, 91);
            this.lstUyeler.Margin = new System.Windows.Forms.Padding(4);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(159, 244);
            this.lstUyeler.TabIndex = 3;
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.ItemHeight = 16;
            this.lstKitaplar.Location = new System.Drawing.Point(651, 91);
            this.lstKitaplar.Margin = new System.Windows.Forms.Padding(4);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(322, 244);
            this.lstKitaplar.TabIndex = 4;
            // 
            // btnYazargetir
            // 
            this.btnYazargetir.Location = new System.Drawing.Point(92, 385);
            this.btnYazargetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnYazargetir.Name = "btnYazargetir";
            this.btnYazargetir.Size = new System.Drawing.Size(114, 59);
            this.btnYazargetir.TabIndex = 5;
            this.btnYazargetir.Text = "Yazarları Getir";
            this.btnYazargetir.UseVisualStyleBackColor = true;
            this.btnYazargetir.Click += new System.EventHandler(this.btnYazargetir_Click);
            // 
            // btnUyeleriGetir
            // 
            this.btnUyeleriGetir.Location = new System.Drawing.Point(373, 385);
            this.btnUyeleriGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeleriGetir.Name = "btnUyeleriGetir";
            this.btnUyeleriGetir.Size = new System.Drawing.Size(129, 59);
            this.btnUyeleriGetir.TabIndex = 6;
            this.btnUyeleriGetir.Text = "Uyeleri Getir";
            this.btnUyeleriGetir.UseVisualStyleBackColor = true;
            this.btnUyeleriGetir.Click += new System.EventHandler(this.btnUyeleriGetir_Click);
            // 
            // kitapVeYazarEkleToolStripMenuItem
            // 
            this.kitapVeYazarEkleToolStripMenuItem.Name = "kitapVeYazarEkleToolStripMenuItem";
            this.kitapVeYazarEkleToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.kitapVeYazarEkleToolStripMenuItem.Text = "Kitap ve Yazar Ekle";
            this.kitapVeYazarEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapVeYazarEkleToolStripMenuItem_Click);
            // 
            // btnKitaplariGetir
            // 
            this.btnKitaplariGetir.Location = new System.Drawing.Point(739, 385);
            this.btnKitaplariGetir.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitaplariGetir.Name = "btnKitaplariGetir";
            this.btnKitaplariGetir.Size = new System.Drawing.Size(160, 59);
            this.btnKitaplariGetir.TabIndex = 7;
            this.btnKitaplariGetir.Text = "Kitapları Getir";
            this.btnKitaplariGetir.UseVisualStyleBackColor = true;
            this.btnKitaplariGetir.Click += new System.EventHandler(this.btnKitaplariGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnKitaplariGetir);
            this.Controls.Add(this.btnUyeleriGetir);
            this.Controls.Add(this.btnYazargetir);
            this.Controls.Add(this.lstKitaplar);
            this.Controls.Add(this.lstUyeler);
            this.Controls.Add(this.lstyazar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lstyazar;
        private System.Windows.Forms.ListBox lstUyeler;
        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.Button btnYazargetir;
        private System.Windows.Forms.Button btnUyeleriGetir;
        private System.Windows.Forms.ToolStripMenuItem üyeKayıtİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapVeYazarEkleToolStripMenuItem;
        private System.Windows.Forms.Button btnKitaplariGetir;
    }
}

