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
using static DevExpress.Data.Helpers.ExpressiveSortInfo;

namespace InventoryManagementSystem {
    public partial class ManageOrders : Form {
        public ManageOrders()
        {
            InitializeComponent();
            CustomersGV.CellClick += CustomersGV_CellClick;
            ProductsGV.CellClick += ProductsGV_CellClick;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizab\OneDrive\Документы\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populatecustomer()
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

        void populateproduct()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //CatCombo.ValueMember = "CatName";
                //CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        
        int num = 0;
        int price, totprice, qty;
        string product;

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populatecustomer();
            populateproduct();
            fillcategory();
            //updateproduct();

            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("TotPrice", typeof(int));
        }

        private void CustomersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Перевіряємо, що клік було здійснено по рядку, а не заголовку стовпця
            {
                // Витягуємо значення з клітинок клікнутого рядка
                DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
                CustIdTb.Text = row.Cells[0].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 1) // Перевіряємо, що клік було здійснено по рядку, а не заголовку стовпця
            {
                // Витягуємо значення з клітинок клікнутого рядка
                DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
                CustIdTb.Text = row.Cells[0].Value?.ToString() ?? "";
            }
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        int flag = 0;
        int stock;
        //private int id;
        DataTable table = new DataTable();

        private void ProductsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                //id = Convert.ToInt32(row.Cells[0].Value?.ToString()); // Зберігаємо id вибраного продукту
                product = row.Cells[1].Value?.ToString() ?? "";
                stock = Convert.ToInt32(row.Cells[2].Value?.ToString());
                price = Convert.ToInt32(row.Cells[3].Value?.ToString());
                flag = 1;
            }
            if (e.RowIndex >= 1) // Перевіряємо, що клік було здійснено по рядку, а не заголовку стовпця
            {
                // Витягуємо значення з клітинок клікнутого рядка
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                product = row.Cells[1].Value?.ToString() ?? "";
                stock = Convert.ToInt32(row.Cells[2].Value?.ToString());
                price = Convert.ToInt32(row.Cells[3].Value?.ToString() ?? "");
            }
            if (e.RowIndex >= 2) // Перевіряємо, що клік було здійснено по рядку, а не заголовку стовпця
            {
                // Витягуємо значення з клітинок клікнутого рядка
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                product = row.Cells[1].Value?.ToString() ?? "";
                stock = Convert.ToInt32(row.Cells[2].Value?.ToString());
                price = Convert.ToInt32(row.Cells[3].Value?.ToString() ?? "");
            }
            if (e.RowIndex >= 3) // Перевіряємо, що клік було здійснено по рядку, а не заголовку стовпця
            {
                // Витягуємо значення з клітинок клікнутого рядка
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                product = row.Cells[1].Value?.ToString() ?? "";
                stock = Convert.ToInt32(row.Cells[2].Value?.ToString());
                price = Convert.ToInt32(row.Cells[3].Value?.ToString() ?? "");
            }

            flag = 1;
        }

        /*void updateproduct()
        {
            Con.Open();
            // where ProdId = "+id+"
            //int id = Convert.ToInt32(row.Cells[3].Value?.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            string query = "update ProductTbl set ProdQty = "+newQty+";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            populateproduct();
        }*/

        private int totalSum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("Enter the Quantity of Product");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product");
            }
            else if (Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("No Enough Stock Available");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * price;
                table.Rows.Add(num, product, qty, price, totprice);
                OrderGV.DataSource = table;
                flag = 0;

                totalSum += totprice;
                TotAmount.Text = totalSum.ToString() + " $";
            }
        }
    }
}
