using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_ONLINE_SHOP
{
    public partial class forgotpasswordform : Form
    {
        public forgotpasswordform()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Logincs login = new Logincs();
            login.Show();
            this.Hide();
        }
    }
}
