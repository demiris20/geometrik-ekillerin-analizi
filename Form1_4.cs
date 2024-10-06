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
    public partial class Form1_4 : Form
    {
        public Form1_4()
        {
            InitializeComponent();
        }
         Cember cember = new Cember();
        Dikdortgen dikdortgen = new Dikdortgen();

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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
