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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string query = "SELECT * FROM customers";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader(); 
            DataTable dt = new DataTable();
            dt.Load(reader); 
            customertabledataview.DataSource = dt;
            reader.Close(); 
            con.Close(); 
        }


        private void dashboardbtn_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void productsbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void orderitemsbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Logincs login = new Logincs();
            login.Show();
            this.Hide();
        }
    }
}
