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
            pictureBox1.Height += 10;
            pictureBox1.Width += 10;
        }
    }
}
