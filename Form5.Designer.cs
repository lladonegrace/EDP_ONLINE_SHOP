namespace EDP_ONLINE_SHOP
{
    partial class Form5
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
            this.logoutbtn = new System.Windows.Forms.Button();
            this.transactionbtn = new System.Windows.Forms.Button();
            this.inventroybtn = new System.Windows.Forms.Button();
            this.orderitemsbtn = new System.Windows.Forms.Button();
            this.productsbtn = new System.Windows.Forms.Button();
            this.customerbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearinventorybtn = new System.Windows.Forms.Button();
            this.searchinventorysearch = new System.Windows.Forms.TextBox();
            this.quantityaddedinput = new System.Windows.Forms.TextBox();
            this.prodcutidinput = new System.Windows.Forms.TextBox();
            this.exportexcelbtn = new System.Windows.Forms.Button();
            this.updateinventorybtn = new System.Windows.Forms.Button();
            this.addinventorybtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventorytable = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorytable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.transactionbtn);
            this.panel1.Controls.Add(this.inventroybtn);
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
            // logoutbtn
            // 
            this.logoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutbtn.Location = new System.Drawing.Point(0, 630);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(206, 39);
            this.logoutbtn.TabIndex = 33;
            this.logoutbtn.TabStop = false;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // transactionbtn
            // 
            this.transactionbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.transactionbtn.FlatAppearance.BorderSize = 0;
            this.transactionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionbtn.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.transactionbtn.Location = new System.Drawing.Point(0, 493);
            this.transactionbtn.Name = "transactionbtn";
            this.transactionbtn.Size = new System.Drawing.Size(206, 45);
            this.transactionbtn.TabIndex = 32;
            this.transactionbtn.Text = "Audit Log";
            this.transactionbtn.UseVisualStyleBackColor = false;
            this.transactionbtn.Click += new System.EventHandler(this.transactionbtn_Click);
            // 
            // inventroybtn
            // 
            this.inventroybtn.BackColor = System.Drawing.Color.IndianRed;
            this.inventroybtn.FlatAppearance.BorderSize = 0;
            this.inventroybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventroybtn.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventroybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventroybtn.Location = new System.Drawing.Point(0, 442);
            this.inventroybtn.Name = "inventroybtn";
            this.inventroybtn.Size = new System.Drawing.Size(206, 45);
            this.inventroybtn.TabIndex = 6;
            this.inventroybtn.Text = "Inventory";
            this.inventroybtn.UseVisualStyleBackColor = false;
            // 
            // orderitemsbtn
            // 
            this.orderitemsbtn.BackColor = System.Drawing.Color.PaleVioletRed;
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
            this.orderitemsbtn.Click += new System.EventHandler(this.orderitemsbtn_Click);
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage1.Controls.Add(this.clearinventorybtn);
            this.tabPage1.Controls.Add(this.searchinventorysearch);
            this.tabPage1.Controls.Add(this.quantityaddedinput);
            this.tabPage1.Controls.Add(this.prodcutidinput);
            this.tabPage1.Controls.Add(this.exportexcelbtn);
            this.tabPage1.Controls.Add(this.updateinventorybtn);
            this.tabPage1.Controls.Add(this.addinventorybtn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.inventorytable);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventory";
            // 
            // clearinventorybtn
            // 
            this.clearinventorybtn.BackColor = System.Drawing.Color.Orchid;
            this.clearinventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearinventorybtn.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearinventorybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearinventorybtn.Location = new System.Drawing.Point(511, 154);
            this.clearinventorybtn.Name = "clearinventorybtn";
            this.clearinventorybtn.Size = new System.Drawing.Size(180, 36);
            this.clearinventorybtn.TabIndex = 65;
            this.clearinventorybtn.Text = "Clear";
            this.clearinventorybtn.UseVisualStyleBackColor = false;
            this.clearinventorybtn.Click += new System.EventHandler(this.clearinventorybtn_Click);
            // 
            // searchinventorysearch
            // 
            this.searchinventorysearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchinventorysearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchinventorysearch.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchinventorysearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.searchinventorysearch.Location = new System.Drawing.Point(88, 263);
            this.searchinventorysearch.Name = "searchinventorysearch";
            this.searchinventorysearch.Size = new System.Drawing.Size(203, 25);
            this.searchinventorysearch.TabIndex = 59;
            this.searchinventorysearch.Text = "  Search";
            this.searchinventorysearch.TextChanged += new System.EventHandler(this.searchinventorysearch_TextChanged);
            // 
            // quantityaddedinput
            // 
            this.quantityaddedinput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityaddedinput.Location = new System.Drawing.Point(520, 97);
            this.quantityaddedinput.Name = "quantityaddedinput";
            this.quantityaddedinput.Size = new System.Drawing.Size(189, 25);
            this.quantityaddedinput.TabIndex = 16;
            // 
            // prodcutidinput
            // 
            this.prodcutidinput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcutidinput.Location = new System.Drawing.Point(167, 94);
            this.prodcutidinput.Name = "prodcutidinput";
            this.prodcutidinput.Size = new System.Drawing.Size(185, 25);
            this.prodcutidinput.TabIndex = 15;
            // 
            // exportexcelbtn
            // 
            this.exportexcelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportexcelbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportexcelbtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.exportexcelbtn.FlatAppearance.BorderSize = 2;
            this.exportexcelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportexcelbtn.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportexcelbtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.exportexcelbtn.Location = new System.Drawing.Point(542, 261);
            this.exportexcelbtn.Name = "exportexcelbtn";
            this.exportexcelbtn.Size = new System.Drawing.Size(167, 27);
            this.exportexcelbtn.TabIndex = 60;
            this.exportexcelbtn.Text = "Export to MS Excel";
            this.exportexcelbtn.UseVisualStyleBackColor = false;
            this.exportexcelbtn.Click += new System.EventHandler(this.exportexcelbtn_Click);
            // 
            // updateinventorybtn
            // 
            this.updateinventorybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateinventorybtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.updateinventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateinventorybtn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateinventorybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateinventorybtn.Location = new System.Drawing.Point(309, 154);
            this.updateinventorybtn.Name = "updateinventorybtn";
            this.updateinventorybtn.Size = new System.Drawing.Size(180, 36);
            this.updateinventorybtn.TabIndex = 57;
            this.updateinventorybtn.Text = "Update";
            this.updateinventorybtn.UseVisualStyleBackColor = false;
            this.updateinventorybtn.Click += new System.EventHandler(this.updateinventorybtn_Click);
            // 
            // addinventorybtn
            // 
            this.addinventorybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addinventorybtn.BackColor = System.Drawing.Color.LimeGreen;
            this.addinventorybtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addinventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addinventorybtn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addinventorybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addinventorybtn.Location = new System.Drawing.Point(109, 154);
            this.addinventorybtn.Name = "addinventorybtn";
            this.addinventorybtn.Size = new System.Drawing.Size(180, 36);
            this.addinventorybtn.TabIndex = 56;
            this.addinventorybtn.Text = "Add";
            this.addinventorybtn.UseVisualStyleBackColor = false;
            this.addinventorybtn.Click += new System.EventHandler(this.addinventorybtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(383, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity Added";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(84, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Product Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(312, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Inventory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inventorytable
            // 
            this.inventorytable.AllowUserToResizeColumns = false;
            this.inventorytable.AllowUserToResizeRows = false;
            this.inventorytable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventorytable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inventorytable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventorytable.Location = new System.Drawing.Point(88, 294);
            this.inventorytable.Name = "inventorytable";
            this.inventorytable.Size = new System.Drawing.Size(621, 313);
            this.inventorytable.TabIndex = 12;
            this.inventorytable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventorytable_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(212, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 669);
            this.tabControl1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(274, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 40);
            this.label3.TabIndex = 12;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 668);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorytable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inventroybtn;
        private System.Windows.Forms.Button orderitemsbtn;
        private System.Windows.Forms.Button productsbtn;
        private System.Windows.Forms.Button customerbtn;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button transactionbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button clearinventorybtn;
        private System.Windows.Forms.TextBox searchinventorysearch;
        private System.Windows.Forms.TextBox quantityaddedinput;
        private System.Windows.Forms.TextBox prodcutidinput;
        private System.Windows.Forms.Button exportexcelbtn;
        private System.Windows.Forms.Button updateinventorybtn;
        private System.Windows.Forms.Button addinventorybtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView inventorytable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
    }
}