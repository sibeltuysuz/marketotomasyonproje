using MarketOtomasyon.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarketOtomasyon.Forms
{
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
            this.Text = "Ürün Yönetimi";
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            VerileriGetir();

        }

        private void VerileriGetir()
        {
            try
            {
                supermarketEntities db = new supermarketEntities();

                cmbKategori.DataSource = db.Categories.ToList();
                cmbKategori.DisplayMember = "CategoryName";
                cmbKategori.ValueMember = "CategoryId";
                                
                cmbFirmaAdi.DataSource = db.Suppliers.ToList();
                cmbFirmaAdi.DisplayMember = "CompanyName";
                cmbFirmaAdi.ValueMember = "CompanyId";

                var urunler = db.Products
                    .Select(x => new UrunViewModel()
                    {
                        UrunId = x.ProductId,
                        UrunAdi = x.ProductName,
                        Barkod = x.Barcode,
                        TedarikciFirma = x.Supplier.CompanyName,
                        AlisFiyati = x.UnitPrice ?? 0,
                        SatisFiyati = x.SalesPrice ?? 0,
                        Kategori = x.Category.CategoryName,
                        Stok = x.Stock ?? 0
                    }).ToList();
                lstUrunler.Items.Clear();

                urunler.ForEach(x =>
                {
                    ListViewItem viewItem = new ListViewItem(x.UrunId.ToString());
                    viewItem.SubItems.Add(x.UrunAdi);
                    viewItem.SubItems.Add(x.Barkod);
                    viewItem.SubItems.Add(x.TedarikciFirma);
                    viewItem.SubItems.Add($"{x.AlisFiyati:c2}");
                    
                    viewItem.SubItems.Add(x.Kategori);
                    viewItem.SubItems.Add(x.Stok.ToString());

                    lstUrunler.Items.Add(viewItem);
                });
                                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                supermarketEntities db = new supermarketEntities();
                var seciliKategori = cmbKategori.SelectedItem as Category;
                var seciliTedarikci = cmbFirmaAdi.SelectedItem as Supplier;

                if (seciliKategori == null || seciliTedarikci == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }
                Product yeniurun = new Product
                {
                    ProductName = txtUrunAdi.Text,
                    Barcode = txtUrunKodu.Text,
                    CompanyId = seciliTedarikci.CompanyId,
                    UnitPrice = nAlisFiyati.Value,
                    SalesPrice = nSatisFiyati.Value,
                    CategoryId = seciliKategori.CategoryId,
                    Stock = Convert.ToInt32(nStok.Value),
                    ProductImage = resimDosyası

                };
                db.Products.Add(yeniurun);
                db.SaveChanges();
                MessageBox.Show($"{yeniurun.ProductName} ürünü başarıyla eklendi");
                VerileriGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        byte[] resimDosyası;
        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog
            {
                Title = "Bir resim dosyası seçiniz",
                Multiselect = false,
                Filter = "JPG formatlı (*.jpg)|*.jpg;*.jpg;|PNG Formatlı | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            DialogResult result = dosyaAc.ShowDialog();
            MemoryStream memoryStream = new MemoryStream();
            var buffer = new byte[64];
            if (result == DialogResult.OK)
            {
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(buffer, 0, 64) != 0)
                {
                    memoryStream.Write(buffer, 0, 64);
                }
                resimDosyası = memoryStream.ToArray();
                pbResim.Image = new Bitmap(memoryStream);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItems == null) return;
                supermarketEntities db = new supermarketEntities();
            int seciliUrun = int.Parse(lstUrunler.SelectedItems[0].Text);
            var sonuc = db.Products.Where(x => x.ProductId == seciliUrun).FirstOrDefault();
            db.Products.Remove(sonuc);
            db.SaveChanges();
            VerileriGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstUrunler.SelectedItems == null) return;
                supermarketEntities db = new supermarketEntities();
                int seciliUrun = int.Parse(lstUrunler.SelectedItems[0].Text);
                var sonuc = db.Products.Where(x => x.ProductId == seciliUrun).ToList();

                sonuc.ForEach(x =>
                {
                    x.ProductName = txtUrunAdi.Text;
                    x.Barcode = txtUrunKodu.Text;
                    x.Supplier.CompanyName = cmbFirmaAdi.Text;
                    x.UnitPrice = nAlisFiyati.Value;
                    x.SalesPrice = nSatisFiyati.Value;
                    x.Category.CategoryName = cmbKategori.Text;
                    x.Stock = Convert.ToInt32(nStok.Value);
                    x.ProductImage = resimDosyası;

                });

                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItems == null) return;
            if (lstUrunler.SelectedItems.Count > 0)
            {
                supermarketEntities db = new supermarketEntities();
                int seciliurun = int.Parse(lstUrunler.SelectedItems[0].Text);
                var sonuc = db.Products.Where(x => x.ProductId == seciliurun).ToList();
                sonuc.ForEach(x =>
                {
                    txtUrunAdi.Text = x.ProductName;
                    txtUrunKodu.Text = x.Barcode;
                    cmbFirmaAdi.Text = x.Supplier.CompanyName;
                    nAlisFiyati.Value = Convert.ToDecimal(x.UnitPrice);
                    nSatisFiyati.Value = Convert.ToDecimal(x.SalesPrice);
                    cmbKategori.Text = x.Category.CategoryName;
                    nStok.Value = Convert.ToDecimal(x.Stock);
                    ///pbResim.Image = new Bitmap(new MemoryStream(x.ProductImage));
                    if (x.ProductImage != null)
                    {
                        try
                        {
                            pbResim.Image = new Bitmap(new MemoryStream(x.ProductImage));
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                        pbResim.Image = null;
                });

            }
        }
    }
}
