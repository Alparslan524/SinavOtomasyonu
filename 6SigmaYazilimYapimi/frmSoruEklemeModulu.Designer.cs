
namespace _6SigmaYazilimYapimi
{
    partial class frmSoruEklemeModulu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUnite = new System.Windows.Forms.ComboBox();
            this.txtResimYol = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxSoruEkleme = new System.Windows.Forms.PictureBox();
            this.comboBoxKonu = new System.Windows.Forms.ComboBox();
            this.comboBoxDogruSik = new System.Windows.Forms.ComboBox();
            this.btnResimYolu = new System.Windows.Forms.Button();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridViewSoruekleme = new System.Windows.Forms.DataGridView();
            this.uniteAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruResimYoluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vievSorularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazilimYapimiDataSet1 = new _6SigmaYazilimYapimi.YazilimYapimiDataSet1();
            this.vievSorularTableAdapter = new _6SigmaYazilimYapimi.YazilimYapimiDataSet1TableAdapters.VievSorularTableAdapter();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoruEkleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoruekleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vievSorularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğru Şık:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resim Yolu:";
            // 
            // comboBoxUnite
            // 
            this.comboBoxUnite.FormattingEnabled = true;
            this.comboBoxUnite.Items.AddRange(new object[] {
            "Mevsimler ve İklim",
            "DNA ve Genetik Kod",
            "Basınç",
            "Madde ve Endüstri",
            "Basit Makineler",
            "Enerji Dönüşümleri ve Çevre Bilimi",
            "Elektrik Yükleri ve Elektrik Enerjisi"});
            this.comboBoxUnite.Location = new System.Drawing.Point(111, 201);
            this.comboBoxUnite.Name = "comboBoxUnite";
            this.comboBoxUnite.Size = new System.Drawing.Size(189, 21);
            this.comboBoxUnite.TabIndex = 4;
            this.comboBoxUnite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtResimYol
            // 
            this.txtResimYol.Location = new System.Drawing.Point(111, 387);
            this.txtResimYol.Name = "txtResimYol";
            this.txtResimYol.Size = new System.Drawing.Size(156, 20);
            this.txtResimYol.TabIndex = 5;
            this.txtResimYol.TextChanged += new System.EventHandler(this.txtResimYol_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxSoruEkleme
            // 
            this.pictureBoxSoruEkleme.Location = new System.Drawing.Point(423, 199);
            this.pictureBoxSoruEkleme.Name = "pictureBoxSoruEkleme";
            this.pictureBoxSoruEkleme.Size = new System.Drawing.Size(568, 289);
            this.pictureBoxSoruEkleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSoruEkleme.TabIndex = 6;
            this.pictureBoxSoruEkleme.TabStop = false;
            // 
            // comboBoxKonu
            // 
            this.comboBoxKonu.FormattingEnabled = true;
            this.comboBoxKonu.Items.AddRange(new object[] {
            "Mevsimlerin Oluşumu",
            "İklim ve Hava Hareketleri",
            "DNA ve Genetik Kod",
            "Kalıtım",
            "Mutasyon ve Modifikasyon",
            "Adaptasyon",
            "Biyoteknoloji",
            "Basınç",
            "Periyotik Sistem",
            "Fiziksel ve Kimyasal Değişimler",
            "Soygazlar",
            "Asitler ve Bazlar",
            "Maddenin Isı ve Etkilişimi",
            "Türkiye\'de Kimya Endistrisi",
            "Basit Makineler",
            "Enerji Dönüşümleri",
            "Madde Döngüleri ve Çevre Sorunları",
            "Sürdürülebilir Kalkınma",
            "Elektrik Yükleri ve Elektriklenme",
            "Elektrik Yüklü Cisimler",
            "Elektrik Enerjisinin Dönüşümü"});
            this.comboBoxKonu.Location = new System.Drawing.Point(111, 263);
            this.comboBoxKonu.Name = "comboBoxKonu";
            this.comboBoxKonu.Size = new System.Drawing.Size(189, 21);
            this.comboBoxKonu.TabIndex = 7;
            // 
            // comboBoxDogruSik
            // 
            this.comboBoxDogruSik.FormattingEnabled = true;
            this.comboBoxDogruSik.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxDogruSik.Location = new System.Drawing.Point(111, 323);
            this.comboBoxDogruSik.Name = "comboBoxDogruSik";
            this.comboBoxDogruSik.Size = new System.Drawing.Size(189, 21);
            this.comboBoxDogruSik.TabIndex = 8;
            // 
            // btnResimYolu
            // 
            this.btnResimYolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimYolu.Location = new System.Drawing.Point(273, 387);
            this.btnResimYolu.Name = "btnResimYolu";
            this.btnResimYolu.Size = new System.Drawing.Size(27, 21);
            this.btnResimYolu.TabIndex = 9;
            this.btnResimYolu.Text = "...";
            this.btnResimYolu.UseVisualStyleBackColor = true;
            this.btnResimYolu.Click += new System.EventHandler(this.btnResimYolu_Click);
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSoruEkle.Location = new System.Drawing.Point(111, 423);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(189, 30);
            this.btnSoruEkle.TabIndex = 10;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = false;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListele.Location = new System.Drawing.Point(111, 458);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(189, 30);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Soruları Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridViewSoruekleme
            // 
            this.dataGridViewSoruekleme.AllowUserToAddRows = false;
            this.dataGridViewSoruekleme.AutoGenerateColumns = false;
            this.dataGridViewSoruekleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSoruekleme.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewSoruekleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoruekleme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniteAdiDataGridViewTextBoxColumn,
            this.konuAdiDataGridViewTextBoxColumn,
            this.dogruDataGridViewTextBoxColumn,
            this.soruResimYoluDataGridViewTextBoxColumn});
            this.dataGridViewSoruekleme.DataSource = this.vievSorularBindingSource;
            this.dataGridViewSoruekleme.Location = new System.Drawing.Point(8, 12);
            this.dataGridViewSoruekleme.Name = "dataGridViewSoruekleme";
            this.dataGridViewSoruekleme.Size = new System.Drawing.Size(1066, 143);
            this.dataGridViewSoruekleme.TabIndex = 12;
            // 
            // uniteAdiDataGridViewTextBoxColumn
            // 
            this.uniteAdiDataGridViewTextBoxColumn.DataPropertyName = "UniteAdi";
            this.uniteAdiDataGridViewTextBoxColumn.HeaderText = "UniteAdi";
            this.uniteAdiDataGridViewTextBoxColumn.Name = "uniteAdiDataGridViewTextBoxColumn";
            // 
            // konuAdiDataGridViewTextBoxColumn
            // 
            this.konuAdiDataGridViewTextBoxColumn.DataPropertyName = "KonuAdi";
            this.konuAdiDataGridViewTextBoxColumn.HeaderText = "KonuAdi";
            this.konuAdiDataGridViewTextBoxColumn.Name = "konuAdiDataGridViewTextBoxColumn";
            // 
            // dogruDataGridViewTextBoxColumn
            // 
            this.dogruDataGridViewTextBoxColumn.DataPropertyName = "Dogru";
            this.dogruDataGridViewTextBoxColumn.HeaderText = "Dogru";
            this.dogruDataGridViewTextBoxColumn.Name = "dogruDataGridViewTextBoxColumn";
            // 
            // soruResimYoluDataGridViewTextBoxColumn
            // 
            this.soruResimYoluDataGridViewTextBoxColumn.DataPropertyName = "SoruResimYolu";
            this.soruResimYoluDataGridViewTextBoxColumn.HeaderText = "SoruResimYolu";
            this.soruResimYoluDataGridViewTextBoxColumn.Name = "soruResimYoluDataGridViewTextBoxColumn";
            // 
            // vievSorularBindingSource
            // 
            this.vievSorularBindingSource.DataMember = "VievSorular";
            this.vievSorularBindingSource.DataSource = this.yazilimYapimiDataSet1;
            // 
            // yazilimYapimiDataSet1
            // 
            this.yazilimYapimiDataSet1.DataSetName = "YazilimYapimiDataSet1";
            this.yazilimYapimiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vievSorularTableAdapter
            // 
            this.vievSorularTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(567, 494);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(270, 60);
            this.btnAnaMenu.TabIndex = 13;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // frmSoruEklemeModulu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1083, 559);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.dataGridViewSoruekleme);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.btnResimYolu);
            this.Controls.Add(this.comboBoxDogruSik);
            this.Controls.Add(this.comboBoxKonu);
            this.Controls.Add(this.pictureBoxSoruEkleme);
            this.Controls.Add(this.txtResimYol);
            this.Controls.Add(this.comboBoxUnite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSoruEklemeModulu";
            this.Text = "Soru Ekleme";
            this.Load += new System.EventHandler(this.frmSoruEklemeModulu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoruEkleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoruekleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vievSorularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazilimYapimiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxUnite;
        private System.Windows.Forms.TextBox txtResimYol;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxSoruEkleme;
        private System.Windows.Forms.ComboBox comboBoxKonu;
        private System.Windows.Forms.ComboBox comboBoxDogruSik;
        private System.Windows.Forms.Button btnResimYolu;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridViewSoruekleme;
        private YazilimYapimiDataSet1 yazilimYapimiDataSet1;
        private System.Windows.Forms.BindingSource vievSorularBindingSource;
        private YazilimYapimiDataSet1TableAdapters.VievSorularTableAdapter vievSorularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruResimYoluDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}