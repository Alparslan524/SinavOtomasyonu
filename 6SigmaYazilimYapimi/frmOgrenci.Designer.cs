
namespace _6SigmaYazilimYapimi
{
    partial class frmOgrenci
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
            this.btnGirisO = new System.Windows.Forms.Button();
            this.txtSifreO = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSifremiUnuttumOgrenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGirisO
            // 
            this.btnGirisO.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGirisO.Location = new System.Drawing.Point(247, 151);
            this.btnGirisO.Name = "btnGirisO";
            this.btnGirisO.Size = new System.Drawing.Size(135, 30);
            this.btnGirisO.TabIndex = 14;
            this.btnGirisO.Text = "Giriş";
            this.btnGirisO.UseVisualStyleBackColor = false;
            this.btnGirisO.Click += new System.EventHandler(this.btnGirisO_Click);
            // 
            // txtSifreO
            // 
            this.txtSifreO.Location = new System.Drawing.Point(247, 96);
            this.txtSifreO.Name = "txtSifreO";
            this.txtSifreO.Size = new System.Drawing.Size(135, 20);
            this.txtSifreO.TabIndex = 13;
            // 
            // txtKullaniciAdiO
            // 
            this.txtKullaniciAdiO.Location = new System.Drawing.Point(247, 31);
            this.txtKullaniciAdiO.Name = "txtKullaniciAdiO";
            this.txtKullaniciAdiO.Size = new System.Drawing.Size(135, 20);
            this.txtKullaniciAdiO.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // btnSifremiUnuttumOgrenci
            // 
            this.btnSifremiUnuttumOgrenci.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSifremiUnuttumOgrenci.Location = new System.Drawing.Point(96, 151);
            this.btnSifremiUnuttumOgrenci.Name = "btnSifremiUnuttumOgrenci";
            this.btnSifremiUnuttumOgrenci.Size = new System.Drawing.Size(135, 30);
            this.btnSifremiUnuttumOgrenci.TabIndex = 15;
            this.btnSifremiUnuttumOgrenci.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttumOgrenci.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttumOgrenci.Click += new System.EventHandler(this.btnSifremiUnuttumOgrenci_Click);
            // 
            // frmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.btnSifremiUnuttumOgrenci);
            this.Controls.Add(this.btnGirisO);
            this.Controls.Add(this.txtSifreO);
            this.Controls.Add(this.txtKullaniciAdiO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenci";
            this.Text = "Öğrenci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtKullaniciAdiO;
        public System.Windows.Forms.Button btnGirisO;
        public System.Windows.Forms.TextBox txtSifreO;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSifremiUnuttumOgrenci;
    }
}