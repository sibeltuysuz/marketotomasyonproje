using MarketOtomasyon.Dialogs;
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
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
            this.Text = "Satış Yönetimi";



            arttırToolStripMenuItem.Click += SepetYonetimi;
            azaltToolStripMenuItem.Click += SepetYonetimi;
            çıkartToolStripMenuItem.Click += SepetYonetimi;
            //adetiGüncelleToolStripMenuItem.Click += SepetYonetimi;
        }


        private void SepetYonetimi(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;
            var seciliUrun = lstSepet.SelectedItem as SepetViewModel;

            var menuItem = sender as ToolStripMenuItem;
            if (menuItem.Name == "azaltToolStripMenuItem")
            {
                if (seciliUrun.Quantity >= 2)
                    seciliUrun.Quantity--;
                else if (seciliUrun.Quantity == 1)
                    sepetList.Remove(seciliUrun);
            }
            else if (menuItem.Name == "arttırToolStripMenuItem")
            {
                var urun = urunList.Where(x => x.UrunId == seciliUrun.ProductID).FirstOrDefault();
                if (!StokKontrol(urun))
                {
                    MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                    return;
                }
                seciliUrun.Quantity++;
            }

            else if (menuItem.Name == "çıkartToolStripMenuItem")
                sepetList.Remove(seciliUrun);
            else if (menuItem.Name == "adetiGüncelleToolStripMenuItem")
            {
                DialogAdetGuncelle dialogAdetGuncelle = new DialogAdetGuncelle();
                dialogAdetGuncelle.nDeger.Value = seciliUrun.Quantity;
                dialogAdetGuncelle.StartPosition = FormStartPosition.CenterParent;
                dialogAdetGuncelle.ShowDialog();
                short deger = Convert.ToInt16(dialogAdetGuncelle.nDeger.Value);
                if (deger > 0)
                {
                    var urun = urunList.Where(x => x.UrunId == seciliUrun.ProductID).FirstOrDefault();
                    if (!StokKontrol(urun, deger))
                    {
                        MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                        return;
                    }
                    seciliUrun.Quantity = deger;
                }
                else
                    sepetList.Remove(seciliUrun);
            }
            SepetGuncelle();
        }

        List<UrunViewModel> urunList = new List<UrunViewModel>();
        List<SepetViewModel> sepetList = new List<SepetViewModel>();
        private decimal satisfiyat;

        private void FormSatis_Load(object sender, EventArgs e)
        {
            VerileriGetir();
                                    
            try
            {
                supermarketEntities db = new supermarketEntities();
                              
                cmbMusteri.DataSource = db.Customers.ToList();
                                
                cmbMusteri.DisplayMember = "CompanyName";
                cmbMusteri.ValueMember = "CustomerName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message);
            }
                                    
        }
        void VerileriGetir(string arama = "")
        {

            try
            {
                var ara = arama.ToLower();
                supermarketEntities db = new supermarketEntities();
                var sonuc = from prod in db.Products
                            where (prod.Barcode.Contains(ara))
                            orderby prod.Barcode ascending
                            select new UrunViewModel
                            {
                                UrunId = prod.ProductId,
                                UrunAdi = prod.ProductName,
                                SatisFiyati = prod.SalesPrice ?? 0,
                                Stok = prod.Stock,
                                Kategori = prod.Category.CategoryName
                            };
                lstUrun.DataSource = sonuc.ToList();
                urunList = sonuc.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message);
            }
        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            if (sepetList.Count == 0)
            {
                MessageBox.Show("Önce Sepete Ürün Eklemelisiniz");
                return;
            }

            var musteri = cmbMusteri.SelectedItem as Customer;
            //var kargo = cmbKargo.SelectedItem as Shipper;
            string mesaj = $" siparişi onaylıyor musunuz?\nMüşteri: {musteri.CustomerName}";
            label11.Text = satisfiyat.ToString() + " TL";

            var cevap = MessageBox.Show(mesaj, "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            supermarketEntities db = new supermarketEntities();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var yeniSiparis = new Order()
                    {
                        
                        CustomerId = musteri.CustomerId,
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now.AddDays(7),
                        Freight = nUlasUcret.Value,
                    };
                    db.Orders.Add(yeniSiparis);
                    db.SaveChanges();

                    foreach (var item in sepetList)
                    {
                        var siparisDetay = new OrderDetail()
                        {
                            OrderId = yeniSiparis.OrderId,
                            ProductId = item.ProductID,
                            SalesPrice = item.SalesPrice,
                            Quantity = item.Quantity,
                            //Discount = item.Discount,

                        };
                        //if (item.ProductID == 2) // bilerek hata verdirmek istiyoruz rollbacki görmek için
                        //    throw new Exception("Manuel hata");
                        db.OrderDetails.Add(siparisDetay);

                        var urun = db.Products.Find(item.ProductID);
                        urun.Stock -= item.Quantity;
                    }
                    db.SaveChanges();

                    tran.Commit();
                    decimal toplam = 0, kdv = 0;
                    toplam = sepetList.Sum(x => x.Total);
                    if (rbKrediKarti.Checked)
                    {
                        toplam = nToplam.Value;
                        MessageBox.Show("ödeme türü :kredi \n ücret  kartınızdan  çekildi" + satisfiyat + " TL");
                    }

                    else if (radioButton1.Checked)
                    {
                        toplam = nToplam.Value;
                        decimal nakit = Convert.ToDecimal(txtOdeme.Text);
                        decimal paraUstu = 0.0m;
                        paraUstu = nakit - satisfiyat;
                        txtParaUstu.Text = paraUstu.ToString();
                        MessageBox.Show("ödeme türü:nakit  \n paraüstünüz:" + paraUstu);
                    }
                    MessageBox.Show($"{yeniSiparis.OrderId}'nolu siparişiniz tarafımıza ulaşmıştır");
                    Temizle();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Sipariş Oluşturma işleminde hata oluştu.\n" + ex.Message);
                }
                label11.Text = "";
            }
           


        }
        void Temizle()
        {
            sepetList = new List<SepetViewModel>();
            lstSepet.Items.Clear();
            VerileriGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //textbox’a girdiğimiz textimizin barcode’unu picturebox’ta gösteriyoruz.
            if (txtAra.Text=="")
            {
                return;
            }
            pbBarkod.Image = barcode.Draw(txtAra.Text, 50);

            VerileriGetir(txtAra.Text);
            

        }

        bool StokKontrol(UrunViewModel seciliUrun, short adet = 1)
        {
            bool varmi = false, cevap = false;
            sepetList.ForEach(x =>
            {
                if (x.ProductID == seciliUrun.UrunId)
                {
                    varmi = true;
                    if (adet == 1)
                    {
                        if (seciliUrun.Stok > x.Quantity)
                            cevap = true;
                        else
                            cevap = false;
                    }
                    else if (adet > 1)
                    {
                        if (seciliUrun.Stok >= adet)
                            cevap = true;
                        else
                            cevap = false;
                    }

                }
            });

            if (!varmi)
            {
                if (seciliUrun.Stok > 0)
                    cevap = true;
                else
                    cevap = false;
            }
            return cevap;
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {

            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as UrunViewModel;
            bool kontrol = StokKontrol(seciliUrun);
            if (!kontrol)
            {
                MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                return;
            }
            bool varmi = false;
            sepetList.ForEach(x =>
            {
                if (x.ProductID == seciliUrun.UrunId)
                {
                    varmi = true;
                    x.Quantity++;
                }
            });

            if (!varmi)
            {
                var model = new SepetViewModel()
                {
                    ProductID = seciliUrun.UrunId,
                    Discount = float.Parse(nIndirim.Value.ToString()),
                    ProductName = seciliUrun.UrunAdi,
                    SalesPrice = seciliUrun.SatisFiyati ?? 0
                };
                sepetList.Add(model);
            }
            SepetGuncelle();
        }

        void SepetGuncelle()
        {
            lstSepet.Items.Clear();
            sepetList.ForEach(x => lstSepet.Items.Add(x));
            SepetHesapla();
        }

        void SepetHesapla()
        {
            decimal toplam = 0, kdv = 0;
            toplam = sepetList.Sum(x => x.Total);
            kdv = toplam * 0.18m;
            nToplam.Value = toplam;
            nKdv.Value = kdv;
            decimal kargo = nUlasUcret.Value;
            decimal indirim = 0;
            if (toplam >= 100)
            {
                indirim = nIndirim.Value;

                nIndirim.Value = 20m;

                decimal satisfiyat = toplam + kdv + kargo - indirim;
            }
            else  satisfiyat = toplam + kdv + kargo;

            //if (toplam >= 50)
            //{
            //    nIndirim.Value = 5;

                //    toplam = toplam - 5;
                //}



        }
        void Odeme()
        {
            if (radioButton1.Checked)
            {
                decimal toplam = nToplam.Value;
                decimal nakit = Convert.ToDecimal(txtOdeme.Text);
                decimal paraUstu = 0.0m;
                paraUstu = nakit - satisfiyat;
            }
        }



        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nToplam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBarkod_Click(object sender, EventArgs e)
        {
            //Framewokümüzü kullanarak borcode oluşturmasını istiyoruz
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //textbox’a girdiğimiz textimizin barcode’unu picturebox’ta gösteriyoruz.
            pbBarkod.Image = barcode.Draw(txtAra.Text, 50);
        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;
            var seciliUrun = lstSepet.SelectedItem as UrunViewModel;
            bool kontrol = StokKontrol(seciliUrun);
            if (!kontrol)
            {
                MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                return;
            }
            bool varmi = false;
            sepetList.ForEach(x =>
            {
                if (x.ProductID == seciliUrun.UrunId)
                {
                    varmi = true;
                    x.Quantity--;
                }
            });
            SepetGuncelle();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtOdeme.Visible = true;
                txtParaUstu.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
            }
            else
            {
                txtOdeme.Visible = false;
                txtParaUstu.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                rbKrediKarti.Visible = true;
            }

        }

        private void rbKrediKarti_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKrediKarti.Checked)
            {
                txtOdeme.Visible = false;
                txtParaUstu.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
            }

        }

        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbBarkod_Click(object sender, EventArgs e)
        {
            
        }

        private void nUlasUcret_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtParaUstu_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
