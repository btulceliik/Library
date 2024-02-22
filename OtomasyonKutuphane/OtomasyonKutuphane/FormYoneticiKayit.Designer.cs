namespace OtomasyonKutuphane
{
    partial class FormYoneticiKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYoneticiKayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.buttonYoneticiKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
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
            this.groupBox1.Location = new System.Drawing.Point(71, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 413);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Bilgileri";
            // 
            // textBoxYoneticiSifre
            // 
            this.textBoxYoneticiSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiSifre.Location = new System.Drawing.Point(202, 333);
            this.textBoxYoneticiSifre.Name = "textBoxYoneticiSifre";
            this.textBoxYoneticiSifre.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiSifre.TabIndex = 18;
            // 
            // lblYoneticiSifre
            // 
            this.lblYoneticiSifre.AutoSize = true;
            this.lblYoneticiSifre.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiSifre.Location = new System.Drawing.Point(98, 336);
            this.lblYoneticiSifre.Name = "lblYoneticiSifre";
            this.lblYoneticiSifre.Size = new System.Drawing.Size(77, 27);
            this.lblYoneticiSifre.TabIndex = 17;
            this.lblYoneticiSifre.Text = "Şifre:";
            // 
            // maskedTextBoxYoneticiTelefon
            // 
            this.maskedTextBoxYoneticiTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxYoneticiTelefon.Location = new System.Drawing.Point(202, 199);
            this.maskedTextBoxYoneticiTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxYoneticiTelefon.Name = "maskedTextBoxYoneticiTelefon";
            this.maskedTextBoxYoneticiTelefon.Size = new System.Drawing.Size(231, 30);
            this.maskedTextBoxYoneticiTelefon.TabIndex = 15;
            // 
            // lblYoneticiTelefon
            // 
            this.lblYoneticiTelefon.AutoSize = true;
            this.lblYoneticiTelefon.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiTelefon.Location = new System.Drawing.Point(25, 200);
            this.lblYoneticiTelefon.Name = "lblYoneticiTelefon";
            this.lblYoneticiTelefon.Size = new System.Drawing.Size(150, 27);
            this.lblYoneticiTelefon.TabIndex = 13;
            this.lblYoneticiTelefon.Text = "Telefon No:";
            // 
            // textBoxYoneticiMail
            // 
            this.textBoxYoneticiMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiMail.Location = new System.Drawing.Point(202, 268);
            this.textBoxYoneticiMail.Name = "textBoxYoneticiMail";
            this.textBoxYoneticiMail.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiMail.TabIndex = 16;
            // 
            // lblYoneticiMail
            // 
            this.lblYoneticiMail.AutoSize = true;
            this.lblYoneticiMail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiMail.Location = new System.Drawing.Point(63, 268);
            this.lblYoneticiMail.Name = "lblYoneticiMail";
            this.lblYoneticiMail.Size = new System.Drawing.Size(112, 27);
            this.lblYoneticiMail.TabIndex = 14;
            this.lblYoneticiMail.Text = "E-Posta:";
            // 
            // textBoxYoneticiSoyad
            // 
            this.textBoxYoneticiSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiSoyad.Location = new System.Drawing.Point(202, 137);
            this.textBoxYoneticiSoyad.Name = "textBoxYoneticiSoyad";
            this.textBoxYoneticiSoyad.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiSoyad.TabIndex = 12;
            // 
            // textBoxYoneticiAd
            // 
            this.textBoxYoneticiAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiAd.Location = new System.Drawing.Point(202, 68);
            this.textBoxYoneticiAd.Name = "textBoxYoneticiAd";
            this.textBoxYoneticiAd.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiAd.TabIndex = 11;
            // 
            // lblYoneticiAd
            // 
            this.lblYoneticiAd.AutoSize = true;
            this.lblYoneticiAd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiAd.Location = new System.Drawing.Point(115, 71);
            this.lblYoneticiAd.Name = "lblYoneticiAd";
            this.lblYoneticiAd.Size = new System.Drawing.Size(60, 27);
            this.lblYoneticiAd.TabIndex = 9;
            this.lblYoneticiAd.Text = "Adı:";
            // 
            // lblYoneticiSoyad
            // 
            this.lblYoneticiSoyad.AutoSize = true;
            this.lblYoneticiSoyad.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiSoyad.Location = new System.Drawing.Point(75, 137);
            this.lblYoneticiSoyad.Name = "lblYoneticiSoyad";
            this.lblYoneticiSoyad.Size = new System.Drawing.Size(100, 27);
            this.lblYoneticiSoyad.TabIndex = 10;
            this.lblYoneticiSoyad.Text = "Soyadı:";
            // 
            // buttonYoneticiKaydet
            // 
            this.buttonYoneticiKaydet.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYoneticiKaydet.Location = new System.Drawing.Point(419, 484);
            this.buttonYoneticiKaydet.Name = "buttonYoneticiKaydet";
            this.buttonYoneticiKaydet.Size = new System.Drawing.Size(132, 55);
            this.buttonYoneticiKaydet.TabIndex = 2;
            this.buttonYoneticiKaydet.Text = "Kaydet";
            this.buttonYoneticiKaydet.UseVisualStyleBackColor = true;
            this.buttonYoneticiKaydet.Click += new System.EventHandler(this.buttonYoneticiKaydet_Click);
            // 
            // FormYoneticiKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 565);
            this.Controls.Add(this.buttonYoneticiKaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormYoneticiKayit";
            this.Text = "Yönetici Kayıt Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxYoneticiSoyad;
        private System.Windows.Forms.TextBox textBoxYoneticiAd;
        private System.Windows.Forms.Label lblYoneticiAd;
        private System.Windows.Forms.Label lblYoneticiSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYoneticiTelefon;
        private System.Windows.Forms.Label lblYoneticiTelefon;
        private System.Windows.Forms.TextBox textBoxYoneticiMail;
        private System.Windows.Forms.Label lblYoneticiMail;
        private System.Windows.Forms.TextBox textBoxYoneticiSifre;
        private System.Windows.Forms.Label lblYoneticiSifre;
        private System.Windows.Forms.Button buttonYoneticiKaydet;
    }
}