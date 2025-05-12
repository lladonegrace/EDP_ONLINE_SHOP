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
using Excel = Microsoft.Office.Interop.Excel;

namespace EDP_ONLINE_SHOP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            getData();
            orderitemview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderitemview.MultiSelect = false;
            orderitemview.ReadOnly = true; // Optional: prevent editing directly in grid
            orderitemview.AllowUserToAddRows = false;

            ordertable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordertable.MultiSelect = false;
            ordertable.ReadOnly = true; // Optional: prevent editing directly in grid
            ordertable.AllowUserToAddRows = false;

            paymenttableview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            paymenttableview.MultiSelect = false;
            paymenttableview.ReadOnly = true; // Optional: prevent editing directly in grid
            paymenttableview.AllowUserToAddRows = false;
        }

        public void getData()
        {
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Load latest_order_2025
                string query1 = "SELECT * FROM order_items";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(reader1);
                orderitemview.DataSource = dt1;
                reader1.Close();

                string query2 = "SELECT * FROM orders";
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(reader2);
                ordertable.DataSource = dt2;
                reader2.Close();

                string query3 = "SELECT * FROM payments";
                MySqlCommand cmd3 = new MySqlCommand(query3, con);
                MySqlDataReader reader3 = cmd3.ExecuteReader();
                DataTable dt3 = new DataTable();
                dt3.Load(reader3);
                paymenttableview.DataSource = dt3;
                reader3.Close();
            }
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
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

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void orderitemview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = orderitemview.Rows[e.RowIndex];

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected row: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void transactionbtn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        

        private void searchinpt_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchinpt.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                getData(); // If search box is empty, load all data
                return;
            }

            // SQL query to search for matching customers by name or email
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM order_items WHERE order_id LIKE @searchTerm OR product_id LIKE @searchTerm";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // % allows for partial matches

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                orderitemview.DataSource = dt;

                reader.Close();
                con.Close();
            }
        }

        private void exportexcelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderitemview.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Customers";

                // Add headers
                for (int i = 0; i < orderitemview.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = orderitemview.Columns[i].HeaderText;
                }

                // Add rows
                for (int i = 0; i < orderitemview.Rows.Count; i++)
                {
                    // Avoid exporting the new row placeholder
                    if (!orderitemview.Rows[i].IsNewRow)
                    {
                        for (int j = 0; j < orderitemview.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = orderitemview.Rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }

                excelApp.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }

        private void updateorderbtn_Click(object sender, EventArgs e)
        {
            if (ordertable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            DataGridViewRow selectedRow = ordertable.SelectedRows[0];
            string originalCustomerId = selectedRow.Cells["customer_id"].Value.ToString(); // identifier
            string originalOrderId = selectedRow.Cells["order_id"].Value.ToString();       // identifier

            // Get updated input values
            string updatedCustomerId = customeridinput.Text.Trim();
            string updatedOrderId = orderidinput.Text.Trim();
            string updatedOrderStatus = orderstatusinput.Text.Trim();

            if (string.IsNullOrWhiteSpace(updatedCustomerId) ||
                string.IsNullOrWhiteSpace(updatedOrderId) ||
                string.IsNullOrWhiteSpace(updatedOrderStatus))
            {
                MessageBox.Show("Please fill in required fields (Customer ID, Order ID, Order Status).");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"UPDATE orders 
                         SET customer_id = @updatedCustomerId, 
                             order_status = @updatedOrderStatus 
                         WHERE order_id = @originalOrderId 
                           AND customer_id = @originalCustomerId";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatedCustomerId", updatedCustomerId);
                cmd.Parameters.AddWithValue("@updatedOrderStatus", updatedOrderStatus);
                cmd.Parameters.AddWithValue("@originalOrderId", originalOrderId);
                cmd.Parameters.AddWithValue("@originalCustomerId", originalCustomerId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order updated successfully!");
                    getData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Update failed. Order not found.");
                }
            }
        }

        private void ordertable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = ordertable.Rows[e.RowIndex];

                    customeridinput.Text = row.Cells["customer_id"].Value.ToString();
                    orderidinput.Text = row.Cells["order_id"].Value.ToString();
                    orderstatusinput.Text = row.Cells["order_status"].Value.ToString();
                 
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected row: " + ex.Message);
            }
        }

        private void clearordertbtn_Click(object sender, EventArgs e)
        {
            customeridinput.Text = string.Empty;
            orderidinput.Text = string.Empty;
            orderstatusinput.Text = string.Empty;
        }

        private void deleteorderbtn_Click(object sender, EventArgs e)
        {
            if (ordertable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.");
                return;
            }

            DataGridViewRow selectedRow = ordertable.SelectedRows[0];
            string customerId = selectedRow.Cells["customer_id"].Value.ToString();
            string orderId = selectedRow.Cells["order_id"].Value.ToString();
            string orderStatus = selectedRow.Cells["order_status"].Value.ToString();

            if (!orderStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only orders with status 'Cancelled' can be deleted.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Cancelled order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "DELETE FROM orders WHERE customer_id = @customerId AND order_id = @orderId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cancelled order deleted successfully!");
                    getData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Delete failed. Order not found.");
                }
            }
        }

        private void productsearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = productsearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                getData(); // If search box is empty, load all data
                return;
            }

            // SQL query to search for matching customers by name or email
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM orders WHERE customer_id LIKE @searchTerm OR order_id LIKE @searchTerm";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // % allows for partial matches

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ordertable.DataSource = dt;

                reader.Close();
                con.Close();
            }
        }

        private void exporttomsexcelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ordertable.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Customers";

                // Add headers
                for (int i = 0; i < ordertable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = ordertable.Columns[i].HeaderText;
                }

                // Add rows
                for (int i = 0; i < ordertable.Rows.Count; i++)
                {
                    // Avoid exporting the new row placeholder
                    if (!ordertable.Rows[i].IsNewRow)
                    {
                        for (int j = 0; j < ordertable.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = ordertable.Rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }

                excelApp.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        // PAYMENT SECTION //

        private void updatepaymentbtn_Click(object sender, EventArgs e)
        {
            if (paymenttableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to update.");
                return;
            }

            DataGridViewRow selectedRow = paymenttableview.SelectedRows[0];
            string originalPaymentId = selectedRow.Cells["payment_id"].Value.ToString();
            string originalPaymentStatus = selectedRow.Cells["payment_status"].Value.ToString();

            // Get updated values from input fields
            string updatedPaymentId = paymentidinput.Text.Trim();
            string updatedPaymentStatus = paymentstatusinput.Text.Trim();

            if (string.IsNullOrWhiteSpace(updatedPaymentId) ||
                string.IsNullOrWhiteSpace(updatedPaymentStatus))
            {
                MessageBox.Show("Please fill in all required fields (Payment ID, Payment Status).");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"UPDATE payments 
                         SET payment_id = @updatedPaymentId,  
                             payment_status = @updatedPaymentStatus 
                         WHERE payment_id = @originalPaymentId
                           AND payment_status = @originalPaymentStatus";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatedPaymentId", updatedPaymentId);
                cmd.Parameters.AddWithValue("@updatedPaymentStatus", updatedPaymentStatus); // fixed typo
                cmd.Parameters.AddWithValue("@originalPaymentId", originalPaymentId);
                cmd.Parameters.AddWithValue("@originalPaymentStatus", originalPaymentStatus);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment updated successfully!");
                    getData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Update failed. Payment not found.");
                }
            }
        }


        private void deletepaymentbtn_Click(object sender, EventArgs e)
        {
            if (paymenttableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payment to delete.");
                return;
            }

            // Get selected row
            DataGridViewRow selectedRow = paymenttableview.SelectedRows[0];
            string paymentId = selectedRow.Cells["payment_id"].Value.ToString();
            string paymentStatus = selectedRow.Cells["payment_status"].Value.ToString();

            // Only allow deletion if the payment status is "Failed"
            if (paymentStatus.ToLower() != "failed")
            {
                MessageBox.Show("Only payments with 'Failed' status can be deleted.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this failed payment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "DELETE FROM payments WHERE payment_id = @paymentId AND payment_status = 'Failed'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@paymentId", paymentId);
                cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment deleted successfully!");
                    getData(); // Refresh the table after deletion
                }
                else
                {
                    MessageBox.Show("Delete failed. Payment not found.");
                }
            }
        }


        private void clearpaymentbtn_Click(object sender, EventArgs e)
        {
            paymentidinput.Text = string.Empty;
            paymentstatusinput.Text = string.Empty;
           
        }

        private void paymentidinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentstatusinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymenttableview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = paymenttableview.Rows[e.RowIndex];

                    paymentidinput.Text = row.Cells["payment_id"].Value.ToString();
                    paymentstatusinput.Text = row.Cells["payment_status"].Value.ToString();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected row: " + ex.Message);
            }
        }

        private void exporttomsexcelpayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (paymenttableview.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Customers";

                // Add headers
                for (int i = 0; i < paymenttableview.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = paymenttableview.Columns[i].HeaderText;
                }

                // Add rows
                for (int i = 0; i < paymenttableview.Rows.Count; i++)
                {
                    // Avoid exporting the new row placeholder
                    if (!paymenttableview.Rows[i].IsNewRow)
                    {
                        for (int j = 0; j < paymenttableview.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = paymenttableview.Rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }

                excelApp.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }

        private void searchpaymentinput_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchpaymentinput.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                getData(); // If search box is empty, load all data
                return;
            }

            // SQL query to search for matching customers by name or email
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM payments WHERE payment_method LIKE @searchTerm OR payment_status LIKE @searchTerm";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // % allows for partial matches

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                paymenttableview.DataSource = dt;

                reader.Close();
                con.Close();
            }
        }
    }
}


    

