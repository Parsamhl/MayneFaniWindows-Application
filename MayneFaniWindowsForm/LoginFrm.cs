
using System.Net.Sockets;
using System.Net;

namespace MayneFaniWindowsForm
{
    public partial class LoginFrm : Form
    {


        public string UserType { get; set; }
        public string LoginDate { get; set; }
        public string BaseName { get; set; }
        public static string ShiftId = "";
        public static string DeviceIp { get; set; }
        public string BaseNO { get; set; }
        bool Loginstatus = false;
        public string ConnectionString { get; set; }

        private Authentication.Authentication auth;
        public LoginFrm()
        {
            InitializeComponent();
            auth = new Authentication.Authentication();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Loginstatus = auth.Login(userNametxt.Text, passwordtxt.Text);

            if (Loginstatus == true)
            {
                GetLocalIPAddress();
                GenerateShiftId();
                Main main = new Main();
                main.ShiftId = ShiftId;
                main.DeviceIp = DeviceIp;
                this.Hide();
                MessageBox.Show(ShiftId, "شناسه شیفت", MessageBoxButtons.OK);
                main.Show();
            }
            else if (Loginstatus == false)
            {
                MessageBox.Show(" نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButtons.OK);
            }
            else if (userNametxt.Text == null || passwordtxt.Text == null)
            {
                MessageBox.Show("تمامی فیلد هارا به درستی پر کنید", "خطا", MessageBoxButtons.OK);
            }
        }


        private void LoginFrm_Load(object sender, EventArgs e)
        {

            ChekConnection();
        }


        public string GenerateShiftId()
        {
            string final = "";
            ShiftId = DateTime.Now.ToString().Replace(" ", "").Replace(":", "").Replace("-", "").Replace(".", "").Replace("PM", "").Replace("AM", "");

            final = ShiftId + DeviceIp + BaseNO;

            if (ShiftId is not null)
            {
                return final;
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
                    DeviceIp = ip.ToString().Replace(".", "");
                    return DeviceIp;
                }
            }

            MessageBox.Show("خطا در ارتباط شبکه");
            return null;
        }
        public Result ChekConnection()
        {
            if (File.Exists("C:\\Users\\Lion\\source\\repos\\MayneFaniWindowsForm\\MayneFaniWindowsForm\\bin\\Debug\\net8.0-windows\\DataBase.txt"))
            {
                if (ConnectionString == null)
                {
                    ConnectionString = File.ReadAllText("C:\\Users\\Lion\\source\\repos\\MayneFaniWindowsForm\\MayneFaniWindowsForm\\bin\\Debug\\net8.0-windows\\DataBase.txt");

                    return new Result { IsSuccess = true, Message = "Logged in" };
                }
            }

            else
            {
                MessageBox.Show("warning", "تنظیمات پایگاه داده وجود ندارد !", MessageBoxButtons.OK);
                DataBaseSetting dataBaseSetting = new DataBaseSetting();
                dataBaseSetting.Show();
                ConnectionString = dataBaseSetting.ConnectionStriong;

                if (ConnectionString != null)
                {
                    Main main = new Main();
                    this.Hide();
                    main.Show();
                    return new Result { IsSuccess = true, Message = "Logged in" };
                }

            }

            return new Result { IsSuccess = false, Message = "404" };
           
        }

    }
}
