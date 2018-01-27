using MarketOdev.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ürün Yönetimi";
        }
        FormUrunler urunlerForm;
        FormKategoriler kategorilerForm;
        FormAlisSiparis alisSiparisForm;
        public FormSatisSiparis satisSiparisForm;
        FormStokBilgisi stokbilgisiForm;
        FormRapor raporForm;
        
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urunlerForm == null || urunlerForm.IsDisposed)
            {
                urunlerForm = new FormUrunler();
                urunlerForm.MdiParent = this;
                urunlerForm.WindowState = FormWindowState.Maximized;
                urunlerForm.Text = "Ürünler";
                urunlerForm.Show();
            }
            else
            {
                urunlerForm.Select();
            }
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kategorilerForm == null || kategorilerForm.IsDisposed)
            {
                kategorilerForm = new FormKategoriler();
                kategorilerForm.MdiParent = this;
                kategorilerForm.WindowState = FormWindowState.Maximized;
                kategorilerForm.Text = "Kategoriler";
                kategorilerForm.Show();
            }
            else
            {
                kategorilerForm.Select();
            }

        }

        private void siparişALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alisSiparisForm == null || alisSiparisForm.IsDisposed)
            {
                alisSiparisForm = new FormAlisSiparis();
                alisSiparisForm.MdiParent = this;
                alisSiparisForm.WindowState = FormWindowState.Maximized;
                alisSiparisForm.Text = "Siparis";
                alisSiparisForm.Show();
            }
            else
            {
                alisSiparisForm.Select();
            }

        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (satisSiparisForm == null || satisSiparisForm.IsDisposed)
            {
                satisSiparisForm = new FormSatisSiparis();
                satisSiparisForm.MdiParent = this;
                satisSiparisForm.WindowState = FormWindowState.Maximized;
                satisSiparisForm.Text = "Ürünler";
                satisSiparisForm.Show();
            }
            else
            {
                satisSiparisForm.Select();
            }
        }

        private void stokBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stokbilgisiForm == null || stokbilgisiForm.IsDisposed)
            {
                stokbilgisiForm = new FormStokBilgisi();
                stokbilgisiForm.MdiParent = this;
                stokbilgisiForm.WindowState = FormWindowState.Maximized;
                stokbilgisiForm.Text = "Ürünler";
                stokbilgisiForm.Show();
            }
            else
            {
                stokbilgisiForm.Select();
            }
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (raporForm == null || raporForm.IsDisposed)
            {
                raporForm = new FormRapor();
                raporForm.MdiParent = this;
                raporForm.WindowState = FormWindowState.Maximized;
                raporForm.Text = "Raporlar";
                raporForm.Show();
            }
            else
            {
                raporForm.Select();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
