﻿namespace InventoryManagementSystem {
    partial class ManageOrders {
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
            panel2 = new Panel();
            label4 = new Label();
            CustomersGV = new DataGridView();
            OrderIdTb = new TextBox();
            CustIdTb = new TextBox();
            OrderDate = new DateTimePicker();
            label5 = new Label();
            SearchCombo = new ComboBox();
            ProductsGV = new DataGridView();
            QtyTb = new TextBox();
            label6 = new Label();
            button1 = new Button();
            OrderGV = new DataGridView();
            CustName = new TextBox();
            label7 = new Label();
            TotAmount = new Label();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
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
            panel1.Size = new Size(1278, 125);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1240, 0);
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
            label2.Location = new Point(306, 9);
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
            label1.Location = new Point(523, 58);
            label1.Name = "label1";
            label1.Size = new Size(277, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 700);
            panel2.Name = "panel2";
            panel2.Size = new Size(1278, 10);
            panel2.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(135, 140);
            label4.Name = "label4";
            label4.Size = new Size(194, 27);
            label4.TabIndex = 32;
            label4.Text = "CUSTOMERS LIST";
            // 
            // CustomersGV
            // 
            CustomersGV.BackgroundColor = Color.White;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGV.GridColor = SystemColors.ControlDarkDark;
            CustomersGV.Location = new Point(14, 170);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowHeadersWidth = 51;
            CustomersGV.RowTemplate.Height = 29;
            CustomersGV.Size = new Size(428, 206);
            CustomersGV.TabIndex = 33;
            CustomersGV.CellContentClick += CustomersGV_CellClick;
            // 
            // OrderIdTb
            // 
            OrderIdTb.BackColor = Color.MistyRose;
            OrderIdTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            OrderIdTb.ForeColor = Color.Crimson;
            OrderIdTb.Location = new Point(14, 426);
            OrderIdTb.Name = "OrderIdTb";
            OrderIdTb.Size = new Size(194, 38);
            OrderIdTb.TabIndex = 34;
            // 
            // CustIdTb
            // 
            CustIdTb.BackColor = Color.MistyRose;
            CustIdTb.Enabled = false;
            CustIdTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CustIdTb.ForeColor = Color.Crimson;
            CustIdTb.Location = new Point(16, 470);
            CustIdTb.Name = "CustIdTb";
            CustIdTb.Size = new Size(194, 38);
            CustIdTb.TabIndex = 35;
            CustIdTb.Text = "CustomerId";
            // 
            // OrderDate
            // 
            OrderDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            OrderDate.Format = DateTimePickerFormat.Short;
            OrderDate.Location = new Point(16, 583);
            OrderDate.MaxDate = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            OrderDate.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(194, 30);
            OrderDate.TabIndex = 36;
            OrderDate.Value = new DateTime(2024, 4, 21, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(14, 555);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 37;
            label5.Text = "Order Date:";
            // 
            // SearchCombo
            // 
            SearchCombo.BackColor = Color.White;
            SearchCombo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchCombo.ForeColor = Color.Crimson;
            SearchCombo.FormattingEnabled = true;
            SearchCombo.Location = new Point(774, 131);
            SearchCombo.Name = "SearchCombo";
            SearchCombo.Size = new Size(174, 36);
            SearchCombo.TabIndex = 39;
            SearchCombo.Text = "Select Category";
            SearchCombo.SelectedIndexChanged += SearchCombo_SelectionChangeCommitted;
            // 
            // ProductsGV
            // 
            ProductsGV.BackgroundColor = Color.White;
            ProductsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGV.GridColor = SystemColors.ControlDarkDark;
            ProductsGV.Location = new Point(459, 170);
            ProductsGV.Name = "ProductsGV";
            ProductsGV.RowHeadersWidth = 51;
            ProductsGV.RowTemplate.Height = 29;
            ProductsGV.Size = new Size(803, 206);
            ProductsGV.TabIndex = 38;
            ProductsGV.CellContentClick += ProductsGV_CellClick;
            // 
            // QtyTb
            // 
            QtyTb.BackColor = Color.MistyRose;
            QtyTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.ForeColor = Color.Crimson;
            QtyTb.Location = new Point(577, 395);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(245, 38);
            QtyTb.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(460, 400);
            label6.Name = "label6";
            label6.Size = new Size(117, 27);
            label6.TabIndex = 41;
            label6.Text = "Quantity:";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(828, 395);
            button1.Name = "button1";
            button1.Size = new Size(137, 38);
            button1.TabIndex = 42;
            button1.Text = "Add To Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderGV
            // 
            OrderGV.BackgroundColor = Color.White;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGV.GridColor = SystemColors.ControlDarkDark;
            OrderGV.Location = new Point(460, 439);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersWidth = 51;
            OrderGV.RowTemplate.Height = 29;
            OrderGV.Size = new Size(678, 220);
            OrderGV.TabIndex = 43;
            // 
            // CustName
            // 
            CustName.BackColor = Color.MistyRose;
            CustName.Enabled = false;
            CustName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CustName.ForeColor = Color.Crimson;
            CustName.Location = new Point(16, 514);
            CustName.Name = "CustName";
            CustName.Size = new Size(194, 38);
            CustName.TabIndex = 44;
            CustName.Text = "CustomerName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(460, 662);
            label7.Name = "label7";
            label7.Size = new Size(209, 27);
            label7.TabIndex = 45;
            label7.Text = "Total Amount in $";
            // 
            // TotAmount
            // 
            TotAmount.AutoSize = true;
            TotAmount.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TotAmount.ForeColor = Color.Black;
            TotAmount.Location = new Point(675, 662);
            TotAmount.Name = "TotAmount";
            TotAmount.Size = new Size(35, 27);
            TotAmount.TabIndex = 46;
            TotAmount.Text = "Rs";
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(16, 621);
            button2.Name = "button2";
            button2.Size = new Size(117, 38);
            button2.TabIndex = 47;
            button2.Text = "Insert Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(139, 621);
            button3.Name = "button3";
            button3.Size = new Size(117, 38);
            button3.TabIndex = 48;
            button3.Text = "View Orders";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(16, 395);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 49;
            label8.Text = "Order Id:";
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(262, 621);
            button4.Name = "button4";
            button4.Size = new Size(102, 38);
            button4.TabIndex = 50;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 710);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(TotAmount);
            Controls.Add(label7);
            Controls.Add(CustName);
            Controls.Add(OrderGV);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(QtyTb);
            Controls.Add(SearchCombo);
            Controls.Add(ProductsGV);
            Controls.Add(label5);
            Controls.Add(OrderDate);
            Controls.Add(CustIdTb);
            Controls.Add(OrderIdTb);
            Controls.Add(CustomersGV);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private DataGridView CustomersGV;
        private TextBox OrderIdTb;
        private TextBox CustIdTb;
        private DateTimePicker OrderDate;
        private Label label5;
        private ComboBox SearchCombo;
        private DataGridView ProductsGV;
        private TextBox QtyTb;
        private Label label6;
        private Button button1;
        private DataGridView OrderGV;
        private TextBox CustName;
        private Label label7;
        private Label TotAmount;
        private Button button2;
        private Button button3;
        private Label label8;
        private Button button4;
    }
}