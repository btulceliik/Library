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
    public partial class FormUyeKayit : Form
    {
        public FormUyeKayit()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUyeKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into UYE (uyeAdi,uyeSoyadi,uyeSifre,uyeTel,uyeYas,uyeEposta,uyeDogumTarihi,uyeAdresID) values (@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@s1", textBoxUyeAd.Text);
            komutkaydet.Parameters.AddWithValue("@s2", textBoxUyeSoyad.Text);
            komutkaydet.Parameters.AddWithValue("@s3", textBoxUyeSifre.Text);
            komutkaydet.Parameters.AddWithValue("@s4", maskedTextBoxUyeTelefon.Text);
            komutkaydet.Parameters.AddWithValue("@s5", comboBoxUyeYas.Text);
            komutkaydet.Parameters.AddWithValue("@s6", textBoxUyeMail.Text);
            komutkaydet.Parameters.AddWithValue("@s7", dateTimePickerUyeDogumTarihi.Text);
            komutkaydet.Parameters.AddWithValue("@s8", textBoxUyeİl.Text);
            komutkaydet.ExecuteNonQuery();

           

            SqlCommand komutkaydetadres = new SqlCommand("insert into UYE_ADRES(adresIl,adresIlce,adresMahalle,adresSokak) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydetadres.Parameters.AddWithValue("@p1", textBoxUyeİl.Text);
            komutkaydetadres.Parameters.AddWithValue("@p2", textBoxUyeİlce.Text);
            komutkaydetadres.Parameters.AddWithValue("@p3", textBoxUyeMahalle.Text);
            komutkaydetadres.Parameters.AddWithValue("@p4", textBoxUyeSokak.Text);
            komutkaydetadres.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Üye Başarıyla Kaydedildi.");
        }

        private void lblUyeAdres_Click(object sender, EventArgs e)
        {

        }

       
    }
}
