namespace MarketOtomasyon.Forms
{
    partial class FormSiparisler
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
            this.lstOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSiparisDetay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.cmsSiparisDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.lstOrders.ContextMenuStrip = this.cmsSiparisDetay;
            this.lstOrders.FullRowSelect = true;
            this.lstOrders.GridLines = true;
            this.lstOrders.HoverSelection = true;
            this.lstOrders.Location = new System.Drawing.Point(347, 16);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrders.MultiSelect = false;
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(825, 435);
            this.lstOrders.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstOrders.TabIndex = 15;
            this.lstOrders.UseCompatibleStateImageBehavior = false;
            this.lstOrders.View = System.Windows.Forms.View.Details;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sipariş No";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sipariş Tarihi";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İstenen Tarih";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ülke";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kargo Tutarı";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Toplam Sipariş Tutarı";
            this.columnHeader6.Width = 120;
            // 
            // cmsSiparisDetay
            // 
            this.cmsSiparisDetay.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSiparisDetay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayToolStripMenuItem});
            this.cmsSiparisDetay.Name = "cmsSiparisDetay";
            this.cmsSiparisDetay.Size = new System.Drawing.Size(176, 56);
            this.cmsSiparisDetay.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSiparisDetay_Opening);
            // 
            // detayToolStripMenuItem
            // 
            this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
            this.detayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.detayToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.detayToolStripMenuItem.Text = "Detay";
            this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click_1);
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 16;
            this.lstCustomer.Location = new System.Drawing.Point(16, 15);
            this.lstCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(321, 436);
            this.lstCustomer.TabIndex = 14;
            this.lstCustomer.SelectedIndexChanged += new System.EventHandler(this.lstCustomer_SelectedIndexChanged_1);
            // 
            // FormSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 464);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.lstCustomer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSiparisler";
            this.Text = "FormSiparisler";
            this.Load += new System.EventHandler(this.FormSiparisler_Load);
            this.cmsSiparisDetay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.ContextMenuStrip cmsSiparisDetay;
        private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
    }
}