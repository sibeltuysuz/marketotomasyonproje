namespace MarketOtomasyon.Forms
{
    partial class FormUrunler
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.nSatisFiyati = new System.Windows.Forms.NumericUpDown();
            this.nAlisFiyati = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nStok = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.cmbFirmaAdi = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstUrunler = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSatisFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlisFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(516, 235);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 53);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(633, 235);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 53);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(395, 235);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 53);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUrunKodu);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.nSatisFiyati);
            this.groupBox1.Controls.Add(this.nAlisFiyati);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nStok);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pbResim);
            this.groupBox1.Controls.Add(this.cmbFirmaAdi);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(806, 326);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Ürün Kodu";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(113, 73);
            this.txtUrunKodu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(227, 22);
            this.txtUrunKodu.TabIndex = 59;
            // 
            // nSatisFiyati
            // 
            this.nSatisFiyati.Location = new System.Drawing.Point(113, 150);
            this.nSatisFiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nSatisFiyati.Name = "nSatisFiyati";
            this.nSatisFiyati.Size = new System.Drawing.Size(228, 22);
            this.nSatisFiyati.TabIndex = 58;
            // 
            // nAlisFiyati
            // 
            this.nAlisFiyati.Location = new System.Drawing.Point(113, 111);
            this.nAlisFiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nAlisFiyati.Name = "nAlisFiyati";
            this.nAlisFiyati.Size = new System.Drawing.Size(228, 22);
            this.nAlisFiyati.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Alış Fiyatı";
            // 
            // nStok
            // 
            this.nStok.Location = new System.Drawing.Point(113, 278);
            this.nStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nStok.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nStok.Name = "nStok";
            this.nStok.Size = new System.Drawing.Size(228, 22);
            this.nStok.TabIndex = 53;
            this.nStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Resim";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(516, 73);
            this.pbResim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(228, 118);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 51;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // cmbFirmaAdi
            // 
            this.cmbFirmaAdi.FormattingEnabled = true;
            this.cmbFirmaAdi.Location = new System.Drawing.Point(113, 235);
            this.cmbFirmaAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFirmaAdi.Name = "cmbFirmaAdi";
            this.cmbFirmaAdi.Size = new System.Drawing.Size(227, 24);
            this.cmbFirmaAdi.TabIndex = 47;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(113, 194);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(227, 24);
            this.cmbKategori.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Firma Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(113, 39);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(227, 22);
            this.txtUrunAdi.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ürün Adı";
            // 
            // lstUrunler
            // 
            this.lstUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lstUrunler.FullRowSelect = true;
            this.lstUrunler.GridLines = true;
            this.lstUrunler.Location = new System.Drawing.Point(16, 358);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(806, 305);
            this.lstUrunler.TabIndex = 46;
            this.lstUrunler.UseCompatibleStateImageBehavior = false;
            this.lstUrunler.View = System.Windows.Forms.View.Details;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ürün Id";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ürün Adı";
            this.columnHeader9.Width = 124;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ürün Kodu";
            this.columnHeader10.Width = 115;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Firma Adı";
            this.columnHeader11.Width = 101;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Alış Fiyatı";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Satış Fiyatı";
            this.columnHeader13.Width = 131;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Kategori";
            this.columnHeader14.Width = 396;
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 664);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUrunler";
            this.Text = "FormUrunler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSatisFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlisFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nSatisFiyati;
        private System.Windows.Forms.NumericUpDown nAlisFiyati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nStok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.ComboBox cmbFirmaAdi;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrunKodu;
    }
}