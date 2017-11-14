namespace Shop_Management_System_Project.Panel_Forms
{
    partial class FormSellProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSellProducts));
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.btnRefreshCustomer = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.comboBoxCustomerList = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superShopDatabaseDataSetCustomerList = new Shop_Management_System_Project.SuperShopDatabaseDataSetCustomerList();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnReset = new ns1.BunifuFlatButton();
            this.btnAdd = new ns1.BunifuFlatButton();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerContactNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superShopDatabaseDataSetProductName = new Shop_Management_System_Project.SuperShopDatabaseDataSetProductName();
            this.btnRemoveItem = new ns1.BunifuFlatButton();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.btnAddItem = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.dataGridViewRecipt = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new ns1.BunifuCustomLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCashReceived = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblChangedAmunt = new ns1.BunifuCustomLabel();
            this.btnPrint = new ns1.BunifuFlatButton();
            this.customerTableAdapter = new Shop_Management_System_Project.SuperShopDatabaseDataSetCustomerListTableAdapters.CustomerTableAdapter();
            this.productsTableAdapter = new Shop_Management_System_Project.SuperShopDatabaseDataSetProductNameTableAdapters.ProductsTableAdapter();
            this.groupBoxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopDatabaseDataSetCustomerList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopDatabaseDataSetProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipt)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.btnRefreshCustomer);
            this.groupBoxCustomer.Controls.Add(this.bunifuCustomLabel1);
            this.groupBoxCustomer.Controls.Add(this.comboBoxCustomerList);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomer.Location = new System.Drawing.Point(25, 10);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(415, 152);
            this.groupBoxCustomer.TabIndex = 0;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Select Customer";
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnRefreshCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefreshCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRefreshCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshCustomer.BorderRadius = 0;
            this.btnRefreshCustomer.ButtonText = "Refresh Customer List";
            this.btnRefreshCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefreshCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefreshCustomer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRefreshCustomer.Iconimage")));
            this.btnRefreshCustomer.Iconimage_right = null;
            this.btnRefreshCustomer.Iconimage_right_Selected = null;
            this.btnRefreshCustomer.Iconimage_Selected = null;
            this.btnRefreshCustomer.IconMarginLeft = 0;
            this.btnRefreshCustomer.IconMarginRight = 0;
            this.btnRefreshCustomer.IconRightVisible = true;
            this.btnRefreshCustomer.IconRightZoom = 0D;
            this.btnRefreshCustomer.IconVisible = true;
            this.btnRefreshCustomer.IconZoom = 90D;
            this.btnRefreshCustomer.IsTab = false;
            this.btnRefreshCustomer.Location = new System.Drawing.Point(255, 84);
            this.btnRefreshCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRefreshCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRefreshCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefreshCustomer.selected = false;
            this.btnRefreshCustomer.Size = new System.Drawing.Size(153, 42);
            this.btnRefreshCustomer.TabIndex = 19;
            this.btnRefreshCustomer.Text = "Refresh Customer List";
            this.btnRefreshCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefreshCustomer.Textcolor = System.Drawing.Color.White;
            this.btnRefreshCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCustomer.Click += new System.EventHandler(this.btnRefreshCustomer_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 42);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(128, 24);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Customer List:";
            // 
            // comboBoxCustomerList
            // 
            this.comboBoxCustomerList.DataSource = this.customerBindingSource;
            this.comboBoxCustomerList.DisplayMember = "name";
            this.comboBoxCustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxCustomerList.FormattingEnabled = true;
            this.comboBoxCustomerList.Location = new System.Drawing.Point(140, 43);
            this.comboBoxCustomerList.Name = "comboBoxCustomerList";
            this.comboBoxCustomerList.Size = new System.Drawing.Size(269, 26);
            this.comboBoxCustomerList.TabIndex = 1;
            this.comboBoxCustomerList.ValueMember = "name";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.superShopDatabaseDataSetCustomerList;
            // 
            // superShopDatabaseDataSetCustomerList
            // 
            this.superShopDatabaseDataSetCustomerList.DataSetName = "SuperShopDatabaseDataSetCustomerList";
            this.superShopDatabaseDataSetCustomerList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 20);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(152, 24);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Customer Name:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(6, 64);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(171, 24);
            this.bunifuCustomLabel4.TabIndex = 21;
            this.bunifuCustomLabel4.Text = "Customer Address:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(6, 105);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(194, 24);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "Customer Contact No:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(205, 27);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(254, 24);
            this.txtCustomerName.TabIndex = 22;
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(939, 94);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(119, 52);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(939, 30);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(119, 49);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(205, 67);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(254, 24);
            this.txtCustomerAddress.TabIndex = 22;
            // 
            // txtCustomerContactNo
            // 
            this.txtCustomerContactNo.Location = new System.Drawing.Point(204, 104);
            this.txtCustomerContactNo.Name = "txtCustomerContactNo";
            this.txtCustomerContactNo.Size = new System.Drawing.Size(255, 24);
            this.txtCustomerContactNo.TabIndex = 22;
            this.txtCustomerContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerContactNo_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.txtCustomerContactNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(443, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 152);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuFlatButton1);
            this.groupBox2.Controls.Add(this.comboBoxProductName);
            this.groupBox2.Controls.Add(this.btnRemoveItem);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1033, 127);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AddProduct";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Refresh Products List";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(250, 74);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(153, 42);
            this.bunifuFlatButton1.TabIndex = 25;
            this.bunifuFlatButton1.Text = "Refresh Products List";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.DataSource = this.productsBindingSource;
            this.comboBoxProductName.DisplayMember = "name";
            this.comboBoxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(148, 39);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(255, 26);
            this.comboBoxProductName.TabIndex = 2;
            this.comboBoxProductName.ValueMember = "name";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.superShopDatabaseDataSetProductName;
            // 
            // superShopDatabaseDataSetProductName
            // 
            this.superShopDatabaseDataSetProductName.DataSetName = "SuperShopDatabaseDataSetProductName";
            this.superShopDatabaseDataSetProductName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveItem.BorderRadius = 0;
            this.btnRemoveItem.ButtonText = "Remove Item";
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemoveItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Iconimage")));
            this.btnRemoveItem.Iconimage_right = null;
            this.btnRemoveItem.Iconimage_right_Selected = null;
            this.btnRemoveItem.Iconimage_Selected = null;
            this.btnRemoveItem.IconMarginLeft = 0;
            this.btnRemoveItem.IconMarginRight = 0;
            this.btnRemoveItem.IconRightVisible = true;
            this.btnRemoveItem.IconRightZoom = 0D;
            this.btnRemoveItem.IconVisible = true;
            this.btnRemoveItem.IconZoom = 90D;
            this.btnRemoveItem.IsTab = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(818, 68);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRemoveItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRemoveItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemoveItem.selected = false;
            this.btnRemoveItem.Size = new System.Drawing.Size(203, 48);
            this.btnRemoveItem.TabIndex = 24;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItem.Textcolor = System.Drawing.Color.White;
            this.btnRemoveItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(536, 41);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(255, 24);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(447, 41);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(83, 24);
            this.bunifuCustomLabel7.TabIndex = 17;
            this.bunifuCustomLabel7.Text = "Quantity:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddItem.BorderRadius = 0;
            this.btnAddItem.ButtonText = "Add Item";
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Iconimage")));
            this.btnAddItem.Iconimage_right = null;
            this.btnAddItem.Iconimage_right_Selected = null;
            this.btnAddItem.Iconimage_Selected = null;
            this.btnAddItem.IconMarginLeft = 0;
            this.btnAddItem.IconMarginRight = 0;
            this.btnAddItem.IconRightVisible = true;
            this.btnAddItem.IconRightZoom = 0D;
            this.btnAddItem.IconVisible = true;
            this.btnAddItem.IconZoom = 90D;
            this.btnAddItem.IsTab = false;
            this.btnAddItem.Location = new System.Drawing.Point(818, 13);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnAddItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddItem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddItem.selected = false;
            this.btnAddItem.Size = new System.Drawing.Size(203, 52);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Textcolor = System.Drawing.Color.White;
            this.btnAddItem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(6, 40);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(136, 24);
            this.bunifuCustomLabel6.TabIndex = 17;
            this.bunifuCustomLabel6.Text = "Product Name:";
            // 
            // dataGridViewRecipt
            // 
            this.dataGridViewRecipt.AllowUserToAddRows = false;
            this.dataGridViewRecipt.AllowUserToDeleteRows = false;
            this.dataGridViewRecipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecipt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewRecipt.Location = new System.Drawing.Point(25, 301);
            this.dataGridViewRecipt.Name = "dataGridViewRecipt";
            this.dataGridViewRecipt.Size = new System.Drawing.Size(816, 270);
            this.dataGridViewRecipt.TabIndex = 27;
            this.dataGridViewRecipt.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipt_CellEndEdit);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Per Unit Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Price";
            this.Column5.Name = "Column5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalAmount);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(847, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 63);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount have to pay";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(94, 25);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(20, 24);
            this.lblTotalAmount.TabIndex = 18;
            this.lblTotalAmount.Text = "0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCashReceived);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(847, 377);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 66);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cash Received:";
            // 
            // txtCashReceived
            // 
            this.txtCashReceived.Location = new System.Drawing.Point(29, 29);
            this.txtCashReceived.Name = "txtCashReceived";
            this.txtCashReceived.Size = new System.Drawing.Size(163, 24);
            this.txtCashReceived.TabIndex = 5;
            this.txtCashReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCashReceived.TextChanged += new System.EventHandler(this.txtCashReceived_TextChanged);
            this.txtCashReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashReceived_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblChangedAmunt);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(847, 449);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 64);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Change Amount";
            // 
            // lblChangedAmunt
            // 
            this.lblChangedAmunt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangedAmunt.AutoSize = true;
            this.lblChangedAmunt.BackColor = System.Drawing.SystemColors.Window;
            this.lblChangedAmunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangedAmunt.ForeColor = System.Drawing.Color.Black;
            this.lblChangedAmunt.Location = new System.Drawing.Point(96, 25);
            this.lblChangedAmunt.Name = "lblChangedAmunt";
            this.lblChangedAmunt.Size = new System.Drawing.Size(20, 24);
            this.lblChangedAmunt.TabIndex = 18;
            this.lblChangedAmunt.Text = "0";
            this.lblChangedAmunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.ButtonText = "Print Recipt";
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrint.Iconimage")));
            this.btnPrint.Iconimage_right = null;
            this.btnPrint.Iconimage_right_Selected = null;
            this.btnPrint.Iconimage_Selected = null;
            this.btnPrint.IconMarginLeft = 0;
            this.btnPrint.IconMarginRight = 0;
            this.btnPrint.IconRightVisible = true;
            this.btnPrint.IconRightZoom = 0D;
            this.btnPrint.IconVisible = true;
            this.btnPrint.IconZoom = 90D;
            this.btnPrint.IsTab = false;
            this.btnPrint.Location = new System.Drawing.Point(847, 523);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrint.selected = false;
            this.btnPrint.Size = new System.Drawing.Size(211, 48);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print Recipt";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.Textcolor = System.Drawing.Color.White;
            this.btnPrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // FormSellProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 598);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridViewRecipt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1070, 598);
            this.MinimumSize = new System.Drawing.Size(1070, 598);
            this.Name = "FormSellProducts";
            this.Text = "FormSellProducts";
            this.Load += new System.EventHandler(this.FormSellProducts_Load);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopDatabaseDataSetCustomerList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopDatabaseDataSetProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomerList;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuFlatButton btnRefreshCustomer;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private ns1.BunifuFlatButton btnReset;
        private ns1.BunifuFlatButton btnAdd;
        private System.Windows.Forms.TextBox txtCustomerContactNo;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuFlatButton btnRemoveItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuFlatButton btnAddItem;
        private System.Windows.Forms.DataGridView dataGridViewRecipt;
        private System.Windows.Forms.GroupBox groupBox3;
        private ns1.BunifuCustomLabel lblTotalAmount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCashReceived;
        private System.Windows.Forms.GroupBox groupBox5;
        private ns1.BunifuCustomLabel lblChangedAmunt;
        private ns1.BunifuFlatButton btnPrint;
        private SuperShopDatabaseDataSetCustomerList superShopDatabaseDataSetCustomerList;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private SuperShopDatabaseDataSetCustomerListTableAdapters.CustomerTableAdapter customerTableAdapter;
        private SuperShopDatabaseDataSetProductName superShopDatabaseDataSetProductName;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SuperShopDatabaseDataSetProductNameTableAdapters.ProductsTableAdapter productsTableAdapter;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}