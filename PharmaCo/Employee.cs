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
    public partial class Employee : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marouen\Documents\PharmaCo.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            conn.Open();
            String myquery = "select * from Employee_Table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, conn);
            SqlCommandBuilder cmd_builder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
           // this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        public Employee()
        {
            InitializeComponent();
        }

        private void BuyingPrice_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void MedName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try {
                if (this.EmployeeID.Text == "" || this.EmployeeAge.Text == "" || this.EmployeeName.Text == "" || this.EmployeePhone.Text == "" || this.EmployeeSalary.Text == "")
                {
                    MessageBox.Show("All Fields Are Required");
                }
                else
                {
                    conn.Open();
                    SqlCommand _cmd = new SqlCommand("insert into Employee_Table values('" + this.EmployeeID.Text + "','" + this.EmployeeName.Text + "','" + this.EmployeeAge.Text + "','" + this.EmployeeSalary.Text + "','" + this.EmployeePhone.Text + "','" + this.EmployeeGender.SelectedItem.ToString() + "');", conn);
                    _cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Successfully");
                    conn.Close();
                    populate();
                }
            }
            catch (Exception) { MessageBox.Show("Enter valid information"); }
            
            
        }

        private void EmployeeAge_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
            this.EmployeeGender.SelectedIndex = 0;
        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EmployeeID.Text = this.guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.EmployeeName.Text = this.guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.EmployeeAge.Text= this.guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.EmployeeSalary.Text = this.guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.EmployeePhone.Text = this.guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           //this.EmployeeGender.SelectedItem= this.guna2DataGridView1.SelectedRows[0].Cells[5];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "UPDATE Employee_Table SET EmpName=@a,EmpAge=@b,EmpSalary=@c,EmpPhone=@d,EmpGender=@e where EmpId=@f";
            SqlCommand _cmd = new SqlCommand(sql, conn);
            _cmd.Parameters.AddWithValue("a", this.EmployeeName.Text);
            _cmd.Parameters.AddWithValue("b", this.EmployeeAge.Text);
            _cmd.Parameters.AddWithValue("c", this.EmployeeSalary.Text);
            _cmd.Parameters.AddWithValue("d", this.EmployeePhone.Text);
            _cmd.Parameters.AddWithValue("e", this.EmployeeGender.SelectedItem.ToString());
            _cmd.Parameters.AddWithValue("f", this.EmployeeID.Text);
            _cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Edited Successfully");
            conn.Close();
            populate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand _cmd = new SqlCommand("DELETE FROM Employee_Table WHERE EmpId='" + this.EmployeeID.Text + "';", conn);
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
    }
}
