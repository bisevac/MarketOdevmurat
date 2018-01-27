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
    public partial class FormRapor : Form
    {
        public FormRapor()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chbAlinan_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTarihFiltre.Checked)
            {
                dtBaslangic.Enabled = true;
                dtBitis.Enabled = true;
            }
            else
            {
                dtBaslangic.Enabled = false;
                dtBitis.Enabled = false;
            }
        }

        private void FormRapor_Load(object sender, EventArgs e)
        {
            
            dtBaslangic.Enabled = false;
            dtBitis.Enabled = false;
            chbAlinan.Checked = true;
            chboxVerilen.Checked = true;
        }

        private void btnSiparisGöster_Click(object sender, EventArgs e)
        {


            var list = new List<Siparis>();

            MyContext db = new MyContext();

            if (chbAlinan.Checked && chboxVerilen.Checked)
            {
                if (chbTarihFiltre.Checked)
                {

                    list = db.Siparisler.Where(x=>x.SiparisTarihi<=dtBitis.Value && x.SiparisTarihi >= dtBaslangic.Value)
                        .OrderBy(x => x.SiparisTarihi).ToList();
                }
                else
                {

                    list = db.Siparisler.OrderBy(x => x.SiparisTarihi).ToList();
                }
                
            }
            else if (chbAlinan.Checked && !chboxVerilen.Checked)
            {
                if (chbTarihFiltre.Checked)
                {

                    list = db.Siparisler.Where(x => x.AlinanMi == true&& x.SiparisTarihi <= dtBitis.Value && x.SiparisTarihi >= dtBaslangic.Value)
                        .OrderBy(x => x.SiparisTarihi).ToList();
                }
                else
                {

                    list = db.Siparisler.Where(x => x.AlinanMi == true).OrderBy(x => x.SiparisTarihi).ToList();
                }
                   
            }
            else if (!chbAlinan.Checked && chboxVerilen.Checked)
            {
                if (chbTarihFiltre.Checked)
                {

                    list = db.Siparisler.Where(x => x.AlinanMi == false && x.SiparisTarihi <= dtBitis.Value && x.SiparisTarihi >= dtBaslangic.Value).OrderBy(x => x.SiparisTarihi).ToList();
                }
                else
                {

                    list = db.Siparisler.Where(x => x.AlinanMi == false).OrderBy(x => x.SiparisTarihi).ToList();
                }
              
            }
            else
            {
                list = null;
            }
            if (list ==null)
            {
                return;
            }
            var list2 = list;
            if (chbNakit.Checked &&chbKredi.Checked)
            {
                list2 = list;
            }
            else if (chbNakit.Checked && !chbKredi.Checked)
            {              
              list2 = list.Where(x=>x.Nakit==true).ToList();
            }
            else if (!chbNakit.Checked && chbKredi.Checked)
            {
                list2 = list.Where(x => x.Nakit == false).ToList();
            }
            else
            {
                DtgridRapor.DataSource = null;
                return;
            }

            DtgridRapor.DataSource = list2;




        }

        private void btnSiparisDetayları_Click(object sender, EventArgs e)
        {
            var list = new List<SiparisDetay>();
            string arama = txtAra.Text;
            MyContext db = new MyContext();

            if (chbAlinan.Checked && chboxVerilen.Checked)
            {
                if (chbTarihFiltre.Checked)
                {

                    list = db.SiparisDetaylar.Where(x => x.Siparis.SiparisTarihi <= dtBitis.Value && x.Siparis.SiparisTarihi >= dtBaslangic.Value && x.Urun.UrunAdi.Contains(arama))
                        .OrderBy(x => x.Siparis.SiparisTarihi).ToList();
                }
                else
                {

                    list = db.SiparisDetaylar.Where(x => x.Urun.UrunAdi.Contains(arama)).OrderBy(x => x.Siparis.SiparisTarihi).ToList();
                }

            }
            else if (chbAlinan.Checked && !chboxVerilen.Checked)
            {
                if (chbTarihFiltre.Checked)
                {

                    list = db.SiparisDetaylar.Where(x => x.Siparis.AlinanMi == true && x.Siparis.SiparisTarihi <= dtBitis.Value && x.Siparis.SiparisTarihi >= dtBaslangic.Value && x.Urun.UrunAdi.Contains(arama))
                        .OrderBy(x => x.Siparis.SiparisTarihi).ToList();
                }
                else
                {

                    list = db.SiparisDetaylar.Where(x => x.Siparis.AlinanMi == true && x.Urun.UrunAdi.Contains(arama)).OrderBy(x => x.Siparis.SiparisTarihi).ToList();
                }

            }
            else if (!chbAlinan.Checked && chboxVerilen.Checked)
            {
                if (chbTarihFiltre.Checked)
                {

                    list = db.SiparisDetaylar.Where(x => x.Siparis.AlinanMi == false && x.Siparis.SiparisTarihi <= dtBitis.Value && x.Siparis.SiparisTarihi >= dtBaslangic.Value && x.Urun.UrunAdi.Contains(arama))
                        .OrderBy(x => x.Siparis.SiparisTarihi).ToList();
                }
                else
                {
                    list = db.SiparisDetaylar.Where(x => x.Siparis.AlinanMi == false && x.Urun.UrunAdi.Contains(arama)).OrderBy(x => x.Siparis.SiparisTarihi).ToList();
                }

            }
            else
            {
            
                DtgridRapor.DataSource = list;
                return;
            }           
        
       


            var list2 = list.Select(x => new  { x.UrunId, x.Urun.UrunAdi, x.Adet, x.Fiyat, x.Indirim, x.Siparis.SiparisTarihi,x.Siparis.Nakit}).ToList();

            if (chbNakit.Checked && chbKredi.Checked)
            {
                DtgridRapor.DataSource = list2;
            }
            else if (chbNakit.Checked && !chbKredi.Checked)
            {
                DtgridRapor.DataSource = list2.Where(x => x.Nakit == true).ToList();
            }
            else if (!chbNakit.Checked && chbKredi.Checked)
            {
                DtgridRapor.DataSource = list2.Where(x => x.Nakit == false).ToList();
            }
            else
            {
                DtgridRapor.DataSource = null;
            }


           
            LabelToplam.Text = $"Toplam = {list2.Sum(x => x.Fiyat * x.Adet * (1 - x.Indirim)):c2}";

        }
    }
}
