
namespace _6SigmaYazilimYapimi
{
    partial class frmAdminKullaniciSil
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
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.dataGridViewKullaniciSil = new System.Windows.Forms.DataGridView();
            this.kullaniciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTipiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimYapimiDataSet3 = new _6SigmaYazilimYapimi.YazilimYapimiDataSet3();
            this.btnKullaniciListle = new System.Windows.Forms.Button();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.tbl_KullaniciTableAdapter = new _6SigmaYazilimYapimi.YazilimYapimiDataSet3TableAdapters.Tbl_KullaniciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullaniciSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(312, 342);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(160, 60);
            this.btnAnaMenu.TabIndex = 0;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // dataGridViewKullaniciSil
            // 
            this.dataGridViewKullaniciSil.AllowUserToAddRows = false;
            this.dataGridViewKullaniciSil.AutoGenerateColumns = false;
            this.dataGridViewKullaniciSil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKullaniciSil.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewKullaniciSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullaniciSil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciIDDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kullaniciTipiIDDataGridViewTextBoxColumn});
            this.dataGridViewKullaniciSil.DataSource = this.tblKullaniciBindingSource;
            this.dataGridViewKullaniciSil.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKullaniciSil.Name = "dataGridViewKullaniciSil";
            this.dataGridViewKullaniciSil.Size = new System.Drawing.Size(761, 310);
            this.dataGridViewKullaniciSil.TabIndex = 1;
            // 
            // kullaniciIDDataGridViewTextBoxColumn
            // 
            this.kullaniciIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.HeaderText = "KullaniciID";
            this.kullaniciIDDataGridViewTextBoxColumn.Name = "kullaniciIDDataGridViewTextBoxColumn";
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kullaniciTipiIDDataGridViewTextBoxColumn
            // 
            this.kullaniciTipiIDDataGridViewTextBoxColumn.DataPropertyName = "KullaniciTipiID";
            this.kullaniciTipiIDDataGridViewTextBoxColumn.HeaderText = "KullaniciTipiID";
            this.kullaniciTipiIDDataGridViewTextBoxColumn.Name = "kullaniciTipiIDDataGridViewTextBoxColumn";
            // 
            // tblKullaniciBindingSource
            // 
            this.tblKullaniciBindingSource.DataMember = "Tbl_Kullanici";
            this.tblKullaniciBindingSource.DataSource = this.yazilimYapimiDataSet3;
            // 
            // yazilimYapimiDataSet3
            // 
            this.yazilimYapimiDataSet3.DataSetName = "YazilimYapimiDataSet3";
            this.yazilimYapimiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKullaniciListle
            // 
            this.btnKullaniciListle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKullaniciListle.Location = new System.Drawing.Point(12, 342);
            this.btnKullaniciListle.Name = "btnKullaniciListle";
            this.btnKullaniciListle.Size = new System.Drawing.Size(160, 60);
            this.btnKullaniciListle.TabIndex = 2;
            this.btnKullaniciListle.Text = "Listele";
            this.btnKullaniciListle.UseVisualStyleBackColor = false;
            this.btnKullaniciListle.Click += new System.EventHandler(this.btnKullaniciListle_Click);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKullaniciSil.Location = new System.Drawing.Point(612, 342);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(160, 60);
            this.btnKullaniciSil.TabIndex = 3;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = false;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // tbl_KullaniciTableAdapter
            // 
            this.tbl_KullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdminKullaniciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(787, 429);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.btnKullaniciListle);
            this.Controls.Add(this.dataGridViewKullaniciSil);
            this.Controls.Add(this.btnAnaMenu);
            this.Name = "frmAdminKullaniciSil";
            this.Text = "Kullanıcı Silme";
            this.Load += new System.EventHandler(this.frmAdminKullaniciSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullaniciSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DataGridView dataGridViewKullaniciSil;
        private System.Windows.Forms.Button btnKullaniciListle;
        private System.Windows.Forms.Button btnKullaniciSil;
        private YazilimYapimiDataSet3 yazilimYapimiDataSet3;
        private System.Windows.Forms.BindingSource tblKullaniciBindingSource;
        private YazilimYapimiDataSet3TableAdapters.Tbl_KullaniciTableAdapter tbl_KullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTipiIDDataGridViewTextBoxColumn;
    }
}