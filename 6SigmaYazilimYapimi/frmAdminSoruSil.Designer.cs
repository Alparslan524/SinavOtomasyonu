
namespace _6SigmaYazilimYapimi
{
    partial class frmAdminSoruSil
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
            this.dataGridViewSoruSil = new System.Windows.Forms.DataGridView();
            this.soruIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruResimYoluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSorularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimYapimiDataSet2 = new _6SigmaYazilimYapimi.YazilimYapimiDataSet2();
            this.btnSoruSil = new System.Windows.Forms.Button();
            this.tbl_SorularTableAdapter = new _6SigmaYazilimYapimi.YazilimYapimiDataSet2TableAdapters.tbl_SorularTableAdapter();
            this.btnKullaniciListle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoruSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSorularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(312, 342);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(160, 60);
            this.btnAnaMenu.TabIndex = 1;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // dataGridViewSoruSil
            // 
            this.dataGridViewSoruSil.AllowUserToAddRows = false;
            this.dataGridViewSoruSil.AutoGenerateColumns = false;
            this.dataGridViewSoruSil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSoruSil.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewSoruSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoruSil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soruIDDataGridViewTextBoxColumn,
            this.dogruDataGridViewTextBoxColumn,
            this.uniteIDDataGridViewTextBoxColumn,
            this.konuIDDataGridViewTextBoxColumn,
            this.soruResimYoluDataGridViewTextBoxColumn});
            this.dataGridViewSoruSil.DataSource = this.tblSorularBindingSource;
            this.dataGridViewSoruSil.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSoruSil.Name = "dataGridViewSoruSil";
            this.dataGridViewSoruSil.Size = new System.Drawing.Size(761, 310);
            this.dataGridViewSoruSil.TabIndex = 2;
            // 
            // soruIDDataGridViewTextBoxColumn
            // 
            this.soruIDDataGridViewTextBoxColumn.DataPropertyName = "SoruID";
            this.soruIDDataGridViewTextBoxColumn.HeaderText = "SoruID";
            this.soruIDDataGridViewTextBoxColumn.Name = "soruIDDataGridViewTextBoxColumn";
            this.soruIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogruDataGridViewTextBoxColumn
            // 
            this.dogruDataGridViewTextBoxColumn.DataPropertyName = "Dogru";
            this.dogruDataGridViewTextBoxColumn.HeaderText = "Dogru";
            this.dogruDataGridViewTextBoxColumn.Name = "dogruDataGridViewTextBoxColumn";
            // 
            // uniteIDDataGridViewTextBoxColumn
            // 
            this.uniteIDDataGridViewTextBoxColumn.DataPropertyName = "UniteID";
            this.uniteIDDataGridViewTextBoxColumn.HeaderText = "UniteID";
            this.uniteIDDataGridViewTextBoxColumn.Name = "uniteIDDataGridViewTextBoxColumn";
            // 
            // konuIDDataGridViewTextBoxColumn
            // 
            this.konuIDDataGridViewTextBoxColumn.DataPropertyName = "KonuID";
            this.konuIDDataGridViewTextBoxColumn.HeaderText = "KonuID";
            this.konuIDDataGridViewTextBoxColumn.Name = "konuIDDataGridViewTextBoxColumn";
            // 
            // soruResimYoluDataGridViewTextBoxColumn
            // 
            this.soruResimYoluDataGridViewTextBoxColumn.DataPropertyName = "SoruResimYolu";
            this.soruResimYoluDataGridViewTextBoxColumn.HeaderText = "SoruResimYolu";
            this.soruResimYoluDataGridViewTextBoxColumn.Name = "soruResimYoluDataGridViewTextBoxColumn";
            // 
            // tblSorularBindingSource
            // 
            this.tblSorularBindingSource.DataMember = "tbl_Sorular";
            this.tblSorularBindingSource.DataSource = this.yazilimYapimiDataSet2;
            // 
            // yazilimYapimiDataSet2
            // 
            this.yazilimYapimiDataSet2.DataSetName = "YazilimYapimiDataSet2";
            this.yazilimYapimiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSoruSil
            // 
            this.btnSoruSil.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSoruSil.Location = new System.Drawing.Point(612, 342);
            this.btnSoruSil.Name = "btnSoruSil";
            this.btnSoruSil.Size = new System.Drawing.Size(160, 60);
            this.btnSoruSil.TabIndex = 5;
            this.btnSoruSil.Text = "Sil";
            this.btnSoruSil.UseVisualStyleBackColor = false;
            this.btnSoruSil.Click += new System.EventHandler(this.btnSoruSil_Click);
            // 
            // tbl_SorularTableAdapter
            // 
            this.tbl_SorularTableAdapter.ClearBeforeFill = true;
            // 
            // btnKullaniciListle
            // 
            this.btnKullaniciListle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKullaniciListle.Location = new System.Drawing.Point(12, 342);
            this.btnKullaniciListle.Name = "btnKullaniciListle";
            this.btnKullaniciListle.Size = new System.Drawing.Size(160, 60);
            this.btnKullaniciListle.TabIndex = 6;
            this.btnKullaniciListle.Text = "Listele";
            this.btnKullaniciListle.UseVisualStyleBackColor = false;
            this.btnKullaniciListle.Click += new System.EventHandler(this.btnKullaniciListle_Click);
            // 
            // frmAdminSoruSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(787, 429);
            this.Controls.Add(this.btnKullaniciListle);
            this.Controls.Add(this.btnSoruSil);
            this.Controls.Add(this.dataGridViewSoruSil);
            this.Controls.Add(this.btnAnaMenu);
            this.Name = "frmAdminSoruSil";
            this.Text = "Soru Silme";
            this.Load += new System.EventHandler(this.frmAdminSoruSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoruSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSorularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DataGridView dataGridViewSoruSil;
        private System.Windows.Forms.Button btnSoruSil;
        private YazilimYapimiDataSet2 yazilimYapimiDataSet2;
        private System.Windows.Forms.BindingSource tblSorularBindingSource;
        private YazilimYapimiDataSet2TableAdapters.tbl_SorularTableAdapter tbl_SorularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruResimYoluDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKullaniciListle;
    }
}