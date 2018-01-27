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
    public partial class OdemeForm : Form
    {
       

        public OdemeForm()
        {
            InitializeComponent();
        }
        
        private void BtnOnayla_Click(object sender, EventArgs e)
        {
            decimal tutar = decimal.Parse(lbltoplamGösterilmeyen.Text);
            string mesaj = $"{ tutar:c2} tutarındaki siparişi onaylıyor musunuz?\n";


            var cevap = MessageBox.Show(mesaj, "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }    
        private void OdemeForm_Load(object sender, EventArgs e)
        {
            RadioNakit.Checked = true;
            BtnOnayla.Enabled = false;
          
        }

        private void nVerilenPara_ValueChanged(object sender, EventArgs e)
        {
      
        }

        private void RadioNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioNakit.Checked)
            {
                nVerilenPara.Value = 0;
                nVerilenPara.Enabled = true;

                txtAdSoyad.Enabled = false;
                txtGüvenlik.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                mskKart.Enabled = false;

         

            }
            else
            {
                txtAdSoyad.Enabled = true;
                txtGüvenlik.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                mskKart.Enabled = true;

                nVerilenPara.Value = 0;
                nVerilenPara.Enabled = false;
            }
        }

        private void txtGüvenlik_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdSoyad.Text) && !string.IsNullOrEmpty(txtGüvenlik.Text) && comboBox1.SelectedIndex!=-1 && comboBox2.SelectedIndex != -1 && mskKart.Text.Count()>=16)
            {
                BtnOnayla.Enabled = true;
            }
            else
            {
                BtnOnayla.Enabled = false;
            }
        }

        private void lbltoplamtl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = DialogResult.Cancel;
            this.DialogResult = result;
            this.Close();

        }

        private void nVerilenPara_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nVerilenPara_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void nVerilenPara_KeyUp(object sender, KeyEventArgs e)
        {
            decimal fiyat = decimal.Parse(lbltoplamGösterilmeyen.Text);
            decimal paraüstü = nVerilenPara.Value - fiyat;
            if (fiyat > nVerilenPara.Value)
            {
                lblParaUstu.Text = "Yeterli Değildir";
                BtnOnayla.Enabled = false;
            }
            else if (fiyat <= nVerilenPara.Value)
            {
                lblParaUstu.Text = $"Para Üstü = {paraüstü:c2}";
                BtnOnayla.Enabled = true;

            }
        }
    }
}
