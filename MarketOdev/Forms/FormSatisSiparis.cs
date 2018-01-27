using MarketOdev.DAL;
using MarketOdev.Entities;
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
using WMPLib;

namespace MarketOdev.Forms
{
    public partial class FormSatisSiparis : Form
    {
        public FormSatisSiparis()
        {
            InitializeComponent();
        }

        private void FormSatisSiparis_Load(object sender, EventArgs e)
        {
            
            MyContext db =new MyContext();
            comboBox1.DisplayMember = "KategoriAdi";
            comboBox1.ValueMember = "KategoriId";
            comboBox1.DataSource = db.Kategoriler.ToList();
          
            

            VerileriGetir();
            chbBütünKategori.Checked = true;
            txtBarkod.Text = "";
            
        }
        private void VerileriGetir(string arama = "")
        {
            try
            {
                var ara = arama.ToLower();
                MyContext db = new MyContext();
                if (chbBütünKategori.Checked)
                {
                    lstUrun.DataSource = db.Urunler.Where(x => x.UrunAdi.ToLower().Contains(ara)).ToList();
                    lstUrun.DisplayMember = "UrunAdi";
                    lstUrun.ValueMember = "BarkodNumarasi";
                    return;
                }                    
                if (comboBox1.SelectedItem != null)
                {
                    lstUrun.DataSource = db.Urunler.Where(x => x.UrunAdi.ToLower().Contains(ara) && x.KategoriId ==(int)(comboBox1.SelectedValue)).ToList();
                }
                else
                {
                    lstUrun.DataSource = db.Urunler.Where(x => x.UrunAdi.ToLower().Contains(ara)).ToList();
                }
                lstUrun.DisplayMember = "UrunAdi";
                lstUrun.ValueMember = "BarkodNumarasi";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message);
            }

        }
        List<SepetView_Model> sepetList = new List<SepetView_Model>();
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Urun;
            bool kontrol = StokKontrol(seciliUrun);
            if (!kontrol)
            {
               MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
            return;
            }
            bool varmi = false;
            sepetList.ForEach(x =>
            {
                if (x.UrunId == seciliUrun.UrunId)
                {
                    varmi = true;
                    x.Adet += (short)nAdet.Value;
                }
            });
            if (!varmi)
            {
                var model = new SepetView_Model()
                {
                    UrunId = seciliUrun.UrunId,
                    Indirim = nIndirim.Value,
                    UrunAdi = seciliUrun.UrunAdi,
                    fiyat = seciliUrun.SatisFiyat,
                    KdvOrani = seciliUrun.Kategori.KdvOrani ?? 0,
                    BarkodId = seciliUrun.BarkodNumarasi,
                    Adet = (short)nAdet.Value
                };
                sepetList.Add(model);
            }
            SepetGuncelle();
        }

        private void SepetGuncelle()
        {

            //lstSepet.Items.Clear();
            //sepetList.ForEach(x => lstSepet.Items.Add(x));
            //SepetHesapla();
            lstViewSepet.Items.Clear();
            foreach(var item in sepetList)
                {
                ListViewItem urun = new ListViewItem(item.UrunAdi.ToString());
                urun.SubItems.Add(item.Adet.ToString());
                urun.SubItems.Add(item.fiyat.ToString());
                urun.SubItems.Add((item.fiyat*item.Adet).ToString());
                lstViewSepet.Items.Add(urun);
            }

            SepetHesapla();

        }
        private void SepetHesapla()
        {
            decimal toplam = 0, kdv = 0;
            toplam = sepetList.Sum(x => x.Total);
            kdv = sepetList.Sum(x => x.kdvHesapla);
            nToplam.Value = toplam;
            nKdv.Value = kdv;

        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var secilenUrun = lstUrun.SelectedItem as Urun;
            if (secilenUrun==null)
            {
                //MessageBox.Show("Böyle Bir ürün Kayıtlı Değildir");
                return;
            }
            byte[] emptyArray = new byte[0];
            if (secilenUrun.Resim != null)
            {
                var ms = new MemoryStream(secilenUrun.Resim ?? emptyArray);
                var ResimGoster = Image.FromStream(ms);
                pictureBox1.Image = ResimGoster;
            }
            else
            {
                pictureBox1.Image = null;
            }
            txtBarkod.Text = secilenUrun.BarkodNumarasi.ToString();
            labelFiyat.Text = $"Fiyatı = {secilenUrun.SatisFiyat}";
            labelStok.Text = $"Stok = {secilenUrun.stok}";

        }

        OdemeForm FormOdeme;
        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {


            if (sepetList.Count == 0)
            {
                MessageBox.Show("Önce Sepete Ürün Eklemelisiniz");
                return;
            }

            FormOdeme = new OdemeForm();

            FormOdeme.Text = "Ödeme";
            decimal toplamf = nKdv.Value + nToplam.Value;

            FormOdeme.lbltoplamtl.Text = $"{toplamf:c2}";
            FormOdeme.lbltoplamGösterilmeyen.Text = toplamf.ToString();
            DialogResult result=FormOdeme.ShowDialog();
            bool nakit = false;
            if (FormOdeme.RadioNakit.Checked)
            {
                nakit = true;
            }


             if (result==DialogResult.Cancel || result!=DialogResult.Yes)
            {
                return;
            }
            
          

            //string mesaj = $"{ nToplam.Value + nKdv.Value:c2} tutarındaki siparişi onaylıyor musunuz?\n";



            //var cevap = MessageBox.Show(mesaj, "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (cevap != DialogResult.Yes) return;

            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var yeniSiparis = new Siparis()
                    {
                        AlinanMi = false,
                        Nakit=nakit                        
                    };
                    db.Siparisler.Add(yeniSiparis);
                    db.SaveChanges();

                    foreach (var item in sepetList)
                    {
                        var siparisDetay = new SiparisDetay()
                        {
                            SiparisId = yeniSiparis.SiparisId,
                            UrunId = item.UrunId,
                            Fiyat = item.fiyat,
                            Adet = item.Adet,
                            Indirim = item.Indirim                                  
                        };

                        db.SiparisDetaylar.Add(siparisDetay);
                        var urun = db.Urunler.Find(item.UrunId);
                        urun.stok -= item.Adet;
                    }
                    db.SaveChanges();

                    tran.Commit();
                    MessageBox.Show($"{yeniSiparis.SiparisId}'nolu siparişiniz tarafımıza ulaşmıştır");
                    Temizle();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Sipariş Oluşturma işleminde hata oluştu.\n" + ex.Message);
                }
            }
        }

        private void Temizle()
        {
            sepetList.Clear();

            sepetList = new List<SepetView_Model>();         
            VerileriGetir();
        }

        bool StokKontrol(Urun seciliUrun, short adet = 1)
        {
            bool varmi = false, cevap = false;
            sepetList.ForEach(x =>
            {
                if (x.UrunId == seciliUrun.UrunId)
                {
                    varmi = true;
                    if (adet == 1)
                    {
                        if (seciliUrun.stok > x.Adet)
                            cevap = true;
                        else
                            cevap = false;
                    }
                    else if (adet > 1)
                    {
                        if (seciliUrun.stok >= adet)
                            cevap = true;
                        else
                            cevap = false;
                    }

                }
            });

            if (!varmi)
            {
                if (seciliUrun.stok > 0)
                    cevap = true;
                else
                    cevap = false;
            }
            return cevap;
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarkod.Text.Count() == 13)
                {
                    BarcodeLib.Barcode b = new BarcodeLib.Barcode();
                    BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
                    type = BarcodeLib.TYPE.EAN13;


                    pctBarkod.Image = b.Encode(type, txtBarkod.Text, 220, 65);
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
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Enter)
            {
                MyContext db = new MyContext();
                long barkod;
                if (!long.TryParse(txtBarkod.Text,out barkod))
                {
                    MessageBox.Show("Barkod Numarası Geçerli Aralıkt Değildir");
                }

                //lstUrun.SelectedValue = long.Parse(txtBarkod.Text);
                lstUrun.SelectedValue = barkod;
                if (lstUrun.SelectedItem == null)
                {
                    txtBarkod.Text = "";
                    MessageBox.Show("Böyle Bir Ürün Yoktur Önce Ürünü Kayıt Yaptırınız");
                    return;
                   
                }
                var seciliUrun = lstUrun.SelectedItem as Urun;
                bool kontrol = StokKontrol(seciliUrun);
                if (!kontrol)
                {
                    MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
                    return;
                }
                bool varmi = false;
                sepetList.ForEach(x =>
                {
                    if (x.UrunId == seciliUrun.UrunId)
                    {
                        varmi = true;
                        x.Adet += (short)nAdet.Value;
                    }
                });
                if (!varmi)
                {
                    var model = new SepetView_Model()
                    {
                        UrunId = seciliUrun.UrunId,
                        Indirim = nIndirim.Value,
                        UrunAdi = seciliUrun.UrunAdi,
                        fiyat = seciliUrun.SatisFiyat,
                        KdvOrani = seciliUrun.Kategori.KdvOrani ?? 0,
                        BarkodId = seciliUrun.BarkodNumarasi,
                        Adet = (short)nAdet.Value
                    };
                    sepetList.Add(model);
                }
                SepetGuncelle();
                txtBarkod.Text = "";

                wmp.URL = "C:\\Users\\Bireysel\\Desktop\\Sesler\\Bleep-SoundBible.com-1927126940.mp3";
                wmp.controls.play();
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            VerileriGetir(txtAra.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void chbBütünKategori_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBütünKategori.Checked)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;         
            }
            VerileriGetir();
        }

        private void cıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstViewSepet.SelectedItems.Count == 0 || lstViewSepet.SelectedItems[0] == null) return;
            MyContext db = new MyContext();
            string urunadi =lstViewSepet.SelectedItems[0].Text;
           var secilisepeturun = sepetList.Where(x => x.UrunAdi == urunadi).First() as SepetView_Model;
        
            //var secilisepeturun = lstSepet.SelectedItem as SepetView_Model;
            sepetList.Remove(secilisepeturun);
            SepetGuncelle();
            SepetHesapla();

        }

        private void adetDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void pctBarkod_Click(object sender, EventArgs e)
        {

        }
    }
}
