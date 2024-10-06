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
    public partial class Form1_5 : Form
    {
        public Form1_5()
        {
            InitializeComponent();
        }

        Cember cember1 = new Cember();
        Cember cember2 = new Cember();
        private void c1r_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(c1r.Text, out a))
            {
                a = 0;
            }
            cember1.R = int.Parse(c1r.Text);
        }

        private void c1mx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(c1mx.Text, out a))
            {
                a = 0;
            }
            cember1.x = int.Parse(c1mx.Text);
        }

        private void c1my_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(c1my.Text, out a))
            {
                a = 0;
            }
            cember1.y = int.Parse(c1my.Text);
        }

        private void c2r_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(c2r.Text, out a))
            {
                a = 0;
            }
            cember2.R = int.Parse(c2r.Text);
        }

        private void c2mx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(c2mx.Text, out a))
            {
                a = 0;
            }
            cember2.x = int.Parse(c2mx.Text);
        }

        private void c2my_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(c2my.Text, out a))
            {
                a = 0;
            }
            cember2.y = int.Parse(c2my.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deltax = cember1.x - cember2.x;
            int deltay = cember1.y - cember2.y;

            double hipo = Math.Sqrt(Math.Abs(deltax) * Math.Abs(deltax) + Math.Abs(deltay) * Math.Abs(deltay));
            if (hipo < cember1.R + cember2.R)
            {
                int sonuc = (int)MessageBox.Show("Cakışma VAR", "Çarpışma denetleyici");
            }
            else
            {
                int sonuc = (int)MessageBox.Show("Cakışma YOK", "Çarpışma denetleyici");
            }
        }
    }
}
