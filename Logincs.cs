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
    public partial class Logincs : Form
    {
        public Label passwordStrengthLabel { get; private set; } // Fix: Change 'object' to 'Label'

        public Label passwordErrorLabel { get; private set; } // Fix: Ensure consistent type

        public Label usernameErrorLabel { get; private set; } // Fix: Ensure consistent type

        public Logincs()
        {
            InitializeComponent();
            usernameErrorLabel = new Label(); // Initialize the label to avoid null reference
            usernameErrorLabel.Visible = false; // Ensure it's hidden by default
            Controls.Add(usernameErrorLabel); // Add it to the form's controls

            passwordErrorLabel = new Label(); // Initialize the label to avoid null reference
            passwordErrorLabel.Visible = false; // Ensure it's hidden by default
            Controls.Add(passwordErrorLabel); // Add it to the form's controls

            passwordStrengthLabel = new Label(); // Initialize the label to avoid null reference
            passwordStrengthLabel.Visible = false; // Ensure it's hidden by default
            Controls.Add(passwordStrengthLabel); // Add it to the form's controls
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logincs_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text.Trim();

            if (ValidateLogin(username, password))
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordbox.Clear();
                passwordbox.Focus();
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string conString = "server=localhost;uid=root;pwd=#GracE_121203;database=online_shop;";
            bool isValid = false;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM admin WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            isValid = reader.HasRows; // True if a matching row exists
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValid;
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernamebox.Text))
            {
                usernamebox.BackColor = Color.MistyRose;

                // Show an error message
                usernameErrorLabel.Text = "Username is required.";
                usernameErrorLabel.ForeColor = Color.Red;
                usernameErrorLabel.Visible = true;
            }
            else
            {
                usernamebox.BackColor = Color.White;

                // Clear the error message
                usernameErrorLabel.Text = "";
                usernameErrorLabel.Visible = false;
            }
        }
        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            passwordbox.PasswordChar = '•'; // Ensures masking

            string password = passwordbox.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                passwordbox.BackColor = Color.MistyRose;

                // Show error
                passwordErrorLabel.Text = "Password is required.";
                passwordErrorLabel.ForeColor = Color.Red;
                passwordErrorLabel.Visible = true;

                // Hide strength label
                passwordStrengthLabel.Text = "";
                passwordStrengthLabel.Visible = false;
            }
            else
            {
                passwordbox.BackColor = Color.White;

                // Hide error label
                passwordErrorLabel.Text = "";
                passwordErrorLabel.Visible = false;

                // Show password strength
                if (password.Length < 6)
                {
                    passwordStrengthLabel.Text = "Weak password";
                    passwordStrengthLabel.ForeColor = Color.Red;
                }
                else if (password.Length >= 6 && password.Any(char.IsDigit))
                {
                    passwordStrengthLabel.Text = "Moderate";
                    passwordStrengthLabel.ForeColor = Color.Orange;
                }
                if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.Any(char.IsSymbol))
                {
                    passwordStrengthLabel.Text = "Strong";
                    passwordStrengthLabel.ForeColor = Color.Green;
                }

                passwordStrengthLabel.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Show password as plain text
                passwordbox.PasswordChar = '\0'; // No masking
            }
            else
            {
                // Hide password using bullet
                passwordbox.PasswordChar = '•';
            }
        }

        private void forgotlink_Click(object sender, EventArgs e)
        {
            forgotpasswordform forgotform = new forgotpasswordform();
            forgotform.Show();
            this.Hide();
        }

        private void createaccbtn_Click(object sender, EventArgs e)
        {
            Register regisform = new Register();
            regisform .Show();
            this.Hide();
        }
    }
}
