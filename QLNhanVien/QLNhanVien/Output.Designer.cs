namespace QLNhanVien
{
    partial class Output
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
            this.lbTile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxNameId = new System.Windows.Forms.ComboBox();
            this.btQuaylai = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboxThungan = new System.Windows.Forms.CheckBox();
            this.cboxLetan = new System.Windows.Forms.CheckBox();
            this.btLoc = new System.Windows.Forms.Button();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.lbAdd = new System.Windows.Forms.Label();
            this.cboxAdd = new System.Windows.Forms.ComboBox();
            this.lbChucvu = new System.Windows.Forms.Label();
            this.lbUntil = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btIn = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dtVDs = new System.Windows.Forms.DataGridView();
            this.fileExcel = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVDs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTile
            // 
            this.lbTile.AutoSize = true;
            this.lbTile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTile.Location = new System.Drawing.Point(325, 9);
            this.lbTile.Name = "lbTile";
            this.lbTile.Size = new System.Drawing.Size(189, 25);
            this.lbTile.TabIndex = 0;
            this.lbTile.Text = "Danh sách nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cBoxNameId);
            this.panel1.Controls.Add(this.btQuaylai);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btLoc);
            this.panel1.Controls.Add(this.numMax);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbAdd);
            this.panel1.Controls.Add(this.cboxAdd);
            this.panel1.Controls.Add(this.lbChucvu);
            this.panel1.Controls.Add(this.lbUntil);
            this.panel1.Controls.Add(this.lbAge);
            this.panel1.Controls.Add(this.lbGender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 153);
            this.panel1.TabIndex = 1;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Location = new System.Drawing.Point(351, 102);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(94, 29);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ tên:";
            // 
            // cBoxNameId
            // 
            this.cBoxNameId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cBoxNameId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxNameId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxNameId.FormattingEnabled = true;
            this.cBoxNameId.Location = new System.Drawing.Point(95, 103);
            this.cBoxNameId.Name = "cBoxNameId";
            this.cBoxNameId.Size = new System.Drawing.Size(231, 28);
            this.cBoxNameId.TabIndex = 9;
            // 
            // btQuaylai
            // 
            this.btQuaylai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btQuaylai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuaylai.Location = new System.Drawing.Point(708, 102);
            this.btQuaylai.Name = "btQuaylai";
            this.btQuaylai.Size = new System.Drawing.Size(94, 29);
            this.btQuaylai.TabIndex = 3;
            this.btQuaylai.Text = "Trở về cũ";
            this.btQuaylai.UseVisualStyleBackColor = false;
            this.btQuaylai.Click += new System.EventHandler(this.btQuaylai_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboxThungan);
            this.panel3.Controls.Add(this.cboxLetan);
            this.panel3.Location = new System.Drawing.Point(475, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 62);
            this.panel3.TabIndex = 2;
            // 
            // cboxThungan
            // 
            this.cboxThungan.AutoSize = true;
            this.cboxThungan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxThungan.Location = new System.Drawing.Point(7, 33);
            this.cboxThungan.Name = "cboxThungan";
            this.cboxThungan.Size = new System.Drawing.Size(92, 24);
            this.cboxThungan.TabIndex = 1;
            this.cboxThungan.Text = "Thu ngân";
            this.cboxThungan.UseVisualStyleBackColor = true;
            // 
            // cboxLetan
            // 
            this.cboxLetan.AutoSize = true;
            this.cboxLetan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxLetan.Location = new System.Drawing.Point(7, 6);
            this.cboxLetan.Name = "cboxLetan";
            this.cboxLetan.Size = new System.Drawing.Size(71, 24);
            this.cboxLetan.TabIndex = 0;
            this.cboxLetan.Text = "Lễ tân";
            this.cboxLetan.UseVisualStyleBackColor = true;
            // 
            // btLoc
            // 
            this.btLoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoc.Location = new System.Drawing.Point(542, 102);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(94, 29);
            this.btLoc.TabIndex = 2;
            this.btLoc.Text = "Lọc";
            this.btLoc.UseVisualStyleBackColor = false;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // numMax
            // 
            this.numMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numMax.Location = new System.Drawing.Point(322, 45);
            this.numMax.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(55, 27);
            this.numMax.TabIndex = 3;
            // 
            // numMin
            // 
            this.numMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numMin.Location = new System.Drawing.Point(221, 44);
            this.numMin.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(55, 27);
            this.numMin.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbNu);
            this.panel2.Controls.Add(this.cbNam);
            this.panel2.Location = new System.Drawing.Point(95, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 61);
            this.panel2.TabIndex = 2;
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNu.Location = new System.Drawing.Point(3, 33);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(51, 24);
            this.cbNu.TabIndex = 1;
            this.cbNu.Text = "Nữ";
            this.cbNu.UseVisualStyleBackColor = true;
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNam.Location = new System.Drawing.Point(3, 3);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(63, 24);
            this.cbNam.TabIndex = 0;
            this.cbNam.Text = "Nam";
            this.cbNam.UseVisualStyleBackColor = true;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Location = new System.Drawing.Point(582, 48);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(58, 20);
            this.lbAdd.TabIndex = 8;
            this.lbAdd.Text = "Địa chỉ:";
            // 
            // cboxAdd
            // 
            this.cboxAdd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboxAdd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxAdd.FormattingEnabled = true;
            this.cboxAdd.Location = new System.Drawing.Point(646, 45);
            this.cboxAdd.Name = "cboxAdd";
            this.cboxAdd.Size = new System.Drawing.Size(162, 28);
            this.cboxAdd.TabIndex = 7;
            this.cboxAdd.Text = "Địa chỉ";
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Location = new System.Drawing.Point(405, 48);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(64, 20);
            this.lbChucvu.TabIndex = 6;
            this.lbChucvu.Text = "Chức vụ:";
            // 
            // lbUntil
            // 
            this.lbUntil.AutoSize = true;
            this.lbUntil.Location = new System.Drawing.Point(282, 48);
            this.lbUntil.Name = "lbUntil";
            this.lbUntil.Size = new System.Drawing.Size(34, 20);
            this.lbUntil.TabIndex = 5;
            this.lbUntil.Text = "đến";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(174, 47);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(41, 20);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "Tuổi:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(11, 51);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(68, 20);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc danh sách";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.btIn);
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.dtVDs);
            this.groupBox1.Location = new System.Drawing.Point(2, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // btIn
            // 
            this.btIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIn.Location = new System.Drawing.Point(606, 288);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(94, 29);
            this.btIn.TabIndex = 4;
            this.btIn.Text = "File Excel";
            this.btIn.UseVisualStyleBackColor = false;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Location = new System.Drawing.Point(836, 275);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 29);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.Location = new System.Drawing.Point(357, 288);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(94, 29);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.Location = new System.Drawing.Point(96, 288);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 29);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dtVDs
            // 
            this.dtVDs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtVDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVDs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtVDs.Location = new System.Drawing.Point(1, 26);
            this.dtVDs.MultiSelect = false;
            this.dtVDs.Name = "dtVDs";
            this.dtVDs.ReadOnly = true;
            this.dtVDs.RowHeadersWidth = 51;
            this.dtVDs.RowTemplate.Height = 29;
            this.dtVDs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtVDs.Size = new System.Drawing.Size(841, 256);
            this.dtVDs.TabIndex = 0;
            this.dtVDs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtVDs_CellDoubleClick);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(819, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Output";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Danh sách nhân viên";
            this.Load += new System.EventHandler(this.Output_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtVDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTile;
        private Panel panel1;
        private Panel panel2;
        private CheckBox cbNu;
        private CheckBox cbNam;
        private Label lbAdd;
        private ComboBox cboxAdd;
        private Label lbChucvu;
        private Label lbUntil;
        private Label lbAge;
        private Label lbGender;
        private Label label1;
        private NumericUpDown numMin;
        private Panel panel3;
        private CheckBox cboxThungan;
        private CheckBox cboxLetan;
        private NumericUpDown numMax;
        private Button btQuaylai;
        private Button btLoc;
        private GroupBox groupBox1;
        private DataGridView dtVDs;
        private Button btThoat;
        private Button btSua;
        private Button btXoa;
        private SaveFileDialog fileExcel;
        private Button btIn;
        private Button btSearch;
        private Label label2;
        private ComboBox cBoxNameId;
    }
}