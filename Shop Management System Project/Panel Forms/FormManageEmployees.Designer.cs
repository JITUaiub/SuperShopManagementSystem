namespace Shop_Management_System_Project.Panel_Forms
{
    partial class FormManageEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageEmployees));
            this.tabControlManageEmployee = new System.Windows.Forms.TabControl();
            this.tabCreateNewEmployee = new System.Windows.Forms.TabPage();
            this.btnReset = new ns1.BunifuFlatButton();
            this.btnAdd = new ns1.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.joinDate = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.tabExistingEmloyee = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel11 = new ns1.BunifuCustomLabel();
            this.lblEmployeeUserName = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.lblEmployeeName = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.lblEmployeeContactNumber = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.txtSearchItems = new System.Windows.Forms.TextBox();
            this.lblEmployeeAddress = new ns1.BunifuCustomLabel();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel13 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new ns1.BunifuCustomLabel();
            this.btnLoadAll = new ns1.BunifuFlatButton();
            this.btnSaveAll = new ns1.BunifuFlatButton();
            this.btnDeleteEmployee = new ns1.BunifuFlatButton();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.tabControlManageEmployee.SuspendLayout();
            this.tabCreateNewEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabExistingEmloyee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlManageEmployee
            // 
            this.tabControlManageEmployee.Controls.Add(this.tabCreateNewEmployee);
            this.tabControlManageEmployee.Controls.Add(this.tabExistingEmloyee);
            this.tabControlManageEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlManageEmployee.Location = new System.Drawing.Point(0, 0);
            this.tabControlManageEmployee.Name = "tabControlManageEmployee";
            this.tabControlManageEmployee.SelectedIndex = 0;
            this.tabControlManageEmployee.Size = new System.Drawing.Size(1070, 598);
            this.tabControlManageEmployee.TabIndex = 0;
            // 
            // tabCreateNewEmployee
            // 
            this.tabCreateNewEmployee.Controls.Add(this.btnReset);
            this.tabCreateNewEmployee.Controls.Add(this.btnAdd);
            this.tabCreateNewEmployee.Controls.Add(this.groupBox1);
            this.tabCreateNewEmployee.Location = new System.Drawing.Point(4, 27);
            this.tabCreateNewEmployee.Name = "tabCreateNewEmployee";
            this.tabCreateNewEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateNewEmployee.Size = new System.Drawing.Size(1062, 567);
            this.tabCreateNewEmployee.TabIndex = 2;
            this.tabCreateNewEmployee.Text = "Create New Employee";
            this.tabCreateNewEmployee.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Reset Form";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReset.Iconimage")));
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = false;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = false;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(570, 478);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(198, 61);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset Form";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAdd.ButtonText = "Add new employee";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = false;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = false;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(785, 478);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(191, 61);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add new employee";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.joinDate);
            this.groupBox1.Controls.Add(this.txtContactNo);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Location = new System.Drawing.Point(82, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 420);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new employee form";
            // 
            // joinDate
            // 
            this.joinDate.Location = new System.Drawing.Point(303, 331);
            this.joinDate.Name = "joinDate";
            this.joinDate.Size = new System.Drawing.Size(333, 24);
            this.joinDate.TabIndex = 7;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(303, 288);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(333, 24);
            this.txtContactNo.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(303, 243);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(333, 24);
            this.txtAddress.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(303, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 24);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(303, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(333, 24);
            this.txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(303, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(333, 24);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(303, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(333, 24);
            this.txtUsername.TabIndex = 1;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(151, 332);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(119, 24);
            this.bunifuCustomLabel7.TabIndex = 3;
            this.bunifuCustomLabel7.Text = "Joining Date:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(151, 288);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(108, 24);
            this.bunifuCustomLabel6.TabIndex = 3;
            this.bunifuCustomLabel6.Text = "Contact No:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(151, 243);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(85, 24);
            this.bunifuCustomLabel5.TabIndex = 3;
            this.bunifuCustomLabel5.Text = "Address:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(151, 198);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(62, 24);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Email:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(151, 153);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(66, 24);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Name:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(151, 108);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(97, 24);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Password:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(151, 63);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(110, 24);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "User Name:";
            // 
            // tabExistingEmloyee
            // 
            this.tabExistingEmloyee.Controls.Add(this.groupBox2);
            this.tabExistingEmloyee.Controls.Add(this.btnLoadAll);
            this.tabExistingEmloyee.Controls.Add(this.btnSaveAll);
            this.tabExistingEmloyee.Controls.Add(this.btnDeleteEmployee);
            this.tabExistingEmloyee.Controls.Add(this.dataGridViewEmployee);
            this.tabExistingEmloyee.Location = new System.Drawing.Point(4, 27);
            this.tabExistingEmloyee.Name = "tabExistingEmloyee";
            this.tabExistingEmloyee.Padding = new System.Windows.Forms.Padding(3);
            this.tabExistingEmloyee.Size = new System.Drawing.Size(1062, 567);
            this.tabExistingEmloyee.TabIndex = 1;
            this.tabExistingEmloyee.Text = "Manage Existing Employees";
            this.tabExistingEmloyee.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuCustomLabel11);
            this.groupBox2.Controls.Add(this.lblEmployeeUserName);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel10);
            this.groupBox2.Controls.Add(this.lblEmployeeName);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox2.Controls.Add(this.lblEmployeeContactNumber);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox2.Controls.Add(this.txtSearchItems);
            this.groupBox2.Controls.Add(this.lblEmployeeAddress);
            this.groupBox2.Controls.Add(this.comboBoxSearch);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel13);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel14);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 155);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Information";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(12, 65);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(198, 24);
            this.bunifuCustomLabel11.TabIndex = 33;
            this.bunifuCustomLabel11.Text = "Employee Username: ";
            // 
            // lblEmployeeUserName
            // 
            this.lblEmployeeUserName.AutoSize = true;
            this.lblEmployeeUserName.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmployeeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeUserName.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeUserName.Location = new System.Drawing.Point(208, 69);
            this.lblEmployeeUserName.Name = "lblEmployeeUserName";
            this.lblEmployeeUserName.Size = new System.Drawing.Size(56, 18);
            this.lblEmployeeUserName.TabIndex = 37;
            this.lblEmployeeUserName.Text = "Name: ";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(341, 59);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(71, 24);
            this.bunifuCustomLabel10.TabIndex = 34;
            this.bunifuCustomLabel10.Text = "Name: ";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeName.Location = new System.Drawing.Point(437, 65);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(56, 18);
            this.lblEmployeeName.TabIndex = 39;
            this.lblEmployeeName.Text = "Name: ";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(12, 119);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(157, 24);
            this.bunifuCustomLabel9.TabIndex = 35;
            this.bunifuCustomLabel9.Text = "Contact Number: ";
            // 
            // lblEmployeeContactNumber
            // 
            this.lblEmployeeContactNumber.AutoSize = true;
            this.lblEmployeeContactNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmployeeContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeContactNumber.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeContactNumber.Location = new System.Drawing.Point(208, 123);
            this.lblEmployeeContactNumber.Name = "lblEmployeeContactNumber";
            this.lblEmployeeContactNumber.Size = new System.Drawing.Size(56, 18);
            this.lblEmployeeContactNumber.TabIndex = 38;
            this.lblEmployeeContactNumber.Text = "Name: ";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(341, 117);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(90, 24);
            this.bunifuCustomLabel8.TabIndex = 36;
            this.bunifuCustomLabel8.Text = "Address: ";
            // 
            // txtSearchItems
            // 
            this.txtSearchItems.Location = new System.Drawing.Point(804, 50);
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.Size = new System.Drawing.Size(232, 24);
            this.txtSearchItems.TabIndex = 2;
            this.txtSearchItems.TextChanged += new System.EventHandler(this.txtSearchItems_TextChanged);
            // 
            // lblEmployeeAddress
            // 
            this.lblEmployeeAddress.AutoSize = true;
            this.lblEmployeeAddress.BackColor = System.Drawing.SystemColors.Window;
            this.lblEmployeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAddress.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeAddress.Location = new System.Drawing.Point(437, 121);
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            this.lblEmployeeAddress.Size = new System.Drawing.Size(56, 18);
            this.lblEmployeeAddress.TabIndex = 40;
            this.lblEmployeeAddress.Text = "Name: ";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Username",
            "Name",
            "Contact Number"});
            this.comboBoxSearch.Location = new System.Drawing.Point(804, 18);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(232, 26);
            this.comboBoxSearch.TabIndex = 1;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(681, 50);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(117, 24);
            this.bunifuCustomLabel13.TabIndex = 31;
            this.bunifuCustomLabel13.Text = "Search Text:";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(643, 18);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(155, 24);
            this.bunifuCustomLabel14.TabIndex = 29;
            this.bunifuCustomLabel14.Text = "Search Category:";
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnLoadAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnLoadAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadAll.BorderRadius = 0;
            this.btnLoadAll.ButtonText = "Load All Data";
            this.btnLoadAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoadAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoadAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLoadAll.Iconimage")));
            this.btnLoadAll.Iconimage_right = null;
            this.btnLoadAll.Iconimage_right_Selected = null;
            this.btnLoadAll.Iconimage_Selected = null;
            this.btnLoadAll.IconMarginLeft = 0;
            this.btnLoadAll.IconMarginRight = 0;
            this.btnLoadAll.IconRightVisible = true;
            this.btnLoadAll.IconRightZoom = 0D;
            this.btnLoadAll.IconVisible = true;
            this.btnLoadAll.IconZoom = 70D;
            this.btnLoadAll.IsTab = false;
            this.btnLoadAll.Location = new System.Drawing.Point(487, 513);
            this.btnLoadAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnLoadAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLoadAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoadAll.selected = false;
            this.btnLoadAll.Size = new System.Drawing.Size(168, 47);
            this.btnLoadAll.TabIndex = 4;
            this.btnLoadAll.Text = "Load All Data";
            this.btnLoadAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadAll.Textcolor = System.Drawing.Color.White;
            this.btnLoadAll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnSaveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnSaveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveAll.BorderRadius = 0;
            this.btnSaveAll.ButtonText = "Save";
            this.btnSaveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveAll.Iconimage")));
            this.btnSaveAll.Iconimage_right = null;
            this.btnSaveAll.Iconimage_right_Selected = null;
            this.btnSaveAll.Iconimage_Selected = null;
            this.btnSaveAll.IconMarginLeft = 0;
            this.btnSaveAll.IconMarginRight = 0;
            this.btnSaveAll.IconRightVisible = false;
            this.btnSaveAll.IconRightZoom = 0D;
            this.btnSaveAll.IconVisible = true;
            this.btnSaveAll.IconZoom = 70D;
            this.btnSaveAll.IsTab = false;
            this.btnSaveAll.Location = new System.Drawing.Point(873, 513);
            this.btnSaveAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnSaveAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSaveAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveAll.selected = false;
            this.btnSaveAll.Size = new System.Drawing.Size(165, 47);
            this.btnSaveAll.TabIndex = 3;
            this.btnSaveAll.Text = "Save";
            this.btnSaveAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveAll.Textcolor = System.Drawing.Color.White;
            this.btnSaveAll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnDeleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnDeleteEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteEmployee.BorderRadius = 0;
            this.btnDeleteEmployee.ButtonText = "Delete Employee";
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteEmployee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Iconimage")));
            this.btnDeleteEmployee.Iconimage_right = null;
            this.btnDeleteEmployee.Iconimage_right_Selected = null;
            this.btnDeleteEmployee.Iconimage_Selected = null;
            this.btnDeleteEmployee.IconMarginLeft = 0;
            this.btnDeleteEmployee.IconMarginRight = 0;
            this.btnDeleteEmployee.IconRightVisible = false;
            this.btnDeleteEmployee.IconRightZoom = 0D;
            this.btnDeleteEmployee.IconVisible = true;
            this.btnDeleteEmployee.IconZoom = 70D;
            this.btnDeleteEmployee.IsTab = false;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(670, 513);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnDeleteEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.selected = false;
            this.btnDeleteEmployee.Size = new System.Drawing.Size(190, 47);
            this.btnDeleteEmployee.TabIndex = 6;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteEmployee.Textcolor = System.Drawing.Color.White;
            this.btnDeleteEmployee.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToOrderColumns = true;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(29, 169);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1009, 335);
            this.dataGridViewEmployee.TabIndex = 42;
            this.dataGridViewEmployee.SelectionChanged += new System.EventHandler(this.dataGridViewEmployee_SelectionChanged);
            // 
            // FormManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 598);
            this.Controls.Add(this.tabControlManageEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1070, 598);
            this.MinimumSize = new System.Drawing.Size(1070, 598);
            this.Name = "FormManageEmployees";
            this.Text = "FormManageEmployees";
            this.Load += new System.EventHandler(this.FormManageEmployees_Load);
            this.tabControlManageEmployee.ResumeLayout(false);
            this.tabCreateNewEmployee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabExistingEmloyee.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManageEmployee;
        private System.Windows.Forms.TabPage tabCreateNewEmployee;
        private System.Windows.Forms.TabPage tabExistingEmloyee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker joinDate;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuFlatButton btnReset;
        private ns1.BunifuFlatButton btnAdd;
        private System.Windows.Forms.TextBox txtSearchItems;
        private ns1.BunifuCustomLabel lblEmployeeAddress;
        private ns1.BunifuCustomLabel lblEmployeeName;
        private ns1.BunifuCustomLabel lblEmployeeContactNumber;
        private ns1.BunifuCustomLabel lblEmployeeUserName;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private ns1.BunifuCustomLabel bunifuCustomLabel11;
        private ns1.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private ns1.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private ns1.BunifuFlatButton btnDeleteEmployee;
        private ns1.BunifuFlatButton btnLoadAll;
        private ns1.BunifuFlatButton btnSaveAll;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}