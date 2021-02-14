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

namespace _Arac_Kiralama
{
    public partial class kaydol : Form
    {
        public kaydol()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-58U3PAJ;Initial Catalog=arac_kiralama;Integrated Security=True");

        private void kaydol_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tc.Text == "" || ad.Text == "" || soyad.Text == "" || kullanıcıadı.Text == "" || sifre.Text == "" || dogumtarihi.Text == "" || telefon.Text == "" || email.Text == "" || adres.Text == "") 
            {
                MessageBox.Show("Lütfen eksik alan bırakmayınız");
            }
            else {
                conn.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO kullanici(tc,ad,soyad,kullanıcı_adı,sifre,dogum_tarihi,telefon,email,adres) VALUES('" + tc.Text + "','" + ad.Text + "','" + soyad.Text + "','" + kullanıcıadı.Text + "' ,'" + sifre.Text + "','" + dogumtarihi.Text + "','" + telefon.Text + "','" + email.Text + "','" + adres.Text + "' )", conn);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yeni kullanıcı Eklendi…");
                conn.Close();                
                this.Hide();
                Login giris = new Login();
                giris.ShowDialog();
            }   
          
           
        }
    
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login giris = new Login();
            giris.ShowDialog();
        }
    }
}
