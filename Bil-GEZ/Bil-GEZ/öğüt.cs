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
    public partial class öğüt : Form
    {
        public öğüt()
        {
            InitializeComponent();
        }

        private void öğüt_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\baxan\\Desktop\\Şeyh Edebali’nin Osman Beye Nasihati  Osmancık.mp4";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Seyhedebalı ebali = new Seyhedebalı();
            ebali.Show();
            this.Hide();
        }
    }
}
