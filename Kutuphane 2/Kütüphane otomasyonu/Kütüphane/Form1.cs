using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class Form1 : Form
    {

    public Form1()
        {
            InitializeComponent();
        }

        private void personelgirisbtn_Click(object sender, EventArgs e)
        {
            string gelenad = adgiristxt.Text;
            string gelensifre = sifregiristxt.Text;
            

            if(gelenad.Equals("furkan.cizreli")&& gelensifre.Equals("123"))
            {
                MessageBox.Show("Giriş Başarılı");
                Panel p = new Panel();
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");

            }

        }
            
        }        
            
        }
    

