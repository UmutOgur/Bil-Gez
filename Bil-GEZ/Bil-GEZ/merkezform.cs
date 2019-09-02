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
    public partial class merkezform : Form
    {
        public merkezform()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Anaform anafrm = new Anaform();
            anafrm.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Seyhedebalı edablı = new Seyhedebalı();
            edablı.Show();
            this.Hide();
        }
    }
}
