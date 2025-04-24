

using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Net.NetworkInformation;

namespace MayneFaniWindowsForm
{
    public partial class Main : Form
    {

        string BaseName { get; set; }
        string NEtworkStatus { get; set; }
        string ConnectionString { get; set; }
        public string ShiftId { get; set; }
        public string DeviceIp { get; set; }

        string Company_Name = "سازمان معاینه فنی خودرو تهران بزرگ";

        public Main()
        {
            InitializeComponent();

            if (CurrentUser.OnlineUser.Role == 1)
            {
                userTypetxt.Text = "مدیر سیستم";

            }
            if (CurrentUser.OnlineUser.Role == 2)
            {
                userTypetxt.Text = "کاربر عادی";
            }

            if (CurrentUser.OnlineUser.Role == 3)
            {
                userTypetxt.Text = "تعمیر و نگهداری سیستم";

            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            if (CurrentUser.OnlineUser.Role != null)
            {

                if (File.Exists("config.cnf"))
                {
                    string[] lines = File.ReadAllLines("config.cnf");

                }
            }
            

            

        }

        void CheckNetStatus()
        {
            Ping ping = new Ping();

            string host = DeviceIp;
            try
            {
                PingReply replay = ping.Send(host, 10);
                if (replay.Status == IPStatus.Success)
                {
                    NetworkStatus.Text = "اتصال به شبکه برقرار است";
                }
                else
                {
                    NetworkStatus.Text = "عدم ارتباط با سرور";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckNetStatus();
        }

    }
}
