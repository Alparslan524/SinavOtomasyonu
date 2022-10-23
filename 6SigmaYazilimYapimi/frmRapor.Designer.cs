
namespace _6SigmaYazilimYapimi
{
    partial class frmRapor
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
            this.btnGirisRapor = new System.Windows.Forms.Button();
            this.btnAnaMenuRapor = new System.Windows.Forms.Button();
            this.lblKullaniciAdiRapor = new System.Windows.Forms.Label();
            this.listViewRapor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnGirisRapor
            // 
            this.btnGirisRapor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGirisRapor.Location = new System.Drawing.Point(74, 41);
            this.btnGirisRapor.Name = "btnGirisRapor";
            this.btnGirisRapor.Size = new System.Drawing.Size(160, 204);
            this.btnGirisRapor.TabIndex = 19;
            this.btnGirisRapor.Text = "Raporu Görüntüle";
            this.btnGirisRapor.UseVisualStyleBackColor = false;
            this.btnGirisRapor.Click += new System.EventHandler(this.btnGirisRapor_Click);
            // 
            // btnAnaMenuRapor
            // 
            this.btnAnaMenuRapor.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenuRapor.Location = new System.Drawing.Point(74, 251);
            this.btnAnaMenuRapor.Name = "btnAnaMenuRapor";
            this.btnAnaMenuRapor.Size = new System.Drawing.Size(160, 60);
            this.btnAnaMenuRapor.TabIndex = 20;
            this.btnAnaMenuRapor.Text = "Ana Menü";
            this.btnAnaMenuRapor.UseVisualStyleBackColor = false;
            this.btnAnaMenuRapor.Click += new System.EventHandler(this.btnAnaMenuRapor_Click);
            // 
            // lblKullaniciAdiRapor
            // 
            this.lblKullaniciAdiRapor.AutoSize = true;
            this.lblKullaniciAdiRapor.Location = new System.Drawing.Point(13, 360);
            this.lblKullaniciAdiRapor.Name = "lblKullaniciAdiRapor";
            this.lblKullaniciAdiRapor.Size = new System.Drawing.Size(0, 13);
            this.lblKullaniciAdiRapor.TabIndex = 21;
            this.lblKullaniciAdiRapor.Visible = false;
            // 
            // listViewRapor
            // 
            this.listViewRapor.BackColor = System.Drawing.SystemColors.Highlight;
            this.listViewRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewRapor.HideSelection = false;
            this.listViewRapor.Location = new System.Drawing.Point(264, 41);
            this.listViewRapor.Name = "listViewRapor";
            this.listViewRapor.Size = new System.Drawing.Size(570, 270);
            this.listViewRapor.TabIndex = 22;
            this.listViewRapor.UseCompatibleStateImageBehavior = false;
            this.listViewRapor.View = System.Windows.Forms.View.Details;
            this.listViewRapor.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doğru Sayısı";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yanlış Sayısı";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sınava Tarihi";
            this.columnHeader4.Width = 116;
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(907, 369);
            this.Controls.Add(this.listViewRapor);
            this.Controls.Add(this.lblKullaniciAdiRapor);
            this.Controls.Add(this.btnAnaMenuRapor);
            this.Controls.Add(this.btnGirisRapor);
            this.Name = "frmRapor";
            this.Text = "Rapor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGirisRapor;
        private System.Windows.Forms.Button btnAnaMenuRapor;
        public System.Windows.Forms.Label lblKullaniciAdiRapor;
        private System.Windows.Forms.ListView listViewRapor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}