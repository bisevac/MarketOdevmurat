using MarketOdev.DAL;
using MarketOdev.Entities;
using MarketOdev.ViewModel;
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
    public partial class FormStokBilgisi : Form
    {
        public FormStokBilgisi()
        {
            InitializeComponent();
        }

        private void FormStokBilgisi_Load(object sender, EventArgs e)
        {
            RdBüyük.Checked = true;
            VerileriGetir();
           
           
        }

        private void VerileriGetir(string arama="")
        {
            var list = new List<Urun>();
            MyContext db = new MyContext();
            if (RdKüçük.Checked)
            {
                 list = db.Urunler.OrderBy(x => x.stok).ToList();
            }
            else if (RdBüyük.Checked)
            {
              list = db.Urunler.OrderBy(x => x.stok).ToList();
                list.Reverse();
            }
            else
            {
                 list = db.Urunler.ToList();
            }
            var listA = list.Where(x => x.UrunAdi.Contains(arama));
           

            var StokList = new List<StokViewModel>();

            foreach (var item in listA)
            {
                var stokview = new StokViewModel()
                {
                    UrunId = item.UrunId,
                    KategoriAdi = item.Kategori.KategoriAdi,
                    stok = item.stok,
                    UrunAdi = item.UrunAdi
                };

                StokList.Add(stokview);               
            }

            DtgridStok.DataSource = StokList;
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerileriGetir(txtAra.Text);
        }
    }
}
