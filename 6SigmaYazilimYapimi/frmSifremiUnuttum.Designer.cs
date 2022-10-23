
namespace _6SigmaYazilimYapimi
{
    partial class frmSifremiUnuttum
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
            this.components = new System.ComponentModel.Container();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.txtKullaniciAdiSifremiUnuttum = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnYeniSifreGir = new System.Windows.Forms.Button();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.btnSifreyiKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAd.Location = new System.Drawing.Point(73, 40);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(101, 20);
            this.lblKullaniciAd.TabIndex = 0;
            this.lblKullaniciAd.Text = "Kullanıcı Adı: ";
            // 
            // txtKullaniciAdiSifremiUnuttum
            // 
            this.txtKullaniciAdiSifremiUnuttum.Location = new System.Drawing.Point(203, 40);
            this.txtKullaniciAdiSifremiUnuttum.Name = "txtKullaniciAdiSifremiUnuttum";
            this.txtKullaniciAdiSifremiUnuttum.Size = new System.Drawing.Size(189, 20);
            this.txtKullaniciAdiSifremiUnuttum.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnYeniSifreGir
            // 
            this.btnYeniSifreGir.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnYeniSifreGir.Location = new System.Drawing.Point(203, 66);
            this.btnYeniSifreGir.Name = "btnYeniSifreGir";
            this.btnYeniSifreGir.Size = new System.Drawing.Size(189, 30);
            this.btnYeniSifreGir.TabIndex = 3;
            this.btnYeniSifreGir.Text = "Kullanıcı Adınızı Giriniz";
            this.btnYeniSifreGir.UseVisualStyleBackColor = false;
            this.btnYeniSifreGir.Click += new System.EventHandler(this.btnYeniSifreGir_Click);
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(203, 166);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(189, 20);
            this.txtYeniSifre.TabIndex = 4;
            this.txtYeniSifre.Visible = false;
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniSifre.Location = new System.Drawing.Point(73, 164);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(86, 20);
            this.lblYeniSifre.TabIndex = 5;
            this.lblYeniSifre.Text = "Yeni Şifre: ";
            this.lblYeniSifre.Visible = false;
            // 
            // btnSifreyiKaydet
            // 
            this.btnSifreyiKaydet.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSifreyiKaydet.Location = new System.Drawing.Point(203, 192);
            this.btnSifreyiKaydet.Name = "btnSifreyiKaydet";
            this.btnSifreyiKaydet.Size = new System.Drawing.Size(189, 30);
            this.btnSifreyiKaydet.TabIndex = 6;
            this.btnSifreyiKaydet.Text = "Şifreyi Kaydet";
            this.btnSifreyiKaydet.UseVisualStyleBackColor = false;
            this.btnSifreyiKaydet.Visible = false;
            this.btnSifreyiKaydet.Click += new System.EventHandler(this.btnSifreyiKaydet_Click);
            // 
            // frmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(490, 286);
            this.Controls.Add(this.btnSifreyiKaydet);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.btnYeniSifreGir);
            this.Controls.Add(this.txtKullaniciAdiSifremiUnuttum);
            this.Controls.Add(this.lblKullaniciAd);
            this.Name = "frmSifremiUnuttum";
            this.Text = "frmSifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.TextBox txtKullaniciAdiSifremiUnuttum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnYeniSifreGir;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.Button btnSifreyiKaydet;
    }
}