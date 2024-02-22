namespace OtomasyonKutuphane
{
    partial class FormKitapListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapListele));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.kUTUPHANEDataSet4 = new OtomasyonKutuphane.KUTUPHANEDataSet4();
            this.kITAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kITAPTableAdapter = new OtomasyonKutuphane.KUTUPHANEDataSet4TableAdapters.KITAPTableAdapter();
            this.kitapISBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEviIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSayfaSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBasinYiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUTUPHANEDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kITAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1127, 546);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapISBNDataGridViewTextBoxColumn,
            this.kitapIsmiDataGridViewTextBoxColumn,
            this.yazarDataGridViewTextBoxColumn,
            this.yayinEviIdDataGridViewTextBoxColumn,
            this.turIdDataGridViewTextBoxColumn,
            this.stokIdDataGridViewTextBoxColumn,
            this.kitapSayfaSayisiDataGridViewTextBoxColumn,
            this.kitapBasinYiliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kITAPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 430);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(924, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ödünç Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kUTUPHANEDataSet4
            // 
            this.kUTUPHANEDataSet4.DataSetName = "KUTUPHANEDataSet4";
            this.kUTUPHANEDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kITAPBindingSource
            // 
            this.kITAPBindingSource.DataMember = "KITAP";
            this.kITAPBindingSource.DataSource = this.kUTUPHANEDataSet4;
            // 
            // kITAPTableAdapter
            // 
            this.kITAPTableAdapter.ClearBeforeFill = true;
            // 
            // kitapISBNDataGridViewTextBoxColumn
            // 
            this.kitapISBNDataGridViewTextBoxColumn.DataPropertyName = "kitapISBN";
            this.kitapISBNDataGridViewTextBoxColumn.HeaderText = "kitapISBN";
            this.kitapISBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapISBNDataGridViewTextBoxColumn.Name = "kitapISBNDataGridViewTextBoxColumn";
            this.kitapISBNDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapIsmiDataGridViewTextBoxColumn
            // 
            this.kitapIsmiDataGridViewTextBoxColumn.DataPropertyName = "kitapIsmi";
            this.kitapIsmiDataGridViewTextBoxColumn.HeaderText = "kitapIsmi";
            this.kitapIsmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapIsmiDataGridViewTextBoxColumn.Name = "kitapIsmiDataGridViewTextBoxColumn";
            this.kitapIsmiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarDataGridViewTextBoxColumn
            // 
            this.yazarDataGridViewTextBoxColumn.DataPropertyName = "yazar";
            this.yazarDataGridViewTextBoxColumn.HeaderText = "yazar";
            this.yazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarDataGridViewTextBoxColumn.Name = "yazarDataGridViewTextBoxColumn";
            this.yazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayinEviIdDataGridViewTextBoxColumn
            // 
            this.yayinEviIdDataGridViewTextBoxColumn.DataPropertyName = "yayinEviId";
            this.yayinEviIdDataGridViewTextBoxColumn.HeaderText = "yayinEviId";
            this.yayinEviIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayinEviIdDataGridViewTextBoxColumn.Name = "yayinEviIdDataGridViewTextBoxColumn";
            this.yayinEviIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // turIdDataGridViewTextBoxColumn
            // 
            this.turIdDataGridViewTextBoxColumn.DataPropertyName = "turId";
            this.turIdDataGridViewTextBoxColumn.HeaderText = "turId";
            this.turIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turIdDataGridViewTextBoxColumn.Name = "turIdDataGridViewTextBoxColumn";
            this.turIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokIdDataGridViewTextBoxColumn
            // 
            this.stokIdDataGridViewTextBoxColumn.DataPropertyName = "stokId";
            this.stokIdDataGridViewTextBoxColumn.HeaderText = "stokId";
            this.stokIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokIdDataGridViewTextBoxColumn.Name = "stokIdDataGridViewTextBoxColumn";
            this.stokIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapSayfaSayisiDataGridViewTextBoxColumn
            // 
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "kitapSayfaSayisi";
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.HeaderText = "kitapSayfaSayisi";
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.Name = "kitapSayfaSayisiDataGridViewTextBoxColumn";
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapBasinYiliDataGridViewTextBoxColumn
            // 
            this.kitapBasinYiliDataGridViewTextBoxColumn.DataPropertyName = "kitapBasinYili";
            this.kitapBasinYiliDataGridViewTextBoxColumn.HeaderText = "kitapBasinYili";
            this.kitapBasinYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapBasinYiliDataGridViewTextBoxColumn.Name = "kitapBasinYiliDataGridViewTextBoxColumn";
            this.kitapBasinYiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormKitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormKitapListele";
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.FormKitapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUTUPHANEDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kITAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private KUTUPHANEDataSet4 kUTUPHANEDataSet4;
        private System.Windows.Forms.BindingSource kITAPBindingSource;
        private KUTUPHANEDataSet4TableAdapters.KITAPTableAdapter kITAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapISBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEviIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBasinYiliDataGridViewTextBoxColumn;
    }
}