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
    public partial class Medicines : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marouen\Documents\PharmaCo.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            conn.Open();
            String myquery = "select * from Medicine_Table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(myquery, conn);
            SqlCommandBuilder cmd_builder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        public Medicines()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try {

                conn.Open();
                SqlCommand _cmd = new SqlCommand("insert into Medicine_Table values('" + this.MedName.Text + "','" + this.BuyingPrice.Text + "','" + this.SellingPrice.Text + "','" + this.Quantity.Text + "','" + this.ExpirationDate.Text + "','" + this.Company.SelectedItem.ToString() + "')", conn);
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Added successfully");
                conn.Close();
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Valide Informations");
            }
            
        }
        public void populateCombobox()
        {

            String sql = "select * from Company_Table;";
            SqlCommand _cmd = new SqlCommand(sql, conn);

            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CompanyName", typeof(String));
                rdr = _cmd.ExecuteReader();
                dt.Load(rdr);
                this.Company.ValueMember = "CompanyName";
                this.Company.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }
        private void Medicines_Load(object sender, EventArgs e)
        {
            populate();
            populateCombobox();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "update Medicine_Table set BuyingPrice='"+this.BuyingPrice.Text+"',SellingPrice='"+this.SellingPrice.Text+"',Quantity='"+this.Quantity.Text+"',ExpirationDate='"+this.ExpirationDate.Text+"',Company='"+this.Company.SelectedItem.ToString()+"'where MedName='" +this.MedName.Text+ "';";
            SqlCommand _cmd = new SqlCommand(query, conn);
           
            _cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Edited Successfully");
            conn.Close();
            populate();
        }

        private void BunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MedName.Text = this.guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.BuyingPrice.Text = this.guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.SellingPrice.Text = this.guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.Quantity.Text = this.guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MedName.Text = this.guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.BuyingPrice.Text = this.guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.SellingPrice.Text = this.guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.Quantity.Text = this.guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MedName.Text == "MedecineName")
            {
                MessageBox.Show("Please click on the medecine you want to delete", "warning");
            }
            else
            {
                String query = "delete  from Medicine_Table where MedName=@a";
                conn.Open();
                SqlCommand _cmd = new SqlCommand(query, conn);
                _cmd.Parameters.AddWithValue("a", MedName.Text);
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine deleted");
                conn.Close();
                populate();
            }
        }
        private void MedecineName_enter(object sender, EventArgs e)
        {
            if (this.MedName.Text == "MedecineName")
            {
                this.MedName.Text = "";
            }
        }

        private void MedecineNmae_leave(object sender, EventArgs e)
        {
            if (this.MedName.Text == "")
            {
                this.MedName.Text = "MedecineName";
            }
        }

        private void BuyingPrice_Enter(object sender, EventArgs e)
        {
            if (this.BuyingPrice.Text == "BuyingPrice")
            {
                this.BuyingPrice.Text = "";
            }
        }

        private void BuyingPrice_leave(object sender, EventArgs e)
        {
            if (this.BuyingPrice.Text == "")
            {
                this.BuyingPrice.Text = "BuyingPrice";
            }
        }

        private void SellingPrice_Enter(object sender, EventArgs e)
        {
            if (this.SellingPrice.Text == "SellingPrice")
            {
                this.SellingPrice.Text = "";
            }
        }

        private void SellingPrice_leave(object sender, EventArgs e)
        {
            if (this.SellingPrice.Text == "")
            {
                this.SellingPrice.Text = "SellingPrice";
            }
        }

        private void Quantity_Enter(object sender, EventArgs e)
        {
            if (this.Quantity.Text == "Quantity")
            {
                this.Quantity.Text = "";
            }
        }

        private void Quantity_leave(object sender, EventArgs e)
        {
            if (this.Quantity.Text == "")
            {
                this.Quantity.Text = "Quantity";
            }
        }

        private void BunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Company_SelectedIndexChanged(object sender, EventArgs e)
        {

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
