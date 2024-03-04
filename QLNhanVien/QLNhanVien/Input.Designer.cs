namespace QLNhanVien
{
    partial class Input
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grThongtin = new System.Windows.Forms.GroupBox();
            this.lbNotify = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLammoi = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dateT = new System.Windows.Forms.DateTimePicker();
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
            this.listVDs = new System.Windows.Forms.ListView();
            this.clMa = new System.Windows.Forms.ColumnHeader();
            this.clName = new System.Windows.Forms.ColumnHeader();
            this.clDate = new System.Windows.Forms.ColumnHeader();
            this.clGender = new System.Windows.Forms.ColumnHeader();
            this.clAdd = new System.Windows.Forms.ColumnHeader();
            this.clSdt = new System.Windows.Forms.ColumnHeader();
            this.clMoney = new System.Windows.Forms.ColumnHeader();
            this.clChucvu = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.grThongtin.SuspendLayout();
            this.pnChucvu.SuspendLayout();
            this.pnGnder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grThongtin
            // 
            this.grThongtin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grThongtin.Controls.Add(this.lbNotify);
            this.grThongtin.Controls.Add(this.btThoat);
            this.grThongtin.Controls.Add(this.btLammoi);
            this.grThongtin.Controls.Add(this.btThem);
            this.grThongtin.Controls.Add(this.btXoa);
            this.grThongtin.Controls.Add(this.dateT);
            this.grThongtin.Controls.Add(this.tbMoney);
            this.grThongtin.Controls.Add(this.tbAdd);
            this.grThongtin.Controls.Add(this.tbSdt);
            this.grThongtin.Controls.Add(this.tbName);
            this.grThongtin.Controls.Add(this.pnChucvu);
            this.grThongtin.Controls.Add(this.pnGnder);
            this.grThongtin.Controls.Add(this.lbChucvu);
            this.grThongtin.Controls.Add(this.lbMoney);
            this.grThongtin.Controls.Add(this.lbSdt);
            this.grThongtin.Controls.Add(this.lbGender);
            this.grThongtin.Controls.Add(this.lbAdd);
            this.grThongtin.Controls.Add(this.lbDate);
            this.grThongtin.Controls.Add(this.lbName);
            this.grThongtin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grThongtin.Location = new System.Drawing.Point(-2, 30);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.Size = new System.Drawing.Size(842, 253);
            this.grThongtin.TabIndex = 0;
            this.grThongtin.TabStop = false;
            this.grThongtin.Text = "Thông tin";
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Location = new System.Drawing.Point(454, 134);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(50, 23);
            this.lbNotify.TabIndex = 19;
            this.lbNotify.Text = "        ";
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Location = new System.Drawing.Point(269, 191);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(91, 35);
            this.btThoat.TabIndex = 18;
            this.btThoat.Text = "Sửa";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLammoi
            // 
            this.btLammoi.AutoSize = true;
            this.btLammoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLammoi.Location = new System.Drawing.Point(662, 191);
            this.btLammoi.Name = "btLammoi";
            this.btLammoi.Size = new System.Drawing.Size(91, 35);
            this.btLammoi.TabIndex = 17;
            this.btLammoi.Text = "Làm mới";
            this.btLammoi.UseVisualStyleBackColor = false;
            this.btLammoi.Click += new System.EventHandler(this.btLammoi_Click);
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Location = new System.Drawing.Point(84, 191);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(91, 35);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.AutoSize = true;
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btXoa.Location = new System.Drawing.Point(469, 191);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(91, 35);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dateT
            // 
            this.dateT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateT.CustomFormat = "yyyy-MM-dd";
            this.dateT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateT.Location = new System.Drawing.Point(650, 38);
            this.dateT.Name = "dateT";
            this.dateT.Size = new System.Drawing.Size(153, 30);
            this.dateT.TabIndex = 14;
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(650, 88);
            this.tbMoney.MaxLength = 10;
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(153, 30);
            this.tbMoney.TabIndex = 12;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(95, 88);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(170, 30);
            this.tbAdd.TabIndex = 11;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(385, 85);
            this.tbSdt.MaxLength = 10;
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(161, 30);
            this.tbSdt.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(95, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 30);
            this.tbName.TabIndex = 9;
            // 
            // pnChucvu
            // 
            this.pnChucvu.Controls.Add(this.rbThungan);
            this.pnChucvu.Controls.Add(this.rbLetan);
            this.pnChucvu.Location = new System.Drawing.Point(95, 131);
            this.pnChucvu.Name = "pnChucvu";
            this.pnChucvu.Size = new System.Drawing.Size(190, 37);
            this.pnChucvu.TabIndex = 8;
            // 
            // rbThungan
            // 
            this.rbThungan.AutoSize = true;
            this.rbThungan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbThungan.Location = new System.Drawing.Point(79, 5);
            this.rbThungan.Name = "rbThungan";
            this.rbThungan.Size = new System.Drawing.Size(104, 27);
            this.rbThungan.TabIndex = 10;
            this.rbThungan.Text = "Thu ngân";
            this.rbThungan.UseVisualStyleBackColor = true;
            // 
            // rbLetan
            // 
            this.rbLetan.AutoSize = true;
            this.rbLetan.Checked = true;
            this.rbLetan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLetan.Location = new System.Drawing.Point(3, 5);
            this.rbLetan.Name = "rbLetan";
            this.rbLetan.Size = new System.Drawing.Size(78, 27);
            this.rbLetan.TabIndex = 9;
            this.rbLetan.TabStop = true;
            this.rbLetan.Text = "Lễ tân";
            this.rbLetan.UseVisualStyleBackColor = true;
            // 
            // pnGnder
            // 
            this.pnGnder.Controls.Add(this.rbNu);
            this.pnGnder.Controls.Add(this.rbNam);
            this.pnGnder.Location = new System.Drawing.Point(386, 33);
            this.pnGnder.Name = "pnGnder";
            this.pnGnder.Size = new System.Drawing.Size(160, 39);
            this.pnGnder.TabIndex = 7;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Checked = true;
            this.rbNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNu.Location = new System.Drawing.Point(97, 6);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(54, 27);
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
            this.rbNam.Location = new System.Drawing.Point(3, 6);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(68, 27);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbChucvu.Location = new System.Drawing.Point(10, 139);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(66, 18);
            this.lbChucvu.TabIndex = 1;
            this.lbChucvu.Text = "Chức vụ:";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMoney.Location = new System.Drawing.Point(567, 91);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(86, 18);
            this.lbMoney.TabIndex = 6;
            this.lbMoney.Text = "Lương(vnd):";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSdt.Location = new System.Drawing.Point(285, 91);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(80, 18);
            this.lbSdt.TabIndex = 5;
            this.lbSdt.Text = "Số liên lạc:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGender.Location = new System.Drawing.Point(285, 43);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(68, 20);
            this.lbGender.TabIndex = 4;
            this.lbGender.Text = "Giới tính:";
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAdd.Location = new System.Drawing.Point(10, 87);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(57, 18);
            this.lbAdd.TabIndex = 3;
            this.lbAdd.Text = "Địa chỉ:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(567, 43);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(77, 20);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Ngày sinh:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(7, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Họ và tên:";
            // 
            // listVDs
            // 
            this.listVDs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMa,
            this.clName,
            this.clDate,
            this.clGender,
            this.clAdd,
            this.clSdt,
            this.clMoney,
            this.clChucvu});
            this.listVDs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listVDs.FullRowSelect = true;
            this.listVDs.GridLines = true;
            this.listVDs.Location = new System.Drawing.Point(-2, 275);
            this.listVDs.Name = "listVDs";
            this.listVDs.Size = new System.Drawing.Size(842, 270);
            this.listVDs.TabIndex = 1;
            this.listVDs.UseCompatibleStateImageBehavior = false;
            this.listVDs.View = System.Windows.Forms.View.Details;
            this.listVDs.SelectedIndexChanged += new System.EventHandler(this.listVDs_SelectedIndexChanged);
            // 
            // clMa
            // 
            this.clMa.Text = "Mã nhân viên";
            this.clMa.Width = 100;
            // 
            // clName
            // 
            this.clName.Text = "Họ tên";
            this.clName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clName.Width = 150;
            // 
            // clDate
            // 
            this.clDate.Text = "Ngày sinh";
            this.clDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clDate.Width = 100;
            // 
            // clGender
            // 
            this.clGender.Text = "Giới tính";
            this.clGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clGender.Width = 100;
            // 
            // clAdd
            // 
            this.clAdd.Text = "Địa chỉ";
            this.clAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clAdd.Width = 150;
            // 
            // clSdt
            // 
            this.clSdt.Text = "Liên lạc";
            this.clSdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSdt.Width = 150;
            // 
            // clMoney
            // 
            this.clMoney.Text = "Lương";
            this.clMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clMoney.Width = 150;
            // 
            // clChucvu
            // 
            this.clChucvu.Text = "Chức vụ";
            this.clChucvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clChucvu.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhân viên";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(819, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listVDs);
            this.Controls.Add(this.grThongtin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Input_Load);
            this.grThongtin.ResumeLayout(false);
            this.grThongtin.PerformLayout();
            this.pnChucvu.ResumeLayout(false);
            this.pnChucvu.PerformLayout();
            this.pnGnder.ResumeLayout(false);
            this.pnGnder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grThongtin;
        private Label lbChucvu;
        private Label lbMoney;
        private Label lbSdt;
        private Label lbGender;
        private Label lbAdd;
        private Label lbDate;
        private Label lbName;
        private Panel pnChucvu;
        private RadioButton rbThungan;
        private RadioButton rbLetan;
        private Panel pnGnder;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private DateTimePicker dateT;
        private TextBox tbMoney;
        private TextBox tbAdd;
        private TextBox tbSdt;
        private TextBox tbName;
        private Button btThoat;
        private Button btLammoi;
        private Button btThem;
        private Button btXoa;
        private ListView listVDs;
        private ColumnHeader clMa;
        private ColumnHeader clName;
        private ColumnHeader clDate;
        private ColumnHeader clGender;
        private ColumnHeader clAdd;
        private ColumnHeader clSdt;
        private ColumnHeader clMoney;
        private ColumnHeader clChucvu;
        private Label lbNotify;
        private Label label1;
    }
}