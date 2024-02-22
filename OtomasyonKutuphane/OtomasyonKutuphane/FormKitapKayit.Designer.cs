namespace OtomasyonKutuphane
{
    partial class FormKitapKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapKayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kITAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxYayinEvi = new System.Windows.Forms.ComboBox();
            this.comboBoxKitapYazari = new System.Windows.Forms.ComboBox();
            this.textBoxKitapISBN = new System.Windows.Forms.TextBox();
            this.labelKitapISBN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.maskedTextBoxBasimYili = new System.Windows.Forms.MaskedTextBox();
            this.textBoxStokNumarası = new System.Windows.Forms.TextBox();
            this.textBoxKitapSayfaSayisi = new System.Windows.Forms.TextBox();
            this.comboBoxKitapTuru = new System.Windows.Forms.ComboBox();
            this.textBoxKitapAd = new System.Windows.Forms.TextBox();
            this.lblKitapYayinEvi = new System.Windows.Forms.Label();
            this.lblStokNumarası = new System.Windows.Forms.Label();
            this.lblBasimYili = new System.Windows.Forms.Label();
            this.lblKitapSayfaSayisi = new System.Windows.Forms.Label();
            this.lblKitapYazari = new System.Windows.Forms.Label();
            this.lblKitapTuru = new System.Windows.Forms.Label();
            this.lblKitapAd = new System.Windows.Forms.Label();
            this.kUTUPHANEDataSet1 = new OtomasyonKutuphane.KUTUPHANEDataSet();
            this.kITAPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kITAPTableAdapter1 = new OtomasyonKutuphane.KUTUPHANEDataSetTableAdapters.KITAPTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kITAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUTUPHANEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kITAPBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1365, 735);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.comboBoxYayinEvi);
            this.groupBox1.Controls.Add(this.comboBoxKitapYazari);
            this.groupBox1.Controls.Add(this.textBoxKitapISBN);
            this.groupBox1.Controls.Add(this.labelKitapISBN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.maskedTextBoxBasimYili);
            this.groupBox1.Controls.Add(this.textBoxStokNumarası);
            this.groupBox1.Controls.Add(this.textBoxKitapSayfaSayisi);
            this.groupBox1.Controls.Add(this.comboBoxKitapTuru);
            this.groupBox1.Controls.Add(this.textBoxKitapAd);
            this.groupBox1.Controls.Add(this.lblKitapYayinEvi);
            this.groupBox1.Controls.Add(this.lblStokNumarası);
            this.groupBox1.Controls.Add(this.lblBasimYili);
            this.groupBox1.Controls.Add(this.lblKitapSayfaSayisi);
            this.groupBox1.Controls.Add(this.lblKitapYazari);
            this.groupBox1.Controls.Add(this.lblKitapTuru);
            this.groupBox1.Controls.Add(this.lblKitapAd);
            this.groupBox1.Location = new System.Drawing.Point(85, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1170, 653);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.yazarDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.kITAPBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(67, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 265);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kITAPBindingSource
            // 
            this.kITAPBindingSource.DataMember = "KITAP";
            // 
            // comboBoxYayinEvi
            // 
            this.comboBoxYayinEvi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxYayinEvi.FormattingEnabled = true;
            this.comboBoxYayinEvi.Location = new System.Drawing.Point(823, 265);
            this.comboBoxYayinEvi.Name = "comboBoxYayinEvi";
            this.comboBoxYayinEvi.Size = new System.Drawing.Size(236, 32);
            this.comboBoxYayinEvi.TabIndex = 20;
            // 
            // comboBoxKitapYazari
            // 
            this.comboBoxKitapYazari.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKitapYazari.FormattingEnabled = true;
            this.comboBoxKitapYazari.Location = new System.Drawing.Point(269, 265);
            this.comboBoxKitapYazari.Name = "comboBoxKitapYazari";
            this.comboBoxKitapYazari.Size = new System.Drawing.Size(236, 32);
            this.comboBoxKitapYazari.TabIndex = 19;
            // 
            // textBoxKitapISBN
            // 
            this.textBoxKitapISBN.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitapISBN.Location = new System.Drawing.Point(269, 110);
            this.textBoxKitapISBN.Name = "textBoxKitapISBN";
            this.textBoxKitapISBN.Size = new System.Drawing.Size(236, 30);
            this.textBoxKitapISBN.TabIndex = 18;
            // 
            // labelKitapISBN
            // 
            this.labelKitapISBN.AutoSize = true;
            this.labelKitapISBN.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKitapISBN.Location = new System.Drawing.Point(102, 113);
            this.labelKitapISBN.Name = "labelKitapISBN";
            this.labelKitapISBN.Size = new System.Drawing.Size(152, 27);
            this.labelKitapISBN.TabIndex = 17;
            this.labelKitapISBN.Text = "Kitap ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kitap Bilgileri";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(765, 21);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(133, 41);
            this.buttonGuncelle.TabIndex = 15;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(904, 21);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(119, 41);
            this.buttonSil.TabIndex = 14;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(1029, 21);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(119, 41);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // maskedTextBoxBasimYili
            // 
            this.maskedTextBoxBasimYili.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxBasimYili.Location = new System.Drawing.Point(823, 161);
            this.maskedTextBoxBasimYili.Mask = "0000";
            this.maskedTextBoxBasimYili.Name = "maskedTextBoxBasimYili";
            this.maskedTextBoxBasimYili.Size = new System.Drawing.Size(236, 30);
            this.maskedTextBoxBasimYili.TabIndex = 11;
            this.maskedTextBoxBasimYili.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxStokNumarası
            // 
            this.textBoxStokNumarası.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxStokNumarası.Location = new System.Drawing.Point(823, 213);
            this.textBoxStokNumarası.Name = "textBoxStokNumarası";
            this.textBoxStokNumarası.Size = new System.Drawing.Size(236, 30);
            this.textBoxStokNumarası.TabIndex = 10;
            // 
            // textBoxKitapSayfaSayisi
            // 
            this.textBoxKitapSayfaSayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitapSayfaSayisi.Location = new System.Drawing.Point(823, 110);
            this.textBoxKitapSayfaSayisi.Name = "textBoxKitapSayfaSayisi";
            this.textBoxKitapSayfaSayisi.Size = new System.Drawing.Size(236, 30);
            this.textBoxKitapSayfaSayisi.TabIndex = 9;
            // 
            // comboBoxKitapTuru
            // 
            this.comboBoxKitapTuru.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKitapTuru.FormattingEnabled = true;
            this.comboBoxKitapTuru.Location = new System.Drawing.Point(269, 210);
            this.comboBoxKitapTuru.Name = "comboBoxKitapTuru";
            this.comboBoxKitapTuru.Size = new System.Drawing.Size(236, 32);
            this.comboBoxKitapTuru.TabIndex = 7;
            // 
            // textBoxKitapAd
            // 
            this.textBoxKitapAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitapAd.Location = new System.Drawing.Point(269, 160);
            this.textBoxKitapAd.Name = "textBoxKitapAd";
            this.textBoxKitapAd.Size = new System.Drawing.Size(236, 30);
            this.textBoxKitapAd.TabIndex = 6;
            // 
            // lblKitapYayinEvi
            // 
            this.lblKitapYayinEvi.AutoSize = true;
            this.lblKitapYayinEvi.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapYayinEvi.Location = new System.Drawing.Point(676, 270);
            this.lblKitapYayinEvi.Name = "lblKitapYayinEvi";
            this.lblKitapYayinEvi.Size = new System.Drawing.Size(132, 27);
            this.lblKitapYayinEvi.TabIndex = 0;
            this.lblKitapYayinEvi.Text = "Yayın Evi:";
            // 
            // lblStokNumarası
            // 
            this.lblStokNumarası.AutoSize = true;
            this.lblStokNumarası.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokNumarası.Location = new System.Drawing.Point(610, 216);
            this.lblStokNumarası.Name = "lblStokNumarası";
            this.lblStokNumarası.Size = new System.Drawing.Size(198, 27);
            this.lblStokNumarası.TabIndex = 5;
            this.lblStokNumarası.Text = "Stok Numarası:";
            // 
            // lblBasimYili
            // 
            this.lblBasimYili.AutoSize = true;
            this.lblBasimYili.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasimYili.Location = new System.Drawing.Point(667, 164);
            this.lblBasimYili.Name = "lblBasimYili";
            this.lblBasimYili.Size = new System.Drawing.Size(141, 27);
            this.lblBasimYili.TabIndex = 4;
            this.lblBasimYili.Text = "Basım Yılı:";
            // 
            // lblKitapSayfaSayisi
            // 
            this.lblKitapSayfaSayisi.AutoSize = true;
            this.lblKitapSayfaSayisi.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapSayfaSayisi.Location = new System.Drawing.Point(647, 111);
            this.lblKitapSayfaSayisi.Name = "lblKitapSayfaSayisi";
            this.lblKitapSayfaSayisi.Size = new System.Drawing.Size(161, 27);
            this.lblKitapSayfaSayisi.TabIndex = 3;
            this.lblKitapSayfaSayisi.Text = "Sayfa Sayısı:";
            // 
            // lblKitapYazari
            // 
            this.lblKitapYazari.AutoSize = true;
            this.lblKitapYazari.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapYazari.Location = new System.Drawing.Point(157, 270);
            this.lblKitapYazari.Name = "lblKitapYazari";
            this.lblKitapYazari.Size = new System.Drawing.Size(97, 27);
            this.lblKitapYazari.TabIndex = 2;
            this.lblKitapYazari.Text = "Yazarı:";
            // 
            // lblKitapTuru
            // 
            this.lblKitapTuru.AutoSize = true;
            this.lblKitapTuru.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapTuru.Location = new System.Drawing.Point(174, 215);
            this.lblKitapTuru.Name = "lblKitapTuru";
            this.lblKitapTuru.Size = new System.Drawing.Size(80, 27);
            this.lblKitapTuru.TabIndex = 1;
            this.lblKitapTuru.Text = "Türü:";
            // 
            // lblKitapAd
            // 
            this.lblKitapAd.AutoSize = true;
            this.lblKitapAd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitapAd.Location = new System.Drawing.Point(194, 163);
            this.lblKitapAd.Name = "lblKitapAd";
            this.lblKitapAd.Size = new System.Drawing.Size(60, 27);
            this.lblKitapAd.TabIndex = 0;
            this.lblKitapAd.Text = "Adı:";
            // 
            // kUTUPHANEDataSet1
            // 
            this.kUTUPHANEDataSet1.DataSetName = "KUTUPHANEDataSet";
            this.kUTUPHANEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kITAPBindingSource1
            // 
            this.kITAPBindingSource1.DataMember = "KITAP";
            this.kITAPBindingSource1.DataSource = this.kUTUPHANEDataSet1;
            // 
            // kITAPTableAdapter1
            // 
            this.kITAPTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kitapISBN";
            this.dataGridViewTextBoxColumn1.HeaderText = "kitapISBN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kitapIsmi";
            this.dataGridViewTextBoxColumn2.HeaderText = "kitapIsmi";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "yazar";
            this.yazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "yayinEviId";
            this.dataGridViewTextBoxColumn3.HeaderText = "yayinEviId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "turId";
            this.dataGridViewTextBoxColumn4.HeaderText = "turId";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stokId";
            this.dataGridViewTextBoxColumn5.HeaderText = "stokId";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "kitapSayfaSayisi";
            this.dataGridViewTextBoxColumn6.HeaderText = "kitapSayfaSayisi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kitapBasinYili";
            this.dataGridViewTextBoxColumn7.HeaderText = "kitapBasinYili";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // FormKitapKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 735);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormKitapKayit";
            this.Text = "Kitap Kayıt Formu";
            this.Load += new System.EventHandler(this.FormKitapKayit_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormKitapKayit_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kITAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUTUPHANEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kITAPBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStokNumarası;
        private System.Windows.Forms.Label lblBasimYili;
        private System.Windows.Forms.Label lblKitapSayfaSayisi;
        private System.Windows.Forms.Label lblKitapYazari;
        private System.Windows.Forms.Label lblKitapTuru;
        private System.Windows.Forms.Label lblKitapAd;
        private System.Windows.Forms.Label lblKitapYayinEvi;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBasimYili;
        private System.Windows.Forms.TextBox textBoxStokNumarası;
        private System.Windows.Forms.TextBox textBoxKitapSayfaSayisi;
        private System.Windows.Forms.ComboBox comboBoxKitapTuru;
        private System.Windows.Forms.TextBox textBoxKitapAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxKitapISBN;
        private System.Windows.Forms.Label labelKitapISBN;
        private System.Windows.Forms.ComboBox comboBoxKitapYazari;
        private System.Windows.Forms.ComboBox comboBoxYayinEvi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KUTUPHANEDataSet kUTUPHANEDataSet;
        private System.Windows.Forms.BindingSource kITAPBindingSource;
        private KUTUPHANEDataSetTableAdapters.KITAPTableAdapter kITAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapISBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEviIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBasinYiliDataGridViewTextBoxColumn;
        private KUTUPHANEDataSet kUTUPHANEDataSet1;
        private System.Windows.Forms.BindingSource kITAPBindingSource1;
        private KUTUPHANEDataSetTableAdapters.KITAPTableAdapter kITAPTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}