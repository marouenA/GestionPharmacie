using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCo
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Medicines m = new Medicines();
            m.Show();
            this.Hide();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
            this.Hide();
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            Billing bil = new Billing();
            bil.Show();
            this.Hide();
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            Company com = new Company();
            com.Show();
            this.Hide();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
