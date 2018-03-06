using MarketOtomasyon.ViewModels;
using System;
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
    public partial class FormSiparisler : Form
    {
        public FormSiparisler()
        {
            InitializeComponent();
        }

        private void FormSiparisler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
        void VerileriGetir()
        {
            supermarketEntities db = new supermarketEntities();
            lstCustomer.DataSource = db.Customers.OrderBy(x => x.CustomerName).ToList();
            lstCustomer.DisplayMember = "CustomerName";
            lstCustomer.ValueMember = "CustomerId";
        }

        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItems == null || lstOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bir şey seçmediniz");
                return;
            }
            try
            {
                var siparisId = int.Parse(lstOrders.SelectedItems[0].Text);
                supermarketEntities db = new supermarketEntities();
                var sonuc = db.OrderDetails.Where(x => x.OrderId == siparisId).ToList();
                List<ListViewItem> viewItemList = new List<ListViewItem>();
                sonuc.ForEach(x =>
                {
                    ListViewItem viewItem = new ListViewItem(x.Product.ProductName);
                    viewItem.SubItems.Add($"{x.SalesPrice:c2}");
                    viewItem.SubItems.Add($"{x.Quantity}");
                    //viewItem.SubItems.Add($"% {/*x.Discount **/ 100}");
                    viewItemList.Add(viewItem);
                });

                FormMusteriSiparisDetay musteriSiparisDetay = new FormMusteriSiparisDetay(viewItemList);
                musteriSiparisDetay.Text = $"{siparisId} nolu siparişin detayı";
                musteriSiparisDetay.StartPosition = FormStartPosition.CenterParent;
                musteriSiparisDetay.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedItem == null) return;

            var seciliMusteri = lstCustomer.SelectedItem as Customer;
            try
            {
                supermarketEntities db = new supermarketEntities();

                var sonuc = db.Orders
                    .Where(x => x.CustomerId == seciliMusteri.CustomerId)
                    .OrderByDescending(x => x.OrderDate)
                    .Select(x => new SiparisViewModel()
                    {
                        IstenenTarih = x.RequiredDate,
                        KargoFirmasi = x.CargoCompany,
                        KargoTutari = x.Freight ?? 0,
                        SiparisNo = x.OrderId,
                        SiparisTarihi = x.OrderDate,
                        Ulke = x.Address,
                        ToplamSiparisTutari = 0
                    })
                    .ToList();
                lstOrders.Items.Clear();
                sonuc.ForEach(x =>
                {
                    x.ToplamSiparisTutari = db.OrderDetails
                    .Where(y => y.OrderId == x.SiparisNo)
                    .Sum(y => y.SalesPrice * y.Quantity);
                    ListViewItem viewItem = new ListViewItem(x.SiparisNo.ToString());
                    viewItem.SubItems.Add($"{x.SiparisTarihi:dd MMMM yyyy}");
                    viewItem.SubItems.Add($"{x.IstenenTarih:dd MMMM yyyy}");
                    viewItem.SubItems.Add(x.Ulke);
                    viewItem.SubItems.Add($"{x.KargoTutari:c2}");
                    viewItem.SubItems.Add($"{x.ToplamSiparisTutari:c2}");
                    viewItem.SubItems.Add(x.KargoFirmasi);
                    lstOrders.Items.Add(viewItem);
                }
                );
                lstOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş bulunamadı");
                MessageBox.Show(ex.Message);
            }
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void cmsSiparisDetay_Opening(object sender, CancelEventArgs e)
        {

        }

        private void detayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

