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
    public partial class Form1_3 : Form
    {
        public Form1_3()
        {
            InitializeComponent();
        }
        Dikdortgen dikdortgen1 = new Dikdortgen();
        Dikdortgen dikdortgen2 = new Dikdortgen();

        private void d1en_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(d1en.Text, out a))
            {
                a = 0;
            }
            dikdortgen1.En = int.Parse(d1en.Text);

        }

        private void d1boy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(d1boy.Text, out a))
            {
                a = 0;
            }
            dikdortgen1.Boy = int.Parse(d1boy.Text);

        }

        private void d1mx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(d1mx.Text, out a))
            {
                a = 0;
            }
            dikdortgen1.x = int.Parse(d1mx.Text);

        }

        private void d1my_TextChanged(object sender, EventArgs e)
        {

            int a;
            if (!int.TryParse(d1my.Text, out a))
            {
                a = 0;
            }
            dikdortgen1.y = int.Parse(d1my.Text);

        }

        private void d2en_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(d2en.Text, out a))
            {
                a = 0;
            }
            dikdortgen2.En = int.Parse(d2en.Text);

        }

        private void d2boy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(d2en.Text, out a))
            {
                a = 0;
            }
            dikdortgen2.Boy = int.Parse(d2en.Text);

        }

        private void d2mx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(d2mx.Text, out a))
            {
                a = 0;
            }
            dikdortgen2.x = int.Parse(d2mx.Text);
        }

        private void d2my_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(d2my.Text, out a))
            {
                a = 0;
            }
            dikdortgen2.y = int.Parse(d2my.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int deltax = dikdortgen1.x - dikdortgen2.x;
            int deltay = dikdortgen1.y - dikdortgen2.y;
            if (Math.Abs(deltax) < dikdortgen1.En/2 + dikdortgen2.En / 2  )
            {
                if (Math.Abs(deltay) < dikdortgen1.Boy/2 + dikdortgen2.Boy/2)
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
