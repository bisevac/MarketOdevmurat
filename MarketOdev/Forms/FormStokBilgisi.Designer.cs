namespace MarketOdev.Forms
{
    partial class FormStokBilgisi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtgridStok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.RdBüyük = new System.Windows.Forms.RadioButton();
            this.RdKüçük = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgridStok)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgridStok
            // 
            this.DtgridStok.AllowUserToAddRows = false;
            this.DtgridStok.AllowUserToDeleteRows = false;
            this.DtgridStok.AllowUserToResizeRows = false;
            this.DtgridStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgridStok.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DtgridStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtgridStok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DtgridStok.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgridStok.DefaultCellStyle = dataGridViewCellStyle1;
            this.DtgridStok.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DtgridStok.Location = new System.Drawing.Point(12, 79);
            this.DtgridStok.MultiSelect = false;
            this.DtgridStok.Name = "DtgridStok";
            this.DtgridStok.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgridStok.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgridStok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DtgridStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgridStok.Size = new System.Drawing.Size(611, 196);
            this.DtgridStok.TabIndex = 0;
            this.DtgridStok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(78, 53);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RdBüyük
            // 
            this.RdBüyük.AutoSize = true;
            this.RdBüyük.Location = new System.Drawing.Point(246, 51);
            this.RdBüyük.Name = "RdBüyük";
            this.RdBüyük.Size = new System.Drawing.Size(139, 17);
            this.RdBüyük.TabIndex = 3;
            this.RdBüyük.TabStop = true;
            this.RdBüyük.Text = "Büyükten Küçüğe Sırala";
            this.RdBüyük.UseVisualStyleBackColor = true;
            // 
            // RdKüçük
            // 
            this.RdKüçük.AutoSize = true;
            this.RdKüçük.Location = new System.Drawing.Point(245, 28);
            this.RdKüçük.Name = "RdKüçük";
            this.RdKüçük.Size = new System.Drawing.Size(139, 17);
            this.RdKüçük.TabIndex = 4;
            this.RdKüçük.TabStop = true;
            this.RdKüçük.Text = "Küçükten Büyüğe Sırala";
            this.RdKüçük.UseVisualStyleBackColor = true;
            this.RdKüçük.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok";
            // 
            // FormStokBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 563);
            this.Controls.Add(this.RdKüçük);
            this.Controls.Add(this.RdBüyük);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgridStok);
            this.Name = "FormStokBilgisi";
            this.Text = "FormStokBilgisi";
            this.Load += new System.EventHandler(this.FormStokBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgridStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgridStok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.RadioButton RdBüyük;
        private System.Windows.Forms.RadioButton RdKüçük;
        private System.Windows.Forms.Label label2;
    }
}