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
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }


        private void simpleButton1_MouseClick(object sender, MouseEventArgs e)
        {
            Giriş frm1 = new Giriş();
            frm1.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            merkezform mrkzfrm = new merkezform();
            mrkzfrm.Show();
            this.Hide();
        }
    }
}
