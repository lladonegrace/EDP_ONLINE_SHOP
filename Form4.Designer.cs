namespace EDP_ONLINE_SHOP
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventorybtn = new System.Windows.Forms.Button();
            this.orderitemsbtn = new System.Windows.Forms.Button();
            this.productsbtn = new System.Windows.Forms.Button();
            this.customerbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderitemtable = new System.Windows.Forms.Label();
            this.orderitemview = new System.Windows.Forms.DataGridView();
            this.labelorder = new System.Windows.Forms.Label();
            this.ordertable = new System.Windows.Forms.DataGridView();
            this.paymenttable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.inventorybtn);
            this.panel1.Controls.Add(this.orderitemsbtn);
            this.panel1.Controls.Add(this.productsbtn);
            this.panel1.Controls.Add(this.customerbtn);
            this.panel1.Controls.Add(this.dashboardbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 669);
            this.panel1.TabIndex = 1;
            // 
            // inventorybtn
            // 
            this.inventorybtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.inventorybtn.FlatAppearance.BorderSize = 0;
            this.inventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventorybtn.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorybtn.Location = new System.Drawing.Point(0, 442);
            this.inventorybtn.Name = "inventorybtn";
            this.inventorybtn.Size = new System.Drawing.Size(206, 45);
            this.inventorybtn.TabIndex = 15;
            this.inventorybtn.Text = "Inventory";
            this.inventorybtn.UseVisualStyleBackColor = false;
            this.inventorybtn.Click += new System.EventHandler(this.inventorybtn_Click);
            // 
            // orderitemsbtn
            // 
            this.orderitemsbtn.BackColor = System.Drawing.Color.IndianRed;
            this.orderitemsbtn.FlatAppearance.BorderSize = 0;
            this.orderitemsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderitemsbtn.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderitemsbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderitemsbtn.Location = new System.Drawing.Point(0, 391);
            this.orderitemsbtn.Name = "orderitemsbtn";
            this.orderitemsbtn.Size = new System.Drawing.Size(206, 45);
            this.orderitemsbtn.TabIndex = 5;
            this.orderitemsbtn.Text = "Order Items";
            this.orderitemsbtn.UseVisualStyleBackColor = false;
            // 
            // productsbtn
            // 
            this.productsbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.productsbtn.FlatAppearance.BorderSize = 0;
            this.productsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsbtn.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.productsbtn.Location = new System.Drawing.Point(3, 340);
            this.productsbtn.Name = "productsbtn";
            this.productsbtn.Size = new System.Drawing.Size(203, 45);
            this.productsbtn.TabIndex = 3;
            this.productsbtn.Text = "Products";
            this.productsbtn.UseVisualStyleBackColor = false;
            this.productsbtn.Click += new System.EventHandler(this.productsbtn_Click);
            // 
            // customerbtn
            // 
            this.customerbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.customerbtn.FlatAppearance.BorderSize = 0;
            this.customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerbtn.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerbtn.Location = new System.Drawing.Point(0, 289);
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.Size = new System.Drawing.Size(206, 45);
            this.customerbtn.TabIndex = 2;
            this.customerbtn.Text = "Customers";
            this.customerbtn.UseVisualStyleBackColor = false;
            this.customerbtn.Click += new System.EventHandler(this.customerbtn_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.dashboardbtn.FlatAppearance.BorderSize = 0;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardbtn.Location = new System.Drawing.Point(0, 238);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(206, 45);
            this.dashboardbtn.TabIndex = 1;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(60, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::EDP_ONLINE_SHOP.Properties.Resources.ada7ea6eb61979926f641471826d43b0_removebg_preview1;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 168);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // orderitemtable
            // 
            this.orderitemtable.AutoSize = true;
            this.orderitemtable.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderitemtable.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.orderitemtable.Location = new System.Drawing.Point(231, 45);
            this.orderitemtable.Name = "orderitemtable";
            this.orderitemtable.Size = new System.Drawing.Size(196, 32);
            this.orderitemtable.TabIndex = 11;
            this.orderitemtable.Text = "Order Items Table";
            this.orderitemtable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderitemview
            // 
            this.orderitemview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderitemview.Location = new System.Drawing.Point(255, 80);
            this.orderitemview.Name = "orderitemview";
            this.orderitemview.Size = new System.Drawing.Size(564, 150);
            this.orderitemview.TabIndex = 12;
            // 
            // labelorder
            // 
            this.labelorder.AutoSize = true;
            this.labelorder.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelorder.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.labelorder.Location = new System.Drawing.Point(231, 270);
            this.labelorder.Name = "labelorder";
            this.labelorder.Size = new System.Drawing.Size(134, 32);
            this.labelorder.TabIndex = 13;
            this.labelorder.Text = "Order Table";
            this.labelorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordertable
            // 
            this.ordertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordertable.Location = new System.Drawing.Point(255, 305);
            this.ordertable.Name = "ordertable";
            this.ordertable.Size = new System.Drawing.Size(564, 131);
            this.ordertable.TabIndex = 14;
            // 
            // paymenttable
            // 
            this.paymenttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymenttable.Location = new System.Drawing.Point(255, 506);
            this.paymenttable.Name = "paymenttable";
            this.paymenttable.Size = new System.Drawing.Size(564, 134);
            this.paymenttable.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(231, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paymets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymenttable);
            this.Controls.Add(this.ordertable);
            this.Controls.Add(this.labelorder);
            this.Controls.Add(this.orderitemview);
            this.Controls.Add(this.orderitemtable);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button orderitemsbtn;
        private System.Windows.Forms.Button productsbtn;
        private System.Windows.Forms.Button customerbtn;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label orderitemtable;
        private System.Windows.Forms.DataGridView orderitemview;
        private System.Windows.Forms.Label labelorder;
        private System.Windows.Forms.DataGridView ordertable;
        private System.Windows.Forms.Button inventorybtn;
        private System.Windows.Forms.DataGridView paymenttable;
        private System.Windows.Forms.Label label2;
    }
}