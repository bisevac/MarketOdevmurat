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

namespace MarketOdev.Forms
{
    public partial class FormAlisSiparis : Form
    {
        public FormAlisSiparis()
        {
            InitializeComponent();
        }

        private void FormAlisSiparis_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }
        List<SepetView_Model> sepetList = new List<SepetView_Model>();
        private void VerileriGetir( string arama = "")
        {          
                try
                {
                    var ara = arama.ToLower();
                    MyContext db = new MyContext();
                lstUrun.DataSource = db.Urunler.Where(x => x.UrunAdi.ToLower().Contains(ara)).ToList();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message);
                }
            
        }
        
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
          
            if (lstUrun.SelectedItem == null) return;
            var seciliUrun = lstUrun.SelectedItem as Urun;
            //bool kontrol = StokKontrol(seciliUrun);
            //if (!kontrol)
            //{
            //    MessageBox.Show("Stokta olandan fazlasını sepete ekleyemezsiniz");
            //    return;
            //}
            bool varmi = false;
            sepetList.ForEach(x =>
            {
                if (x.UrunId == seciliUrun.UrunId)
                {
                    varmi = true;
                    x.Adet+=(short)nAdet.Value;
                }
            });
            if (!varmi)
            {
                var model = new SepetView_Model()
                {
                    UrunId = seciliUrun.UrunId,
                    Indirim = nIndirim.Value,
                    UrunAdi = seciliUrun.UrunAdi,
                    fiyat = seciliUrun.AlisFiyati,
                    KdvOrani=seciliUrun.Kategori.KdvOrani??0,
                    BarkodId=seciliUrun.BarkodNumarasi,
                    Adet=(short)nAdet.Value
                };
                sepetList.Add(model);
            }
            SepetGuncelle();
        }

        private void SepetGuncelle()
        {
            lstSepet.Items.Clear();
            sepetList.ForEach(x => lstSepet.Items.Add(x));
            SepetHesapla();
        }

        private void SepetHesapla()
        {
            decimal toplam=0, kdv = 0;
            toplam = sepetList.Sum(x => x.Total);
            kdv = sepetList.Sum(x => x.kdvHesapla);
            nToplam.Value = toplam;
            nKdv.Value = kdv;
            
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenUrun = lstUrun.SelectedItem as Urun;
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
            txtBarkodNo.Text = secilenUrun.BarkodNumarasi.ToString();

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            VerileriGetir(txtAra.Text);
        }

        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            if (sepetList.Count == 0)
            {
                MessageBox.Show("Önce Sepete Ürün Eklemelisiniz");
                return;
            }
            

            string mesaj = $"{ nToplam.Value + nKdv.Value:c2} tutarındaki siparişi onaylıyor musunuz?\n";
        
            var cevap = MessageBox.Show(mesaj, "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            MyContext db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var yeniSiparis = new Siparis()
                    {
                        AlinanMi = true,
                        Nakit = true
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
                        urun.stok += item.Adet;
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
            sepetList = new List<SepetView_Model>();
            lstSepet.Items.Clear();
            VerileriGetir();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarkodNo.Text.Count() == 13)
                {
                    BarcodeLib.Barcode b = new BarcodeLib.Barcode();
                    BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
                    type = BarcodeLib.TYPE.EAN13;


                    pctBarkod.Image = b.Encode(type, txtBarkodNo.Text, 170, 50);
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
    }
}
