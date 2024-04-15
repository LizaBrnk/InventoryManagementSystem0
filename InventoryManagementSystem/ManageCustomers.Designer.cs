namespace InventoryManagementSystem {
    partial class ManageCustomers {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CustomerPhoneTb = new TextBox();
            CustomernameTb = new TextBox();
            Customerid = new TextBox();
            label4 = new Label();
            CustomersGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 125);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(875, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 40);
            label3.TabIndex = 11;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 9);
            label2.Name = "label2";
            label2.Size = new Size(679, 49);
            label2.TabIndex = 1;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(291, 71);
            label1.Name = "label1";
            label1.Size = new Size(340, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            // 
            // CustomerPhoneTb
            // 
            CustomerPhoneTb.BackColor = Color.MistyRose;
            CustomerPhoneTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPhoneTb.ForeColor = Color.Crimson;
            CustomerPhoneTb.Location = new Point(73, 269);
            CustomerPhoneTb.Name = "CustomerPhoneTb";
            CustomerPhoneTb.Size = new Size(245, 38);
            CustomerPhoneTb.TabIndex = 6;
            CustomerPhoneTb.Text = "CustomerPhone";
            // 
            // CustomernameTb
            // 
            CustomernameTb.BackColor = Color.MistyRose;
            CustomernameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CustomernameTb.ForeColor = Color.Crimson;
            CustomernameTb.Location = new Point(73, 225);
            CustomernameTb.Name = "CustomernameTb";
            CustomernameTb.Size = new Size(245, 38);
            CustomernameTb.TabIndex = 5;
            CustomernameTb.Text = "CustomerName";
            // 
            // Customerid
            // 
            Customerid.BackColor = Color.MistyRose;
            Customerid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Customerid.ForeColor = Color.Crimson;
            Customerid.Location = new Point(73, 181);
            Customerid.Name = "Customerid";
            Customerid.Size = new Size(245, 38);
            Customerid.TabIndex = 4;
            Customerid.Text = "CustomerId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(483, 138);
            label4.Name = "label4";
            label4.Size = new Size(276, 40);
            label4.TabIndex = 13;
            label4.Text = "CUSTOMERS LIST";
            // 
            // CustomersGV
            // 
            CustomersGV.BackgroundColor = Color.White;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGV.GridColor = SystemColors.ControlDarkDark;
            CustomersGV.Location = new Point(400, 181);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowHeadersWidth = 51;
            CustomersGV.RowTemplate.Height = 29;
            CustomersGV.Size = new Size(428, 284);
            CustomersGV.TabIndex = 12;
            CustomersGV.CellContentClick += CustomersGV_CellClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(141, 422);
            button4.Name = "button4";
            button4.Size = new Size(102, 43);
            button4.TabIndex = 17;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(244, 352);
            button3.Name = "button3";
            button3.Size = new Size(74, 43);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(162, 352);
            button2.Name = "button2";
            button2.Size = new Size(62, 43);
            button2.TabIndex = 15;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(73, 352);
            button1.Name = "button1";
            button1.Size = new Size(70, 43);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 657);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 20);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(73, 529);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 101);
            panel3.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 20;
            label5.Text = "Orders Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 33);
            label6.Name = "label6";
            label6.Size = new Size(125, 40);
            label6.TabIndex = 20;
            label6.Text = "Orders";
            // 
            // panel4
            // 
            panel4.BackColor = Color.ForestGreen;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(347, 529);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 101);
            panel4.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 33);
            label7.Name = "label7";
            label7.Size = new Size(146, 40);
            label7.TabIndex = 20;
            label7.Text = "Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 23);
            label8.TabIndex = 20;
            label8.Text = "Orders Amount";
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(622, 529);
            panel5.Name = "panel5";
            panel5.Size = new Size(206, 101);
            panel5.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 33);
            label9.Name = "label9";
            label9.Size = new Size(99, 40);
            label9.TabIndex = 20;
            label9.Text = "Date";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(160, 23);
            label10.TabIndex = 20;
            label10.Text = "Last Order Date";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 677);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(CustomersGV);
            Controls.Add(CustomerPhoneTb);
            Controls.Add(CustomernameTb);
            Controls.Add(Customerid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CustomerPhoneTb;
        private TextBox CustomernameTb;
        private TextBox Customerid;
        private Label label4;
        private DataGridView CustomersGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Label label9;
        private Label label10;
    }
}