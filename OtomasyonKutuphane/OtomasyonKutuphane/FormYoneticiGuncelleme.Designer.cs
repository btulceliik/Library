namespace OtomasyonKutuphane
{
    partial class FormYoneticiGuncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYoneticiGuncelleme));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxYoneticiID = new System.Windows.Forms.TextBox();
            this.lblYoneticiID = new System.Windows.Forms.Label();
            this.textBoxYoneticiSifre = new System.Windows.Forms.TextBox();
            this.lblYoneticiSifre = new System.Windows.Forms.Label();
            this.maskedTextBoxYoneticiTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblYoneticiTelefon = new System.Windows.Forms.Label();
            this.textBoxYoneticiMail = new System.Windows.Forms.TextBox();
            this.lblYoneticiMail = new System.Windows.Forms.Label();
            this.textBoxYoneticiSoyad = new System.Windows.Forms.TextBox();
            this.textBoxYoneticiAd = new System.Windows.Forms.TextBox();
            this.lblYoneticiAd = new System.Windows.Forms.Label();
            this.lblYoneticiSoyad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yoneticiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yONETICIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kUTUPHANEDataSet3 = new OtomasyonKutuphane.KUTUPHANEDataSet3();
            this.yONETICITableAdapter = new OtomasyonKutuphane.KUTUPHANEDataSet3TableAdapters.YONETICITableAdapter();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yONETICIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUTUPHANEDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(891, 725);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.textBoxYoneticiID);
            this.groupBox1.Controls.Add(this.lblYoneticiID);
            this.groupBox1.Controls.Add(this.textBoxYoneticiSifre);
            this.groupBox1.Controls.Add(this.lblYoneticiSifre);
            this.groupBox1.Controls.Add(this.maskedTextBoxYoneticiTelefon);
            this.groupBox1.Controls.Add(this.lblYoneticiTelefon);
            this.groupBox1.Controls.Add(this.textBoxYoneticiMail);
            this.groupBox1.Controls.Add(this.lblYoneticiMail);
            this.groupBox1.Controls.Add(this.textBoxYoneticiSoyad);
            this.groupBox1.Controls.Add(this.textBoxYoneticiAd);
            this.groupBox1.Controls.Add(this.lblYoneticiAd);
            this.groupBox1.Controls.Add(this.lblYoneticiSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(46, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 413);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Bilgileri";
            // 
            // textBoxYoneticiID
            // 
            this.textBoxYoneticiID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiID.Location = new System.Drawing.Point(207, 45);
            this.textBoxYoneticiID.Name = "textBoxYoneticiID";
            this.textBoxYoneticiID.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiID.TabIndex = 20;
            // 
            // lblYoneticiID
            // 
            this.lblYoneticiID.AutoSize = true;
            this.lblYoneticiID.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiID.Location = new System.Drawing.Point(131, 48);
            this.lblYoneticiID.Name = "lblYoneticiID";
            this.lblYoneticiID.Size = new System.Drawing.Size(49, 27);
            this.lblYoneticiID.TabIndex = 19;
            this.lblYoneticiID.Text = "ID:";
            // 
            // textBoxYoneticiSifre
            // 
            this.textBoxYoneticiSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiSifre.Location = new System.Drawing.Point(207, 362);
            this.textBoxYoneticiSifre.Name = "textBoxYoneticiSifre";
            this.textBoxYoneticiSifre.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiSifre.TabIndex = 18;
            // 
            // lblYoneticiSifre
            // 
            this.lblYoneticiSifre.AutoSize = true;
            this.lblYoneticiSifre.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiSifre.Location = new System.Drawing.Point(103, 365);
            this.lblYoneticiSifre.Name = "lblYoneticiSifre";
            this.lblYoneticiSifre.Size = new System.Drawing.Size(77, 27);
            this.lblYoneticiSifre.TabIndex = 17;
            this.lblYoneticiSifre.Text = "Şifre:";
            // 
            // maskedTextBoxYoneticiTelefon
            // 
            this.maskedTextBoxYoneticiTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxYoneticiTelefon.Location = new System.Drawing.Point(207, 228);
            this.maskedTextBoxYoneticiTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxYoneticiTelefon.Name = "maskedTextBoxYoneticiTelefon";
            this.maskedTextBoxYoneticiTelefon.Size = new System.Drawing.Size(231, 30);
            this.maskedTextBoxYoneticiTelefon.TabIndex = 15;
            // 
            // lblYoneticiTelefon
            // 
            this.lblYoneticiTelefon.AutoSize = true;
            this.lblYoneticiTelefon.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiTelefon.Location = new System.Drawing.Point(30, 229);
            this.lblYoneticiTelefon.Name = "lblYoneticiTelefon";
            this.lblYoneticiTelefon.Size = new System.Drawing.Size(150, 27);
            this.lblYoneticiTelefon.TabIndex = 13;
            this.lblYoneticiTelefon.Text = "Telefon No:";
            // 
            // textBoxYoneticiMail
            // 
            this.textBoxYoneticiMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiMail.Location = new System.Drawing.Point(207, 297);
            this.textBoxYoneticiMail.Name = "textBoxYoneticiMail";
            this.textBoxYoneticiMail.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiMail.TabIndex = 16;
            // 
            // lblYoneticiMail
            // 
            this.lblYoneticiMail.AutoSize = true;
            this.lblYoneticiMail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiMail.Location = new System.Drawing.Point(68, 297);
            this.lblYoneticiMail.Name = "lblYoneticiMail";
            this.lblYoneticiMail.Size = new System.Drawing.Size(112, 27);
            this.lblYoneticiMail.TabIndex = 14;
            this.lblYoneticiMail.Text = "E-Posta:";
            // 
            // textBoxYoneticiSoyad
            // 
            this.textBoxYoneticiSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiSoyad.Location = new System.Drawing.Point(207, 166);
            this.textBoxYoneticiSoyad.Name = "textBoxYoneticiSoyad";
            this.textBoxYoneticiSoyad.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiSoyad.TabIndex = 12;
            // 
            // textBoxYoneticiAd
            // 
            this.textBoxYoneticiAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiAd.Location = new System.Drawing.Point(207, 106);
            this.textBoxYoneticiAd.Name = "textBoxYoneticiAd";
            this.textBoxYoneticiAd.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiAd.TabIndex = 11;
            // 
            // lblYoneticiAd
            // 
            this.lblYoneticiAd.AutoSize = true;
            this.lblYoneticiAd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiAd.Location = new System.Drawing.Point(120, 109);
            this.lblYoneticiAd.Name = "lblYoneticiAd";
            this.lblYoneticiAd.Size = new System.Drawing.Size(60, 27);
            this.lblYoneticiAd.TabIndex = 9;
            this.lblYoneticiAd.Text = "Adı:";
            // 
            // lblYoneticiSoyad
            // 
            this.lblYoneticiSoyad.AutoSize = true;
            this.lblYoneticiSoyad.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiSoyad.Location = new System.Drawing.Point(80, 166);
            this.lblYoneticiSoyad.Name = "lblYoneticiSoyad";
            this.lblYoneticiSoyad.Size = new System.Drawing.Size(100, 27);
            this.lblYoneticiSoyad.TabIndex = 10;
            this.lblYoneticiSoyad.Text = "Soyadı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiIdDataGridViewTextBoxColumn,
            this.yoneticiAdiDataGridViewTextBoxColumn,
            this.yoneticiSoyadiDataGridViewTextBoxColumn,
            this.yoneticiSifreDataGridViewTextBoxColumn,
            this.yoneticiMailDataGridViewTextBoxColumn,
            this.yoneticiTelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yONETICIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 485);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 216);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yoneticiIdDataGridViewTextBoxColumn
            // 
            this.yoneticiIdDataGridViewTextBoxColumn.DataPropertyName = "yoneticiId";
            this.yoneticiIdDataGridViewTextBoxColumn.HeaderText = "yoneticiId";
            this.yoneticiIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiIdDataGridViewTextBoxColumn.Name = "yoneticiIdDataGridViewTextBoxColumn";
            this.yoneticiIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.yoneticiIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiAdiDataGridViewTextBoxColumn
            // 
            this.yoneticiAdiDataGridViewTextBoxColumn.DataPropertyName = "yoneticiAdi";
            this.yoneticiAdiDataGridViewTextBoxColumn.HeaderText = "yoneticiAdi";
            this.yoneticiAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiAdiDataGridViewTextBoxColumn.Name = "yoneticiAdiDataGridViewTextBoxColumn";
            this.yoneticiAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiSoyadiDataGridViewTextBoxColumn
            // 
            this.yoneticiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "yoneticiSoyadi";
            this.yoneticiSoyadiDataGridViewTextBoxColumn.HeaderText = "yoneticiSoyadi";
            this.yoneticiSoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiSoyadiDataGridViewTextBoxColumn.Name = "yoneticiSoyadiDataGridViewTextBoxColumn";
            this.yoneticiSoyadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiSifreDataGridViewTextBoxColumn
            // 
            this.yoneticiSifreDataGridViewTextBoxColumn.DataPropertyName = "yoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.HeaderText = "yoneticiSifre";
            this.yoneticiSifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiSifreDataGridViewTextBoxColumn.Name = "yoneticiSifreDataGridViewTextBoxColumn";
            this.yoneticiSifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiMailDataGridViewTextBoxColumn
            // 
            this.yoneticiMailDataGridViewTextBoxColumn.DataPropertyName = "yoneticiMail";
            this.yoneticiMailDataGridViewTextBoxColumn.HeaderText = "yoneticiMail";
            this.yoneticiMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiMailDataGridViewTextBoxColumn.Name = "yoneticiMailDataGridViewTextBoxColumn";
            this.yoneticiMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // yoneticiTelefonDataGridViewTextBoxColumn
            // 
            this.yoneticiTelefonDataGridViewTextBoxColumn.DataPropertyName = "yoneticiTelefon";
            this.yoneticiTelefonDataGridViewTextBoxColumn.HeaderText = "yoneticiTelefon";
            this.yoneticiTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yoneticiTelefonDataGridViewTextBoxColumn.Name = "yoneticiTelefonDataGridViewTextBoxColumn";
            this.yoneticiTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // yONETICIBindingSource
            // 
            this.yONETICIBindingSource.DataMember = "YONETICI";
            this.yONETICIBindingSource.DataSource = this.kUTUPHANEDataSet3;
            // 
            // kUTUPHANEDataSet3
            // 
            this.kUTUPHANEDataSet3.DataSetName = "KUTUPHANEDataSet3";
            this.kUTUPHANEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yONETICITableAdapter
            // 
            this.yONETICITableAdapter.ClearBeforeFill = true;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(588, 89);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(129, 41);
            this.buttonGuncelle.TabIndex = 19;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Location = new System.Drawing.Point(743, 89);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(129, 41);
            this.buttonSil.TabIndex = 20;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // FormYoneticiGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 725);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormYoneticiGuncelleme";
            this.Text = "Yönetici Bilgileri Güncelleme Formu";
            this.Load += new System.EventHandler(this.FormYoneticiGuncelleme_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormYoneticiGuncelleme_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yONETICIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUTUPHANEDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxYoneticiSifre;
        private System.Windows.Forms.Label lblYoneticiSifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYoneticiTelefon;
        private System.Windows.Forms.Label lblYoneticiTelefon;
        private System.Windows.Forms.TextBox textBoxYoneticiMail;
        private System.Windows.Forms.Label lblYoneticiMail;
        private System.Windows.Forms.TextBox textBoxYoneticiSoyad;
        private System.Windows.Forms.TextBox textBoxYoneticiAd;
        private System.Windows.Forms.Label lblYoneticiAd;
        private System.Windows.Forms.Label lblYoneticiSoyad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KUTUPHANEDataSet3 kUTUPHANEDataSet3;
        private System.Windows.Forms.BindingSource yONETICIBindingSource;
        private KUTUPHANEDataSet3TableAdapters.YONETICITableAdapter yONETICITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxYoneticiID;
        private System.Windows.Forms.Label lblYoneticiID;
        private System.Windows.Forms.Button buttonSil;
    }
}