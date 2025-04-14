using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP_ONLINE_SHOP
{
    public partial class Orderinfo : Form
    {
        public Orderinfo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void Orderinfo_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "SELECT * FROM order_info_non_updatable";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            orderinfotable.DataSource = dt;
            reader.Close();
            con.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
