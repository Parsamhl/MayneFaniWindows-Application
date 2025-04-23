using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayneFaniWindowsForm
{
    public partial class DataBaseSetting : Form
    {


        public string ConnectionStriong = "";

        public string FilePath = "DataBase";
        public DataBaseSetting()
        {
            InitializeComponent();
        }

        public string SetConnectionString()
        {
            string con = "";

            con = "Data Source=" + servernametxt.Text + ";" + "Initial Catalog=" + dataBaseNameTxt.Text + ";" + "User ID=" + userNametxt.Text + ";" + "Password=" + passwordTxt.Text + ";" + "TrustServerCertificate=True;Encrypt=True";
            if (con is not null)
            {
                ConnectionStriong = con;
                return con;
            }
            else
            {
                MessageBox.Show("خطا در بروز رسانی تنظیمات پایگاه داده");
                return "";
            }

        }

        public void ClearDataBase()
        {
            if (File.Exists("DataBase"))
            {
                File.Delete(FilePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("DataBase"))
            {
                using (StreamWriter sw = new StreamWriter(FilePath, append: false))
                {
                    sw.WriteLine(ConnectionStriong);
                }

                MessageBox.Show("تنظیمات پایگاه داده با موفقیت ذخیره شد !");
                Main main = new Main(); 

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearDataBase();
        }
    }
}
