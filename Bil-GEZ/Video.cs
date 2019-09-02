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
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void Video_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\baxan\\Desktop\\Şeyh Edebali Türbesi Bilecik.mp4";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Seyhedebalı edebalı = new Seyhedebalı();
            edebalı.Show();
            this.Hide();
        }
    }
}
