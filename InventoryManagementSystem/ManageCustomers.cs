using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem {
    public partial class ManageCustomers : Form {
        public ManageCustomers()
        {
            InitializeComponent();
            CustomersGV.CellClick += CustomersGV_CellClick;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizab\OneDrive\Документы\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + Customerid.Text + "', '" + CustomernameTb.Text + "', '" + CustomerPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Customerid.Text == "")
            {
                MessageBox.Show("Enter the Customer Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTbl where CustId = '" + Customerid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void CustomersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Перевіряємо, що клік було здійснено по рядку, а не заголовку стовпця
            {
                // Витягуємо значення з клітинок клікнутого рядка
                DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
                Customerid.Text = row.Cells[0].Value?.ToString() ?? "";
                CustomernameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                CustomerPhoneTb.Text = row.Cells[2].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 1)
            {
                DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
                Customerid.Text = row.Cells[0].Value?.ToString() ?? "";
                CustomernameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                CustomerPhoneTb.Text = row.Cells[2].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 2)
            {
                DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
                Customerid.Text = row.Cells[0].Value?.ToString() ?? "";
                CustomernameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                CustomerPhoneTb.Text = row.Cells[2].Value?.ToString() ?? "";
            }

            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTbl where CustId = "+Customerid.Text+"", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderLabel.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmt) from OrderTbl where CustId = " + Customerid.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from OrderTbl where CustId = " + Customerid.Text + "", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DateLabel.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName='" + CustomernameTb.Text + "', CustPhone='" + CustomerPhoneTb.Text + "' where CustId='" + Customerid.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
