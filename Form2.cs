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

        private void customerbtn_Click(object sender, EventArgs e)
        {

        }

        private void transactionbtn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void nameinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputaddress_TextChanged(object sender, EventArgs e)
        {

        }
        private void addcategorybtn_Click(object sender, EventArgs e)
        {
            string name = nameinput.Text;
            string email = inputemail.Text;
            string address = inputaddress.Text;
            string phone = phoneinput.Text; // <-- new line

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in required fields (Name, Email, Phone).");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "INSERT INTO customers (name, email, address, phone) VALUES (@name, @email, @address, @phone)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully!");
                getData();
            }
        }


        private void updatecategorybtn_Click(object sender, EventArgs e)
        {
            if (customertabledataview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            // Get the selected row and the original values
            DataGridViewRow selectedRow = customertabledataview.SelectedRows[0];
            string originalName = selectedRow.Cells["name"].Value.ToString();
            string originalEmail = selectedRow.Cells["email"].Value.ToString();

            // Get the new values from the input fields
            string newName = nameinput.Text.Trim();
            string newEmail = inputemail.Text.Trim();
            string newAddress = inputaddress.Text.Trim();
            string newPhone = phoneinput.Text.Trim();

            // Validate the input fields
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Name and Email cannot be empty.");
                return;
            }

            // Database connection string
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Update query
                string query = @"UPDATE customers 
                         SET name = @newName, email = @newEmail, address = @newAddress, phone = @newPhone 
                         WHERE name = @originalName AND email = @originalEmail";

                // Prepare the SQL command
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newName", newName);
                cmd.Parameters.AddWithValue("@newEmail", newEmail);
                cmd.Parameters.AddWithValue("@newAddress", newAddress);
                cmd.Parameters.AddWithValue("@newPhone", newPhone);
                cmd.Parameters.AddWithValue("@originalName", originalName);
                cmd.Parameters.AddWithValue("@originalEmail", originalEmail);

                // Execute the update
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Customer updated successfully!");
                    getData(); // Refresh the data grid view with updated info
                }
                else
                {
                    MessageBox.Show("Update failed. Customer not found.");
                }
            }
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (customertabledataview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            DataGridViewRow selectedRow = customertabledataview.SelectedRows[0];
            string name = selectedRow.Cells["name"].Value.ToString();
            string email = selectedRow.Cells["email"].Value.ToString();

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "DELETE FROM customers WHERE name = @name AND email = @email";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully!");
                    getData();
                }
                else
                {
                    MessageBox.Show("Delete failed. Customer not found.");
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void exporttomsexcelbtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void customertabledataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customertabledataview.Rows[e.RowIndex];
                // Automatically fill the textboxes with selected row's data
                nameinput.Text = row.Cells["name"].Value.ToString();
                inputemail.Text = row.Cells["email"].Value.ToString();
                inputaddress.Text = row.Cells["address"].Value.ToString();
                phoneinput.Text = row.Cells["phone"].Value.ToString();
            }
        }

        private void deletecategorybtn_Click(object sender, EventArgs e)
        {

        }

     
    }
}
