namespace EDP_ONLINE_SHOP
{
    partial class forgotpasswordform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailinput = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(167, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(59, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Email Address";
            // 
            // emailinput
            // 
            this.emailinput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailinput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailinput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailinput.Location = new System.Drawing.Point(63, 152);
            this.emailinput.Name = "emailinput";
            this.emailinput.Size = new System.Drawing.Size(397, 37);
            this.emailinput.TabIndex = 2;
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.LightCoral;
            this.sendbtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendbtn.Location = new System.Drawing.Point(188, 207);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(151, 47);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = false;
            // 
            // backbtn
            // 
            this.backbtn.AutoSize = true;
            this.backbtn.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.backbtn.Location = new System.Drawing.Point(217, 268);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(89, 15);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "< Back to login";
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // forgotpasswordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(523, 323);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.emailinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "forgotpasswordform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgotpasswordform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailinput;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Label backbtn;
    }
}