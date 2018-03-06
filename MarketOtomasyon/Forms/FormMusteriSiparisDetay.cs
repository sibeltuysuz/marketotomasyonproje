﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyon.Forms
{
    public partial class FormMusteriSiparisDetay : Form
    {
        public FormMusteriSiparisDetay(List<ListViewItem> viewItems)
        {
            InitializeComponent();
            this.ViewItems = viewItems;
            foreach (var item in viewItems)
            {
                lstDetay.Items.Add(item);
            }
            lstDetay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public List<ListViewItem> ViewItems { get; set; }

        private void FormMusteriSiparisDetay_Load(object sender, EventArgs e)
        {

        }

        private void lstDetay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
