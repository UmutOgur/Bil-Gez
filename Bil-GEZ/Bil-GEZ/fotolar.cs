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
    public partial class fotolar : Form
    {
        public fotolar()
        {
            InitializeComponent();
        }

        private void fotolar_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Seyhedebalı edebali = new Seyhedebalı();
            edebali.Show();
            this.Hide();
        }
    }
}
