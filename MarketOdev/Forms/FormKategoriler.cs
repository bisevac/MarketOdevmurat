using MarketOdev.DAL;
using MarketOdev.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOdev.Forms
{
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            try
            {
                MyContext db = new MyContext();

                lstKategori.DataSource = db.Kategoriler.OrderBy(x => x.KategoriAdi).ToList();
                lstKategori.DisplayMember = "KategoriAdi";
                lstKategori.ValueMember = "KategoriId";
               // lstKategori.DisplayMember = "";
               //  lstKategori.ValueMember = "CategoryID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                MyContext db = new MyContext();
                Kategoriler cat = new Kategoriler
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    Aciklama = txtAciklama.Text,
                    KdvOrani=nKdvOrani.Value
                };
                db.Kategoriler.Add(cat);
                db.SaveChanges();
                VerileriGetir();
               // lstKategori.SelectedValue = cat.kate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();

                var secilikagetori = lstKategori.SelectedItem as Kategoriler;
                secilikagetori = db.Kategoriler.Find(secilikagetori.KategoriId);
                secilikagetori.KategoriAdi = txtKategoriAdi.Text;
                secilikagetori.Aciklama = txtAciklama.Text;
                secilikagetori.KdvOrani = nKdvOrani.Value;
                db.SaveChanges();
                VerileriGetir();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
   
        }

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;

            var seciliKategori = lstKategori.SelectedItem as Kategoriler;
            txtKategoriAdi.Text = seciliKategori.KategoriAdi;
            txtAciklama.Text = seciliKategori.Aciklama;
            nKdvOrani.Value = seciliKategori.KdvOrani ?? 0;
        }
    }
}
