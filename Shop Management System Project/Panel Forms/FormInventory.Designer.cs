namespace Shop_Management_System_Project.Panel_Forms
{
    partial class FormInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventory));
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superShopDatabaseDataSet = new Shop_Management_System_Project.SuperShopDatabaseDataSet();
            this.btnLoad = new ns1.BunifuFlatButton();
            this.productsTableAdapter = new Shop_Management_System_Project.SuperShopDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.txtSearchItems = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.Inventory = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopDatabaseDataSet)).BeginInit();
            this.Inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToOrderColumns = true;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(19, 101);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(1009, 370);
            this.dataGridViewProducts.TabIndex = 17;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 46);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(155, 24);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Search Category:";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.superShopDatabaseDataSet;
            // 
            // superShopDatabaseDataSet
            // 
            this.superShopDatabaseDataSet.DataSetName = "SuperShopDatabaseDataSet";
            this.superShopDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLoad
            // 
            this.btnLoad.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.BorderRadius = 0;
            this.btnLoad.ButtonText = "Load All Data";
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoad.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLoad.Iconimage")));
            this.btnLoad.Iconimage_right = null;
            this.btnLoad.Iconimage_right_Selected = null;
            this.btnLoad.Iconimage_Selected = null;
            this.btnLoad.IconMarginLeft = 0;
            this.btnLoad.IconMarginRight = 0;
            this.btnLoad.IconRightVisible = true;
            this.btnLoad.IconRightZoom = 0D;
            this.btnLoad.IconVisible = true;
            this.btnLoad.IconZoom = 90D;
            this.btnLoad.IsTab = false;
            this.btnLoad.Location = new System.Drawing.Point(861, 519);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnLoad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLoad.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoad.selected = false;
            this.btnLoad.Size = new System.Drawing.Size(179, 47);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load All Data";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.Textcolor = System.Drawing.Color.White;
            this.btnLoad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(537, 46);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(117, 24);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Search Text:";
            // 
            // txtSearchItems
            // 
            this.txtSearchItems.Location = new System.Drawing.Point(671, 46);
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.Size = new System.Drawing.Size(325, 26);
            this.txtSearchItems.TabIndex = 2;
            this.txtSearchItems.TextChanged += new System.EventHandler(this.txtSearchItems_TextChanged_1);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBoxSearch.Location = new System.Drawing.Point(203, 44);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(291, 28);
            this.comboBoxSearch.TabIndex = 1;
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.bunifuCustomLabel1);
            this.Inventory.Controls.Add(this.dataGridViewProducts);
            this.Inventory.Controls.Add(this.comboBoxSearch);
            this.Inventory.Controls.Add(this.bunifuCustomLabel2);
            this.Inventory.Controls.Add(this.txtSearchItems);
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(12, 16);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(1046, 487);
            this.Inventory.TabIndex = 22;
            this.Inventory.TabStop = false;
            this.Inventory.Text = "Inventory";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 598);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.btnLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1070, 598);
            this.MinimumSize = new System.Drawing.Size(1070, 598);
            this.Name = "FormInventory";
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopDatabaseDataSet)).EndInit();
            this.Inventory.ResumeLayout(false);
            this.Inventory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private SuperShopDatabaseDataSet superShopDatabaseDataSet;
        private ns1.BunifuFlatButton btnLoad;
        private SuperShopDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtSearchItems;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.GroupBox Inventory;

    }
}