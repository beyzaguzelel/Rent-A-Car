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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-58U3PAJ;Initial Catalog=arac_kiralama;Integrated Security=True");

        public static string kadi;
        private void btngiriş_Click(object sender, EventArgs e)
        {
            kadi = txtkullanıcı.Text;
            string parola = txtsifre.Text;

            conn.Open();
            SqlCommand komut = new SqlCommand("SELECT  *  FROM kullanici WHERE kullanıcı_adı='" + kadi + "' AND sifre='" + parola + "' ", conn);
            SqlDataReader oku = komut.ExecuteReader();

             if (oku.Read())
            {
                this.Hide();
                anasayfa islem = new anasayfa();
                islem.ShowDialog();
            }
    
            else
            {            
                MessageBox.Show("Hatalı giriş yaptınız");
                txtkullanıcı.Clear();
                txtsifre.Clear();
                txtkullanıcı.Focus();
            }
            conn.Close();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtkullanıcı.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblkaydol_Click(object sender, EventArgs e)
        {
            this.Hide();
            kaydol kayıt = new kaydol();
            kayıt.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
