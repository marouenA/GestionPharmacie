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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            home hom = new home();
            if (this.bunifuMaterialTextbox1.Text=="admin" && this.bunifuMaterialTextbox2.Text == "0000")
            {
                hom.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Please check username or password");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
