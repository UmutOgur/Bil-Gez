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
    public partial class Kullanıcılar : Form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
        }
        SqlConnection Baglantı = new SqlConnection("Data Source=DESKTOP-T2GKN5C\\SQLEXPRESS;Initial Catalog=Bil-Gez;Integrated Security=True");
        private void SqlBagşanti()
        {
            Baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from Kullanıcılar", Baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

               
                ekle.Text = oku["KullanıcıAdSoyad"].ToString();
                ekle.SubItems.Add(oku["KullanıcıŞifre"].ToString());
                

                listView1.Items.Add(ekle);


            }
            Baglantı.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlBagşanti();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Baglantı.Open();
            SqlCommand komut = new SqlCommand("Insert into Kullanıcılar (KullanıcıAdSoyad,KullanıcıŞifre) Values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')", Baglantı);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Oluşturulmuştur.");
            Giriş grş = new Giriş();
            grş.Show();
            this.Hide();
            Baglantı.Close();
            //SqlBagşanti();
        }
    }
}
