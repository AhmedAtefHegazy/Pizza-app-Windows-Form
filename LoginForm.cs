using System.Windows.Forms;

namespace Pizza_app
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, System.EventArgs e)
        {
            if (chkShowPassword.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }

            else
            {
                txtPassword.PasswordChar = '\0';
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkShowPassword.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }

            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (((txtPassword.Tag.ToString()) == txtPassword.Text) && ((txtUserName.Tag.ToString()) == txtUserName.Text))
            {
                txtUserName.Clear();
                txtPassword.Clear();

                Form frmOrderPizza = new frmOrderPizza();
                frmOrderPizza.ShowDialog();
            }

            else
            {
                MessageBox.Show("Error ! ,wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
