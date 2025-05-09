using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP_ONLINE_SHOP
{
    public partial class Newpasswordform : Form
    {
        private readonly string _userEmail; // Use readonly for email as it shouldn't change

        public Newpasswordform(string email)
        {
            InitializeComponent();
            _userEmail = email;
        }

        private async void submitbtn_Click(object sender, EventArgs e)
        {
            string newPassword = newpasswordinput.Text.Trim();
            string confirmPassword = confirmpasswordinput.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consider hashing the password before storing it in the database for security.
            // For this example, we'll proceed with plain text, but it's strongly discouraged in production.

            string connectionString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync(); // Use asynchronous operation

                    string query = "UPDATE admin SET password = @password WHERE email = @userEmail";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", newPassword);
                        command.Parameters.AddWithValue("@userEmail", _userEmail);

                        int rowsAffected = await command.ExecuteNonQueryAsync(); // Use asynchronous operation

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Consider navigating back to the login form instead of a generic Form1
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show($"Failed to update password for email: {_userEmail}. Email not found or an error occurred.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the detailed error for debugging purposes
                Console.WriteLine($"MySQL Error Details:\n{ex}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the detailed error for debugging purposes
                Console.WriteLine($"General Error Details:\n{ex}");
            }
        }

        private void Newpasswordform_Load(object sender, EventArgs e)
        {
            // Any initialization logic for the form can go here
        }

        private void newpasswordinput_TextChanged(object sender, EventArgs e)
        {
            newpasswordinput.PasswordChar = '•';// You can add real-time password validation here if needed
        }

        private void confirmpasswordinput_TextChanged(object sender, EventArgs e)
        {
            confirmpasswordinput.PasswordChar = '•'; // You can add real-time password matching validation here if needed
        }
    }
}