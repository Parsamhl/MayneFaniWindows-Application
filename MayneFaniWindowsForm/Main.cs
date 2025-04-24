using MayneFaniWindowsForm.Entities;
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
    public partial class Main : Form
    {
        int UserType { get; set; }
        string BaseName { get; set; }
        string NEtworkStatus { get; set; }
        string ConnectionString { get; set; }
        public string ShiftId { get; set; }

        string Company_Name = "سازمان معاینه فنی خودرو تهران بزرگ";

        public Main()
        {
            InitializeComponent();
        }

       
        private void Main_Load(object sender, EventArgs e)
        {
            
        }


    }
}
