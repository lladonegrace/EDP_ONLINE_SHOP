namespace EDP_ONLINE_SHOP
{
    partial class Newpasswordform
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.newpasswordinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmpasswordinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.LightCoral;
            this.submitbtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitbtn.Location = new System.Drawing.Point(182, 303);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(151, 47);
            this.submitbtn.TabIndex = 12;
            this.submitbtn.Text = "Save";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // newpasswordinput
            // 
            this.newpasswordinput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newpasswordinput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newpasswordinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newpasswordinput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasswordinput.Location = new System.Drawing.Point(65, 152);
            this.newpasswordinput.Name = "newpasswordinput";
            this.newpasswordinput.Size = new System.Drawing.Size(397, 37);
            this.newpasswordinput.TabIndex = 11;
            this.newpasswordinput.TextChanged += new System.EventHandler(this.newpasswordinput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(176, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(61, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirm Password";
            // 
            // confirmpasswordinput
            // 
            this.confirmpasswordinput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmpasswordinput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmpasswordinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpasswordinput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordinput.Location = new System.Drawing.Point(65, 247);
            this.confirmpasswordinput.Name = "confirmpasswordinput";
            this.confirmpasswordinput.Size = new System.Drawing.Size(397, 37);
            this.confirmpasswordinput.TabIndex = 14;
            this.confirmpasswordinput.TextChanged += new System.EventHandler(this.confirmpasswordinput_TextChanged);
            // 
            // Newpasswordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(523, 408);
            this.Controls.Add(this.confirmpasswordinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.newpasswordinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Newpasswordform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newpasswordform";
            this.Load += new System.EventHandler(this.Newpasswordform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.TextBox newpasswordinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmpasswordinput;
    }
}