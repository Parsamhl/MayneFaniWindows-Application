
using MayneFaniWindowsForm.Authentication;

namespace MayneFaniWindowsForm
{
    public partial class LoginFrm : Form
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string LoginDate { get; set; }
        public string BaseName { get; set; }

        private Authentication.Authentication auth;
        public LoginFrm()
        {
            InitializeComponent();
            auth = new Authentication.Authentication();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
