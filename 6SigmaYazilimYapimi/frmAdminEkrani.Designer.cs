
namespace _6SigmaYazilimYapimi
{
    partial class frmAdminEkrani
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
            this.btnAdminKullaniciSil = new System.Windows.Forms.Button();
            this.btnAdminSoruSil = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminKullaniciSil
            // 
            this.btnAdminKullaniciSil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdminKullaniciSil.Location = new System.Drawing.Point(41, 160);
            this.btnAdminKullaniciSil.Name = "btnAdminKullaniciSil";
            this.btnAdminKullaniciSil.Size = new System.Drawing.Size(160, 30);
            this.btnAdminKullaniciSil.TabIndex = 0;
            this.btnAdminKullaniciSil.Text = "Kullanıcı Sil";
            this.btnAdminKullaniciSil.UseVisualStyleBackColor = false;
            this.btnAdminKullaniciSil.Click += new System.EventHandler(this.btnAdminKullaniciSil_Click);
            // 
            // btnAdminSoruSil
            // 
            this.btnAdminSoruSil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdminSoruSil.Location = new System.Drawing.Point(41, 113);
            this.btnAdminSoruSil.Name = "btnAdminSoruSil";
            this.btnAdminSoruSil.Size = new System.Drawing.Size(160, 30);
            this.btnAdminSoruSil.TabIndex = 0;
            this.btnAdminSoruSil.Text = "Soru Sil";
            this.btnAdminSoruSil.UseVisualStyleBackColor = false;
            this.btnAdminSoruSil.Click += new System.EventHandler(this.btnAdminSoruSil_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(41, 420);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(160, 60);
            this.btnAnaMenu.TabIndex = 2;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // frmAdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(249, 496);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnAdminSoruSil);
            this.Controls.Add(this.btnAdminKullaniciSil);
            this.Name = "frmAdminEkrani";
            this.Text = "Admin Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminKullaniciSil;
        private System.Windows.Forms.Button btnAdminSoruSil;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}