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
    public partial class ViewOrders : Form {
        public ViewOrders()
        {
            InitializeComponent();
            //OrdersGV.CellClick += OrdersGV.CellClick;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizab\OneDrive\Документы\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void populateorders()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateorders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrdersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = OrdersGV.Rows[e.RowIndex];

                if (selectedRow != null && !selectedRow.IsNewRow)
                {
                    string orderId = selectedRow.Cells["OrderId"].Value.ToString();
                    string customerId = selectedRow.Cells["CustId"].Value.ToString();
                    string customerName = selectedRow.Cells["CustName"].Value.ToString();
                    string orderDate = selectedRow.Cells["OrderDate"].Value.ToString();
                    string totalAmount = selectedRow.Cells["TotalAmt"].Value.ToString();
                    printDocument1_OrderId = orderId;
                    printDocument1_CustomerId = customerId;
                    printDocument1_CustomerName = customerName;
                    printDocument1_OrderDate = orderDate;
                    printDocument1_TotAmt = totalAmount;

                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
            }
        }

        private string printDocument1_OrderId;
        private string printDocument1_CustomerId;
        private string printDocument1_CustomerName;
        private string printDocument1_OrderDate;
        private string printDocument1_TotAmt;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Малюємо текст
            e.Graphics.DrawString("Order Summary", new Font("Century", 30, FontStyle.Bold), Brushes.Red, new Point(255,70));
            e.Graphics.DrawString("Order ID: " + printDocument1_OrderId, new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 180));
            e.Graphics.DrawString("Customer ID: " + printDocument1_CustomerId, new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 230));
            e.Graphics.DrawString("Customer Name: " + printDocument1_CustomerName, new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 280));
            e.Graphics.DrawString("Order Date: " + printDocument1_OrderDate, new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 330));
            e.Graphics.DrawString("Total Amount (in $): " + printDocument1_TotAmt, new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 380));
            e.Graphics.DrawString("Powered By IMS", new Font("Century", 30, FontStyle.Bold), Brushes.Red, new Point(400, 700));
        }
    }
}
