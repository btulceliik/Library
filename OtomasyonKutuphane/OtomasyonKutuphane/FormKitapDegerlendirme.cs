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
    public partial class FormKitapDegerlendirme : Form
    {
        public FormKitapDegerlendirme()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void buttonDegerlendir_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into UYE_DEGERLENDIRME (uyeAd,uyeSoyad,kitapAdi,degerlendirme) values (@e1,@e2,@e3,@e4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@e1", comboBoxUyeAd.Text);
            komut.Parameters.AddWithValue("@e2", comboBoxUyeSoyad.Text);
            komut.Parameters.AddWithValue("@e3", comboBoxKitapAd.Text);
            komut.Parameters.AddWithValue("@e4", richTextBoxDegerlendirme.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Değerlendirmeniz Kaydedilmiştir");

            //Uye Id çekme
            SqlCommand komutt = new SqlCommand("select uyeId from UYE", bgl.baglanti());
            SqlDataReader okuu = komutt.ExecuteReader();
            while (okuu.Read())
            {
                textBoxUyeId.Text = okuu[0].ToString();
            }
            bgl.baglanti().Close();

            //kitapId çekme

            SqlCommand komut2 = new SqlCommand("select kitapISBN from KITAP", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                textBoxKitapISBN.Text = oku2[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void FormKitapDegerlendirme_Load(object sender, EventArgs e)
        {

            SqlCommand komut3 = new SqlCommand("Select uyeAdi From UYE", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                comboBoxUyeAd.Items.Add(oku3[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut22 = new SqlCommand("Select kitapIsmi From KITAP", bgl.baglanti());
            SqlDataReader oku22 = komut22.ExecuteReader();
            while (oku22.Read())
            {
                comboBoxKitapAd.Items.Add(oku22[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut5 = new SqlCommand("Select uyeSoyadi From UYE", bgl.baglanti());
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                comboBoxUyeSoyad.Items.Add(oku5[0].ToString());
            }
            bgl.baglanti().Close();
        }
    }
}
