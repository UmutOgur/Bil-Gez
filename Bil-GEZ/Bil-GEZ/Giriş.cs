using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Bil_GEZ
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        SqlConnection Baglantı = new SqlConnection("Data Source=DESKTOP-T2GKN5C\\SQLEXPRESS;Initial Catalog=Bil-Gez;Integrated Security=True");

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanıcılar where KullanıcıAdSoyad='" + kllncıtxt.Text + "' and  KullanıcıŞifre='" + sifretxt.Text + "'", Baglantı);

            SqlDataReader dr = komut.ExecuteReader();


            if (dr.Read())
            {
                Anaform anaform = new Anaform();
                anaform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");

            }
            Baglantı.Close();

        }
        private void Getir()
        {
            Baglantı.Open();
            SqlCommand komut = new SqlCommand("select  ");
        }
        private void simpleButton3_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Kullanıcılar kullanıclarfrm = new Kullanıcılar();
            kullanıclarfrm.Show();
            this.Hide();
        }
    }
}
