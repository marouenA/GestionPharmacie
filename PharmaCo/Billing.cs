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
    public partial class Billing : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marouen\Documents\PharmaCo.mdf;Integrated Security=True;Connect Timeout=30");
        public void populateCombobox()
        {
            
            String sql = "select * from Medicine_Table;";
            SqlCommand _cmd = new SqlCommand(sql, conn);
            
            SqlDataReader rdr;
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("MedName", typeof(String));
                rdr = _cmd.ExecuteReader();
                dt.Load(rdr);
                this.comboBox1.ValueMember = "MedName";
                this.comboBox1.DataSource = dt;
                conn.Close();
            }
            catch
            {

            }
        }
        int x,unitprice;
        public void fetchQty()
        {
            conn.Open();
            string sql = "select * from Medicine_Table where MedName='" + this.comboBox1.SelectedValue.ToString() + "';";
            SqlCommand _cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(_cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
               x = Convert.ToInt32(dr["Quantity"].ToString());
                unitprice = Convert.ToInt32(dr["SellingPrice"]);
                this.Stock.Text = dr["Quantity"].ToString();
                this.Stock.Visible = true;
                
            }
            conn.Close();
        }
        public void updateMedicine()
        {
            conn.Open();
            int newQuantity = x - Convert.ToInt32(this.Quantity.Text);
            String query = "update Medicine_Table set Quantity='" + newQuantity +  "'where MedName='" + this.comboBox1.SelectedValue.ToString()+ "';";
            SqlCommand _cmd = new SqlCommand(query, conn);

            _cmd.ExecuteNonQuery();
            //MessageBox.Show("Medicine Edited Successfully");
            conn.Close();
        }
        public Billing()
        {
            InitializeComponent();
        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            populateCombobox();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }

        private void Billing_Load_1(object sender, EventArgs e)
        {
            populateCombobox();
        }

        private void Stock_Click(object sender, EventArgs e)
        {

        }
        int GridTotal=0;
        Bitmap bitmap;
        private void Button1_Click(object sender, EventArgs e)
        {
            Panel pan = new Panel();
            this.Controls.Add(pan);
            Graphics graph =pan.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graph);
            graph = Graphics.FromImage(bitmap);
            Point point = PointToScreen(pan.Location);
            graph.CopyFromScreen(point.X, point.Y, 0, 0, size);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if(this.Quantity.Text=="Quantity" || Convert.ToInt32(this.Quantity.Text) > x)
            {
                MessageBox.Show("Please Enter a valide quantity,it must be less than the available stock");
            }else {
                int n = 0, total = Convert.ToInt32(this.Quantity.Text) * unitprice;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(guna2DataGridView1);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = this.comboBox1.SelectedValue.ToString();
                newRow.Cells[2].Value = this.Quantity.Text;
                newRow.Cells[3].Value = unitprice;
                newRow.Cells[4].Value = total;
                this.guna2DataGridView1.Rows.Add(newRow);
                GridTotal = GridTotal + total;
                updateMedicine();
                this.TotalAmountVal.Text = GridTotal.ToString();
                this.TotalAmountVal.Visible = true;
            }
            
        }
    }
}
