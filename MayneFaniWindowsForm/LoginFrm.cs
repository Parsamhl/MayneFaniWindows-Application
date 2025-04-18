
using MayneFaniWindowsForm.Authentication;
using System.Net.Sockets;
using System.Net;

namespace MayneFaniWindowsForm
{
    public partial class LoginFrm : Form
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string LoginDate { get; set; }
        public string BaseName { get; set; }
        public static string ShiftId { get; set; }

        public static string DeviceIp { get; set; }
        public string BaseNO { get; set; }


        private Authentication.Authentication auth;
        public LoginFrm()
        {
            InitializeComponent();
            auth = new Authentication.Authentication();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }

        public string GenerateShiftId()
        {
            ShiftId = DateTime.Now.ToString("yy-mm-dd") + DeviceIp + BaseNO;

            if(ShiftId is not null)
            {
                return ShiftId;
            }
            MessageBox.Show("خطا در تولید شناسه شیفت");
            return null;
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    DeviceIp = ip.ToString();
                    return ip.ToString(); 
                }
            }

            MessageBox.Show("خطا در ارتباط شبکه");
            return null;
        }
    }
}
