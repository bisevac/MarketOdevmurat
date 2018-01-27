namespace MarketOdev.Forms
{
    partial class FormRapor
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
            this.DtgridRapor = new System.Windows.Forms.DataGridView();
            this.chbAlinan = new System.Windows.Forms.CheckBox();
            this.chboxVerilen = new System.Windows.Forms.CheckBox();
            this.btnSiparisGöster = new System.Windows.Forms.Button();
            this.btnSiparisDetayları = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbTarihFiltre = new System.Windows.Forms.CheckBox();
            this.LabelToplam = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chbNakit = new System.Windows.Forms.CheckBox();
            this.chbKredi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgridRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgridRapor
            // 
            this.DtgridRapor.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.DtgridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgridRapor.Location = new System.Drawing.Point(12, 206);
            this.DtgridRapor.Name = "DtgridRapor";
            this.DtgridRapor.Size = new System.Drawing.Size(749, 307);
            this.DtgridRapor.TabIndex = 0;
            // 
            // chbAlinan
            // 
            this.chbAlinan.AutoSize = true;
            this.chbAlinan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbAlinan.ForeColor = System.Drawing.Color.Crimson;
            this.chbAlinan.Location = new System.Drawing.Point(18, 47);
            this.chbAlinan.Name = "chbAlinan";
            this.chbAlinan.Size = new System.Drawing.Size(137, 20);
            this.chbAlinan.TabIndex = 2;
            this.chbAlinan.Text = "AlinanSiparisler";
            this.chbAlinan.UseVisualStyleBackColor = true;
            this.chbAlinan.CheckedChanged += new System.EventHandler(this.chbAlinan_CheckedChanged);
            // 
            // chboxVerilen
            // 
            this.chboxVerilen.AutoSize = true;
            this.chboxVerilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chboxVerilen.ForeColor = System.Drawing.Color.Crimson;
            this.chboxVerilen.Location = new System.Drawing.Point(18, 87);
            this.chboxVerilen.Name = "chboxVerilen";
            this.chboxVerilen.Size = new System.Drawing.Size(147, 20);
            this.chboxVerilen.TabIndex = 3;
            this.chboxVerilen.Text = "Verilen Siparisler";
            this.chboxVerilen.UseVisualStyleBackColor = true;
            // 
            // btnSiparisGöster
            // 
            this.btnSiparisGöster.BackColor = System.Drawing.Color.Coral;
            this.btnSiparisGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisGöster.Location = new System.Drawing.Point(249, 145);
            this.btnSiparisGöster.Name = "btnSiparisGöster";
            this.btnSiparisGöster.Size = new System.Drawing.Size(163, 41);
            this.btnSiparisGöster.TabIndex = 4;
            this.btnSiparisGöster.Text = "Siparisleri Göster";
            this.btnSiparisGöster.UseVisualStyleBackColor = false;
            this.btnSiparisGöster.Click += new System.EventHandler(this.btnSiparisGöster_Click);
            // 
            // btnSiparisDetayları
            // 
            this.btnSiparisDetayları.BackColor = System.Drawing.Color.Coral;
            this.btnSiparisDetayları.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisDetayları.Location = new System.Drawing.Point(487, 145);
            this.btnSiparisDetayları.Name = "btnSiparisDetayları";
            this.btnSiparisDetayları.Size = new System.Drawing.Size(163, 42);
            this.btnSiparisDetayları.TabIndex = 4;
            this.btnSiparisDetayları.Text = "Siparis Detaylarını Göster";
            this.btnSiparisDetayları.UseVisualStyleBackColor = false;
            this.btnSiparisDetayları.Click += new System.EventHandler(this.btnSiparisDetayları_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 175);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(143, 20);
            this.txtAra.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürünü Arama";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Location = new System.Drawing.Point(300, 51);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtBaslangic.TabIndex = 7;
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(300, 87);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 20);
            this.dtBitis.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(212, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarihinden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(188, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "TarihineKadar";
            // 
            // chbTarihFiltre
            // 
            this.chbTarihFiltre.AutoSize = true;
            this.chbTarihFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbTarihFiltre.ForeColor = System.Drawing.Color.Crimson;
            this.chbTarihFiltre.Location = new System.Drawing.Point(300, 12);
            this.chbTarihFiltre.Name = "chbTarihFiltre";
            this.chbTarihFiltre.Size = new System.Drawing.Size(162, 20);
            this.chbTarihFiltre.TabIndex = 2;
            this.chbTarihFiltre.Text = "Tarihe Göre Filtrele";
            this.chbTarihFiltre.UseVisualStyleBackColor = true;
            this.chbTarihFiltre.CheckedChanged += new System.EventHandler(this.chbAlinan_CheckedChanged);
            // 
            // LabelToplam
            // 
            this.LabelToplam.AutoSize = true;
            this.LabelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelToplam.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelToplam.Location = new System.Drawing.Point(381, 530);
            this.LabelToplam.Name = "LabelToplam";
            this.LabelToplam.Size = new System.Drawing.Size(102, 25);
            this.LabelToplam.TabIndex = 6;
            this.LabelToplam.Text = "Toplam=";
            // 
            // chbNakit
            // 
            this.chbNakit.AutoSize = true;
            this.chbNakit.Checked = true;
            this.chbNakit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbNakit.ForeColor = System.Drawing.Color.Crimson;
            this.chbNakit.Location = new System.Drawing.Point(588, 50);
            this.chbNakit.Name = "chbNakit";
            this.chbNakit.Size = new System.Drawing.Size(134, 20);
            this.chbNakit.TabIndex = 2;
            this.chbNakit.Text = "Nakit Siparisler";
            this.chbNakit.UseVisualStyleBackColor = true;
            this.chbNakit.CheckedChanged += new System.EventHandler(this.chbAlinan_CheckedChanged);
            // 
            // chbKredi
            // 
            this.chbKredi.AutoSize = true;
            this.chbKredi.Checked = true;
            this.chbKredi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbKredi.ForeColor = System.Drawing.Color.Crimson;
            this.chbKredi.Location = new System.Drawing.Point(588, 90);
            this.chbKredi.Name = "chbKredi";
            this.chbKredi.Size = new System.Drawing.Size(173, 20);
            this.chbKredi.TabIndex = 3;
            this.chbKredi.Text = "Kredi Kartı Siparisleri";
            this.chbKredi.UseVisualStyleBackColor = true;
            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 578);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelToplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnSiparisDetayları);
            this.Controls.Add(this.btnSiparisGöster);
            this.Controls.Add(this.chbKredi);
            this.Controls.Add(this.chboxVerilen);
            this.Controls.Add(this.chbTarihFiltre);
            this.Controls.Add(this.chbNakit);
            this.Controls.Add(this.chbAlinan);
            this.Controls.Add(this.DtgridRapor);
            this.Name = "FormRapor";
            this.Text = "FormRapor";
            this.Load += new System.EventHandler(this.FormRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgridRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgridRapor;
        private System.Windows.Forms.CheckBox chbAlinan;
        private System.Windows.Forms.CheckBox chboxVerilen;
        private System.Windows.Forms.Button btnSiparisGöster;
        private System.Windows.Forms.Button btnSiparisDetayları;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbTarihFiltre;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label LabelToplam;
        private System.Windows.Forms.CheckBox chbNakit;
        private System.Windows.Forms.CheckBox chbKredi;
    }
}