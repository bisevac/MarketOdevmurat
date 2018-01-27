namespace MarketOdev.Forms
{
    partial class OdemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtGüvenlik = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.mskKart = new System.Windows.Forms.MaskedTextBox();
            this.nVerilenPara = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.RadioKredi = new System.Windows.Forms.RadioButton();
            this.RadioNakit = new System.Windows.Forms.RadioButton();
            this.BtnOnayla = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltoplamtl = new System.Windows.Forms.Label();
            this.lbltoplamGösterilmeyen = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nVerilenPara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBox2.Location = new System.Drawing.Point(677, 342);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 24);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.Text = "YIL";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(568, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "AY";
            // 
            // txtGüvenlik
            // 
            this.txtGüvenlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGüvenlik.Location = new System.Drawing.Point(568, 381);
            this.txtGüvenlik.Name = "txtGüvenlik";
            this.txtGüvenlik.Size = new System.Drawing.Size(95, 26);
            this.txtGüvenlik.TabIndex = 19;
            this.txtGüvenlik.TextChanged += new System.EventHandler(this.txtGüvenlik_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(568, 302);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(204, 26);
            this.txtAdSoyad.TabIndex = 20;
            // 
            // mskKart
            // 
            this.mskKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskKart.Location = new System.Drawing.Point(568, 259);
            this.mskKart.Mask = "0000-0000-0000-0000";
            this.mskKart.Name = "mskKart";
            this.mskKart.Size = new System.Drawing.Size(204, 26);
            this.mskKart.TabIndex = 18;
            // 
            // nVerilenPara
            // 
            this.nVerilenPara.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nVerilenPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nVerilenPara.Location = new System.Drawing.Point(153, 262);
            this.nVerilenPara.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nVerilenPara.Name = "nVerilenPara";
            this.nVerilenPara.Size = new System.Drawing.Size(120, 26);
            this.nVerilenPara.TabIndex = 17;
            this.nVerilenPara.ValueChanged += new System.EventHandler(this.nVerilenPara_ValueChanged);
            this.nVerilenPara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nVerilenPara_KeyDown);
            this.nVerilenPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nVerilenPara_KeyPress);
            this.nVerilenPara.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nVerilenPara_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(451, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Güvenlik Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(413, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Son Kullanma Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(412, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kart Üzerindeki İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(453, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kart Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Verilen Miktar";
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaUstu.Location = new System.Drawing.Point(62, 342);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(106, 24);
            this.lblParaUstu.TabIndex = 15;
            this.lblParaUstu.Text = "Para Üstü =";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(312, 32);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(143, 24);
            this.lblToplam.TabIndex = 16;
            this.lblToplam.Text = "Toplam Tutar = ";
            // 
            // RadioKredi
            // 
            this.RadioKredi.AutoSize = true;
            this.RadioKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RadioKredi.Location = new System.Drawing.Point(563, 66);
            this.RadioKredi.Name = "RadioKredi";
            this.RadioKredi.Size = new System.Drawing.Size(110, 24);
            this.RadioKredi.TabIndex = 8;
            this.RadioKredi.TabStop = true;
            this.RadioKredi.Text = "Kredi Kartı";
            this.RadioKredi.UseVisualStyleBackColor = true;
            // 
            // RadioNakit
            // 
            this.RadioNakit.AutoSize = true;
            this.RadioNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RadioNakit.Location = new System.Drawing.Point(92, 66);
            this.RadioNakit.Name = "RadioNakit";
            this.RadioNakit.Size = new System.Drawing.Size(130, 24);
            this.RadioNakit.TabIndex = 9;
            this.RadioNakit.TabStop = true;
            this.RadioNakit.Text = "Nakit Ödeme";
            this.RadioNakit.UseVisualStyleBackColor = true;
            this.RadioNakit.CheckedChanged += new System.EventHandler(this.RadioNakit_CheckedChanged);
            // 
            // BtnOnayla
            // 
            this.BtnOnayla.BackColor = System.Drawing.Color.Salmon;
            this.BtnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOnayla.Location = new System.Drawing.Point(205, 478);
            this.BtnOnayla.Name = "BtnOnayla";
            this.BtnOnayla.Size = new System.Drawing.Size(169, 62);
            this.BtnOnayla.TabIndex = 7;
            this.BtnOnayla.Text = "İslemi Tamamla";
            this.BtnOnayla.UseVisualStyleBackColor = false;
            this.BtnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::MarketOdev.Properties.Resources.krediFoto;
            this.pictureBox2.Location = new System.Drawing.Point(568, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::MarketOdev.Properties.Resources.nakitFoto;
            this.pictureBox1.Location = new System.Drawing.Point(92, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbltoplamtl
            // 
            this.lbltoplamtl.AutoSize = true;
            this.lbltoplamtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamtl.Location = new System.Drawing.Point(471, 32);
            this.lbltoplamtl.Name = "lbltoplamtl";
            this.lbltoplamtl.Size = new System.Drawing.Size(15, 24);
            this.lbltoplamtl.TabIndex = 16;
            this.lbltoplamtl.Text = " ";
            this.lbltoplamtl.Click += new System.EventHandler(this.lbltoplamtl_Click);
            // 
            // lbltoplamGösterilmeyen
            // 
            this.lbltoplamGösterilmeyen.AutoSize = true;
            this.lbltoplamGösterilmeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamGösterilmeyen.Location = new System.Drawing.Point(30, 20);
            this.lbltoplamGösterilmeyen.Name = "lbltoplamGösterilmeyen";
            this.lbltoplamGösterilmeyen.Size = new System.Drawing.Size(20, 24);
            this.lbltoplamGösterilmeyen.TabIndex = 16;
            this.lbltoplamGösterilmeyen.Text = "0";
            this.lbltoplamGösterilmeyen.Visible = false;
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptal.Location = new System.Drawing.Point(428, 478);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(166, 62);
            this.btn_iptal.TabIndex = 25;
            this.btn_iptal.Text = "İPTAL ET";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 590);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtGüvenlik);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.mskKart);
            this.Controls.Add(this.nVerilenPara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParaUstu);
            this.Controls.Add(this.lbltoplamtl);
            this.Controls.Add(this.lbltoplamGösterilmeyen);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.RadioKredi);
            this.Controls.Add(this.RadioNakit);
            this.Controls.Add(this.BtnOnayla);
            this.Name = "OdemeForm";
            this.Text = "OdemeForm";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nVerilenPara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtGüvenlik;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.MaskedTextBox mskKart;
        private System.Windows.Forms.NumericUpDown nVerilenPara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.Button BtnOnayla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblToplam;
        public System.Windows.Forms.Label lbltoplamtl;
        public System.Windows.Forms.Label lbltoplamGösterilmeyen;
        private System.Windows.Forms.Button btn_iptal;
        public System.Windows.Forms.RadioButton RadioKredi;
        public System.Windows.Forms.RadioButton RadioNakit;
    }
}