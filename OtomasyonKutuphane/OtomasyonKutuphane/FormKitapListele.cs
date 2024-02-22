using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonKutuphane
{
    public partial class FormKitapListele : Form
    {
        public FormKitapListele()
        {
            InitializeComponent();
        }

        private void FormKitapListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kUTUPHANEDataSet4.KITAP' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kITAPTableAdapter.Fill(this.kUTUPHANEDataSet4.KITAP);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmanet fr = new FormEmanet();
            fr.Show();
        }
    }
}
