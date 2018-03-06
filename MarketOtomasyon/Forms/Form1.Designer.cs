namespace MarketOtomasyon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSatisYonetim = new System.Windows.Forms.Button();
            this.btnSiparisYonetim = new System.Windows.Forms.Button();
            this.btnStokYonetim = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunYonetimi
            // 
            this.btnUrunYonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunYonetimi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunYonetimi.ImageIndex = 11;
            this.btnUrunYonetimi.ImageList = this.ımageList1;
            this.btnUrunYonetimi.Location = new System.Drawing.Point(79, 29);
            this.btnUrunYonetimi.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunYonetimi.Name = "btnUrunYonetimi";
            this.btnUrunYonetimi.Size = new System.Drawing.Size(548, 89);
            this.btnUrunYonetimi.TabIndex = 0;
            this.btnUrunYonetimi.Text = "Ürün Yönetimi";
            this.btnUrunYonetimi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunYonetimi.UseVisualStyleBackColor = true;
            this.btnUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "satis.png");
            this.ımageList1.Images.SetKeyName(1, "cikis.png");
            this.ımageList1.Images.SetKeyName(2, "raporicon.ico");
            this.ımageList1.Images.SetKeyName(3, "raporico.ico");
            this.ımageList1.Images.SetKeyName(4, "urunicon.png");
            this.ımageList1.Images.SetKeyName(5, "siparico.png");
            this.ımageList1.Images.SetKeyName(6, "stokicon.png");
            this.ımageList1.Images.SetKeyName(7, "satis_ikon.png");
            this.ımageList1.Images.SetKeyName(8, "indir (1).jpg");
            this.ımageList1.Images.SetKeyName(9, "images.png");
            this.ımageList1.Images.SetKeyName(10, "images.png");
            this.ımageList1.Images.SetKeyName(11, "114-512.png");
            this.ımageList1.Images.SetKeyName(12, "Storehouse_depot_wealth_warehouse_treasury.png");
            // 
            // btnSatisYonetim
            // 
            this.btnSatisYonetim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSatisYonetim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSatisYonetim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisYonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYonetim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisYonetim.ImageIndex = 7;
            this.btnSatisYonetim.ImageList = this.ımageList1;
            this.btnSatisYonetim.Location = new System.Drawing.Point(79, 278);
            this.btnSatisYonetim.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatisYonetim.Name = "btnSatisYonetim";
            this.btnSatisYonetim.Size = new System.Drawing.Size(548, 103);
            this.btnSatisYonetim.TabIndex = 1;
            this.btnSatisYonetim.Text = "Satışlar";
            this.btnSatisYonetim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisYonetim.UseVisualStyleBackColor = false;
            this.btnSatisYonetim.Click += new System.EventHandler(this.btnSatisYonetim_Click);
            // 
            // btnSiparisYonetim
            // 
            this.btnSiparisYonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisYonetim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSiparisYonetim.ImageIndex = 8;
            this.btnSiparisYonetim.ImageList = this.ımageList1;
            this.btnSiparisYonetim.Location = new System.Drawing.Point(79, 149);
            this.btnSiparisYonetim.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisYonetim.Name = "btnSiparisYonetim";
            this.btnSiparisYonetim.Size = new System.Drawing.Size(548, 101);
            this.btnSiparisYonetim.TabIndex = 2;
            this.btnSiparisYonetim.Text = "Sipariş Yönetimi";
            this.btnSiparisYonetim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSiparisYonetim.UseVisualStyleBackColor = true;
            this.btnSiparisYonetim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStokYonetim
            // 
            this.btnStokYonetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokYonetim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStokYonetim.ImageIndex = 12;
            this.btnStokYonetim.ImageList = this.ımageList1;
            this.btnStokYonetim.Location = new System.Drawing.Point(79, 413);
            this.btnStokYonetim.Margin = new System.Windows.Forms.Padding(4);
            this.btnStokYonetim.Name = "btnStokYonetim";
            this.btnStokYonetim.Size = new System.Drawing.Size(548, 97);
            this.btnStokYonetim.TabIndex = 3;
            this.btnStokYonetim.Text = "Stok Yönetimi";
            this.btnStokYonetim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStokYonetim.UseVisualStyleBackColor = true;
            this.btnStokYonetim.Click += new System.EventHandler(this.btnStokYonetim_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRaporlar.ImageIndex = 10;
            this.btnRaporlar.ImageList = this.ımageList1;
            this.btnRaporlar.Location = new System.Drawing.Point(79, 532);
            this.btnRaporlar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(548, 99);
            this.btnRaporlar.TabIndex = 4;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRaporlar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 758);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnStokYonetim);
            this.Controls.Add(this.btnSiparisYonetim);
            this.Controls.Add(this.btnSatisYonetim);
            this.Controls.Add(this.btnUrunYonetimi);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunYonetimi;
        private System.Windows.Forms.Button btnSiparisYonetim;
        private System.Windows.Forms.Button btnStokYonetim;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSatisYonetim;
    }
}

