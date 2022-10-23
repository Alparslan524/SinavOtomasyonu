
namespace _6SigmaYazilimYapimi
{
    partial class frmAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdiA = new System.Windows.Forms.TextBox();
            this.txtSifreA = new System.Windows.Forms.TextBox();
            this.btnGirisA = new System.Windows.Forms.Button();
            this.btnSifremiUnuttumAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(104, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txtKullaniciAdiA
            // 
            this.txtKullaniciAdiA.Location = new System.Drawing.Point(247, 32);
            this.txtKullaniciAdiA.Name = "txtKullaniciAdiA";
            this.txtKullaniciAdiA.Size = new System.Drawing.Size(135, 20);
            this.txtKullaniciAdiA.TabIndex = 2;
            // 
            // txtSifreA
            // 
            this.txtSifreA.Location = new System.Drawing.Point(247, 97);
            this.txtSifreA.Name = "txtSifreA";
            this.txtSifreA.Size = new System.Drawing.Size(135, 20);
            this.txtSifreA.TabIndex = 3;
            // 
            // btnGirisA
            // 
            this.btnGirisA.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGirisA.Location = new System.Drawing.Point(247, 152);
            this.btnGirisA.Name = "btnGirisA";
            this.btnGirisA.Size = new System.Drawing.Size(135, 30);
            this.btnGirisA.TabIndex = 4;
            this.btnGirisA.Text = "Giriş";
            this.btnGirisA.UseVisualStyleBackColor = false;
            this.btnGirisA.Click += new System.EventHandler(this.btnGirisA_Click);
            // 
            // btnSifremiUnuttumAdmin
            // 
            this.btnSifremiUnuttumAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSifremiUnuttumAdmin.Location = new System.Drawing.Point(95, 152);
            this.btnSifremiUnuttumAdmin.Name = "btnSifremiUnuttumAdmin";
            this.btnSifremiUnuttumAdmin.Size = new System.Drawing.Size(135, 30);
            this.btnSifremiUnuttumAdmin.TabIndex = 5;
            this.btnSifremiUnuttumAdmin.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttumAdmin.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttumAdmin.Click += new System.EventHandler(this.btnSifremiUnuttumAdmin_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.btnSifremiUnuttumAdmin);
            this.Controls.Add(this.btnGirisA);
            this.Controls.Add(this.txtSifreA);
            this.Controls.Add(this.txtKullaniciAdiA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdiA;
        private System.Windows.Forms.TextBox txtSifreA;
        private System.Windows.Forms.Button btnGirisA;
        private System.Windows.Forms.Button btnSifremiUnuttumAdmin;
    }
}