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

        private string originalPassword = ""; // Зберігає оригінальний пароль

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // Зберігаємо оригінальний пароль
                originalPassword = PasswordTb.Text;
                // Забираємо символ заміни, щоб дозволити вводити символи
                PasswordTb.PasswordChar = '\0';
                // Встановлюємо введений пароль, щоб його можна було змінювати
                PasswordTb.Text = originalPassword;
            }
            else
            {
                // Зберігаємо введений пароль
                originalPassword = PasswordTb.Text;
                // Встановлюємо символ заміни для маскування пароля
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