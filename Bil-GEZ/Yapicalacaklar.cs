using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil_GEZ
{
    public partial class Yapicalacaklar : Form
    {
        public Yapicalacaklar()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Seyhedebalı edebali = new Seyhedebalı();

            edebali.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Height += 50;
            pictureBox1.Width += 50;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Height += 80;
            pictureBox1.Width += 80;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Height -= 80;
            pictureBox1.Width -= 80;
        }
                

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox2.Height += 80;
            pictureBox2.Width += 80;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Height -= 80;
            pictureBox2.Width -= 80;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Height += 80;
            pictureBox3.Width += 80;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Width -= 80;
            pictureBox3.Height -= 80;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Height += 80;
            pictureBox4.Width += 80;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Height -= 80;
            pictureBox4.Width -= 80;
        }
    }
}
