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

            }
        }
    }
}
