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
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True";

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Delete From Araclar where Plaka='" + dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

       
     


        private void cbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarka.SelectedIndex == 0)
            {
                cbxSeri.Items.Clear();

                cbxSeri.Items.Add("A3");
                cbxSeri.Items.Add("A4");
                cbxSeri.Items.Add("Q7");
                cbxSeri.Items.Add("Q8");
                cbxSeri.Items.Add("R8");
            }
            else if (cbxMarka.SelectedIndex == 1)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("320 i");
                cbxSeri.Items.Add("M5");
                cbxSeri.Items.Add("M4");
                cbxSeri.Items.Add("M8");
            }
            else if (cbxMarka.SelectedIndex == 2)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("GLA");
                cbxSeri.Items.Add("GLC");
                cbxSeri.Items.Add("CLS");
                cbxSeri.Items.Add("SL");

            }
            else if (cbxMarka.SelectedIndex == 3)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("Jogger");
                cbxSeri.Items.Add("Duster");
                cbxSeri.Items.Add("Sandero");
            }
            else if (cbxMarka.SelectedIndex == 4)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("Clio");
                cbxSeri.Items.Add("Megan");
                cbxSeri.Items.Add("Talisman");
                cbxSeri.Items.Add("Symbol");
            }
        }
        public void Arac_Listele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Select * From Araclar";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            Arac_Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Update Araclar set Marka =@marka ,Seri =@seri ,Model =@Model,Renk=@renk,Kilometre=@Km,Yakıt=@yakit,Kira_Ücreti=@ücret,Durumu=@durum where Plaka=@Plaka";

            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@seri", cbxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@Km", txtKm.Text);
            komut.Parameters.AddWithValue("@yakit", cbxYakit.SelectedItem);
            komut.Parameters.AddWithValue("@ücret", txtÜcret.Text);
            komut.Parameters.AddWithValue("@durum", cbxDurum.SelectedItem);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Arac_Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbxMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxSeri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cbxYakit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtÜcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cbxDurum.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
           


        }
    }
}
