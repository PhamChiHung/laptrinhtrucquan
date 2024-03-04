namespace QLNhanVien
{
    partial class ManageStaff
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnSalary = new System.Windows.Forms.Panel();
            this.lbSalary = new System.Windows.Forms.Label();
            this.pnAcc = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.tbNameID = new System.Windows.Forms.TextBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pnOutput = new System.Windows.Forms.Panel();
            this.lbOuput = new System.Windows.Forms.Label();
            this.pnInput = new System.Windows.Forms.Panel();
            this.lbInput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnShow = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.pnSalary.SuspendLayout();
            this.pnAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.pnOutput.SuspendLayout();
            this.pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.pnMenu.Controls.Add(this.pnSalary);
            this.pnMenu.Controls.Add(this.pnAcc);
            this.pnMenu.Controls.Add(this.Date);
            this.pnMenu.Controls.Add(this.tbNameID);
            this.pnMenu.Controls.Add(this.picExit);
            this.pnMenu.Controls.Add(this.picUser);
            this.pnMenu.Controls.Add(this.pnOutput);
            this.pnMenu.Controls.Add(this.pnInput);
            this.pnMenu.Controls.Add(this.pictureBox1);
            this.pnMenu.Location = new System.Drawing.Point(-5, -5);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(279, 548);
            this.pnMenu.TabIndex = 0;
            // 
            // pnSalary
            // 
            this.pnSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSalary.Controls.Add(this.lbSalary);
            this.pnSalary.Location = new System.Drawing.Point(-15, 423);
            this.pnSalary.Name = "pnSalary";
            this.pnSalary.Size = new System.Drawing.Size(309, 53);
            this.pnSalary.TabIndex = 7;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSalary.Location = new System.Drawing.Point(109, 14);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(104, 23);
            this.lbSalary.TabIndex = 0;
            this.lbSalary.Text = "Bảng lương";
            this.lbSalary.Click += new System.EventHandler(this.lbSalary_Click);
            // 
            // pnAcc
            // 
            this.pnAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnAcc.Controls.Add(this.label1);
            this.pnAcc.Location = new System.Drawing.Point(-10, 345);
            this.pnAcc.Name = "pnAcc";
            this.pnAcc.Size = new System.Drawing.Size(309, 53);
            this.pnAcc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Date
            // 
            this.Date.Enabled = false;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(84, 147);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(192, 27);
            this.Date.TabIndex = 5;
            // 
            // tbNameID
            // 
            this.tbNameID.Enabled = false;
            this.tbNameID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNameID.Location = new System.Drawing.Point(84, 94);
            this.tbNameID.Name = "tbNameID";
            this.tbNameID.Size = new System.Drawing.Size(192, 27);
            this.tbNameID.TabIndex = 4;
            this.tbNameID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::QLNhanVien.Properties.Resources.enter;
            this.picExit.Location = new System.Drawing.Point(118, 541);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(28, 50);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picUser
            // 
            this.picUser.Image = global::QLNhanVien.Properties.Resources.avatar;
            this.picUser.Location = new System.Drawing.Point(3, 94);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(75, 89);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 2;
            this.picUser.TabStop = false;
            // 
            // pnOutput
            // 
            this.pnOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOutput.Controls.Add(this.lbOuput);
            this.pnOutput.Location = new System.Drawing.Point(3, 271);
            this.pnOutput.Name = "pnOutput";
            this.pnOutput.Size = new System.Drawing.Size(309, 53);
            this.pnOutput.TabIndex = 1;
            // 
            // lbOuput
            // 
            this.lbOuput.AutoSize = true;
            this.lbOuput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOuput.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOuput.Location = new System.Drawing.Point(60, 14);
            this.lbOuput.Name = "lbOuput";
            this.lbOuput.Size = new System.Drawing.Size(173, 23);
            this.lbOuput.TabIndex = 0;
            this.lbOuput.Text = "Danh sách nhân viên";
            this.lbOuput.Click += new System.EventHandler(this.lbOuput_Click);
            // 
            // pnInput
            // 
            this.pnInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInput.Controls.Add(this.lbInput);
            this.pnInput.Location = new System.Drawing.Point(3, 196);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(309, 53);
            this.pnInput.TabIndex = 1;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbInput.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInput.Location = new System.Drawing.Point(75, 13);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(133, 23);
            this.lbInput.TabIndex = 0;
            this.lbInput.Text = "Nhập thông tin";
            this.lbInput.Click += new System.EventHandler(this.lbInput_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::QLNhanVien.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnShow
            // 
            this.pnShow.Location = new System.Drawing.Point(277, -1);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(819, 544);
            this.pnShow.TabIndex = 1;
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1096, 542);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.ManageStaff_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnSalary.ResumeLayout(false);
            this.pnSalary.PerformLayout();
            this.pnAcc.ResumeLayout(false);
            this.pnAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.pnOutput.ResumeLayout(false);
            this.pnOutput.PerformLayout();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnMenu;
        private DateTimePicker Date;
        private TextBox tbNameID;
        private PictureBox picExit;
        private PictureBox picUser;
        private Panel pnOutput;
        private Label lbOuput;
        private Panel pnInput;
        private Label lbInput;
        private PictureBox pictureBox1;
        private Panel pnShow;
        private Panel pnAcc;
        private Label label1;
        private Panel pnSalary;
        private Label lbSalary;
    }
}