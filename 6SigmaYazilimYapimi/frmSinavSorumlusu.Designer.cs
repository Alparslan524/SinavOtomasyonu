
namespace _6SigmaYazilimYapimi
{
    partial class frmSinavSorumlusu
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
            this.btnGirisSS = new System.Windows.Forms.Button();
            this.txtSifreSS = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdiSS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSifremiUnuttumSS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGirisSS
            // 
            this.btnGirisSS.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGirisSS.Location = new System.Drawing.Point(245, 152);
            this.btnGirisSS.Name = "btnGirisSS";
            this.btnGirisSS.Size = new System.Drawing.Size(135, 30);
            this.btnGirisSS.TabIndex = 9;
            this.btnGirisSS.Text = "Giriş";
            this.btnGirisSS.UseVisualStyleBackColor = false;
            this.btnGirisSS.Click += new System.EventHandler(this.btnGirisSS_Click);
            // 
            // txtSifreSS
            // 
            this.txtSifreSS.Location = new System.Drawing.Point(245, 97);
            this.txtSifreSS.Name = "txtSifreSS";
            this.txtSifreSS.Size = new System.Drawing.Size(135, 20);
            this.txtSifreSS.TabIndex = 8;
            // 
            // txtKullaniciAdiSS
            // 
            this.txtKullaniciAdiSS.Location = new System.Drawing.Point(245, 32);
            this.txtKullaniciAdiSS.Name = "txtKullaniciAdiSS";
            this.txtKullaniciAdiSS.Size = new System.Drawing.Size(135, 20);
            this.txtKullaniciAdiSS.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // btnSifremiUnuttumSS
            // 
            this.btnSifremiUnuttumSS.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSifremiUnuttumSS.Location = new System.Drawing.Point(96, 151);
            this.btnSifremiUnuttumSS.Name = "btnSifremiUnuttumSS";
            this.btnSifremiUnuttumSS.Size = new System.Drawing.Size(135, 30);
            this.btnSifremiUnuttumSS.TabIndex = 10;
            this.btnSifremiUnuttumSS.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttumSS.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttumSS.Click += new System.EventHandler(this.btnSifremiUnuttumSS_Click);
            // 
            // frmSinavSorumlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.btnSifremiUnuttumSS);
            this.Controls.Add(this.btnGirisSS);
            this.Controls.Add(this.txtSifreSS);
            this.Controls.Add(this.txtKullaniciAdiSS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSinavSorumlusu";
            this.Text = "Sınav Sorumlusu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisSS;
        private System.Windows.Forms.TextBox txtSifreSS;
        private System.Windows.Forms.TextBox txtKullaniciAdiSS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSifremiUnuttumSS;
    }
}