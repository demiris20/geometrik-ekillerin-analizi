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
    public partial class Form1_15 : Form
    {
        public Form1_15()
        {
            InitializeComponent();
        }
        DikdortgenP dikdortgenP = new DikdortgenP();
        Kure kure = new Kure();
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

        private void kr_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(kr.Text, out a))
            {
                a = 0;
            }
            kure.R = int.Parse(kr.Text);
        }

        private void kmx_TextChanged(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(kmx.Text, out a))
            {
                a = 0;
            }
            kure.x = int.Parse(kmx.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
