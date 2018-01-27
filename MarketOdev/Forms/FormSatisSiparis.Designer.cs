namespace MarketOdev.Forms
{
    partial class FormSatisSiparis
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
            this.components = new System.ComponentModel.Container();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.nKdv = new System.Windows.Forms.NumericUpDown();
            this.nToplam = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nAdet = new System.Windows.Forms.NumericUpDown();
            this.nIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelStok = new System.Windows.Forms.Label();
            this.chbBütünKategori = new System.Windows.Forms.CheckBox();
            this.lstViewSepet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pctBarkod = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(315, 46);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(198, 20);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSiparisOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOlustur.ForeColor = System.Drawing.Color.Crimson;
            this.btnSiparisOlustur.Location = new System.Drawing.Point(584, 494);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(263, 57);
            this.btnSiparisOlustur.TabIndex = 68;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = false;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // nKdv
            // 
            this.nKdv.DecimalPlaces = 2;
            this.nKdv.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nKdv.Location = new System.Drawing.Point(679, 442);
            this.nKdv.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nKdv.Name = "nKdv";
            this.nKdv.ReadOnly = true;
            this.nKdv.Size = new System.Drawing.Size(168, 40);
            this.nKdv.TabIndex = 67;
            this.nKdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nToplam
            // 
            this.nToplam.DecimalPlaces = 2;
            this.nToplam.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nToplam.Location = new System.Drawing.Point(679, 399);
            this.nToplam.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nToplam.Name = "nToplam";
            this.nToplam.ReadOnly = true;
            this.nToplam.Size = new System.Drawing.Size(168, 40);
            this.nToplam.TabIndex = 66;
            this.nToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(579, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "KDV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Barkod Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(369, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(358, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "İndirim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(579, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Toplam";
            // 
            // lstSepet
            // 
            this.lstSepet.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSepet.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 16;
            this.lstSepet.Location = new System.Drawing.Point(866, 423);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(75, 36);
            this.lstSepet.TabIndex = 60;
            this.lstSepet.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cıkarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // cıkarToolStripMenuItem
            // 
            this.cıkarToolStripMenuItem.Name = "cıkarToolStripMenuItem";
            this.cıkarToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.cıkarToolStripMenuItem.Text = "Çıkar";
            this.cıkarToolStripMenuItem.Click += new System.EventHandler(this.cıkarToolStripMenuItem_Click);
            // 
            // nAdet
            // 
            this.nAdet.Location = new System.Drawing.Point(344, 234);
            this.nAdet.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nAdet.Name = "nAdet";
            this.nAdet.Size = new System.Drawing.Size(116, 20);
            this.nAdet.TabIndex = 58;
            this.nAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nIndirim
            // 
            this.nIndirim.DecimalPlaces = 2;
            this.nIndirim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nIndirim.Location = new System.Drawing.Point(346, 311);
            this.nIndirim.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nIndirim.Name = "nIndirim";
            this.nIndirim.Size = new System.Drawing.Size(116, 20);
            this.nIndirim.TabIndex = 59;
            this.nIndirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(331, 369);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(150, 83);
            this.btnSepeteEkle.TabIndex = 57;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtAra.Location = new System.Drawing.Point(27, 252);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(235, 20);
            this.txtAra.TabIndex = 55;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstUrun
            // 
            this.lstUrun.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.ItemHeight = 20;
            this.lstUrun.Location = new System.Drawing.Point(27, 278);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(235, 224);
            this.lstUrun.TabIndex = 56;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.Location = new System.Drawing.Point(25, 516);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(68, 20);
            this.labelFiyat.TabIndex = 72;
            this.labelFiyat.Text = "Fiyat = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Kategori";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 74;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStok.Location = new System.Drawing.Point(139, 516);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(61, 20);
            this.labelStok.TabIndex = 72;
            this.labelStok.Text = "Stok =";
            // 
            // chbBütünKategori
            // 
            this.chbBütünKategori.AutoSize = true;
            this.chbBütünKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbBütünKategori.Location = new System.Drawing.Point(28, 72);
            this.chbBütünKategori.Name = "chbBütünKategori";
            this.chbBütünKategori.Size = new System.Drawing.Size(145, 20);
            this.chbBütünKategori.TabIndex = 75;
            this.chbBütünKategori.Text = "Bütün Kategoriler";
            this.chbBütünKategori.UseVisualStyleBackColor = true;
            this.chbBütünKategori.CheckedChanged += new System.EventHandler(this.chbBütünKategori_CheckedChanged);
            // 
            // lstViewSepet
            // 
            this.lstViewSepet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstViewSepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewSepet.ContextMenuStrip = this.contextMenuStrip1;
            this.lstViewSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewSepet.FullRowSelect = true;
            this.lstViewSepet.Location = new System.Drawing.Point(583, 34);
            this.lstViewSepet.Name = "lstViewSepet";
            this.lstViewSepet.Size = new System.Drawing.Size(358, 359);
            this.lstViewSepet.TabIndex = 76;
            this.lstViewSepet.UseCompatibleStateImageBehavior = false;
            this.lstViewSepet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adi";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Toplam";
            this.columnHeader4.Width = 121;
            // 
            // pctBarkod
            // 
            this.pctBarkod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBarkod.Location = new System.Drawing.Point(331, 72);
            this.pctBarkod.Name = "pctBarkod";
            this.pctBarkod.Size = new System.Drawing.Size(217, 68);
            this.pctBarkod.TabIndex = 71;
            this.pctBarkod.TabStop = false;
            this.pctBarkod.Click += new System.EventHandler(this.pctBarkod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(28, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // FormSatisSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 635);
            this.Controls.Add(this.lstViewSepet);
            this.Controls.Add(this.chbBütünKategori);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelStok);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.pctBarkod);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.nKdv);
            this.Controls.Add(this.nToplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.nAdet);
            this.Controls.Add(this.nIndirim);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrun);
            this.Name = "FormSatisSiparis";
            this.Text = "FormSatisSiparis";
            this.Load += new System.EventHandler(this.FormSatisSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nKdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nToplam)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.NumericUpDown nAdet;
        private System.Windows.Forms.NumericUpDown nIndirim;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.PictureBox pctBarkod;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.CheckBox chbBütünKategori;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cıkarToolStripMenuItem;
        private System.Windows.Forms.ListView lstViewSepet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.NumericUpDown nKdv;
        public System.Windows.Forms.NumericUpDown nToplam;
    }
}