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

namespace PharmaCo
{
    public partial class Company : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marouen\Documents\PharmaCo.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            conn.Open();
            String myquery = "select * from Company_Table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, conn);
            SqlCommandBuilder cmd_builder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            // this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        public Company()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try {
                if (this.CompanyID.Text == "" || this.CompanyAdress.Text == "" || this.CompanyName.Text == "" || this.CompanyPhone.Text == "")
                {
                    MessageBox.Show("All Fields Are Required");
                }
                else
                {
                    conn.Open();
                    SqlCommand _cmd = new SqlCommand("insert into Company_Table values('" + this.CompanyID.Text + "','" + this.CompanyName.Text + "','" + this.CompanyAdress.Text + "','" + this.CompanyPhone.Text + "');", conn);
                    _cmd.ExecuteNonQuery();
                    MessageBox.Show("Company Added Successfully");
                    conn.Close();
                    populate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter vallid informations");
            }
            

        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CompanyID.Text = this.guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.CompanyName.Text = this.guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.CompanyAdress.Text = this.guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.CompanyPhone.Text = this.guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "UPDATE Company_Table SET CompanyName=@a,CompanyAdress=@b,CompanyPhone=@c where CompanyId=@f";
            SqlCommand _cmd = new SqlCommand(sql, conn);
            _cmd.Parameters.AddWithValue("a", this.CompanyName.Text);
            _cmd.Parameters.AddWithValue("b", this.CompanyAdress.Text);
            _cmd.Parameters.AddWithValue("c", this.CompanyPhone.Text);
            _cmd.Parameters.AddWithValue("f", this.CompanyID.Text);
            _cmd.ExecuteNonQuery();
            MessageBox.Show("Company Edited Successfully");
            conn.Close();
            populate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand _cmd = new SqlCommand("DELETE FROM Company_Table WHERE CompanyId='" + this.CompanyID.Text + "';", conn);
            _cmd.ExecuteNonQuery();
            MessageBox.Show("this row will be deleted!");
            conn.Close();
            populate();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
