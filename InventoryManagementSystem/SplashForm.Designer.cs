namespace InventoryManagementSystem {
    partial class SplashForm {
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 9);
            label2.Name = "label2";
            label2.Size = new Size(679, 49);
            label2.TabIndex = 3;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(172, 58);
            label1.Name = "label1";
            label1.Size = new Size(446, 37);
            label1.TabIndex = 4;
            label1.Text = "Developed By Liza Baranchuk";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.White;
            progressBar1.Location = new Point(229, 140);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(347, 227);
            progressBar1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(229, 415);
            label3.Name = "label3";
            label3.Size = new Size(347, 26);
            label3.TabIndex = 6;
            label3.Text = "Developed By Liza Baranchuk";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ProgressBar progressBar1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}