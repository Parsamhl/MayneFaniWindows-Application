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
    public partial class Validationfrm : Form
    {

        public string CarName { get; set; }
        public string Plate {  get; set; }
        public string IdentityNumber { get; set; }
        public string ManufactureDate { get; set; }
        public Validationfrm()
        {
            InitializeComponent();
        }
    }
}
