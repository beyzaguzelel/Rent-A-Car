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
    public partial class ödeme : Form
    {
        public ödeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-58U3PAJ;Initial Catalog=arac_kiralama;Integrated Security=True");
        void listele()
        {
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT tc,plaka,faturano,hesap,ödemesekli,toplamücret,kalanücret FROM kiralamabilgileri ", baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
       
        }
        void islem()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int toplam = Convert.ToInt32(lblkasa.Text);
                int x = Convert.ToInt32(dataGridView1.Rows[i].Cells["toplamücret"].Value) - Convert.ToInt32(dataGridView1.Rows[i].Cells["kalanücret"].Value);  
                toplam += x;
                lblkasa.Text = toplam.ToString();
            }  
        }
        private void ayarlar_Load(object sender, EventArgs e)
        {             
            listele();
            islem();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = Convert.ToInt32(lblkasa.Text);
            toplam += Convert.ToInt32(txtmiktar.Text);
            lblkasa.Text = toplam.ToString();

            int a=Convert.ToInt32(dataGridView1.CurrentRow.Cells["kalanücret"].Value);
            int b = Convert.ToInt32(txtmiktar.Text);
            int y = a - b;           

            if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "UPDATE kiralamabilgileri SET kalanücret='" + y.ToString() + "' WHERE faturano='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) + "'";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    listele();
                    MessageBox.Show("Ödeme gerçekleştirildi!");
                }    
        }
    }
}
