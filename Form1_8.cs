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
    public partial class Form1_8 : Form
    {
        public Form1_8()
        {
            InitializeComponent();
        }
        Nokta nokta = new Nokta();
      Silindir silindir = new Silindir();
        private void sr_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(sr.Text, out a))
            {
                a = 0;
            }
            silindir.R = int.Parse(sr.Text);
        }

        private void sh_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(sh.Text, out a))
            {
                a = 0;
            }
            silindir.H = int.Parse(sh.Text);
        }

        private void smx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(smx.Text, out a))
            {
                a = 0;
            }
            silindir.x = int.Parse(smx.Text);
        }

        private void smy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(smy.Text, out a))
            {
                a = 0;
            }
            silindir.y = int.Parse(smy.Text);
        }

        private void smz_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(smz.Text, out a))
            {
                a = 0;
            }
            silindir.z= int.Parse(smz.Text);
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

        private void nmz_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(nmz.Text, out a))
            {
                a = 0;
            }
            nokta.z = int.Parse(nmz.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int deltax = nokta.x - silindir.x;
            int deltay = nokta.y - silindir.y;

            if (Math.Abs(deltax) < silindir.R)
            {
                if (Math.Abs(deltay) < silindir.R)
                {
                    if (silindir.z - (silindir.H / 2) <= nokta.x && nokta.x <= silindir.z + (silindir.H / 2)) {
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
