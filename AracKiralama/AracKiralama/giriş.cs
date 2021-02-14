using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Arac_Kiralama
{
    public partial class giriş : Form
    {
        public giriş()
        {
            InitializeComponent();
        }
        private void giriş_Load(object sender, EventArgs e)
        {
            
        }
        int baslamanoktasi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            baslamanoktasi += 1;
            progressBar1.Value = baslamanoktasi;
                if(progressBar1.Value == 35)
                {
                    progressBar1.Value = 0;
                    timer1.Stop();
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }

        }
    }
}
