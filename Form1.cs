using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP_ONLINE_SHOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Load latest_order_2025
                string query1 = "SELECT * FROM order_status_view";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(reader1);
                todaysorderview.DataSource = dt1;
                reader1.Close();

                // Load another table, e.g., previous_order_2024
                string query2 = "SELECT * FROM customer_order_summary";
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(reader2);
                customersummary.DataSource = dt2;
                reader2.Close();
            }
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void productsbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
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
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void customerinfoview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void todaysorderview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerinfobtn_Click(object sender, EventArgs e)
        {
            Customerinfo customerinfo = new Customerinfo();
            customerinfo.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Monthlysales monthlysales = new Monthlysales();
            monthlysales.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Latestorder latestorder = new Latestorder();
            latestorder.Show();
            this.Hide();
        }

        private void orderinfobtn_Click(object sender, EventArgs e)
        {
            Orderinfo orderinfo = new Orderinfo();
            orderinfo.Show();
            this.Hide();
        }

        private void customerspendbtn_Click(object sender, EventArgs e)
        {
            Customerspend customerspend = new Customerspend();
            customerspend.Show();
            this.Hide();
        }
    }
}
