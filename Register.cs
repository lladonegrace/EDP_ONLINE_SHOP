using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace EDP_ONLINE_SHOP
{
    public partial class Register : Form
    {
        private static string connectionString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";

        public Register()
        {
            InitializeComponent();
        }

        private void emailinput_TextChanged(object sender, EventArgs e)
        {
            // You can add validation here if needed
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {
            // You can add validation here if needed
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            passwordbox.PasswordChar = '•';    // You can add validation here if needed
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordbox.PasswordChar = '\0';
            }
            else
            {
                passwordbox.PasswordChar = '•';
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text.Trim();
            string email = emailinput.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string plainPassword = password; // No hashing

            if (InsertUserIntoDatabase(username, plainPassword, email))
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Removed the dynamic button creation. Button should be on the form already.
        }

        private bool InsertUserIntoDatabase(string username, string password, string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO admin (username, password, email, created_at) VALUES (@username, @password, @email, NOW())";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password); // Store plain password
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
                MessageBox.Show("Database error occurred. Please contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ClearForm()
        {
            usernamebox.Clear();
            passwordbox.Clear();
            emailinput.Clear();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)([\w\-]+)((\.(?!\.))([\w\-]+))*$", DomainMapper,
                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new System.Globalization.IdnMapping();
                    string domainName = match.Groups[2].Value;
                    try
                    {
                        domainName = idn.GetAscii(domainName);
                    }
                    catch (ArgumentException)
                    {
                        return string.Empty;
                    }
                    return match.Groups[1].Value + domainName + match.Groups[3].Value;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void registerbtn_Click_1(object sender, EventArgs e)
        {
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text.Trim();
            string email = emailinput.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string plainPassword = password; // No hashing

            if (InsertUserIntoDatabase(username, plainPassword, email))
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alreadyhaveaccbtn_Click(object sender, EventArgs e)
        {
            Logincs login = new Logincs();
            login.Show();
            this.Hide();
        }
    }
}
