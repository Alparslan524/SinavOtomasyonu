
namespace _6SigmaYazilimYapimi
{
    partial class frmSinavModul
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
            this.pictureBoxSinavModul = new System.Windows.Forms.PictureBox();
            this.btnSonrakiSoru = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblUnite = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.btnSoruKaydet = new System.Windows.Forms.Button();
            this.groupBoxSiklar = new System.Windows.Forms.GroupBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.lblKullaniciad = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSinavModul)).BeginInit();
            this.groupBoxSiklar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxSinavModul
            // 
            this.pictureBoxSinavModul.Location = new System.Drawing.Point(263, 12);
            this.pictureBoxSinavModul.Name = "pictureBoxSinavModul";
            this.pictureBoxSinavModul.Size = new System.Drawing.Size(939, 449);
            this.pictureBoxSinavModul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSinavModul.TabIndex = 0;
            this.pictureBoxSinavModul.TabStop = false;
            // 
            // btnSonrakiSoru
            // 
            this.btnSonrakiSoru.BackColor = System.Drawing.Color.DarkGray;
            this.btnSonrakiSoru.Location = new System.Drawing.Point(263, 484);
            this.btnSonrakiSoru.Name = "btnSonrakiSoru";
            this.btnSonrakiSoru.Size = new System.Drawing.Size(292, 60);
            this.btnSonrakiSoru.TabIndex = 6;
            this.btnSonrakiSoru.Text = "Başlat";
            this.btnSonrakiSoru.UseVisualStyleBackColor = false;
            this.btnSonrakiSoru.Click += new System.EventHandler(this.btnSinavBasla_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(12, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 20);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Ünite: ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(12, 96);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(50, 20);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Konu:";
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnite.Location = new System.Drawing.Point(12, 57);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(73, 20);
            this.lblUnite.TabIndex = 9;
            this.lblUnite.Text = "                ";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonu.Location = new System.Drawing.Point(12, 135);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(65, 20);
            this.lblKonu.TabIndex = 10;
            this.lblKonu.Text = "              ";
            // 
            // btnSoruKaydet
            // 
            this.btnSoruKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnSoruKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruKaydet.Location = new System.Drawing.Point(503, 17);
            this.btnSoruKaydet.Name = "btnSoruKaydet";
            this.btnSoruKaydet.Size = new System.Drawing.Size(130, 60);
            this.btnSoruKaydet.TabIndex = 13;
            this.btnSoruKaydet.Text = "Soruyu Kaydet";
            this.btnSoruKaydet.UseVisualStyleBackColor = false;
            this.btnSoruKaydet.Click += new System.EventHandler(this.btnSoruKaydet_Click_1);
            // 
            // groupBoxSiklar
            // 
            this.groupBoxSiklar.Controls.Add(this.radioButtonD);
            this.groupBoxSiklar.Controls.Add(this.radioButtonC);
            this.groupBoxSiklar.Controls.Add(this.radioButtonB);
            this.groupBoxSiklar.Controls.Add(this.radioButtonA);
            this.groupBoxSiklar.Controls.Add(this.btnSoruKaydet);
            this.groupBoxSiklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxSiklar.Location = new System.Drawing.Point(561, 467);
            this.groupBoxSiklar.Name = "groupBoxSiklar";
            this.groupBoxSiklar.Size = new System.Drawing.Size(641, 84);
            this.groupBoxSiklar.TabIndex = 14;
            this.groupBoxSiklar.TabStop = false;
            this.groupBoxSiklar.Text = "Şıklar";
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(390, 39);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(39, 24);
            this.radioButtonD.TabIndex = 17;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(278, 39);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(38, 24);
            this.radioButtonC.TabIndex = 16;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(166, 39);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(38, 24);
            this.radioButtonB.TabIndex = 15;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(54, 39);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(38, 24);
            this.radioButtonA.TabIndex = 14;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // lblKullaniciad
            // 
            this.lblKullaniciad.AutoSize = true;
            this.lblKullaniciad.Location = new System.Drawing.Point(1272, 448);
            this.lblKullaniciad.Name = "lblKullaniciad";
            this.lblKullaniciad.Size = new System.Drawing.Size(0, 13);
            this.lblKullaniciad.TabIndex = 17;
            this.lblKullaniciad.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(55, 493);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(32, 31);
            this.lblDakika.TabIndex = 18;
            this.lblDakika.Text = "--";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(123, 493);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(32, 31);
            this.lblSaniye.TabIndex = 18;
            this.lblSaniye.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Süre";
            // 
            // frmSinavModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1214, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblKullaniciad);
            this.Controls.Add(this.groupBoxSiklar);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.lblUnite);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSonrakiSoru);
            this.Controls.Add(this.pictureBoxSinavModul);
            this.Name = "frmSinavModul";
            this.Text = "Sınav Modul";
            this.Load += new System.EventHandler(this.frmSinavModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSinavModul)).EndInit();
            this.groupBoxSiklar.ResumeLayout(false);
            this.groupBoxSiklar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSoruKaydet;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        public System.Windows.Forms.Label lblKullaniciad;
        public System.Windows.Forms.PictureBox pictureBoxSinavModul;
        public System.Windows.Forms.Button btnSonrakiSoru;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.Label lblUnite;
        public System.Windows.Forms.Label lblKonu;
        public System.Windows.Forms.GroupBox groupBoxSiklar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}