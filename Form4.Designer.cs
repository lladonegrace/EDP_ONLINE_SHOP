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
            this.orderitemtable = new System.Windows.Forms.Label();
            this.orderitemview = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ordertable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customeridinput = new System.Windows.Forms.TextBox();
            this.orderidinput = new System.Windows.Forms.TextBox();
            this.orderstatusinput = new System.Windows.Forms.TextBox();
            this.updateorderbtn = new System.Windows.Forms.Button();
            this.deleteorderbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.paymenttable = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.paymentidinput = new System.Windows.Forms.TextBox();
            this.paymentstatusinput = new System.Windows.Forms.TextBox();
            this.updatepaymentbtn = new System.Windows.Forms.Button();
            this.deletepaymentbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemview)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            // orderitemtable
            // 
            this.orderitemtable.AutoSize = true;
            this.orderitemtable.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderitemtable.ForeColor = System.Drawing.Color.LightCoral;
            this.orderitemtable.Location = new System.Drawing.Point(276, 247);
            this.orderitemtable.Name = "orderitemtable";
            this.orderitemtable.Size = new System.Drawing.Size(253, 37);
            this.orderitemtable.TabIndex = 11;
            this.orderitemtable.Text = "Order Items Table";
            this.orderitemtable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderitemview
            // 
            this.orderitemview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderitemview.Location = new System.Drawing.Point(120, 303);
            this.orderitemview.Name = "orderitemview";
            this.orderitemview.Size = new System.Drawing.Size(522, 266);
            this.orderitemview.TabIndex = 12;
            this.orderitemview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderitemview_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(227, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 644);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.orderitemtable);
            this.tabPage1.Controls.Add(this.orderitemview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order_items_Table";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.deleteorderbtn);
            this.tabPage2.Controls.Add(this.updateorderbtn);
            this.tabPage2.Controls.Add(this.orderstatusinput);
            this.tabPage2.Controls.Add(this.orderidinput);
            this.tabPage2.Controls.Add(this.customeridinput);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ordertable);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage3.Controls.Add(this.deletepaymentbtn);
            this.tabPage3.Controls.Add(this.updatepaymentbtn);
            this.tabPage3.Controls.Add(this.paymentstatusinput);
            this.tabPage3.Controls.Add(this.paymentidinput);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.paymenttable);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(746, 618);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(290, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Table";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ordertable
            // 
            this.ordertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordertable.Location = new System.Drawing.Point(73, 319);
            this.ordertable.Name = "ordertable";
            this.ordertable.Size = new System.Drawing.Size(627, 259);
            this.ordertable.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(273, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Update Order ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(127, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(125, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(152, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Order Id";
            // 
            // customeridinput
            // 
            this.customeridinput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeridinput.Location = new System.Drawing.Point(234, 99);
            this.customeridinput.Name = "customeridinput";
            this.customeridinput.Size = new System.Drawing.Size(170, 25);
            this.customeridinput.TabIndex = 6;
            // 
            // orderidinput
            // 
            this.orderidinput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidinput.Location = new System.Drawing.Point(234, 141);
            this.orderidinput.Name = "orderidinput";
            this.orderidinput.Size = new System.Drawing.Size(170, 25);
            this.orderidinput.TabIndex = 7;
            // 
            // orderstatusinput
            // 
            this.orderstatusinput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderstatusinput.Location = new System.Drawing.Point(234, 185);
            this.orderstatusinput.Name = "orderstatusinput";
            this.orderstatusinput.Size = new System.Drawing.Size(170, 25);
            this.orderstatusinput.TabIndex = 8;
            // 
            // updateorderbtn
            // 
            this.updateorderbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.updateorderbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.updateorderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateorderbtn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateorderbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateorderbtn.Location = new System.Drawing.Point(456, 99);
            this.updateorderbtn.Name = "updateorderbtn";
            this.updateorderbtn.Size = new System.Drawing.Size(175, 44);
            this.updateorderbtn.TabIndex = 9;
            this.updateorderbtn.Text = "Update";
            this.updateorderbtn.UseVisualStyleBackColor = false;
            // 
            // deleteorderbtn
            // 
            this.deleteorderbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.deleteorderbtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteorderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteorderbtn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteorderbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteorderbtn.Location = new System.Drawing.Point(456, 166);
            this.deleteorderbtn.Name = "deleteorderbtn";
            this.deleteorderbtn.Size = new System.Drawing.Size(175, 44);
            this.deleteorderbtn.TabIndex = 10;
            this.deleteorderbtn.Text = "Delete";
            this.deleteorderbtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(262, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Payment Table";
            // 
            // paymenttable
            // 
            this.paymenttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymenttable.Location = new System.Drawing.Point(56, 344);
            this.paymenttable.Name = "paymenttable";
            this.paymenttable.Size = new System.Drawing.Size(644, 243);
            this.paymenttable.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Salmon;
            this.label8.Location = new System.Drawing.Point(253, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "Update Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Salmon;
            this.label9.Location = new System.Drawing.Point(80, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Payment Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Salmon;
            this.label10.Location = new System.Drawing.Point(359, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = " Payment Status";
            // 
            // paymentidinput
            // 
            this.paymentidinput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentidinput.Location = new System.Drawing.Point(172, 123);
            this.paymentidinput.Name = "paymentidinput";
            this.paymentidinput.Size = new System.Drawing.Size(162, 25);
            this.paymentidinput.TabIndex = 5;
            // 
            // paymentstatusinput
            // 
            this.paymentstatusinput.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentstatusinput.Location = new System.Drawing.Point(495, 123);
            this.paymentstatusinput.Name = "paymentstatusinput";
            this.paymentstatusinput.Size = new System.Drawing.Size(162, 25);
            this.paymentstatusinput.TabIndex = 6;
            // 
            // updatepaymentbtn
            // 
            this.updatepaymentbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.updatepaymentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatepaymentbtn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatepaymentbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatepaymentbtn.Location = new System.Drawing.Point(190, 188);
            this.updatepaymentbtn.Name = "updatepaymentbtn";
            this.updatepaymentbtn.Size = new System.Drawing.Size(175, 44);
            this.updatepaymentbtn.TabIndex = 7;
            this.updatepaymentbtn.Text = "Update";
            this.updatepaymentbtn.UseVisualStyleBackColor = false;
            // 
            // deletepaymentbtn
            // 
            this.deletepaymentbtn.BackColor = System.Drawing.Color.IndianRed;
            this.deletepaymentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletepaymentbtn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletepaymentbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletepaymentbtn.Location = new System.Drawing.Point(404, 188);
            this.deletepaymentbtn.Name = "deletepaymentbtn";
            this.deletepaymentbtn.Size = new System.Drawing.Size(175, 44);
            this.deletepaymentbtn.TabIndex = 8;
            this.deletepaymentbtn.Text = "Delete";
            this.deletepaymentbtn.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::EDP_ONLINE_SHOP.Properties.Resources._294bba2466aff48c4c5c7742e243cd3a;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(29, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 203);
            this.panel2.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemview)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttable)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button inventorybtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ordertable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customeridinput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateorderbtn;
        private System.Windows.Forms.TextBox orderstatusinput;
        private System.Windows.Forms.TextBox orderidinput;
        private System.Windows.Forms.Button deleteorderbtn;
        private System.Windows.Forms.DataGridView paymenttable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updatepaymentbtn;
        private System.Windows.Forms.TextBox paymentstatusinput;
        private System.Windows.Forms.TextBox paymentidinput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deletepaymentbtn;
    }
}