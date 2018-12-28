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
            this.lstyazar = new System.Windows.Forms.ListBox();
            this.lstUyeler = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnYazargetir = new System.Windows.Forms.Button();
            this.btnUyeleriGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lstyazar
            // 
            this.lstyazar.FormattingEnabled = true;
            this.lstyazar.Location = new System.Drawing.Point(57, 74);
            this.lstyazar.Name = "lstyazar";
            this.lstyazar.Size = new System.Drawing.Size(120, 199);
            this.lstyazar.TabIndex = 2;
            // 
            // lstUyeler
            // 
            this.lstUyeler.FormattingEnabled = true;
            this.lstUyeler.Location = new System.Drawing.Point(267, 74);
            this.lstUyeler.Name = "lstUyeler";
            this.lstUyeler.Size = new System.Drawing.Size(120, 199);
            this.lstUyeler.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(488, 74);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 199);
            this.listBox3.TabIndex = 4;
            // 
            // btnYazargetir
            // 
            this.btnYazargetir.Location = new System.Drawing.Point(57, 313);
            this.btnYazargetir.Name = "btnYazargetir";
            this.btnYazargetir.Size = new System.Drawing.Size(149, 48);
            this.btnYazargetir.TabIndex = 5;
            this.btnYazargetir.Text = "Yazarları Getir";
            this.btnYazargetir.UseVisualStyleBackColor = true;
            this.btnYazargetir.Click += new System.EventHandler(this.btnYazargetir_Click);
            // 
            // btnUyeleriGetir
            // 
            this.btnUyeleriGetir.Location = new System.Drawing.Point(267, 313);
            this.btnUyeleriGetir.Name = "btnUyeleriGetir";
            this.btnUyeleriGetir.Size = new System.Drawing.Size(120, 48);
            this.btnUyeleriGetir.TabIndex = 6;
            this.btnUyeleriGetir.Text = "Uyeleri Getir";
            this.btnUyeleriGetir.UseVisualStyleBackColor = true;
            this.btnUyeleriGetir.Click += new System.EventHandler(this.btnUyeleriGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUyeleriGetir);
            this.Controls.Add(this.btnYazargetir);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.lstUyeler);
            this.Controls.Add(this.lstyazar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lstyazar;
        private System.Windows.Forms.ListBox lstUyeler;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnYazargetir;
        private System.Windows.Forms.Button btnUyeleriGetir;
    }
}

