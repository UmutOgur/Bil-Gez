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
    public partial class HARİTA : Form
    {
        public HARİTA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string sokak = textBox5.Text;
            //string sehir = textBox6.Text;
            //string ilce = textBox7.Text;
            //string postakodu = textBox8.Text;

            //try
            //{
            //    StringBuilder adrres = new StringBuilder();
            //    adrres.Append("http://maps.google.com/maps?q=");
            //    if (sokak != string.Empty)
            //    {
            //        adrres.Append(sokak + "," + "+");
            //    }
            //    if (sehir != string.Empty)
            //    {
            //        adrres.Append(sehir + "," + "+");
            //    }
            //    if (ilce != string.Empty)
            //    {
            //        adrres.Append(ilce + "," + "+");
            //    }
            //    if (postakodu != string.Empty)
            //    {
            //        adrres.Append(postakodu + "," + "+");
            //    }
            //    webBrowser1.Navigate(adrres.ToString());
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message.ToString(), "Hata");
            //}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Seyhedebalı edebali = new Seyhedebalı();
            edebali.Show();
            this.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string sokak = textBox5.Text;
            string sehir = textBox6.Text;
            string ilce = textBox7.Text;
            string postakodu = textBox8.Text;

            try
            {
                StringBuilder adrres = new StringBuilder();
                adrres.Append("http://maps.google.com/maps?q=");
                if (sokak != string.Empty)
                {
                    adrres.Append(sokak + "," + "+");
                }
                if (sehir != string.Empty)
                {
                    adrres.Append(sehir + "," + "+");
                }
                if (ilce != string.Empty)
                {
                    adrres.Append(ilce + "," + "+");
                }
                if (postakodu != string.Empty)
                {
                    adrres.Append(postakodu + "," + "+");
                }
                webBrowser1.Navigate(adrres.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Hata");
            }
        }
    }
}
