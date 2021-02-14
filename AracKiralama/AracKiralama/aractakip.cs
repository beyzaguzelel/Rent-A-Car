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
    public partial class aractakip : Form
    {
        public aractakip()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-58U3PAJ;Initial Catalog=arac_kiralama;Integrated Security=True");
        void listele()
        {
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT plaka,marka,model,km,ad,soyad,alıştarihi,dönüştarihi FROM kiralamabilgileri WHERE aracdurumu='kiralanmış' ", baglanti);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void aractakip_Load(object sender, EventArgs e)
        {
            listele();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Count(*) FROM arac", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lblfilo.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter da = new SqlDataAdapter("SELECT Count(aracdurumu) FROM kiralamabilgileri WHERE aracdurumu='kiralanmış'", baglanti);
            DataTable dtable = new DataTable();
            da.Fill(dtable);
            lbldolu.Text = dtable.Rows[0][0].ToString();

            lblboş.Text = (Convert.ToInt32(lblfilo.Text) - Convert.ToInt32(lbldolu.Text)).ToString();
        }
        private void button1_Click(object sender, EventArgs e)//arac teslim al
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE arac SET aracdurum='müsait 'WHERE plaka='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                SqlCommand kmt = new SqlCommand();
                kmt.Connection = baglanti;
                kmt.CommandText = "UPDATE arac SET km='"+txtkm.Text+"'  WHERE plaka='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();

                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE kiralamabilgileri SET aracdurumu='müsait'  WHERE plaka='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                komut.ExecuteNonQuery();
                komut.Dispose();

                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(item);
                }

                baglanti.Close();
                MessageBox.Show("Araç teslim alındı!");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {               
                DateTime d1 = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dönüştarihi"].Value);
                DateTime d2 = DateTime.Now;
                TimeSpan ts = d1 - d2;
                if (ts.Days <= 3)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Salmon;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}