using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ePOS.UI.UI;

namespace ePOS.UI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            StoreSetting setting = new StoreSetting();
            setting.ShowDialog(); 

        }
    }
}
