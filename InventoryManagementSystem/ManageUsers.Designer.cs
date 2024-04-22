namespace InventoryManagementSystem {
    partial class ManageUsers {
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
            unameTb = new TextBox();
            FnameTb = new TextBox();
            PasswordTb = new TextBox();
            PhoneTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            UsersGV = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
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
            panel1.TabIndex = 0;
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
            label1.Location = new Point(323, 68);
            label1.Name = "label1";
            label1.Size = new Size(248, 40);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // unameTb
            // 
            unameTb.BackColor = Color.MistyRose;
            unameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            unameTb.ForeColor = Color.Crimson;
            unameTb.Location = new Point(41, 204);
            unameTb.Name = "unameTb";
            unameTb.Size = new Size(245, 38);
            unameTb.TabIndex = 1;
            unameTb.Text = "UserName";
            // 
            // FnameTb
            // 
            FnameTb.BackColor = Color.MistyRose;
            FnameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FnameTb.ForeColor = Color.Crimson;
            FnameTb.Location = new Point(41, 278);
            FnameTb.Name = "FnameTb";
            FnameTb.Size = new Size(245, 38);
            FnameTb.TabIndex = 2;
            FnameTb.Text = "FullName";
            // 
            // PasswordTb
            // 
            PasswordTb.BackColor = Color.MistyRose;
            PasswordTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.ForeColor = Color.Crimson;
            PasswordTb.Location = new Point(41, 356);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(245, 38);
            PasswordTb.TabIndex = 3;
            PasswordTb.Text = "Password";
            PasswordTb.TextChanged += textBox3_TextChanged;
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = Color.MistyRose;
            PhoneTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.ForeColor = Color.Crimson;
            PhoneTb.Location = new Point(41, 432);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(245, 38);
            PhoneTb.TabIndex = 4;
            PhoneTb.Text = "Telephone";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 509);
            button1.Name = "button1";
            button1.Size = new Size(70, 43);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(130, 509);
            button2.Name = "button2";
            button2.Size = new Size(62, 43);
            button2.TabIndex = 6;
            button2.Text = "Edit";
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
            button3.Location = new Point(212, 509);
            button3.Name = "button3";
            button3.Size = new Size(74, 43);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(112, 581);
            button4.Name = "button4";
            button4.Size = new Size(102, 43);
            button4.TabIndex = 8;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UsersGV
            // 
            UsersGV.BackgroundColor = Color.White;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.GridColor = SystemColors.ControlDarkDark;
            UsersGV.Location = new Point(323, 204);
            UsersGV.Name = "UsersGV";
            UsersGV.RowHeadersWidth = 51;
            UsersGV.RowTemplate.Height = 29;
            UsersGV.Size = new Size(553, 420);
            UsersGV.TabIndex = 9;
            UsersGV.CellContentClick += UsersGV_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 657);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 20);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(518, 161);
            label4.Name = "label4";
            label4.Size = new Size(174, 40);
            label4.TabIndex = 11;
            label4.Text = "USERS LIST";
            label4.Click += label4_Click;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 677);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(UsersGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PhoneTb);
            Controls.Add(PasswordTb);
            Controls.Add(FnameTb);
            Controls.Add(unameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox unameTb;
        private TextBox FnameTb;
        private TextBox PasswordTb;
        private TextBox PhoneTb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView UsersGV;
        private Panel panel2;
        private Label label3;
        private Label label4;
    }
}