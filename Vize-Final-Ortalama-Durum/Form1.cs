using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Final_Ortalama_Durum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int vize, final, ortalama, durum;

            vize = Convert.ToInt32(txtVize.Text);
            final = Convert.ToInt32(txtFinal.Text);
            
            ortalama = (vize * 40 / 100) + (final * 60 / 100);
            lblOrtalama.Text = "Ortalama: " + ortalama;
            

            if (final>=50 && ortalama>=50)
            {
                lblDurum.Text = "Geçtiniz.";
            }

            else 
            {
                lblDurum.Text = "Kaldınız.";
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOrtalama.Text = "Ortalama: 0";
            lblDurum.Text = "Durum: 0";
        }
    }
}
