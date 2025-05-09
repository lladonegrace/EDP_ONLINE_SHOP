using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EDP_ONLINE_SHOP
{
    public partial class forgotpasswordform : Form
    {
        private string generatedCode;
        private string userInput;

        public forgotpasswordform()
        {
            InitializeComponent();
        }

        private void forgotpasswordform_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Logincs login = new Logincs();
            login.Show();
            this.Hide();
        }

        private void emailinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            userInput = emailinput.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            try
            {
                // TODO: Replace this block with your database validation if needed.
                // For now, we assume the email is valid and exists.

                generatedCode = GenerateVerificationCode();
                SendOtpEmail(userInput, generatedCode);

                // Optional: Show another form for entering the code
                Verificationform enterCodeForm = new Verificationform (this, generatedCode, userInput);
                enterCodeForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private string GenerateVerificationCode()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }

        private void SendOtpEmail(string toEmail, string otp)
        {
            try
            {
                var fromAddress = new MailAddress("gabl2022-1866-69048@bicol-u.edu.ph", "Online Shop");
                var toAddress = new MailAddress(toEmail);
                const string fromPassword = "euul bomt yrje iiuz"; // Use your Gmail App Password

                string subject = "OTP Verification Code";
                string body = $"Your OTP code is: {otp}\n\nThis code will expire in 5 minutes.";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                MessageBox.Show("OTP has been sent to your email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message);
            }
        }
    }
}
