namespace OtomasyonKutuphane
{
    partial class FormUyeGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUyeMail = new System.Windows.Forms.TextBox();
            this.lblUyeMail = new System.Windows.Forms.Label();
            this.textBoxUyeSifre = new System.Windows.Forms.TextBox();
            this.lblUyeSifre = new System.Windows.Forms.Label();
            this.buttonUyeGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxUyeMail
            // 
            this.textBoxUyeMail.BackColor = System.Drawing.Color.White;
            this.textBoxUyeMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUyeMail.Location = new System.Drawing.Point(189, 116);
            this.textBoxUyeMail.Name = "textBoxUyeMail";
            this.textBoxUyeMail.Size = new System.Drawing.Size(231, 30);
            this.textBoxUyeMail.TabIndex = 11;
            // 
            // lblUyeMail
            // 
            this.lblUyeMail.AutoSize = true;
            this.lblUyeMail.BackColor = System.Drawing.Color.RosyBrown;
            this.lblUyeMail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeMail.Location = new System.Drawing.Point(41, 118);
            this.lblUyeMail.Name = "lblUyeMail";
            this.lblUyeMail.Size = new System.Drawing.Size(111, 27);
            this.lblUyeMail.TabIndex = 9;
            this.lblUyeMail.Text = "E-posta:";
            // 
            // textBoxUyeSifre
            // 
            this.textBoxUyeSifre.BackColor = System.Drawing.Color.White;
            this.textBoxUyeSifre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUyeSifre.Location = new System.Drawing.Point(189, 185);
            this.textBoxUyeSifre.Name = "textBoxUyeSifre";
            this.textBoxUyeSifre.Size = new System.Drawing.Size(231, 30);
            this.textBoxUyeSifre.TabIndex = 17;
            // 
            // lblUyeSifre
            // 
            this.lblUyeSifre.AutoSize = true;
            this.lblUyeSifre.BackColor = System.Drawing.Color.RosyBrown;
            this.lblUyeSifre.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeSifre.Location = new System.Drawing.Point(75, 188);
            this.lblUyeSifre.Name = "lblUyeSifre";
            this.lblUyeSifre.Size = new System.Drawing.Size(77, 27);
            this.lblUyeSifre.TabIndex = 16;
            this.lblUyeSifre.Text = "Şifre:";
            // 
            // buttonUyeGiris
            // 
            this.buttonUyeGiris.BackColor = System.Drawing.Color.White;
            this.buttonUyeGiris.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUyeGiris.Location = new System.Drawing.Point(283, 241);
            this.buttonUyeGiris.Name = "buttonUyeGiris";
            this.buttonUyeGiris.Size = new System.Drawing.Size(137, 38);
            this.buttonUyeGiris.TabIndex = 18;
            this.buttonUyeGiris.Text = "Giriş Yap";
            this.buttonUyeGiris.UseVisualStyleBackColor = false;
            this.buttonUyeGiris.Click += new System.EventHandler(this.buttonUyeGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Üye Giriş Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.buttonUyeGiris);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxUyeSifre);
            this.groupBox2.Controls.Add(this.lblUyeSifre);
            this.groupBox2.Controls.Add(this.textBoxUyeMail);
            this.groupBox2.Controls.Add(this.lblUyeMail);
            this.groupBox2.Location = new System.Drawing.Point(73, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 325);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // FormUyeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormUyeGiris";
            this.Text = "Üye Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUyeMail;
        private System.Windows.Forms.Label lblUyeMail;
        private System.Windows.Forms.TextBox textBoxUyeSifre;
        private System.Windows.Forms.Label lblUyeSifre;
        private System.Windows.Forms.Button buttonUyeGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}