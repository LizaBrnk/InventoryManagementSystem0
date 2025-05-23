﻿namespace InventoryManagementSystem {
    partial class ManageProducts {
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
            PriceTb = new TextBox();
            QtyTb = new TextBox();
            ProdNameTb = new TextBox();
            ProdIdTb = new TextBox();
            DescriptionTb = new TextBox();
            CatCombo = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            ProductsGV = new DataGridView();
            SearchCombo = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).BeginInit();
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
            panel1.Size = new Size(1183, 125);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1145, 0);
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
            label2.Location = new Point(265, 9);
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
            label1.Location = new Point(449, 58);
            label1.Name = "label1";
            label1.Size = new Size(312, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 693);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 20);
            panel2.TabIndex = 19;
            // 
            // PriceTb
            // 
            PriceTb.BackColor = Color.MistyRose;
            PriceTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.ForeColor = Color.Crimson;
            PriceTb.Location = new Point(41, 366);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(245, 38);
            PriceTb.TabIndex = 23;
            PriceTb.Text = "ProductPrice";
            // 
            // QtyTb
            // 
            QtyTb.BackColor = Color.MistyRose;
            QtyTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            QtyTb.ForeColor = Color.Crimson;
            QtyTb.Location = new Point(41, 322);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(245, 38);
            QtyTb.TabIndex = 22;
            QtyTb.Text = "ProductQty";
            // 
            // ProdNameTb
            // 
            ProdNameTb.BackColor = Color.MistyRose;
            ProdNameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ProdNameTb.ForeColor = Color.Crimson;
            ProdNameTb.Location = new Point(41, 278);
            ProdNameTb.Name = "ProdNameTb";
            ProdNameTb.Size = new Size(245, 38);
            ProdNameTb.TabIndex = 21;
            ProdNameTb.Text = "ProductName";
            // 
            // ProdIdTb
            // 
            ProdIdTb.BackColor = Color.MistyRose;
            ProdIdTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ProdIdTb.ForeColor = Color.Crimson;
            ProdIdTb.Location = new Point(41, 234);
            ProdIdTb.Name = "ProdIdTb";
            ProdIdTb.Size = new Size(245, 38);
            ProdIdTb.TabIndex = 20;
            ProdIdTb.Text = "ProductId";
            // 
            // DescriptionTb
            // 
            DescriptionTb.BackColor = Color.MistyRose;
            DescriptionTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTb.ForeColor = Color.Crimson;
            DescriptionTb.Location = new Point(41, 410);
            DescriptionTb.Name = "DescriptionTb";
            DescriptionTb.Size = new Size(245, 38);
            DescriptionTb.TabIndex = 24;
            DescriptionTb.Text = "Description";
            // 
            // CatCombo
            // 
            CatCombo.BackColor = Color.White;
            CatCombo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CatCombo.ForeColor = Color.Crimson;
            CatCombo.FormattingEnabled = true;
            CatCombo.Location = new Point(41, 454);
            CatCombo.Name = "CatCombo";
            CatCombo.Size = new Size(245, 36);
            CatCombo.TabIndex = 25;
            CatCombo.Text = "Product Category";
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(111, 576);
            button4.Name = "button4";
            button4.Size = new Size(102, 43);
            button4.TabIndex = 29;
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
            button3.Location = new Point(212, 518);
            button3.Name = "button3";
            button3.Size = new Size(74, 43);
            button3.TabIndex = 28;
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
            button2.Location = new Point(130, 518);
            button2.Name = "button2";
            button2.Size = new Size(62, 43);
            button2.TabIndex = 27;
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
            button1.Location = new Point(41, 518);
            button1.Name = "button1";
            button1.Size = new Size(70, 43);
            button1.TabIndex = 26;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(613, 137);
            label4.Name = "label4";
            label4.Size = new Size(255, 40);
            label4.TabIndex = 31;
            label4.Text = "PRODUCTS LIST";
            // 
            // ProductsGV
            // 
            ProductsGV.BackgroundColor = Color.White;
            ProductsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGV.GridColor = SystemColors.ControlDarkDark;
            ProductsGV.Location = new Point(329, 234);
            ProductsGV.Name = "ProductsGV";
            ProductsGV.RowHeadersWidth = 51;
            ProductsGV.RowTemplate.Height = 29;
            ProductsGV.Size = new Size(803, 385);
            ProductsGV.TabIndex = 30;
            ProductsGV.CellContentClick += ProductsGV_CellClick;
            // 
            // SearchCombo
            // 
            SearchCombo.BackColor = Color.White;
            SearchCombo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchCombo.ForeColor = Color.Crimson;
            SearchCombo.FormattingEnabled = true;
            SearchCombo.Location = new Point(520, 191);
            SearchCombo.Name = "SearchCombo";
            SearchCombo.Size = new Size(174, 36);
            SearchCombo.TabIndex = 32;
            SearchCombo.Text = "Select Category";
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(718, 191);
            button5.Name = "button5";
            button5.Size = new Size(96, 36);
            button5.TabIndex = 33;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(840, 191);
            button6.Name = "button6";
            button6.Size = new Size(96, 36);
            button6.TabIndex = 34;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 713);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(SearchCombo);
            Controls.Add(label4);
            Controls.Add(ProductsGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CatCombo);
            Controls.Add(DescriptionTb);
            Controls.Add(PriceTb);
            Controls.Add(QtyTb);
            Controls.Add(ProdNameTb);
            Controls.Add(ProdIdTb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox PriceTb;
        private TextBox QtyTb;
        private TextBox ProdNameTb;
        private TextBox ProdIdTb;
        private TextBox DescriptionTb;
        private ComboBox CatCombo;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private DataGridView ProductsGV;
        private ComboBox SearchCombo;
        private Button button5;
        private Button button6;
    }
}