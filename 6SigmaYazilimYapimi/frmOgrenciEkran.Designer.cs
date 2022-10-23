
namespace _6SigmaYazilimYapimi
{
    partial class frmOgrenciEkran
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
            this.btnSınavModulGetir = new System.Windows.Forms.Button();
            this.btnAlistirmaGetir = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.lblOgrenciEkranKulalniciAd = new System.Windows.Forms.Label();
            this.btnRapor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSınavModulGetir
            // 
            this.btnSınavModulGetir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSınavModulGetir.Location = new System.Drawing.Point(41, 128);
            this.btnSınavModulGetir.Name = "btnSınavModulGetir";
            this.btnSınavModulGetir.Size = new System.Drawing.Size(160, 30);
            this.btnSınavModulGetir.TabIndex = 0;
            this.btnSınavModulGetir.Text = "6 Sigma İle Sınav Yap";
            this.btnSınavModulGetir.UseVisualStyleBackColor = false;
            this.btnSınavModulGetir.Click += new System.EventHandler(this.btnSınavModulGetir_Click);
            // 
            // btnAlistirmaGetir
            // 
            this.btnAlistirmaGetir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlistirmaGetir.Location = new System.Drawing.Point(41, 69);
            this.btnAlistirmaGetir.Name = "btnAlistirmaGetir";
            this.btnAlistirmaGetir.Size = new System.Drawing.Size(160, 30);
            this.btnAlistirmaGetir.TabIndex = 1;
            this.btnAlistirmaGetir.Text = "Alıştırma yap";
            this.btnAlistirmaGetir.UseVisualStyleBackColor = false;
            this.btnAlistirmaGetir.Click += new System.EventHandler(this.btnAlistirmaGetir_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(41, 420);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(160, 60);
            this.btnAnaMenu.TabIndex = 2;
            this.btnAnaMenu.Text = "Çıkış Yap";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // lblOgrenciEkranKulalniciAd
            // 
            this.lblOgrenciEkranKulalniciAd.AutoSize = true;
            this.lblOgrenciEkranKulalniciAd.Location = new System.Drawing.Point(211, 9);
            this.lblOgrenciEkranKulalniciAd.Name = "lblOgrenciEkranKulalniciAd";
            this.lblOgrenciEkranKulalniciAd.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciEkranKulalniciAd.TabIndex = 3;
            this.lblOgrenciEkranKulalniciAd.Visible = false;
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRapor.Location = new System.Drawing.Point(41, 187);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(160, 30);
            this.btnRapor.TabIndex = 4;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(37, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Çıkış İçin Tıklayınız";
            // 
            // frmOgrenciEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(249, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.lblOgrenciEkranKulalniciAd);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnAlistirmaGetir);
            this.Controls.Add(this.btnSınavModulGetir);
            this.Name = "frmOgrenciEkran";
            this.Text = "Öğrenci Ekran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblOgrenciEkranKulalniciAd;
        public System.Windows.Forms.Button btnSınavModulGetir;
        public System.Windows.Forms.Button btnAlistirmaGetir;
        public System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Label label2;
    }
}