namespace OtomasyonKutuphane
{
    partial class FormYoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYoneticiGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonYoneticiGiris = new System.Windows.Forms.Button();
            this.textBoxYoneticiSifre = new System.Windows.Forms.TextBox();
            this.lblYoneticiSifre = new System.Windows.Forms.Label();
            this.textBoxYoneticiMail = new System.Windows.Forms.TextBox();
            this.lblYoneticiMail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Size = new System.Drawing.Size(552, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.buttonYoneticiGiris);
            this.groupBox1.Controls.Add(this.textBoxYoneticiSifre);
            this.groupBox1.Controls.Add(this.lblYoneticiSifre);
            this.groupBox1.Controls.Add(this.textBoxYoneticiMail);
            this.groupBox1.Controls.Add(this.lblYoneticiMail);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(55, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonYoneticiGiris
            // 
            this.buttonYoneticiGiris.Location = new System.Drawing.Point(253, 172);
            this.buttonYoneticiGiris.Name = "buttonYoneticiGiris";
            this.buttonYoneticiGiris.Size = new System.Drawing.Size(141, 35);
            this.buttonYoneticiGiris.TabIndex = 23;
            this.buttonYoneticiGiris.Text = "Giriş Yap";
            this.buttonYoneticiGiris.UseVisualStyleBackColor = true;
            this.buttonYoneticiGiris.Click += new System.EventHandler(this.buttonYoneticiGiris_Click);
            // 
            // textBoxYoneticiSifre
            // 
            this.textBoxYoneticiSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiSifre.Location = new System.Drawing.Point(163, 123);
            this.textBoxYoneticiSifre.Name = "textBoxYoneticiSifre";
            this.textBoxYoneticiSifre.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiSifre.TabIndex = 22;
            // 
            // lblYoneticiSifre
            // 
            this.lblYoneticiSifre.AutoSize = true;
            this.lblYoneticiSifre.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiSifre.Location = new System.Drawing.Point(59, 126);
            this.lblYoneticiSifre.Name = "lblYoneticiSifre";
            this.lblYoneticiSifre.Size = new System.Drawing.Size(77, 27);
            this.lblYoneticiSifre.TabIndex = 21;
            this.lblYoneticiSifre.Text = "Şifre:";
            // 
            // textBoxYoneticiMail
            // 
            this.textBoxYoneticiMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYoneticiMail.Location = new System.Drawing.Point(163, 58);
            this.textBoxYoneticiMail.Name = "textBoxYoneticiMail";
            this.textBoxYoneticiMail.Size = new System.Drawing.Size(231, 30);
            this.textBoxYoneticiMail.TabIndex = 20;
            // 
            // lblYoneticiMail
            // 
            this.lblYoneticiMail.AutoSize = true;
            this.lblYoneticiMail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneticiMail.Location = new System.Drawing.Point(24, 58);
            this.lblYoneticiMail.Name = "lblYoneticiMail";
            this.lblYoneticiMail.Size = new System.Drawing.Size(112, 27);
            this.lblYoneticiMail.TabIndex = 19;
            this.lblYoneticiMail.Text = "E-Posta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "Yönetici Giriş Bilgileri";
            // 
            // FormYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormYoneticiGiris";
            this.Text = "Yönetici Girişi";
            this.Load += new System.EventHandler(this.FormYoneticiGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonYoneticiGiris;
        private System.Windows.Forms.TextBox textBoxYoneticiSifre;
        private System.Windows.Forms.Label lblYoneticiSifre;
        private System.Windows.Forms.TextBox textBoxYoneticiMail;
        private System.Windows.Forms.Label lblYoneticiMail;
        private System.Windows.Forms.Label label1;
    }
}