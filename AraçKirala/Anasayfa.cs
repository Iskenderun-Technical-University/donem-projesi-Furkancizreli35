﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKirala
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MüsteriEkle musterieklefrm =new MüsteriEkle();
            musterieklefrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MüsteriListele musterilistelefrm = new MüsteriListele();
            musterilistelefrm.Show();

        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle araceklefrm =new AracEkle();
            araceklefrm.Show();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracListele araclistelefrm = new AracListele();
            araclistelefrm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
