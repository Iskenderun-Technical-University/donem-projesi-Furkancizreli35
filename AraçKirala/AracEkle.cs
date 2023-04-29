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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }

        private string baglantiCumlesi = @"Data Source=localhost;Initial Catalog=AracKiralama;Integrated Security=True";

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutCumlesi = "Insert Into Araclar values (@Plaka,@Marka,@Seri,@Model,@Renk,@Kilometre,@Yakit,@Ucret,@Durum)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);

            komut.Parameters.AddWithValue("@Plaka",txtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka",cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@Seri",cbxSeri.SelectedItem);
            komut.Parameters.AddWithValue("@Model",txtModel.Text);
            komut.Parameters.AddWithValue("@Renk",txtRenk.Text);
            komut.Parameters.AddWithValue("@Kilometre",txtKm.Text);
            komut.Parameters.AddWithValue("@Yakit",cbxYakit.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret",txtÜcret.Text);
            komut.Parameters.AddWithValue("@Durum",cbxDurum.SelectedItem);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Araç Kaydedildi");
        }

        private void cbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxMarka.SelectedIndex == 0)
            {
                cbxSeri.Items.Clear();

                cbxSeri.Items.Add("A3");
                cbxSeri.Items.Add("A4");
                cbxSeri.Items.Add("Q7");
                cbxSeri.Items.Add("Q8");
                cbxSeri.Items.Add("R8");
            }
            else if(cbxMarka.SelectedIndex == 1)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("320 i");
                cbxSeri.Items.Add("M5");
                cbxSeri.Items.Add("M4");
                cbxSeri.Items.Add("M8");
            }
            else if(cbxMarka.SelectedIndex ==2)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("GLA");
                cbxSeri.Items.Add("GLC");
                cbxSeri.Items.Add("CLS");
                cbxSeri.Items.Add("SL");

            }
            else if(cbxMarka.SelectedIndex ==3 )
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("Jogger");
                cbxSeri.Items.Add("Duster");
                cbxSeri.Items.Add("Sandero");
            }
            else if(cbxMarka.SelectedIndex == 4)
            {
                cbxSeri.Items.Clear();
                cbxSeri.Text = "";
                cbxSeri.Items.Add("Clio");
                cbxSeri.Items.Add("Megan");
                cbxSeri.Items.Add("Talisman");
                cbxSeri.Items.Add("Symbol");
            } 
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
