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
    public partial class ManageProducts : Form {
        public ManageProducts()
        {
            InitializeComponent();
            ProductsGV.CellClick += ProductsGV_CellClick;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizab\OneDrive\Документы\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
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
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void filterbycategory()
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + ProdIdTb.Text + "', '" + ProdNameTb.Text + "', '" + QtyTb.Text + "', '" + PriceTb.Text + "', '" + DescriptionTb.Text + "', '" + CatCombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Enter the Product Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTbl where ProdId = " + ProdIdTb.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void ProductsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Перевіряємо, що клік було здійснено по рядку, а не заголовку стовпця
            {
                // Витягуємо значення з клітинок клікнутого рядка
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                ProdIdTb.Text = row.Cells[0].Value?.ToString() ?? "";
                ProdNameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                QtyTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PriceTb.Text = row.Cells[3].Value?.ToString() ?? "";
                DescriptionTb.Text = row.Cells[4].Value?.ToString() ?? "";
                CatCombo.SelectedValue = row.Cells[5].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 1)
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                ProdIdTb.Text = row.Cells[0].Value?.ToString() ?? "";
                ProdNameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                QtyTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PriceTb.Text = row.Cells[3].Value?.ToString() ?? "";
                DescriptionTb.Text = row.Cells[4].Value?.ToString() ?? "";
                CatCombo.SelectedValue = row.Cells[5].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 2)
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                ProdIdTb.Text = row.Cells[0].Value?.ToString() ?? "";
                ProdNameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                QtyTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PriceTb.Text = row.Cells[3].Value?.ToString() ?? "";
                DescriptionTb.Text = row.Cells[4].Value?.ToString() ?? "";
                CatCombo.SelectedValue = row.Cells[5].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 3)
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                ProdIdTb.Text = row.Cells[0].Value?.ToString() ?? "";
                ProdNameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                QtyTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PriceTb.Text = row.Cells[3].Value?.ToString() ?? "";
                DescriptionTb.Text = row.Cells[4].Value?.ToString() ?? "";
                CatCombo.SelectedValue = row.Cells[5].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 4)
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                ProdIdTb.Text = row.Cells[0].Value?.ToString() ?? "";
                ProdNameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                QtyTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PriceTb.Text = row.Cells[3].Value?.ToString() ?? "";
                DescriptionTb.Text = row.Cells[4].Value?.ToString() ?? "";
                CatCombo.SelectedValue = row.Cells[5].Value?.ToString() ?? "";
            }

            if (e.RowIndex >= 5)
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                ProdIdTb.Text = row.Cells[0].Value?.ToString() ?? "";
                ProdNameTb.Text = row.Cells[1].Value?.ToString() ?? "";
                QtyTb.Text = row.Cells[2].Value?.ToString() ?? "";
                PriceTb.Text = row.Cells[3].Value?.ToString() ?? "";
                DescriptionTb.Text = row.Cells[4].Value?.ToString() ?? "";
                CatCombo.SelectedValue = row.Cells[5].Value?.ToString() ?? "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdName='" + ProdNameTb.Text + "', ProdQty='" + QtyTb.Text + "', ProdPrice='" + PriceTb.Text + "', ProdDescr='" + DescriptionTb.Text + "', ProdCat='" + CatCombo.SelectedValue.ToString() + "' where ProdId=" + ProdIdTb.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
