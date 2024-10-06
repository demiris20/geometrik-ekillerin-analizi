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
    public partial class Form1_2 : Form
    {
        public Form1_2()
        {
            InitializeComponent();
        }

        Nokta nokta = new Nokta();
        Cember cember = new Cember();


        private void label1_Click(object sender, EventArgs e)
        {
            //GEREKSİZ
        }

        private void cr_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(cr.Text, out a))
            {
                a = 0;
            }
            cember.R = int.Parse(cr.Text);

        }

        private void cmx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(cmx.Text, out a))
            {
                a = 0;
            }
            cember.x = int.Parse(cmx.Text);
        }

        private void cmy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(cmy.Text, out a))
            {
                a = 0;
            }
            cember.y = int.Parse(cmy.Text);
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
            int deltax = nokta.x - cember.x;
            int deltay = nokta.y - cember.y;

            if (Math.Abs(deltax)< cember.R )
            {
                if (Math.Abs(deltay)< cember.R)
                {
                    int sonuc = (int)MessageBox.Show("Cakışma VAR", "Çarpışma denetleyici");
                }
            }

            else
            {
                int sonuc = (int)MessageBox.Show("Cakışma YOK", "Çarpışma denetleyici");
            }

        }
    }
}
