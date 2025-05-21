using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_ONLINE_SHOP
{
    public partial class Verificationform : Form
    {
        private string generatedCode;
        private string userEmail;
        private forgotpasswordform parentForm;

        // Constructor accepting three arguments  
        public Verificationform(forgotpasswordform parent, string code, string email)
        {
            InitializeComponent();
            parentForm = parent;
            generatedCode = code;
            userEmail = email;
        }

        private void Verificationform_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void codeinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void verifybtn_Click(object sender, EventArgs e)
        {
            string enteredCode = codeinput.Text.Trim();

            if (enteredCode == generatedCode)
            {
                MessageBox.Show("Verification successful!");

                // Open the Newpasswordform
                Newpasswordform newPasswordForm = new Newpasswordform(userEmail);
                newPasswordForm.Show();

                // Optionally close the verification form
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid code. Please try again.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
