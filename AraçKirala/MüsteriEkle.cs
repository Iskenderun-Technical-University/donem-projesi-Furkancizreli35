using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKirala
{
    public partial class MüsteriEkle : Form
    {
        public MüsteriEkle()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True";


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MüsteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Musteriler Values (@TcNo,@AdSoyad,@TelefonNo,@Mail,@Adres)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@TcNo", tcnoo.Text);
            komut.Parameters.AddWithValue("@AdSoyad", adsoyadd.Text);
            komut.Parameters.AddWithValue("@TelefonNo", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");


        }
    }
}
