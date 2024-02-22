namespace OtomasyonKutuphane
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUyeGirisi = new System.Windows.Forms.Button();
            this.buttonUyeGuncelleme = new System.Windows.Forms.Button();
            this.buttonUyeEkleme = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonYoneticiGuncelleme = new System.Windows.Forms.Button();
            this.buttonYoneticiEkleme = new System.Windows.Forms.Button();
            this.buttonYoneticiGiris = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKitapListele = new System.Windows.Forms.Button();
            this.buttonKitapGuncelle = new System.Windows.Forms.Button();
            this.buttonKitapKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonKitapOdunc = new System.Windows.Forms.Button();
            this.buttonKitapDegerlendir = new System.Windows.Forms.Button();
            this.buttonKitapIade = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 775);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonUyeGirisi);
            this.groupBox1.Controls.Add(this.buttonUyeGuncelleme);
            this.groupBox1.Controls.Add(this.buttonUyeEkleme);
            this.groupBox1.Location = new System.Drawing.Point(69, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üye";
            // 
            // buttonUyeGirisi
            // 
            this.buttonUyeGirisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUyeGirisi.Location = new System.Drawing.Point(60, 80);
            this.buttonUyeGirisi.Name = "buttonUyeGirisi";
            this.buttonUyeGirisi.Size = new System.Drawing.Size(225, 41);
            this.buttonUyeGirisi.TabIndex = 2;
            this.buttonUyeGirisi.Text = "Giriş Yap";
            this.buttonUyeGirisi.UseVisualStyleBackColor = true;
            this.buttonUyeGirisi.Click += new System.EventHandler(this.buttonUyeGirisi_Click);
            // 
            // buttonUyeGuncelleme
            // 
            this.buttonUyeGuncelleme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUyeGuncelleme.Location = new System.Drawing.Point(60, 207);
            this.buttonUyeGuncelleme.Name = "buttonUyeGuncelleme";
            this.buttonUyeGuncelleme.Size = new System.Drawing.Size(225, 41);
            this.buttonUyeGuncelleme.TabIndex = 1;
            this.buttonUyeGuncelleme.Text = "Güncelle";
            this.buttonUyeGuncelleme.UseVisualStyleBackColor = true;
            this.buttonUyeGuncelleme.Click += new System.EventHandler(this.buttonUyeGuncelleme_Click);
            // 
            // buttonUyeEkleme
            // 
            this.buttonUyeEkleme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUyeEkleme.Location = new System.Drawing.Point(60, 144);
            this.buttonUyeEkleme.Name = "buttonUyeEkleme";
            this.buttonUyeEkleme.Size = new System.Drawing.Size(225, 41);
            this.buttonUyeEkleme.TabIndex = 0;
            this.buttonUyeEkleme.Text = "Kayıt Ol";
            this.buttonUyeEkleme.UseVisualStyleBackColor = true;
            this.buttonUyeEkleme.Click += new System.EventHandler(this.buttonUyeEkleme_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonYoneticiGuncelleme);
            this.groupBox2.Controls.Add(this.buttonYoneticiEkleme);
            this.groupBox2.Controls.Add(this.buttonYoneticiGiris);
            this.groupBox2.Location = new System.Drawing.Point(476, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 267);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(127, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yönetici";
            // 
            // buttonYoneticiGuncelleme
            // 
            this.buttonYoneticiGuncelleme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYoneticiGuncelleme.Location = new System.Drawing.Point(65, 207);
            this.buttonYoneticiGuncelleme.Name = "buttonYoneticiGuncelleme";
            this.buttonYoneticiGuncelleme.Size = new System.Drawing.Size(225, 41);
            this.buttonYoneticiGuncelleme.TabIndex = 5;
            this.buttonYoneticiGuncelleme.Text = "Güncelle";
            this.buttonYoneticiGuncelleme.UseVisualStyleBackColor = true;
            this.buttonYoneticiGuncelleme.Click += new System.EventHandler(this.buttonYoneticiGuncelleme_Click);
            // 
            // buttonYoneticiEkleme
            // 
            this.buttonYoneticiEkleme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYoneticiEkleme.Location = new System.Drawing.Point(65, 144);
            this.buttonYoneticiEkleme.Name = "buttonYoneticiEkleme";
            this.buttonYoneticiEkleme.Size = new System.Drawing.Size(225, 41);
            this.buttonYoneticiEkleme.TabIndex = 4;
            this.buttonYoneticiEkleme.Text = "Kayıt Ol";
            this.buttonYoneticiEkleme.UseVisualStyleBackColor = true;
            this.buttonYoneticiEkleme.Click += new System.EventHandler(this.buttonYoneticiEkleme_Click);
            // 
            // buttonYoneticiGiris
            // 
            this.buttonYoneticiGiris.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYoneticiGiris.Location = new System.Drawing.Point(65, 80);
            this.buttonYoneticiGiris.Name = "buttonYoneticiGiris";
            this.buttonYoneticiGiris.Size = new System.Drawing.Size(225, 41);
            this.buttonYoneticiGiris.TabIndex = 3;
            this.buttonYoneticiGiris.Text = "Giriş Yap";
            this.buttonYoneticiGiris.UseVisualStyleBackColor = true;
            this.buttonYoneticiGiris.Click += new System.EventHandler(this.buttonYoneticiGiris_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.buttonKitapListele);
            this.groupBox3.Controls.Add(this.buttonKitapGuncelle);
            this.groupBox3.Controls.Add(this.buttonKitapKaydet);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(69, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 267);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // buttonKitapListele
            // 
            this.buttonKitapListele.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapListele.Location = new System.Drawing.Point(60, 83);
            this.buttonKitapListele.Name = "buttonKitapListele";
            this.buttonKitapListele.Size = new System.Drawing.Size(225, 41);
            this.buttonKitapListele.TabIndex = 7;
            this.buttonKitapListele.Text = "Listele";
            this.buttonKitapListele.UseVisualStyleBackColor = true;
            this.buttonKitapListele.Click += new System.EventHandler(this.buttonKitapListele_Click);
            // 
            // buttonKitapGuncelle
            // 
            this.buttonKitapGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapGuncelle.Location = new System.Drawing.Point(60, 210);
            this.buttonKitapGuncelle.Name = "buttonKitapGuncelle";
            this.buttonKitapGuncelle.Size = new System.Drawing.Size(225, 41);
            this.buttonKitapGuncelle.TabIndex = 6;
            this.buttonKitapGuncelle.Text = "Güncelle";
            this.buttonKitapGuncelle.UseVisualStyleBackColor = true;
            this.buttonKitapGuncelle.Click += new System.EventHandler(this.buttonKitapGuncelle_Click);
            // 
            // buttonKitapKaydet
            // 
            this.buttonKitapKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapKaydet.Location = new System.Drawing.Point(60, 147);
            this.buttonKitapKaydet.Name = "buttonKitapKaydet";
            this.buttonKitapKaydet.Size = new System.Drawing.Size(225, 41);
            this.buttonKitapKaydet.TabIndex = 5;
            this.buttonKitapKaydet.Text = "Kaydet";
            this.buttonKitapKaydet.UseVisualStyleBackColor = true;
            this.buttonKitapKaydet.Click += new System.EventHandler(this.buttonKitapKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(140, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kitap";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox4.Controls.Add(this.buttonKitapOdunc);
            this.groupBox4.Controls.Add(this.buttonKitapDegerlendir);
            this.groupBox4.Controls.Add(this.buttonKitapIade);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(476, 457);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 267);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // buttonKitapOdunc
            // 
            this.buttonKitapOdunc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapOdunc.Location = new System.Drawing.Point(65, 83);
            this.buttonKitapOdunc.Name = "buttonKitapOdunc";
            this.buttonKitapOdunc.Size = new System.Drawing.Size(225, 41);
            this.buttonKitapOdunc.TabIndex = 11;
            this.buttonKitapOdunc.Text = "Ödünç Al";
            this.buttonKitapOdunc.UseVisualStyleBackColor = true;
            this.buttonKitapOdunc.Click += new System.EventHandler(this.buttonKitapOdunc_Click);
            // 
            // buttonKitapDegerlendir
            // 
            this.buttonKitapDegerlendir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapDegerlendir.Location = new System.Drawing.Point(65, 210);
            this.buttonKitapDegerlendir.Name = "buttonKitapDegerlendir";
            this.buttonKitapDegerlendir.Size = new System.Drawing.Size(225, 41);
            this.buttonKitapDegerlendir.TabIndex = 10;
            this.buttonKitapDegerlendir.Text = "Değerlendir";
            this.buttonKitapDegerlendir.UseVisualStyleBackColor = true;
            this.buttonKitapDegerlendir.Click += new System.EventHandler(this.buttonKitapDegerlendir_Click);
            // 
            // buttonKitapIade
            // 
            this.buttonKitapIade.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKitapIade.Location = new System.Drawing.Point(65, 147);
            this.buttonKitapIade.Name = "buttonKitapIade";
            this.buttonKitapIade.Size = new System.Drawing.Size(225, 41);
            this.buttonKitapIade.TabIndex = 9;
            this.buttonKitapIade.Text = "İade Et";
            this.buttonKitapIade.UseVisualStyleBackColor = true;
            this.buttonKitapIade.Click += new System.EventHandler(this.buttonKitapIade_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(126, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "İşlemler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(218, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(444, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Erzurum Halk Kütüphanesi";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 775);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AnaForm";
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUyeGirisi;
        private System.Windows.Forms.Button buttonUyeGuncelleme;
        private System.Windows.Forms.Button buttonUyeEkleme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonYoneticiEkleme;
        private System.Windows.Forms.Button buttonYoneticiGiris;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonYoneticiGuncelleme;
        private System.Windows.Forms.Button buttonKitapListele;
        private System.Windows.Forms.Button buttonKitapGuncelle;
        private System.Windows.Forms.Button buttonKitapKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKitapOdunc;
        private System.Windows.Forms.Button buttonKitapDegerlendir;
        private System.Windows.Forms.Button buttonKitapIade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

