using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPPROJE
{
    public partial class Form1_16 : Form
    {
        public Form1_16()
        {
            InitializeComponent();
        }
        DikdortgenP dikdortgenP1 = new DikdortgenP();
        DikdortgenP dikdortgenP2 = new DikdortgenP();
        private void dp1en_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp1en.Text, out a))
            {
                a = 0;
            }
            dikdortgenP1.En = int.Parse(dp1en.Text);
        }

        private void dp1boy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp1boy.Text, out a))
            {
                a = 0;
            }
            dikdortgenP1.Boy = int.Parse(dp1boy.Text);
        }

        private void dp1h_TextChanged(object sender, EventArgs e)
        {


            int a;
            if (!int.TryParse(dp1h.Text, out a))
            {
                a = 0;
            }
            dikdortgenP1.H = int.Parse(dp1h.Text);
        }

        private void dp1mx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp1mx.Text, out a))
            {
                a = 0;
            }
            dikdortgenP1.x = int.Parse(dp1mx.Text);
        }

        private void dp1my_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp1my.Text, out a))
            {
                a = 0;
            }
            dikdortgenP1.y = int.Parse(dp1my.Text);
        }

        private void dp1mz_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp1mz.Text, out a))
            {
                a = 0;
            }
            dikdortgenP1.z = int.Parse(dp1mz.Text);
        }

        private void dp2en_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp2en.Text, out a))
            {
                a = 0;
            }
            dikdortgenP2.En = int.Parse(dp2en.Text);
        }

        private void dp2boy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp2boy.Text, out a))
            {
                a = 0;
            }
            dikdortgenP2.Boy = int.Parse(dp2boy.Text);
        }

        private void dp2h_TextChanged(object sender, EventArgs e)
        {


            int a;
            if (!int.TryParse(dp2h.Text, out a))
            {
                a = 0;
            }
            dikdortgenP2.H = int.Parse(dp2h.Text);


        }

        private void dp2mx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp2mx.Text, out a))
            {
                a = 0;
            }
            dikdortgenP2.x = int.Parse(dp2mx.Text);
        }

        private void dp2my_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp2my.Text, out a))
            {
                a = 0;
            }
            dikdortgenP2.y = int.Parse(dp2my.Text);
        }

        private void dp2mz_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dp2mz.Text, out a))
            {
                a = 0;
            }
            dikdortgenP2.z = int.Parse(dp2mz.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int deltax = dikdortgenP1.x - dikdortgenP2.x;
            int deltay = dikdortgenP1.y - dikdortgenP2.y;
            int deltaz = dikdortgenP1.z - dikdortgenP2.z;
            if (Math.Abs(deltax) < dikdortgenP1.En / 2 + dikdortgenP2.En / 2)
            {
                if (Math.Abs(deltay) < dikdortgenP1.Boy / 2 + dikdortgenP2.Boy / 2)
                {
                    if (Math.Abs(deltaz) < dikdortgenP1.H / 2 + dikdortgenP2.H / 2)
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
