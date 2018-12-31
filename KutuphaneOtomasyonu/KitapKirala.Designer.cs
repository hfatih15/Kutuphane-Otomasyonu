namespace KutuphaneOtomasyonu
{
    partial class KitapKirala
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
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.ItemHeight = 16;
            this.lstKitaplar.Location = new System.Drawing.Point(253, 87);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(403, 260);
            this.lstKitaplar.TabIndex = 0;
            // 
            // cmbTurler
            // 
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(49, 87);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(121, 24);
            this.cmbTurler.TabIndex = 1;
            // 
            // KitapKirala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.lstKitaplar);
            this.Name = "KitapKirala";
            this.Text = "KitapKirala";
            this.Load += new System.EventHandler(this.KitapKirala_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKitaplar;
        private System.Windows.Forms.ComboBox cmbTurler;
    }
}