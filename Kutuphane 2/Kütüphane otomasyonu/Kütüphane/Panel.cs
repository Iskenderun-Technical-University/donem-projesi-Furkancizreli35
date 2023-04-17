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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Load(object sender, EventArgs e)
        {
            eklekullanıcıbtn.Visible = false;
            düzenlekullanıcıbtn.Visible=false;
            silkullanıcıbtn.Visible=false;
        }

        private void kullanıcılarbtn_Click(object sender, EventArgs e)
        {
            if(eklekullanıcıbtn.Visible == false)
            {
                eklekullanıcıbtn.Visible = true;
                düzenlekullanıcıbtn.Visible = true;
                silkullanıcıbtn.Visible = true;
            }
            else
            {
                eklekullanıcıbtn.Visible = false;
                düzenlekullanıcıbtn.Visible = false;
                silkullanıcıbtn.Visible = false;

            }
           
        }
            
       }
    }

