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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            getData();
            inventorytable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            inventorytable.MultiSelect = false;
            inventorytable.ReadOnly = true; // Optional: prevent editing directly in grid
            inventorytable.AllowUserToAddRows = false;
        }
        public void getData()
        {
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Load latest_order_2025
                string query1 = "SELECT * FROM inventory";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(reader1);
                inventorytable.DataSource = dt1;
                reader1.Close();
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

        private void orderitemsbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void transactionbtn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void addinventorybtn_Click(object sender, EventArgs e)
        {
            string productId = prodcutidinput.Text.Trim();
            string quantityAdded = quantityaddedinput.Text.Trim();

            if (string.IsNullOrWhiteSpace(productId) || string.IsNullOrWhiteSpace(quantityAdded))
            {
                MessageBox.Show("Please fill in required fields (Product ID and Quantity).");
                return;
            }

            if (!int.TryParse(quantityAdded, out int quantity))
            {
                MessageBox.Show("Please enter a valid number for Quantity.");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE inventory SET quantity = quantity + @quantity WHERE product_id = @productId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inventory updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Product ID not found. No inventory was updated.");
                    }

                    getData(); // Refresh the data display
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void updateinventorybtn_Click(object sender, EventArgs e)
        {
            if (inventorytable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            DataGridViewRow selectedRow = inventorytable.SelectedRows[0];
            string currentProductId = selectedRow.Cells["product_id"].Value?.ToString()?.Trim();
            string updatedQuantityText = selectedRow.Cells["quantity_added"].Value?.ToString()?.Trim();

            // Validate inputs
            if (string.IsNullOrWhiteSpace(currentProductId) || string.IsNullOrWhiteSpace(updatedQuantityText))
            {
                MessageBox.Show("Please ensure Product ID and Quantity are filled in.");
                return;
            }

            if (!int.TryParse(updatedQuantityText, out int updatedQuantity))
            {
                MessageBox.Show("Please enter a valid number for Quantity.");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE inventory 
                             SET quantity_added = @updatedQuantityAdded 
                             WHERE product_id = @productId";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@updatedQuantityAdded", updatedQuantity);
                    cmd.Parameters.AddWithValue("@productId", currentProductId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inventory updated successfully!");
                        getData(); // Refresh the table
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void searchinventorysearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchinventorysearch.Text.Trim();

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
                string query = "SELECT * FROM inventory WHERE product_id LIKE @searchTerm OR inventory_id LIKE @searchTerm";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // % allows for partial matches

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                inventorytable.DataSource = dt;

                reader.Close();
                con.Close();
            }
        }


        private void clearinventorybtn_Click(object sender, EventArgs e)
        {
            prodcutidinput.Text = string.Empty;
            quantityaddedinput.Text = string.Empty;
        }

        private void exportexcelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (inventorytable.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Customers";

                // Add headers
                for (int i = 0; i < inventorytable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = inventorytable.Columns[i].HeaderText;
                }

                // Add rows
                for (int i = 0; i < inventorytable.Rows.Count; i++)
                {
                    // Avoid exporting the new row placeholder
                    if (!inventorytable.Rows[i].IsNewRow)
                    {
                        for (int j = 0; j < inventorytable.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = inventorytable.Rows[i].Cells[j].Value?.ToString();
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

        private void inventorytable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = inventorytable.Rows[e.RowIndex];

                    prodcutidinput.Text = row.Cells["product_id"].Value.ToString();
                    quantityaddedinput.Text = row.Cells["quantity_added"].Value.ToString();
                   

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected row: " + ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Logincs login = new Logincs();
            login.Show();
            this.Hide();
        }
    }
    }
  
    

