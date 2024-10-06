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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private int kkontrol1(int a)
        {
            if (a == 750)
            {
                return -2;
            }
            else
            {
                return 2;
            }
        }

        private int kkontrol2(int b)
        {
            if (b == 550)
            {
                return -2;
            }
            else
            {
                return 2;
            }


        }
        int karara = +2;
        int kararb = +2;



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left == 750 || pictureBox1.Left == 0)
            {
                karara = kkontrol1(pictureBox1.Location.X);
            }

            if (pictureBox1.Top == 550 || pictureBox1.Top == 0)
            {
                kararb = kkontrol1(pictureBox1.Location.Y);
            }


            pictureBox1.Left = pictureBox1.Left + karara;
            pictureBox1.Top = pictureBox1.Top + kararb;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private int sonuca(int x)
        {
            if (x == 0)
            {
                return 2;
            }

            else
            {
                return -2;
            }
        }

        private int sonucb(int y)
        {
            if (y == 0)
            {
                return 1;
            }

            else
            {
                return -1;
            }
        }

        int karara1 = 1;
        int karary1 = 1;

        int karara2 = 1;
        int karary2 = 1;

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
