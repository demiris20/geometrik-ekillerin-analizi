using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPPROJE
{
    public partial class Form1_6 : Form
    {
        public Form1_6()
        {
            InitializeComponent();
        }

        Kure kure = new Kure();
        Nokta nokta = new Nokta();
        private void kr_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(kr.Text, out a))
            {
                a = 0;
            }
            kure.R= int.Parse(kr.Text);
        }

        private void kmx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(kmx.Text, out a))
            {
                a = 0;
            }
            kure.x= int.Parse(kmx.Text);
        }

        private void kmy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(kmy.Text, out a))
            {
                a = 0;
            }
            kure.y = int.Parse(kmy.Text);
        }

        private void kmz_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(kmz.Text, out a))
            {
                a = 0;
            }
            kure.z = int.Parse(kmz.Text);
        }

        private void nmx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(nmx.Text, out a))
            {
                a = 0;
            }
            nokta.x = int.Parse(nmx.Text);
        }

        private void nmy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(nmy.Text, out a))
            {
                a = 0;
            }
            nokta.y = int.Parse(nmy.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deltax = nokta.x - kure.x;
            int deltay = nokta.y - kure.y;
            int deltaz = nokta.z - kure.z;


            if (Math.Abs(deltax) < kure.R)
            {
                if (Math.Abs(deltay) < kure.R)
                {
                    if (Math.Abs(deltaz) < kure.R)
                    {
                        int sonuc = (int)MessageBox.Show("Cakışma VAR", "Çarpışma denetleyici");
                    }
                }
            }

            else
            {
                int sonuc = (int)MessageBox.Show("Cakışma YOK", "Çarpışma denetleyici");
            }


        }
    }
}
