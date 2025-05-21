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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            getData();
            producttableview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            producttableview.MultiSelect = false;
            producttableview.ReadOnly = true; // Optional: prevent editing directly in grid
            producttableview.AllowUserToAddRows = false;

            categorytableview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categorytableview.MultiSelect = false;
            categorytableview.ReadOnly = true; // Optional: prevent editing directly in grid
            categorytableview.AllowUserToAddRows = false;
        }

        public void getData()
        {
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                // Load latest_order_2025
                string query1 = "SELECT * FROM products";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(reader1);
                producttableview.DataSource = dt1;
                reader1.Close();

                // Load another table, e.g., previous_order_2024
                string query2 = "SELECT * FROM categories";
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(reader2);
                categorytableview.DataSource = dt2;
                reader2.Close();
            }
        }

        private void dashbtn_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void customerbtn_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
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


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void transactionbtn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void productnameinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryidproductinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptioninput_TextChanged(object sender, EventArgs e)
        {

        }


        private void producttableview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = producttableview.Rows[e.RowIndex];

                    productnameinput.Text = row.Cells["product_name"].Value.ToString();
                    categoryidproductinput.Text = row.Cells["category_id"].Value.ToString();
                    priceinput.Text = row.Cells["price"].Value.ToString();
                    descriptioninput.Text = row.Cells["description"].Value.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected row: " + ex.Message);
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
                string query = "SELECT * FROM products WHERE product_name LIKE @searchTerm OR price LIKE @searchTerm";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%"); // % allows for partial matches

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                producttableview.DataSource = dt;

                reader.Close();
                con.Close();
            }
        }

        private void addbproductbtn_Click(object sender, EventArgs e)
        {
            string productName = productnameinput.Text.Trim();
            string categoryId = categoryidproductinput.Text.Trim();
            string price = priceinput.Text.Trim();
            string description = descriptioninput.Text.Trim();
            string stockQuantityText = stockquantityinput.Text.Trim(); // Assuming you have a textbox for this

            // Basic validation
            if (string.IsNullOrWhiteSpace(productName) ||
                string.IsNullOrWhiteSpace(categoryId) ||
                string.IsNullOrWhiteSpace(price) ||
                string.IsNullOrWhiteSpace(stockQuantityText))
            {
                MessageBox.Show("Please fill in all required fields (Product Name, Category ID, Price, Stock Quantity).");
                return;
            }

            // Validate price and stock quantity
            if (!decimal.TryParse(price, out decimal priceValue))
            {
                MessageBox.Show("Invalid price value.");
                return;
            }

            if (!int.TryParse(stockQuantityText, out int stockQuantity))
            {
                MessageBox.Show("Invalid stock quantity.");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();

                    // Check if product already exists
                    string checkQuery = "SELECT COUNT(*) FROM products WHERE product_name = @productName AND category_id = @categoryId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@productName", productName);
                    checkCmd.Parameters.AddWithValue("@categoryId", categoryId);

                    int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (existingCount > 0)
                    {
                        MessageBox.Show("This product already exists.");
                        return;
                    }

                    // Insert product
                    string insertQuery = "INSERT INTO products (product_name, category_id, price, description, stock_quantity) " +
                                         "VALUES (@productName, @categoryId, @price, @description, @stockQuantity)";
                    MySqlCommand cmd = new MySqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@productName", productName);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Parameters.AddWithValue("@price", priceValue);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@stockQuantity", stockQuantity);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added successfully!");
                        getData(); // Refresh product list or table

                        // Clear input fields
                        productnameinput.Clear();
                        categoryidproductinput.Clear();
                        priceinput.Clear();
                        descriptioninput.Clear();
                        stockquantityinput.Clear(); // Also clear stock quantity input
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void updateproductsbtn_Click(object sender, EventArgs e)
        {
            if (producttableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            DataGridViewRow selectedRow = producttableview.SelectedRows[0];
            string originalProductName = selectedRow.Cells["product_name"].Value.ToString(); // identifier
            string originalCategoryId = selectedRow.Cells["category_id"].Value.ToString();   // identifier
            string originalStockQuantity = selectedRow.Cells["stock_quantity"].Value.ToString(); // identifier

            // Get updated input values
            string updatedProductName = productnameinput.Text.Trim();
            string updatedCategoryId = categoryidproductinput.Text.Trim();
            string updatedPrice = priceinput.Text.Trim();
            string updatedDescription = descriptioninput.Text.Trim();
            string updatedStockQuantity = stockquantityinput.Text.Trim(); // assuming this exists

            if (string.IsNullOrWhiteSpace(updatedProductName) ||
                string.IsNullOrWhiteSpace(updatedCategoryId) ||
                string.IsNullOrWhiteSpace(updatedPrice) ||
                string.IsNullOrWhiteSpace(updatedStockQuantity))
            {
                MessageBox.Show("Please fill in required fields (Product Name, Category ID, Price, Stock Quantity).");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = @"UPDATE products 
                         SET product_name = @updatedProductName, 
                             category_id = @updatedCategoryId, 
                             price = @updatedPrice, 
                             description = @updatedDescription, 
                             stock_quantity = @updatedStockQuantity 
                         WHERE product_name = @originalProductName 
                           AND category_id = @originalCategoryId 
                           AND stock_quantity = @originalStockQuantity";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatedProductName", updatedProductName);
                cmd.Parameters.AddWithValue("@updatedCategoryId", updatedCategoryId);
                cmd.Parameters.AddWithValue("@updatedPrice", updatedPrice);
                cmd.Parameters.AddWithValue("@updatedDescription", updatedDescription);
                cmd.Parameters.AddWithValue("@updatedStockQuantity", updatedStockQuantity);
                cmd.Parameters.AddWithValue("@originalProductName", originalProductName);
                cmd.Parameters.AddWithValue("@originalCategoryId", originalCategoryId);
                cmd.Parameters.AddWithValue("@originalStockQuantity", originalStockQuantity);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully!");
                    getData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Update failed. Product not found.");
                }
            }
        }


        private void deleteproductsbtn_Click(object sender, EventArgs e)
        {
            if (producttableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            DataGridViewRow selectedRow = producttableview.SelectedRows[0];
            string productName = selectedRow.Cells["product_name"].Value.ToString();
            string categoryId = selectedRow.Cells["category_id"].Value.ToString();

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "DELETE FROM products WHERE product_name = @productName AND category_id = @categoryId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product deleted successfully!");
                    getData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Delete failed. Product not found.");
                }
            }
        }

        private void exportexcelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (producttableview.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Customers";

                // Add headers
                for (int i = 0; i < producttableview.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = producttableview.Columns[i].HeaderText;
                }

                // Add rows
                for (int i = 0; i < producttableview.Rows.Count; i++)
                {
                    // Avoid exporting the new row placeholder
                    if (!producttableview.Rows[i].IsNewRow)
                    {
                        for (int j = 0; j < producttableview.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = producttableview.Rows[i].Cells[j].Value?.ToString();
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

        private void stockquantityinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearproductbtn_Click(object sender, EventArgs e)
        {
            productnameinput.Text = string.Empty;
            categoryidproductinput.Text = string.Empty;
            priceinput.Text = string.Empty;
            stockquantityinput.Text = string.Empty;
            descriptioninput.Text = string.Empty;
        }



        // CATEGORY//


        private void addcategorybtn_Click(object sender, EventArgs e)
        {
            string categoryName = categorynameinput.Text;
            string categoryId = categoryidinput.Text;

            if (string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(categoryId))
            {
                MessageBox.Show("Please fill in required fields (Category Name, Category ID).");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO categories (category_name, category_id) VALUES (@categoryName, @categoryId)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@categoryName", categoryName);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category added successfully!");
                    getData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void clearcategorybtn_Click(object sender, EventArgs e)
        {
            categorynameinput.Text = string.Empty;
            categoryidinput.Text = string.Empty;
        }

        private void updatecategorybtn_Click(object sender, EventArgs e)
        {
            if (categorytableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to update.");
                return;
            }

            // Get selected row's current category_id to locate the correct record in DB
            DataGridViewRow selectedRow = categorytableview.SelectedRows[0];
            string currentId = selectedRow.Cells["category_id"].Value.ToString();

            // New input values
            string updatedName = categorynameinput.Text.Trim();
            string updatedId = categoryidinput.Text.Trim();

            if (string.IsNullOrWhiteSpace(updatedName) || string.IsNullOrWhiteSpace(updatedId))
            {
                MessageBox.Show("Please fill in required fields (Category Name, Category ID).");
                return;
            }

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE categories 
                             SET category_name = @updatedName, category_id = @updatedId 
                             WHERE category_id = @currentId";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@updatedName", updatedName);
                    cmd.Parameters.AddWithValue("@updatedId", updatedId);
                    cmd.Parameters.AddWithValue("@currentId", currentId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category updated successfully!");
                        getData(); // Refresh table
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Category not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void deletecategorybtn_Click(object sender, EventArgs e)
        {
            if (categorytableview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Get selected category ID
            DataGridViewRow selectedRow = categorytableview.SelectedRows[0];
            string categoryId = selectedRow.Cells["category_id"].Value.ToString();

            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "DELETE FROM categories WHERE category_id = @categoryId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category deleted successfully!");
                    getData(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Delete failed. Category not found.");
                }
            }
        }

        private void categorytableview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = categorytableview.Rows[e.RowIndex];

                    categorynameinput.Text = row.Cells["category_name"].Value.ToString();
                    categoryidinput.Text = row.Cells["category_id"].Value.ToString();
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected row: " + ex.Message);
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Logincs login = new Logincs();
            login.Show();
            this.Hide();
        }
    }
}


