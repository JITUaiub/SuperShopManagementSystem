namespace Shop_Management_System_Project.Panel_Forms
{
    partial class FormHomePageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePageAdmin));
            this.dataGridViewLatestTransection = new System.Windows.Forms.DataGridView();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perunitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superShopDatabaseDataSet9 = new Shop_Management_System_Project.SuperShopDatabaseDataSet9();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.salesReportViewTableAdapter = new Shop_Management_System_Project.SuperShopDatabaseDataSet9TableAdapters.salesReportViewTableAdapter();
            this.btnRefreshCustomer = new ns1.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatestTransection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopDatabaseDataSet9)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLatestTransection
            // 
            this.dataGridViewLatestTransection.AllowUserToAddRows = false;
            this.dataGridViewLatestTransection.AllowUserToDeleteRows = false;
            this.dataGridViewLatestTransection.AllowUserToOrderColumns = true;
            this.dataGridViewLatestTransection.AutoGenerateColumns = false;
            this.dataGridViewLatestTransection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLatestTransection.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLatestTransection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLatestTransection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customernameDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.buydateDataGridViewTextBoxColumn,
            this.invoicenumberDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.perunitpriceDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.dataGridViewLatestTransection.DataSource = this.salesReportViewBindingSource;
            this.dataGridViewLatestTransection.Location = new System.Drawing.Point(18, 28);
            this.dataGridViewLatestTransection.Name = "dataGridViewLatestTransection";
            this.dataGridViewLatestTransection.ReadOnly = true;
            this.dataGridViewLatestTransection.Size = new System.Drawing.Size(1010, 389);
            this.dataGridViewLatestTransection.TabIndex = 1;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "employee_name";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buydateDataGridViewTextBoxColumn
            // 
            this.buydateDataGridViewTextBoxColumn.DataPropertyName = "buy_date";
            this.buydateDataGridViewTextBoxColumn.HeaderText = "buy_date";
            this.buydateDataGridViewTextBoxColumn.Name = "buydateDataGridViewTextBoxColumn";
            this.buydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoicenumberDataGridViewTextBoxColumn
            // 
            this.invoicenumberDataGridViewTextBoxColumn.DataPropertyName = "invoice_number";
            this.invoicenumberDataGridViewTextBoxColumn.HeaderText = "invoice_number";
            this.invoicenumberDataGridViewTextBoxColumn.Name = "invoicenumberDataGridViewTextBoxColumn";
            this.invoicenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perunitpriceDataGridViewTextBoxColumn
            // 
            this.perunitpriceDataGridViewTextBoxColumn.DataPropertyName = "per_unit_price";
            this.perunitpriceDataGridViewTextBoxColumn.HeaderText = "per_unit_price";
            this.perunitpriceDataGridViewTextBoxColumn.Name = "perunitpriceDataGridViewTextBoxColumn";
            this.perunitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesReportViewBindingSource
            // 
            this.salesReportViewBindingSource.DataMember = "salesReportView";
            this.salesReportViewBindingSource.DataSource = this.superShopDatabaseDataSet9;
            // 
            // superShopDatabaseDataSet9
            // 
            this.superShopDatabaseDataSet9.DataSetName = "SuperShopDatabaseDataSet9";
            this.superShopDatabaseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(394, 31);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(346, 37);
            this.lblAdminName.TabIndex = 2;
            this.lblAdminName.Text = "Welcome Admin Name";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesReportViewTableAdapter
            // 
            this.salesReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnRefreshCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefreshCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRefreshCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshCustomer.BorderRadius = 0;
            this.btnRefreshCustomer.ButtonText = "Refresh Transections";
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
            this.btnRefreshCustomer.Location = new System.Drawing.Point(811, 535);
            this.btnRefreshCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRefreshCustomer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRefreshCustomer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefreshCustomer.selected = false;
            this.btnRefreshCustomer.Size = new System.Drawing.Size(229, 54);
            this.btnRefreshCustomer.TabIndex = 21;
            this.btnRefreshCustomer.Text = "Refresh Transections";
            this.btnRefreshCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefreshCustomer.Textcolor = System.Drawing.Color.White;
            this.btnRefreshCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCustomer.Click += new System.EventHandler(this.btnRefreshCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewLatestTransection);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 437);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Latest Transections";
            // 
            // FormHomePageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 598);
            this.Controls.Add(this.btnRefreshCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdminName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1070, 598);
            this.MinimumSize = new System.Drawing.Size(1070, 598);
            this.Name = "FormHomePageAdmin";
            this.Text = "FormHomePage";
            this.Load += new System.EventHandler(this.FormHomePageAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLatestTransection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopDatabaseDataSet9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLatestTransection;
        private System.Windows.Forms.Label lblAdminName;
        private SuperShopDatabaseDataSet9 superShopDatabaseDataSet9;
        private System.Windows.Forms.BindingSource salesReportViewBindingSource;
        private SuperShopDatabaseDataSet9TableAdapters.salesReportViewTableAdapter salesReportViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private ns1.BunifuFlatButton btnRefreshCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}