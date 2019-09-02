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
    public partial class Seyhedebalı : Form
    {
        public Seyhedebalı()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            merkezform mrkzfrm = new merkezform();
            mrkzfrm.Show();
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HARİTA harita = new HARİTA();
            harita.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Tarihce trh = new Tarihce();
            trh.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Yapicalacaklar ypl = new Yapicalacaklar();
            ypl.Show();
            this.Hide();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            HARİTA harita = new HARİTA();
            harita.Show();
            this.Hide();
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            fotolar fto = new fotolar();
            fto.Show();
            this.Hide();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Video vdo = new Video();
            vdo.Show();
            this.Hide();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            öğüt ogt = new öğüt();
            ogt.Show();
            this.Hide();
        }
    }
}
