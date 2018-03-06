namespace MarketOtomasyon.Forms
{
    partial class FormSatis
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
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.nKdv = new System.Windows.Forms.NumericUpDown();
            this.nToplam = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.sepet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.txtOdeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pbBarkod = new System.Windows.Forms.PictureBox();
            this.btnBarkod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nUlasUcret = new System.Windows.Forms.NumericUpDown();
            this.nIndirim = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).BeginInit();
            this.sepet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUlasUcret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOlustur.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSiparisOlustur.Location = new System.Drawing.Point(595, 286);
            this.btnSiparisOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(333, 134);
            this.btnSiparisOlustur.TabIndex = 52;
            this.btnSiparisOlustur.Text = "Siparişi Tamamla";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(156, 28);
            this.cmbMusteri.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(219, 24);
            this.cmbMusteri.TabIndex = 47;
            this.cmbMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteri_SelectedIndexChanged);
            // 
            // nKdv
            // 
            this.nKdv.DecimalPlaces = 2;
            this.nKdv.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nKdv.Location = new System.Drawing.Point(131, 514);
            this.nKdv.Margin = new System.Windows.Forms.Padding(4);
            this.nKdv.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKdv.Name = "nKdv";
            this.nKdv.ReadOnly = true;
            this.nKdv.Size = new System.Drawing.Size(148, 34);
            this.nKdv.TabIndex = 46;
            this.nKdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nToplam
            // 
            this.nToplam.DecimalPlaces = 2;
            this.nToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nToplam.Location = new System.Drawing.Point(131, 472);
            this.nToplam.Margin = new System.Windows.Forms.Padding(4);
            this.nToplam.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nToplam.Name = "nToplam";
            this.nToplam.ReadOnly = true;
            this.nToplam.Size = new System.Drawing.Size(148, 27);
            this.nToplam.TabIndex = 45;
            this.nToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nToplam.ValueChanged += new System.EventHandler(this.nToplam_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(56, 522);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "KDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 474);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tutar(kdv hariç)";
            // 
            // lstSepet
            // 
            this.lstSepet.ContextMenuStrip = this.sepet;
            this.lstSepet.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 20;
            this.lstSepet.Location = new System.Drawing.Point(338, 189);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(4);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(235, 264);
            this.lstSepet.TabIndex = 42;
            this.lstSepet.SelectedIndexChanged += new System.EventHandler(this.lstSepet_SelectedIndexChanged);
            // 
            // sepet
            // 
            this.sepet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sepet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arttırToolStripMenuItem,
            this.azaltToolStripMenuItem,
            this.çıkartToolStripMenuItem});
            this.sepet.Name = "sepet";
            this.sepet.Size = new System.Drawing.Size(117, 76);
            // 
            // arttırToolStripMenuItem
            // 
            this.arttırToolStripMenuItem.Name = "arttırToolStripMenuItem";
            this.arttırToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.arttırToolStripMenuItem.Text = "Arttır";
            // 
            // azaltToolStripMenuItem
            // 
            this.azaltToolStripMenuItem.Name = "azaltToolStripMenuItem";
            this.azaltToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.azaltToolStripMenuItem.Text = "Azalt";
            // 
            // çıkartToolStripMenuItem
            // 
            this.çıkartToolStripMenuItem.Name = "çıkartToolStripMenuItem";
            this.çıkartToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.çıkartToolStripMenuItem.Text = "Çıkart";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(205, 311);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(135, 38);
            this.btnSepeteEkle.TabIndex = 40;
            this.btnSepeteEkle.Text = "Sepete Ekle >>";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(156, 79);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(219, 22);
            this.txtAra.TabIndex = 38;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.ItemHeight = 16;
            this.lstUrun.Location = new System.Drawing.Point(4, 186);
            this.lstUrun.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(202, 260);
            this.lstUrun.TabIndex = 39;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParaUstu);
            this.groupBox1.Controls.Add(this.txtOdeme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbKrediKarti);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(581, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(347, 222);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Şekli";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Location = new System.Drawing.Point(164, 115);
            this.txtParaUstu.Margin = new System.Windows.Forms.Padding(4);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.Size = new System.Drawing.Size(160, 22);
            this.txtParaUstu.TabIndex = 7;
            this.txtParaUstu.TextChanged += new System.EventHandler(this.txtParaUstu_TextChanged);
            // 
            // txtOdeme
            // 
            this.txtOdeme.Location = new System.Drawing.Point(164, 65);
            this.txtOdeme.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdeme.Name = "txtOdeme";
            this.txtOdeme.Size = new System.Drawing.Size(160, 22);
            this.txtOdeme.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Para Üstü:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ödeme:";
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(0, 152);
            this.rbKrediKarti.Margin = new System.Windows.Forms.Padding(4);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(95, 21);
            this.rbKrediKarti.TabIndex = 3;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.rbKrediKarti_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 40);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nakit";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pbBarkod
            // 
            this.pbBarkod.Location = new System.Drawing.Point(156, 127);
            this.pbBarkod.Margin = new System.Windows.Forms.Padding(4);
            this.pbBarkod.Name = "pbBarkod";
            this.pbBarkod.Size = new System.Drawing.Size(219, 51);
            this.pbBarkod.TabIndex = 55;
            this.pbBarkod.TabStop = false;
            this.pbBarkod.Click += new System.EventHandler(this.pbBarkod_Click);
            // 
            // btnBarkod
            // 
            this.btnBarkod.Location = new System.Drawing.Point(33, 139);
            this.btnBarkod.Margin = new System.Windows.Forms.Padding(4);
            this.btnBarkod.Name = "btnBarkod";
            this.btnBarkod.Size = new System.Drawing.Size(99, 27);
            this.btnBarkod.TabIndex = 57;
            this.btnBarkod.Text = "Barkod";
            this.btnBarkod.UseVisualStyleBackColor = true;
            this.btnBarkod.Click += new System.EventHandler(this.btnBarkod_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(301, 483);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Kargo ücreti";
            // 
            // nUlasUcret
            // 
            this.nUlasUcret.DecimalPlaces = 3;
            this.nUlasUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nUlasUcret.Location = new System.Drawing.Point(409, 476);
            this.nUlasUcret.Margin = new System.Windows.Forms.Padding(4);
            this.nUlasUcret.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nUlasUcret.Name = "nUlasUcret";
            this.nUlasUcret.Size = new System.Drawing.Size(129, 27);
            this.nUlasUcret.TabIndex = 59;
            this.nUlasUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUlasUcret.Value = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.nUlasUcret.ValueChanged += new System.EventHandler(this.nUlasUcret_ValueChanged);
            // 
            // nIndirim
            // 
            this.nIndirim.DecimalPlaces = 3;
            this.nIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nIndirim.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nIndirim.Location = new System.Drawing.Point(409, 525);
            this.nIndirim.Margin = new System.Windows.Forms.Padding(4);
            this.nIndirim.Name = "nIndirim";
            this.nIndirim.Size = new System.Drawing.Size(129, 27);
            this.nIndirim.TabIndex = 58;
            this.nIndirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nIndirim.Value = new decimal(new int[] {
            5000,
            0,
            0,
            196608});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(316, 525);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "İndirim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, -22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Müşteri:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Ürün kodunu girin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 590);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 65;
            this.label3.Text = "Toplam Satış tutarı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(315, 590);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 29);
            this.label11.TabIndex = 66;
            this.label11.Text = "                         ";
            // 
            // FormSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 639);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nUlasUcret);
            this.Controls.Add(this.nIndirim);
            this.Controls.Add(this.btnBarkod);
            this.Controls.Add(this.pbBarkod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.nKdv);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.nToplam);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSatis";
            this.Text = "FormSatis";
            this.Load += new System.EventHandler(this.FormSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).EndInit();
            this.sepet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUlasUcret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.NumericUpDown nKdv;
        private System.Windows.Forms.NumericUpDown nToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.TextBox txtOdeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pbBarkod;
        private System.Windows.Forms.Button btnBarkod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUlasUcret;
        private System.Windows.Forms.NumericUpDown nIndirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip sepet;
        private System.Windows.Forms.ToolStripMenuItem arttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkartToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
    }
}