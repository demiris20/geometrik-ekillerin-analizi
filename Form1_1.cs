using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NDPPROJE
{
    public partial class Form1_1 : Form
    {

        
        public Form1_1()
        {
            InitializeComponent();
        }

        Dikdortgen dikdortgen = new Dikdortgen();
        Nokta nokta = new Nokta();

        private void den_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(den.Text, out a))
            {
                a = 0;
            }
            dikdortgen.En = int.Parse(den.Text);


        }

        private void dboy_TextChanged(object sender, EventArgs e)
        {


            int a;
            if (!int.TryParse(dboy.Text, out a))
            {
                a = 0;
            }
            dikdortgen.Boy = int.Parse(dboy.Text);


        }

        private void dmx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dmx.Text, out a))
            {
                a = 0;
            }
            dikdortgen.x = int.Parse(dmx.Text);

        }

        private void dmy_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(dmy.Text, out a))
            {
                a = 0;
            }
            dikdortgen.y = int.Parse(dmy.Text);

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
            if (dikdortgen.x - (dikdortgen.En / 2) <= nokta.x && nokta.x <= dikdortgen.x + (dikdortgen.En / 2))
            {

                if (dikdortgen.y - (dikdortgen.Boy / 2) <= nokta.y && nokta.y <= dikdortgen.y + (dikdortgen.Boy / 2))
                {
                    int sonuc = (int)MessageBox.Show("Cakışma VAR", "Çarpışma denetleyici");

                }

            }

            else
            {
                int sonuc = (int)MessageBox.Show("Cakışma YOK", "Çarpışma denetleyici");
            }
        }

        private void Form1_1_Load(object sender, EventArgs e)
        {

        }
    }
}

