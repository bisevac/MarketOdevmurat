using MarketOdev.DAL;
using MarketOdev.Entities;
using MarketOdev.ViewModel;
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

namespace MarketOdev.Forms
{
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            lstUrunView.GridLines = true;
            lstUrunView.FullRowSelect = true;
            VerileriGetir();
            
        }

        private void VerileriGetir()
        {

            //
            //try
            //{
            //    MyContext db = new MyContext();
            //    cmbKategori.DataSource = db.Kategoriler.ToList();
            //    cmbKategori.DisplayMember = "KategoriAdi";
            //    cmbKategori.ValueMember = "KategoriId";

            //    lstUrun.DataSource = db.Urunler.OrderBy(x => x.UrunAdi).ToList();
            //    // lstUrun.DisplayMember = "UrunAdi";
            //    // lstUrun.ValueMember = "UrunId";
            //    pictureBox1.Image = null;

            //    this.Text += $" Toplam Ürün Sayısı: {db.Urunler.Count()} - {DateTime.Now:dd MMMM yy dddd}";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            lstUrunView.Items.Clear();
            try
            {
                
                MyContext db = new MyContext();
                pictureBox1.Image = null;

                  this.Text += $" Toplam Ürün Sayısı: {db.Urunler.Count()} - {DateTime.Now:dd MMMM yy dddd}";
                
                  cmbKategori.DataSource = db.Kategoriler.ToList();
                  cmbKategori.DisplayMember = "KategoriAdi";
                  cmbKategori.ValueMember = "KategoriId";

                foreach (var item in db.Urunler.ToList())
                {
                    ListViewItem urun = new ListViewItem(item.UrunId.ToString());
                    urun.SubItems.Add(item.UrunAdi);
                    urun.SubItems.Add(item.stok.ToString());
                    urun.SubItems.Add(item.EklenmeZamani.ToString());
                    lstUrunView.Items.Add(urun);
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        byte[] resim;
        string resimPath;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Kategorisiz Ekleme Yapılamaz");
                return;
                    
            }
            long Id;
            bool a = long.TryParse(txtBarkod.Text, out Id);
            if (!a)
            {
                MessageBox.Show("Id sadece sayılardan oluşabilir");
                return;
            }
            if (resimPath!=null && resimPath!="")
            {
                //Resimimizi FileStream metoduyla okuma modunda açıyoruz.
                FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
                //BinaryReader ile byte dizisi ile FileStream arasında veri akışı sağlanıyor.
                BinaryReader br = new BinaryReader(fs);
                /*ReadBytes ile FileStreamde belirtilen resim dosyasındaki byte lar
                byte dizisine aktarılıyor.
                */
                resim = br.ReadBytes((int)fs.Length);
            }
       

            Urun urun = new Urun()
            {
                BarkodNumarasi = long.Parse(txtBarkod.Text),
                UrunAdi = txtUrunAdi.Text,
                Resim = resim??null,
                KategoriId =int.Parse(cmbKategori.SelectedValue.ToString()),
                SatisFiyat =  nSatisFiyat.Value,
                AlisFiyati=nAlisFiyat.Value               
            };

            try
            {
                MyContext db = new MyContext();
                db.Urunler.Add(urun);
                db.SaveChanges();
                VerileriGetir();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            temizle();
        }

        private void temizle()
        {
            txtUrunAdi.Text = string.Empty;
            txtResim.Text= string.Empty;
            cmbKategori.SelectedValue = 0;
            nSatisFiyat.Value = 0;
            nAlisFiyat.Value = 0;
            txtBarkod.Text = "";

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            {
                //Resim dosyalarımızı openFileDialog nesnesi ile açacağız.
                openFileDialog1.Title = "Resim Aç";
                openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                    txtResim.Text = openFileDialog1.FileName.ToString();
                    resimPath = openFileDialog1.FileName.ToString();
                }

            }
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;

            var seciliUrun = lstUrun.SelectedItem as Urun;
            txtUrunAdi.Text = seciliUrun.UrunAdi;          
            nAlisFiyat.Value = seciliUrun.AlisFiyati;
            nSatisFiyat.Value = seciliUrun.SatisFiyat;
            cmbKategori.SelectedValue = seciliUrun.KategoriId;
            txtBarkod.Text = seciliUrun.BarkodNumarasi.ToString();

            byte[] emptyArray = new byte[0];
            if (seciliUrun.Resim != null)
            {
                var ms = new MemoryStream(seciliUrun.Resim ?? emptyArray);
                var ResimGoster = Image.FromStream(ms);
                pictureBox1.Image = ResimGoster;
            }
            else
            {
                pictureBox1.Image = null;
            }





        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //if (lstUrun.SelectedItem == null)
            //{
            //    return;

            //}
            if (cmbKategori.SelectedValue == null)
            {
                MessageBox.Show("Kategorisiz Guncelleme Yapılamaz");
                return;
            }


            if (lstUrunView.SelectedItems.Count == 0 || lstUrunView.SelectedItems[0] == null) return;
            MyContext db = new MyContext();
            var a = int.Parse(lstUrunView.SelectedItems[0].Text);
            var seciliUrun = db.Urunler.Find(a) as Urun;

            seciliUrun = db.Urunler.Find(seciliUrun.UrunId);

            seciliUrun.AlisFiyati = nAlisFiyat.Value;
            seciliUrun.SatisFiyat = nSatisFiyat.Value;
            seciliUrun.UrunAdi = txtUrunAdi.Text;
            seciliUrun.KategoriId = int.Parse(cmbKategori.SelectedValue.ToString());
            seciliUrun.BarkodNumarasi = long.Parse(txtBarkod.Text);
            if (txtResim.Text == string.Empty)
            {
                resim = seciliUrun.Resim;
            }
            else
            {
                //Resimimizi FileStream metoduyla okuma modunda açıyoruz.
                FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
                //BinaryReader ile byte dizisi ile FileStream arasında veri akışı sağlanıyor.
                BinaryReader br = new BinaryReader(fs);
                /*ReadBytes ile FileStreamde belirtilen resim dosyasındaki byte lar
                byte dizisine aktarılıyor.
                */
                resim = br.ReadBytes((int)fs.Length);
            }
            seciliUrun.Resim = resim;
            db.SaveChanges();
            
            VerileriGetir();

            temizle();


        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstUrunView.Items.Clear();
            try
            {
                MyContext db = new MyContext();
                string arama = txtAra.Text.ToLower();
                foreach (var item in db.Urunler.Where(x=>x.UrunAdi.Contains(arama)).ToList())
                {
                    ListViewItem urun = new ListViewItem(item.UrunId.ToString());
                    urun.SubItems.Add(item.UrunAdi);
                    urun.SubItems.Add(item.stok.ToString());
                    urun.SubItems.Add(item.EklenmeZamani.ToString());
                    lstUrunView.Items.Add(urun);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    MyContext db = new MyContext();
            //    string arama = txtAra.Text.ToLower();
            //    lstUrun.DataSource = db.Urunler.Where(x => x.UrunAdi.ToLower().Contains(arama)).OrderBy(x => x.UrunAdi).ToList();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
         
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunView.SelectedItems.Count == 0 || lstUrunView.SelectedItems[0] == null) return;
            MyContext db = new MyContext();
            var a = int.Parse(lstUrunView.SelectedItems[0].Text);
            var seciliUrun = db.Urunler.Find(a) as Urun;

            seciliUrun = db.Urunler.Find(seciliUrun.UrunId);
            db.Urunler.Remove(seciliUrun);
            db.SaveChanges();
            VerileriGetir();
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarkod.Text.Count() == 13)
                {
                    BarcodeLib.Barcode b = new BarcodeLib.Barcode();
                    BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
                    type = BarcodeLib.TYPE.EAN13;


                    pctBarkod.Image = b.Encode(type, txtBarkod.Text, 170, 50);
                }
                else
                {
                    pctBarkod.Image = null;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstUrunView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunView.SelectedItems.Count==0 || lstUrunView.SelectedItems[0] == null) return;
            MyContext db = new MyContext();
            var a = int.Parse(lstUrunView.SelectedItems[0].Text);
            var seciliUrun = db.Urunler.Find(a) as Urun;
            txtUrunAdi.Text = seciliUrun.UrunAdi;
            nAlisFiyat.Value = seciliUrun.AlisFiyati;
            nSatisFiyat.Value = seciliUrun.SatisFiyat;
            cmbKategori.SelectedValue = seciliUrun.KategoriId;
            txtBarkod.Text = seciliUrun.BarkodNumarasi.ToString();

            byte[] emptyArray = new byte[0];
            if (seciliUrun.Resim != null)
            {
                var ms = new MemoryStream(seciliUrun.Resim ?? emptyArray);
                var ResimGoster = Image.FromStream(ms);
                pictureBox1.Image = ResimGoster;
            }
            else
            {
                pictureBox1.Image = null;
            }

        }
    }
}
