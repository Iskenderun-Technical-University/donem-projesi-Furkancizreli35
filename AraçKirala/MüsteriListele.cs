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
    public partial class MüsteriListele : Form
    {
        public MüsteriListele()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True";
        private void MüsteriListele_Load(object sender, EventArgs e)
        {
            Musteri_Listele();
        }
        public void Musteri_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Musteriler";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da= new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tcnoo.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            adsoyadd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Musteriler set Musteri_AdSoyad =@adsoyad ,Musteri_TelNo =@Telno ,Musteri_Mail =@mail,Musteri_Adres=@adres Where Musteri_TC=@Tc";

            SqlCommand komut = new SqlCommand(komutCumlesi,baglanti);
            komut.Parameters.AddWithValue("@Tc",tcnoo.Text);
            komut.Parameters.AddWithValue("@adsoyad", adsoyadd.Text);
            komut.Parameters.AddWithValue("@Telno", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi ="Delete From Musteriler where Musteri_TC='" + dataGridView1.CurrentRow.Cells["Musteri_TC"].Value.ToString()+"'";
            SqlCommand komut = new SqlCommand(komutCumlesi,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Musteri_Listele();
        }
    }
}
