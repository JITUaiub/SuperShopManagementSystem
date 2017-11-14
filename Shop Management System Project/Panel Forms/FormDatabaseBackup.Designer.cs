namespace Shop_Management_System_Project.Panel_Forms
{
    partial class FormDatabaseBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabaseBackup));
            this.groupBoxBackup = new System.Windows.Forms.GroupBox();
            this.btnBackupBrowse = new ns1.BunifuFlatButton();
            this.btnBackup = new ns1.BunifuFlatButton();
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestoreBrowse = new ns1.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestore = new ns1.BunifuFlatButton();
            this.txtRestoreLocation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxBackup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBackup
            // 
            this.groupBoxBackup.Controls.Add(this.btnBackupBrowse);
            this.groupBoxBackup.Controls.Add(this.btnBackup);
            this.groupBoxBackup.Controls.Add(this.txtBackupLocation);
            this.groupBoxBackup.Controls.Add(this.label2);
            this.groupBoxBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBackup.Location = new System.Drawing.Point(97, 78);
            this.groupBoxBackup.Name = "groupBoxBackup";
            this.groupBoxBackup.Size = new System.Drawing.Size(839, 158);
            this.groupBoxBackup.TabIndex = 2;
            this.groupBoxBackup.TabStop = false;
            this.groupBoxBackup.Text = "Backup database";
            // 
            // btnBackupBrowse
            // 
            this.btnBackupBrowse.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnBackupBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackupBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnBackupBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackupBrowse.BorderRadius = 0;
            this.btnBackupBrowse.ButtonText = "Browse";
            this.btnBackupBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackupBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnBackupBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBackupBrowse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBackupBrowse.Iconimage")));
            this.btnBackupBrowse.Iconimage_right = null;
            this.btnBackupBrowse.Iconimage_right_Selected = null;
            this.btnBackupBrowse.Iconimage_Selected = null;
            this.btnBackupBrowse.IconMarginLeft = 0;
            this.btnBackupBrowse.IconMarginRight = 0;
            this.btnBackupBrowse.IconRightVisible = true;
            this.btnBackupBrowse.IconRightZoom = 0D;
            this.btnBackupBrowse.IconVisible = true;
            this.btnBackupBrowse.IconZoom = 90D;
            this.btnBackupBrowse.IsTab = false;
            this.btnBackupBrowse.Location = new System.Drawing.Point(666, 22);
            this.btnBackupBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackupBrowse.Name = "btnBackupBrowse";
            this.btnBackupBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnBackupBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBackupBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackupBrowse.selected = false;
            this.btnBackupBrowse.Size = new System.Drawing.Size(135, 56);
            this.btnBackupBrowse.TabIndex = 1;
            this.btnBackupBrowse.Text = "Browse";
            this.btnBackupBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBackupBrowse.Textcolor = System.Drawing.Color.White;
            this.btnBackupBrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupBrowse.Click += new System.EventHandler(this.btnBackupBrowse_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.BorderRadius = 0;
            this.btnBackup.ButtonText = "Backup";
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.DisabledColor = System.Drawing.Color.Gray;
            this.btnBackup.Enabled = false;
            this.btnBackup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBackup.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBackup.Iconimage")));
            this.btnBackup.Iconimage_right = null;
            this.btnBackup.Iconimage_right_Selected = null;
            this.btnBackup.Iconimage_Selected = null;
            this.btnBackup.IconMarginLeft = 0;
            this.btnBackup.IconMarginRight = 0;
            this.btnBackup.IconRightVisible = true;
            this.btnBackup.IconRightZoom = 0D;
            this.btnBackup.IconVisible = true;
            this.btnBackup.IconZoom = 90D;
            this.btnBackup.IsTab = false;
            this.btnBackup.Location = new System.Drawing.Point(666, 93);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnBackup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBackup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackup.selected = false;
            this.btnBackup.Size = new System.Drawing.Size(135, 52);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBackup.Textcolor = System.Drawing.Color.White;
            this.btnBackup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Location = new System.Drawing.Point(119, 39);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.Size = new System.Drawing.Size(535, 26);
            this.txtBackupLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestoreBrowse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.txtRestoreLocation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restore from database";
            // 
            // btnRestoreBrowse
            // 
            this.btnRestoreBrowse.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnRestoreBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestoreBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRestoreBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestoreBrowse.BorderRadius = 0;
            this.btnRestoreBrowse.ButtonText = "Browse";
            this.btnRestoreBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnRestoreBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRestoreBrowse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRestoreBrowse.Iconimage")));
            this.btnRestoreBrowse.Iconimage_right = null;
            this.btnRestoreBrowse.Iconimage_right_Selected = null;
            this.btnRestoreBrowse.Iconimage_Selected = null;
            this.btnRestoreBrowse.IconMarginLeft = 0;
            this.btnRestoreBrowse.IconMarginRight = 0;
            this.btnRestoreBrowse.IconRightVisible = true;
            this.btnRestoreBrowse.IconRightZoom = 0D;
            this.btnRestoreBrowse.IconVisible = true;
            this.btnRestoreBrowse.IconZoom = 90D;
            this.btnRestoreBrowse.IsTab = false;
            this.btnRestoreBrowse.Location = new System.Drawing.Point(666, 23);
            this.btnRestoreBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestoreBrowse.Name = "btnRestoreBrowse";
            this.btnRestoreBrowse.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRestoreBrowse.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRestoreBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRestoreBrowse.selected = false;
            this.btnRestoreBrowse.Size = new System.Drawing.Size(135, 56);
            this.btnRestoreBrowse.TabIndex = 4;
            this.btnRestoreBrowse.Text = "Browse";
            this.btnRestoreBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRestoreBrowse.Textcolor = System.Drawing.Color.White;
            this.btnRestoreBrowse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreBrowse.Click += new System.EventHandler(this.btnRestoreBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location: ";
            // 
            // btnRestore
            // 
            this.btnRestore.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestore.BorderRadius = 0;
            this.btnRestore.ButtonText = "Restore";
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DisabledColor = System.Drawing.Color.Gray;
            this.btnRestore.Enabled = false;
            this.btnRestore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRestore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRestore.Iconimage")));
            this.btnRestore.Iconimage_right = null;
            this.btnRestore.Iconimage_right_Selected = null;
            this.btnRestore.Iconimage_Selected = null;
            this.btnRestore.IconMarginLeft = 0;
            this.btnRestore.IconMarginRight = 0;
            this.btnRestore.IconRightVisible = true;
            this.btnRestore.IconRightZoom = 0D;
            this.btnRestore.IconVisible = true;
            this.btnRestore.IconZoom = 90D;
            this.btnRestore.IsTab = false;
            this.btnRestore.Location = new System.Drawing.Point(666, 89);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnRestore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRestore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRestore.selected = false;
            this.btnRestore.Size = new System.Drawing.Size(135, 57);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRestore.Textcolor = System.Drawing.Color.White;
            this.btnRestore.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtRestoreLocation
            // 
            this.txtRestoreLocation.Location = new System.Drawing.Point(119, 44);
            this.txtRestoreLocation.Name = "txtRestoreLocation";
            this.txtRestoreLocation.Size = new System.Drawing.Size(535, 26);
            this.txtRestoreLocation.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxBackup);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1026, 566);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup your Database";
            // 
            // FormDatabaseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 598);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1070, 598);
            this.MinimumSize = new System.Drawing.Size(1070, 598);
            this.Name = "FormDatabaseBackup";
            this.Text = "FormDatabaseBackup";
            this.groupBoxBackup.ResumeLayout(false);
            this.groupBoxBackup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBackup;
        private System.Windows.Forms.TextBox txtBackupLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuFlatButton btnBackupBrowse;
        private ns1.BunifuFlatButton btnBackup;
        private ns1.BunifuFlatButton btnRestoreBrowse;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuFlatButton btnRestore;
        private System.Windows.Forms.TextBox txtRestoreLocation;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}