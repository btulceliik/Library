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
    public partial class FormYoneticiGiris : Form
    {
        public FormYoneticiGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonYoneticiGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from YONETICI where yoneticiMail=@p1 and yoneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxYoneticiMail.Text);
            komut.Parameters.AddWithValue("@p2", textBoxYoneticiSifre.Text);

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FormKitapKayit fr = new FormKitapKayit();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
                textBoxYoneticiMail.Clear();
                textBoxYoneticiSifre.Clear();
                textBoxYoneticiMail.Focus();


            }
            bgl.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormYoneticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
