namespace Shop_Management_System_Project.Panel_Forms
{
    partial class FormDigitalClock
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
            this.lblHourMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.groupBoxDigitalClock = new System.Windows.Forms.GroupBox();
            this.timerLiveTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDigitalClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHourMinute
            // 
            this.lblHourMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHourMinute.AutoSize = true;
            this.lblHourMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHourMinute.Font = new System.Drawing.Font("Courier New", 99.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourMinute.Location = new System.Drawing.Point(94, 143);
            this.lblHourMinute.Name = "lblHourMinute";
            this.lblHourMinute.Size = new System.Drawing.Size(702, 146);
            this.lblHourMinute.TabIndex = 0;
            this.lblHourMinute.Text = "HH:MM:SS";
            // 
            // lblSecond
            // 
            this.lblSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecond.AutoSize = true;
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecond.Font = new System.Drawing.Font("Courier New", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(794, 184);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(136, 91);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "SS";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(90, 431);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(361, 82);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "April 25 2017";
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDay.AutoSize = true;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(655, 431);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(271, 82);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Saturday";
            // 
            // groupBoxDigitalClock
            // 
            this.groupBoxDigitalClock.BackColor = System.Drawing.Color.White;
            this.groupBoxDigitalClock.Controls.Add(this.label3);
            this.groupBoxDigitalClock.Controls.Add(this.label2);
            this.groupBoxDigitalClock.Controls.Add(this.label1);
            this.groupBoxDigitalClock.Controls.Add(this.lblHourMinute);
            this.groupBoxDigitalClock.Controls.Add(this.lblDay);
            this.groupBoxDigitalClock.Controls.Add(this.lblSecond);
            this.groupBoxDigitalClock.Controls.Add(this.lblDate);
            this.groupBoxDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDigitalClock.Location = new System.Drawing.Point(21, 11);
            this.groupBoxDigitalClock.Name = "groupBoxDigitalClock";
            this.groupBoxDigitalClock.Size = new System.Drawing.Size(1027, 575);
            this.groupBoxDigitalClock.TabIndex = 2;
            this.groupBoxDigitalClock.TabStop = false;
            this.groupBoxDigitalClock.Text = "System Time";
            // 
            // timerLiveTime
            // 
            this.timerLiveTime.Enabled = true;
            this.timerLiveTime.Interval = 1000;
            this.timerLiveTime.Tick += new System.EventHandler(this.timerLiveTime_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time:";
            // 
            // FormDigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 598);
            this.Controls.Add(this.groupBoxDigitalClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1070, 598);
            this.MinimumSize = new System.Drawing.Size(1070, 598);
            this.Name = "FormDigitalClock";
            this.Text = "FormDigitalClock";
            this.groupBoxDigitalClock.ResumeLayout(false);
            this.groupBoxDigitalClock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHourMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.GroupBox groupBoxDigitalClock;
        private System.Windows.Forms.Timer timerLiveTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}