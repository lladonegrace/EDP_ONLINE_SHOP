namespace EDP_ONLINE_SHOP
{
    partial class Verificationform
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
            this.verifybtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codeinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // verifybtn
            // 
            this.verifybtn.BackColor = System.Drawing.Color.LightCoral;
            this.verifybtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verifybtn.Location = new System.Drawing.Point(190, 209);
            this.verifybtn.Name = "verifybtn";
            this.verifybtn.Size = new System.Drawing.Size(151, 47);
            this.verifybtn.TabIndex = 8;
            this.verifybtn.Text = "Verify";
            this.verifybtn.UseVisualStyleBackColor = false;
            this.verifybtn.Click += new System.EventHandler(this.verifybtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(61, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Verification Code";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(193, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Verification";
            // 
            // codeinput
            // 
            this.codeinput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeinput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeinput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeinput.Location = new System.Drawing.Point(65, 154);
            this.codeinput.Name = "codeinput";
            this.codeinput.Size = new System.Drawing.Size(397, 37);
            this.codeinput.TabIndex = 7;
            this.codeinput.TextChanged += new System.EventHandler(this.codeinput_TextChanged);
            // 
            // Verificationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 323);
            this.Controls.Add(this.verifybtn);
            this.Controls.Add(this.codeinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Verificationform";
            this.Text = "Verificationform";
            this.Load += new System.EventHandler(this.Verificationform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button verifybtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeinput;
    }
}