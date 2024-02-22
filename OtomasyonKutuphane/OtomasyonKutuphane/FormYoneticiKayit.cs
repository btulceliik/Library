using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtomasyonKutuphane
{
    public partial class FormYoneticiKayit : Form
    {
        public FormYoneticiKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void buttonYoneticiKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into YONETICI (yoneticiAdi,yoneticiSoyadi,yoneticiSifre,yoneticiMail,yoneticiTelefon) values (@s1,@s2,@s3,@s4,@s5)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@s1", textBoxYoneticiAd.Text);
            komutkaydet.Parameters.AddWithValue("@s2", textBoxYoneticiSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@s3", textBoxYoneticiSifre.Text);
            komutkaydet.Parameters.AddWithValue("@s4", textBoxYoneticiMail.Text);
            komutkaydet.Parameters.AddWithValue("@s5", maskedTextBoxYoneticiTelefon.Text);
            komutkaydet.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Üye Başarıyla Kaydedildi.");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
