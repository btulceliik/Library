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
    public partial class FormUyeGiris : Form
    {
        public FormUyeGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUyeGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from UYE where uyeEposta=@p1 and uyeSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxUyeMail.Text);
            komut.Parameters.AddWithValue("@p2", textBoxUyeSifre.Text);
           
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FormEmanet fr = new FormEmanet();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
                textBoxUyeMail.Clear();
                textBoxUyeSifre.Clear();
                textBoxUyeMail.Focus();


            }
            bgl.baglanti().Close();
        }
    }
}
