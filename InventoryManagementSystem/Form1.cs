namespace InventoryManagementSystem {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private string originalPassword = ""; // ������ ����������� ������

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // �������� ����������� ������
                originalPassword = PasswordTb.Text;
                // �������� ������ �����, ��� ��������� ������� �������
                PasswordTb.PasswordChar = '\0';
                // ������������ �������� ������, ��� ���� ����� ���� ��������
                PasswordTb.Text = originalPassword;
            }
            else
            {
                // �������� �������� ������
                originalPassword = PasswordTb.Text;
                // ������������ ������ ����� ��� ���������� ������
                PasswordTb.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }
    }
}