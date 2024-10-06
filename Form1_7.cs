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
    public partial class Form1_7 : Form
    {
        public Form1_7()
        {
            InitializeComponent();
        }

        DikdortgenP dikdortgenP = new DikdortgenP();    
        Nokta nokta = new Nokta();
        private void dpen_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dpen.Text, out a))
            {
                a = 0;
            }
            dikdortgenP.En = int.Parse(dpen.Text);
        }

        private void dpboy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dpboy.Text, out a))
            {
                a = 0;
            }
            dikdortgenP.Boy = int.Parse(dpboy.Text);
        }
        private void dph_TextChanged(object sender, EventArgs e)
        {

            int a;
            if (!int.TryParse(dph.Text, out a))
            {
                a = 0;
            }
            dikdortgenP.H = int.Parse(dph.Text);

        }


        private void dpmx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dpmx.Text, out a))
            {
                a = 0;
            }
            dikdortgenP.x = int.Parse(dpmx.Text);
        }

        private void dpmy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dpmy.Text, out a))
            {
                a = 0;
            }
            dikdortgenP.y = int.Parse(dpmy.Text);
        }

        private void dpmz_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dpmz.Text, out a))
            {
                a = 0;
            }
            dikdortgenP.z = int.Parse(dpmz.Text);
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

            if (dikdortgenP.x - (dikdortgenP.En / 2) <= nokta.x && nokta.x <= dikdortgenP.x + (dikdortgenP.En / 2))
            {

                if (dikdortgenP.y - (dikdortgenP.Boy / 2) <= nokta.y && nokta.y <= dikdortgenP.y + (dikdortgenP.Boy / 2))
                {

                    if (dikdortgenP.z - (dikdortgenP.H / 2) <= nokta.z && nokta.z <= dikdortgenP.z + (dikdortgenP.H / 2))
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
