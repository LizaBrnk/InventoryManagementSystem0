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

namespace InventoryManagementSystem {
    public partial class ManageUsers : Form {
        public ManageUsers()
        {
            InitializeComponent();
            UsersGV.CellClick += UsersGV_CellClick;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizab\OneDrive\Документы\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + unameTb.Text + "', '" + FnameTb.Text + "', '" + PasswordTb.Text + "', '" + PhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Enter the Users Phone Number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where UPhone = '" + PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void UsersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Перевіряємо, що клік було здійснено по рядку, а не заголовку стовпця
            {
                // Витягуємо значення з клітинок клікнутого рядка
                DataGridViewRow row = UsersGV.Rows[e.RowIndex];
                unameTb.Text = row.Cells[0].Value?.ToString() ?? "";
                FnameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                PasswordTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PhoneTb.Text = row.Cells[3].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 1)
            {
                DataGridViewRow row = UsersGV.Rows[e.RowIndex];
                unameTb.Text = row.Cells[0].Value?.ToString() ?? "";
                FnameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                PasswordTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PhoneTb.Text = row.Cells[3].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 2)
            {
                DataGridViewRow row = UsersGV.Rows[e.RowIndex];
                unameTb.Text = row.Cells[0].Value?.ToString() ?? "";
                FnameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                PasswordTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PhoneTb.Text = row.Cells[3].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 3)
            {
                DataGridViewRow row = UsersGV.Rows[e.RowIndex];
                unameTb.Text = row.Cells[0].Value?.ToString() ?? "";
                FnameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                PasswordTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PhoneTb.Text = row.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname='" + unameTb.Text + "', Ufullname='" + FnameTb.Text + "', Upassword='" + PasswordTb.Text + "' where UPhone='" + PhoneTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }

        }
    }
}
