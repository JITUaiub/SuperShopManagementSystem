namespace Shop_Management_System_Project.Panel_Forms
{
    partial class FormManageUserEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageUserEmployee));
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSignOut = new ns1.BunifuFlatButton();
            this.btnUpdateAll = new ns1.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 53);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(164, 24);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Current Password:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(203, 57);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(329, 29);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(21, 157);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(62, 24);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(203, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 29);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(21, 96);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(141, 24);
            this.bunifuCustomLabel7.TabIndex = 9;
            this.bunifuCustomLabel7.Text = "New Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 29);
            this.textBox1.TabIndex = 10;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(203, 97);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(329, 29);
            this.txtNewPassword.TabIndex = 2;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.BorderRadius = 0;
            this.btnSignOut.ButtonText = "Sign Out";
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Iconimage")));
            this.btnSignOut.Iconimage_right = null;
            this.btnSignOut.Iconimage_right_Selected = null;
            this.btnSignOut.Iconimage_Selected = null;
            this.btnSignOut.IconMarginLeft = 0;
            this.btnSignOut.IconMarginRight = 0;
            this.btnSignOut.IconRightVisible = true;
            this.btnSignOut.IconRightZoom = 0D;
            this.btnSignOut.IconVisible = true;
            this.btnSignOut.IconZoom = 90D;
            this.btnSignOut.IsTab = false;
            this.btnSignOut.Location = new System.Drawing.Point(296, 425);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnSignOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSignOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignOut.selected = false;
            this.btnSignOut.Size = new System.Drawing.Size(212, 60);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignOut.Textcolor = System.Drawing.Color.White;
            this.btnSignOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click_1);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnUpdateAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateAll.BorderRadius = 0;
            this.btnUpdateAll.ButtonText = "Update";
            this.btnUpdateAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateAll.Enabled = false;
            this.btnUpdateAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateAll.Iconimage")));
            this.btnUpdateAll.Iconimage_right = null;
            this.btnUpdateAll.Iconimage_right_Selected = null;
            this.btnUpdateAll.Iconimage_Selected = null;
            this.btnUpdateAll.IconMarginLeft = 0;
            this.btnUpdateAll.IconMarginRight = 0;
            this.btnUpdateAll.IconRightVisible = true;
            this.btnUpdateAll.IconRightZoom = 0D;
            this.btnUpdateAll.IconVisible = true;
            this.btnUpdateAll.IconZoom = 90D;
            this.btnUpdateAll.IsTab = false;
            this.btnUpdateAll.Location = new System.Drawing.Point(586, 425);
            this.btnUpdateAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnUpdateAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdateAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateAll.selected = false;
            this.btnUpdateAll.Size = new System.Drawing.Size(217, 60);
            this.btnUpdateAll.TabIndex = 4;
            this.btnUpdateAll.Text = "Update";
            this.btnUpdateAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateAll.Textcolor = System.Drawing.Color.White;
            this.btnUpdateAll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtCurrentPassword);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(271, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 332);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update your profile";
            // 
            // FormManageUserEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnUpdateAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1070, 598);
            this.MinimumSize = new System.Drawing.Size(1070, 598);
            this.Name = "FormManageUserEmployee";
            this.Text = "FormDatabaseBackup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txtEmail;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private ns1.BunifuFlatButton btnSignOut;
        private ns1.BunifuFlatButton btnUpdateAll;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}