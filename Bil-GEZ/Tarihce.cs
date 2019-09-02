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
    public partial class Tarihce : Form
    {
        public Tarihce()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Seyhedebalı edebalı = new Seyhedebalı();
            edebalı.Show();
            this.Hide();
        }
    }
}
