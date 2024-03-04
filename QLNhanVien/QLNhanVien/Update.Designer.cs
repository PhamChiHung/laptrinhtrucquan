namespace QLNhanVien
{
    partial class Update
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
            this.dateT = new System.Windows.Forms.DateTimePicker();
            this.lbVnd = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pnChucvu = new System.Windows.Forms.Panel();
            this.rbThungan = new System.Windows.Forms.RadioButton();
            this.rbLetan = new System.Windows.Forms.RadioButton();
            this.pnGnder = new System.Windows.Forms.Panel();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.lbChucvu = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTile = new System.Windows.Forms.Label();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.picStaff = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnChucvu.SuspendLayout();
            this.pnGnder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dateT
            // 
            this.dateT.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateT.Enabled = false;
            this.dateT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT.Location = new System.Drawing.Point(290, 115);
            this.dateT.Name = "dateT";
            this.dateT.Size = new System.Drawing.Size(199, 27);
            this.dateT.TabIndex = 35;
            // 
            // lbVnd
            // 
            this.lbVnd.AutoSize = true;
            this.lbVnd.Location = new System.Drawing.Point(756, 166);
            this.lbVnd.Name = "lbVnd";
            this.lbVnd.Size = new System.Drawing.Size(40, 20);
            this.lbVnd.TabIndex = 34;
            this.lbVnd.Text = "VND";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(601, 163);
            this.tbMoney.MaxLength = 8;
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(146, 27);
            this.tbMoney.TabIndex = 33;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(290, 163);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(199, 27);
            this.tbAdd.TabIndex = 32;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(601, 112);
            this.tbSdt.MaxLength = 10;
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(146, 27);
            this.tbSdt.TabIndex = 31;
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(290, 67);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(199, 30);
            this.tbName.TabIndex = 30;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnChucvu
            // 
            this.pnChucvu.Controls.Add(this.rbThungan);
            this.pnChucvu.Controls.Add(this.rbLetan);
            this.pnChucvu.Location = new System.Drawing.Point(290, 210);
            this.pnChucvu.Name = "pnChucvu";
            this.pnChucvu.Size = new System.Drawing.Size(204, 37);
            this.pnChucvu.TabIndex = 29;
            // 
            // rbThungan
            // 
            this.rbThungan.AutoSize = true;
            this.rbThungan.Checked = true;
            this.rbThungan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThungan.Location = new System.Drawing.Point(79, 3);
            this.rbThungan.Name = "rbThungan";
            this.rbThungan.Size = new System.Drawing.Size(91, 24);
            this.rbThungan.TabIndex = 10;
            this.rbThungan.TabStop = true;
            this.rbThungan.Text = "Thu ngân";
            this.rbThungan.UseVisualStyleBackColor = true;
            // 
            // rbLetan
            // 
            this.rbLetan.AutoSize = true;
            this.rbLetan.Checked = true;
            this.rbLetan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLetan.Location = new System.Drawing.Point(3, 3);
            this.rbLetan.Name = "rbLetan";
            this.rbLetan.Size = new System.Drawing.Size(70, 24);
            this.rbLetan.TabIndex = 9;
            this.rbLetan.TabStop = true;
            this.rbLetan.Text = "Lễ tân";
            this.rbLetan.UseVisualStyleBackColor = true;
            // 
            // pnGnder
            // 
            this.pnGnder.Controls.Add(this.rbNu);
            this.pnGnder.Controls.Add(this.rbNam);
            this.pnGnder.Location = new System.Drawing.Point(601, 55);
            this.pnGnder.Name = "pnGnder";
            this.pnGnder.Size = new System.Drawing.Size(145, 39);
            this.pnGnder.TabIndex = 28;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Checked = true;
            this.rbNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNu.Location = new System.Drawing.Point(71, 10);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(50, 24);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNam.Location = new System.Drawing.Point(3, 10);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(62, 24);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Location = new System.Drawing.Point(208, 210);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(64, 20);
            this.lbChucvu.TabIndex = 21;
            this.lbChucvu.Text = "Chức vụ:";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(495, 163);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(54, 20);
            this.lbMoney.TabIndex = 27;
            this.lbMoney.Text = "Lương:";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Location = new System.Drawing.Point(495, 115);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(100, 20);
            this.lbSdt.TabIndex = 26;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(495, 67);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(68, 20);
            this.lbGender.TabIndex = 25;
            this.lbGender.Text = "Giới tính:";
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Location = new System.Drawing.Point(208, 163);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(58, 20);
            this.lbAdd.TabIndex = 24;
            this.lbAdd.Text = "Địa chỉ:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(208, 115);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(77, 20);
            this.lbDate.TabIndex = 23;
            this.lbDate.Text = "Ngày sinh:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(208, 67);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 20);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "Họ và tên:";
            // 
            // lbTile
            // 
            this.lbTile.AutoSize = true;
            this.lbTile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTile.Location = new System.Drawing.Point(351, 19);
            this.lbTile.Name = "lbTile";
            this.lbTile.Size = new System.Drawing.Size(99, 25);
            this.lbTile.TabIndex = 20;
            this.lbTile.Text = "Nhân viên";
            // 
            // btCapnhat
            // 
            this.btCapnhat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCapnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCapnhat.Location = new System.Drawing.Point(347, 297);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(94, 29);
            this.btCapnhat.TabIndex = 36;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = false;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Location = new System.Drawing.Point(556, 297);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 29);
            this.btThoat.TabIndex = 37;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // picStaff
            // 
            this.picStaff.Image = global::QLNhanVien.Properties.Resources.avatar;
            this.picStaff.Location = new System.Drawing.Point(12, 55);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(190, 211);
            this.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStaff.TabIndex = 38;
            this.picStaff.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(60, 269);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 20);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Chọn ảnh...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picStaff);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.dateT);
            this.Controls.Add(this.lbVnd);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.tbSdt);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pnChucvu);
            this.Controls.Add(this.pnGnder);
            this.Controls.Add(this.lbChucvu);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.lbSdt);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTile);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin nhân viên";
            this.Load += new System.EventHandler(this.Update_Load);
            this.pnChucvu.ResumeLayout(false);
            this.pnChucvu.PerformLayout();
            this.pnGnder.ResumeLayout(false);
            this.pnGnder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateT;
        private Label lbVnd;
        private TextBox tbMoney;
        private TextBox tbAdd;
        private TextBox tbSdt;
        private TextBox tbName;
        private Panel pnChucvu;
        private RadioButton rbThungan;
        private RadioButton rbLetan;
        private Panel pnGnder;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private Label lbChucvu;
        private Label lbMoney;
        private Label lbSdt;
        private Label lbGender;
        private Label lbAdd;
        private Label lbDate;
        private Label lbName;
        private Label lbTile;
        private Button btCapnhat;
        private Button btThoat;
        private PictureBox picStaff;
        private LinkLabel linkLabel1;
    }
}