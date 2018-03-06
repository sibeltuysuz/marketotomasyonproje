namespace MarketOtomasyon.Dialogs
{
    partial class DialogAdetGuncelle
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
            this.btnTamam = new System.Windows.Forms.Button();
            this.nDeger = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nDeger)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(39, 40);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(161, 26);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // nDeger
            // 
            this.nDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nDeger.Location = new System.Drawing.Point(39, 12);
            this.nDeger.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nDeger.Name = "nDeger";
            this.nDeger.Size = new System.Drawing.Size(161, 22);
            this.nDeger.TabIndex = 2;
            this.nDeger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DialogAdetGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 80);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.nDeger);
            this.Name = "DialogAdetGuncelle";
            this.Text = "DialogAdetGuncelle";
            this.Load += new System.EventHandler(this.DialogAdetGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nDeger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.NumericUpDown nDeger;
    }
}