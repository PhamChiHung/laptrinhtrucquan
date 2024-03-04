namespace HOTELMANAGER
{
    partial class frmHD
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
            this.dgvhd = new System.Windows.Forms.DataGridView();
            this.btxem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.dpicker_ngaylaphd = new System.Windows.Forms.DateTimePicker();
            this.cbbnv = new System.Windows.Forms.ComboBox();
            this.cbbkh = new System.Windows.Forms.ComboBox();
            this.dgvhd1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdichvu = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvphong = new System.Windows.Forms.DataGridView();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_delete_DP = new System.Windows.Forms.Button();
            this.btn_editDP = new System.Windows.Forms.Button();
            this.btn_addDP = new System.Windows.Forms.Button();
            this.btn_addDV = new System.Windows.Forms.Button();
            this.btn_edit_DV = new System.Windows.Forms.Button();
            this.btn_delete_DV = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbmadv = new System.Windows.Forms.ComboBox();
            this.cbbgiadv = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbmap = new System.Windows.Forms.ComboBox();
            this.cbbgiaphong = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dpicker_thuephong = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbloaiphong = new System.Windows.Forms.ComboBox();
            this.checkbox_find_hd = new System.Windows.Forms.CheckBox();
            this.checkbox_find_by_kh = new System.Windows.Forms.CheckBox();
            this.checkbox_find_by_nv = new System.Windows.Forms.CheckBox();
            this.cb_search_kh = new System.Windows.Forms.ComboBox();
            this.cb_search_nv = new System.Windows.Forms.ComboBox();
            this.btn_addHD = new System.Windows.Forms.Button();
            this.btn_editHD = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dpicker_ngaytraphong = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dpicker_ngaysddv = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELDataSet = new HOTELMANAGER.HOTELDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbtendv = new System.Windows.Forms.ComboBox();
            this.btn_deleteHD = new System.Windows.Forms.Button();
            this.bt_inHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvhd
            // 
            this.dgvhd.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvhd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Location = new System.Drawing.Point(16, 108);
            this.dgvhd.Margin = new System.Windows.Forms.Padding(4);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.RowHeadersWidth = 51;
            this.dgvhd.Size = new System.Drawing.Size(785, 655);
            this.dgvhd.TabIndex = 0;
            // 
            // btxem
            // 
            this.btxem.BackColor = System.Drawing.Color.LemonChiffon;
            this.btxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btxem.Location = new System.Drawing.Point(492, 802);
            this.btxem.Margin = new System.Windows.Forms.Padding(4);
            this.btxem.Name = "btxem";
            this.btxem.Size = new System.Drawing.Size(197, 39);
            this.btxem.TabIndex = 2;
            this.btxem.Text = "Xem DS Hoá Đơn";
            this.btxem.UseVisualStyleBackColor = false;
            this.btxem.Click += new System.EventHandler(this.btxem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN HOÁ ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã HĐ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày lập:";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(128, 144);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(188, 22);
            this.txt_mahd.TabIndex = 12;
            // 
            // dpicker_ngaylaphd
            // 
            this.dpicker_ngaylaphd.Location = new System.Drawing.Point(472, 144);
            this.dpicker_ngaylaphd.Margin = new System.Windows.Forms.Padding(4);
            this.dpicker_ngaylaphd.Name = "dpicker_ngaylaphd";
            this.dpicker_ngaylaphd.Size = new System.Drawing.Size(292, 22);
            this.dpicker_ngaylaphd.TabIndex = 13;
            // 
            // cbbnv
            // 
            this.cbbnv.FormattingEnabled = true;
            this.cbbnv.Location = new System.Drawing.Point(172, 187);
            this.cbbnv.Margin = new System.Windows.Forms.Padding(4);
            this.cbbnv.Name = "cbbnv";
            this.cbbnv.Size = new System.Drawing.Size(287, 24);
            this.cbbnv.TabIndex = 14;
            // 
            // cbbkh
            // 
            this.cbbkh.FormattingEnabled = true;
            this.cbbkh.Location = new System.Drawing.Point(172, 233);
            this.cbbkh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbkh.Name = "cbbkh";
            this.cbbkh.Size = new System.Drawing.Size(287, 24);
            this.cbbkh.TabIndex = 15;
            // 
            // dgvhd1
            // 
            this.dgvhd1.BackgroundColor = System.Drawing.Color.White;
            this.dgvhd1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvhd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd1.Location = new System.Drawing.Point(28, 350);
            this.dgvhd1.Margin = new System.Windows.Forms.Padding(4);
            this.dgvhd1.Name = "dgvhd1";
            this.dgvhd1.RowHeadersWidth = 51;
            this.dgvhd1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhd1.Size = new System.Drawing.Size(759, 398);
            this.dgvhd1.TabIndex = 16;
            this.dgvhd1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhd1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(840, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "THÔNG TIN CHI TIẾT HOÁ ĐƠN PHÒNG";
            // 
            // dgvdichvu
            // 
            this.dgvdichvu.BackgroundColor = System.Drawing.Color.White;
            this.dgvdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdichvu.Location = new System.Drawing.Point(845, 564);
            this.dgvdichvu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvdichvu.Name = "dgvdichvu";
            this.dgvdichvu.RowHeadersWidth = 51;
            this.dgvdichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdichvu.Size = new System.Drawing.Size(931, 134);
            this.dgvdichvu.TabIndex = 21;
            this.dgvdichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdichvu_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(840, 443);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(393, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "THÔNG TIN CHI TIẾT HOÁ ĐƠN DICH VỤ";
            // 
            // dgvphong
            // 
            this.dgvphong.BackgroundColor = System.Drawing.Color.White;
            this.dgvphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphong.Location = new System.Drawing.Point(812, 228);
            this.dgvphong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvphong.Name = "dgvphong";
            this.dgvphong.RowHeadersWidth = 51;
            this.dgvphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvphong.Size = new System.Drawing.Size(1015, 134);
            this.dgvphong.TabIndex = 22;
            this.dgvphong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphong_CellContentClick);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(809, 108);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.Size = new System.Drawing.Size(1019, 655);
            this.dgvCTHD.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(724, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 42);
            this.label7.TabIndex = 8;
            this.label7.Text = "QUẢN LÝ HOÁ ĐƠN";
            // 
            // btn_delete_DP
            // 
            this.btn_delete_DP.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_delete_DP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_DP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete_DP.Location = new System.Drawing.Point(1651, 382);
            this.btn_delete_DP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete_DP.Name = "btn_delete_DP";
            this.btn_delete_DP.Size = new System.Drawing.Size(92, 27);
            this.btn_delete_DP.TabIndex = 30;
            this.btn_delete_DP.Text = "Xoá";
            this.btn_delete_DP.UseVisualStyleBackColor = false;
            this.btn_delete_DP.Click += new System.EventHandler(this.btn_delete_DP_Click);
            // 
            // btn_editDP
            // 
            this.btn_editDP.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_editDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editDP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_editDP.Location = new System.Drawing.Point(1251, 382);
            this.btn_editDP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editDP.Name = "btn_editDP";
            this.btn_editDP.Size = new System.Drawing.Size(92, 27);
            this.btn_editDP.TabIndex = 29;
            this.btn_editDP.Text = "Sửa";
            this.btn_editDP.UseVisualStyleBackColor = false;
            this.btn_editDP.Click += new System.EventHandler(this.btn_editDP_Click);
            // 
            // btn_addDP
            // 
            this.btn_addDP.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_addDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addDP.Location = new System.Drawing.Point(899, 382);
            this.btn_addDP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addDP.Name = "btn_addDP";
            this.btn_addDP.Size = new System.Drawing.Size(92, 27);
            this.btn_addDP.TabIndex = 28;
            this.btn_addDP.Text = "Thêm";
            this.btn_addDP.UseVisualStyleBackColor = false;
            this.btn_addDP.Click += new System.EventHandler(this.btn_addDP_Click);
            // 
            // btn_addDV
            // 
            this.btn_addDV.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_addDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addDV.Location = new System.Drawing.Point(899, 722);
            this.btn_addDV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addDV.Name = "btn_addDV";
            this.btn_addDV.Size = new System.Drawing.Size(92, 27);
            this.btn_addDV.TabIndex = 28;
            this.btn_addDV.Text = "Thêm";
            this.btn_addDV.UseVisualStyleBackColor = false;
            this.btn_addDV.Click += new System.EventHandler(this.btn_addDV_Click);
            // 
            // btn_edit_DV
            // 
            this.btn_edit_DV.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_edit_DV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_DV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_edit_DV.Location = new System.Drawing.Point(1251, 721);
            this.btn_edit_DV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit_DV.Name = "btn_edit_DV";
            this.btn_edit_DV.Size = new System.Drawing.Size(92, 27);
            this.btn_edit_DV.TabIndex = 29;
            this.btn_edit_DV.Text = "Sửa";
            this.btn_edit_DV.UseVisualStyleBackColor = false;
            this.btn_edit_DV.Click += new System.EventHandler(this.btn_edit_DV_Click);
            // 
            // btn_delete_DV
            // 
            this.btn_delete_DV.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_delete_DV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_DV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete_DV.Location = new System.Drawing.Point(1653, 718);
            this.btn_delete_DV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete_DV.Name = "btn_delete_DV";
            this.btn_delete_DV.Size = new System.Drawing.Size(92, 27);
            this.btn_delete_DV.TabIndex = 30;
            this.btn_delete_DV.Text = "Xoá";
            this.btn_delete_DV.UseVisualStyleBackColor = false;
            this.btn_delete_DV.Click += new System.EventHandler(this.btn_delete_DV_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(873, 480);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã dịch vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(871, 530);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Giá dịch vụ:";
            // 
            // cbbmadv
            // 
            this.cbbmadv.FormattingEnabled = true;
            this.cbbmadv.Location = new System.Drawing.Point(971, 480);
            this.cbbmadv.Margin = new System.Windows.Forms.Padding(4);
            this.cbbmadv.Name = "cbbmadv";
            this.cbbmadv.Size = new System.Drawing.Size(287, 24);
            this.cbbmadv.TabIndex = 14;
            this.cbbmadv.SelectedIndexChanged += new System.EventHandler(this.cbbmadv_SelectedIndexChanged);
            // 
            // cbbgiadv
            // 
            this.cbbgiadv.FormattingEnabled = true;
            this.cbbgiadv.Location = new System.Drawing.Point(971, 529);
            this.cbbgiadv.Margin = new System.Windows.Forms.Padding(4);
            this.cbbgiadv.Name = "cbbgiadv";
            this.cbbgiadv.Size = new System.Drawing.Size(287, 24);
            this.cbbgiadv.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(841, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Mã phòng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1119, 145);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 18);
            this.label13.TabIndex = 10;
            this.label13.Text = "Loại phòng:";
            // 
            // cbbmap
            // 
            this.cbbmap.FormattingEnabled = true;
            this.cbbmap.Location = new System.Drawing.Point(935, 143);
            this.cbbmap.Margin = new System.Windows.Forms.Padding(4);
            this.cbbmap.Name = "cbbmap";
            this.cbbmap.Size = new System.Drawing.Size(140, 24);
            this.cbbmap.TabIndex = 14;
            this.cbbmap.SelectedIndexChanged += new System.EventHandler(this.cbbmap_SelectedIndexChanged);
            // 
            // cbbgiaphong
            // 
            this.cbbgiaphong.FormattingEnabled = true;
            this.cbbgiaphong.Location = new System.Drawing.Point(1527, 143);
            this.cbbgiaphong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbgiaphong.Name = "cbbgiaphong";
            this.cbbgiaphong.Size = new System.Drawing.Size(177, 24);
            this.cbbgiaphong.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(844, 196);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 18);
            this.label14.TabIndex = 11;
            this.label14.Text = "Ngày thuê phòng:";
            // 
            // dpicker_thuephong
            // 
            this.dpicker_thuephong.Location = new System.Drawing.Point(983, 190);
            this.dpicker_thuephong.Margin = new System.Windows.Forms.Padding(4);
            this.dpicker_thuephong.Name = "dpicker_thuephong";
            this.dpicker_thuephong.Size = new System.Drawing.Size(265, 22);
            this.dpicker_thuephong.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1429, 145);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
            this.label15.TabIndex = 10;
            this.label15.Text = "Giá phòng:";
            // 
            // cbbloaiphong
            // 
            this.cbbloaiphong.FormattingEnabled = true;
            this.cbbloaiphong.Location = new System.Drawing.Point(1223, 143);
            this.cbbloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbloaiphong.Name = "cbbloaiphong";
            this.cbbloaiphong.Size = new System.Drawing.Size(177, 24);
            this.cbbloaiphong.TabIndex = 15;
            // 
            // checkbox_find_hd
            // 
            this.checkbox_find_hd.AutoSize = true;
            this.checkbox_find_hd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_find_hd.Location = new System.Drawing.Point(28, 281);
            this.checkbox_find_hd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbox_find_hd.Name = "checkbox_find_hd";
            this.checkbox_find_hd.Size = new System.Drawing.Size(153, 22);
            this.checkbox_find_hd.TabIndex = 31;
            this.checkbox_find_hd.Text = "Tìm kiếm hoá đơn:";
            this.checkbox_find_hd.UseVisualStyleBackColor = true;
            this.checkbox_find_hd.CheckedChanged += new System.EventHandler(this.checkbox1_CheckedChanged);
            // 
            // checkbox_find_by_kh
            // 
            this.checkbox_find_by_kh.AutoSize = true;
            this.checkbox_find_by_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_find_by_kh.Location = new System.Drawing.Point(28, 321);
            this.checkbox_find_by_kh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbox_find_by_kh.Name = "checkbox_find_by_kh";
            this.checkbox_find_by_kh.Size = new System.Drawing.Size(141, 22);
            this.checkbox_find_by_kh.TabIndex = 31;
            this.checkbox_find_by_kh.Text = "Tìm theo tên KH:";
            this.checkbox_find_by_kh.UseVisualStyleBackColor = true;
            this.checkbox_find_by_kh.CheckedChanged += new System.EventHandler(this.check_find_by_kh_CheckedChanged);
            // 
            // checkbox_find_by_nv
            // 
            this.checkbox_find_by_nv.AutoSize = true;
            this.checkbox_find_by_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_find_by_nv.Location = new System.Drawing.Point(395, 318);
            this.checkbox_find_by_nv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbox_find_by_nv.Name = "checkbox_find_by_nv";
            this.checkbox_find_by_nv.Size = new System.Drawing.Size(140, 22);
            this.checkbox_find_by_nv.TabIndex = 31;
            this.checkbox_find_by_nv.Text = "Tìm theo tên NV:";
            this.checkbox_find_by_nv.UseVisualStyleBackColor = true;
            this.checkbox_find_by_nv.CheckedChanged += new System.EventHandler(this.checkbox_find_by_nv_CheckedChanged);
            // 
            // cb_search_kh
            // 
            this.cb_search_kh.FormattingEnabled = true;
            this.cb_search_kh.Location = new System.Drawing.Point(187, 318);
            this.cb_search_kh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_search_kh.Name = "cb_search_kh";
            this.cb_search_kh.Size = new System.Drawing.Size(201, 24);
            this.cb_search_kh.TabIndex = 14;
            this.cb_search_kh.SelectedIndexChanged += new System.EventHandler(this.cb_search_kh_SelectedIndexChanged);
            // 
            // cb_search_nv
            // 
            this.cb_search_nv.FormattingEnabled = true;
            this.cb_search_nv.Location = new System.Drawing.Point(559, 318);
            this.cb_search_nv.Margin = new System.Windows.Forms.Padding(4);
            this.cb_search_nv.Name = "cb_search_nv";
            this.cb_search_nv.Size = new System.Drawing.Size(228, 24);
            this.cb_search_nv.TabIndex = 14;
            this.cb_search_nv.SelectedIndexChanged += new System.EventHandler(this.cb_search_nv_SelectedIndexChanged);
            // 
            // btn_addHD
            // 
            this.btn_addHD.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_addHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addHD.Location = new System.Drawing.Point(577, 185);
            this.btn_addHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addHD.Name = "btn_addHD";
            this.btn_addHD.Size = new System.Drawing.Size(187, 27);
            this.btn_addHD.TabIndex = 32;
            this.btn_addHD.Text = "Thêm HĐ";
            this.btn_addHD.UseVisualStyleBackColor = false;
            this.btn_addHD.Click += new System.EventHandler(this.btn_addHD_Click);
            // 
            // btn_editHD
            // 
            this.btn_editHD.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_editHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_editHD.Location = new System.Drawing.Point(579, 228);
            this.btn_editHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editHD.Name = "btn_editHD";
            this.btn_editHD.Size = new System.Drawing.Size(187, 27);
            this.btn_editHD.TabIndex = 33;
            this.btn_editHD.Text = "Sửa HĐ";
            this.btn_editHD.UseVisualStyleBackColor = false;
            this.btn_editHD.Click += new System.EventHandler(this.btn_editHD_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1277, 192);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 18);
            this.label17.TabIndex = 11;
            this.label17.Text = "Ngày trả phòng:";
            // 
            // dpicker_ngaytraphong
            // 
            this.dpicker_ngaytraphong.Location = new System.Drawing.Point(1399, 188);
            this.dpicker_ngaytraphong.Margin = new System.Windows.Forms.Padding(4);
            this.dpicker_ngaytraphong.Name = "dpicker_ngaytraphong";
            this.dpicker_ngaytraphong.Size = new System.Drawing.Size(265, 22);
            this.dpicker_ngaytraphong.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1317, 530);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày sử dụng dịch vụ:";
            // 
            // dpicker_ngaysddv
            // 
            this.dpicker_ngaysddv.Location = new System.Drawing.Point(1511, 526);
            this.dpicker_ngaysddv.Margin = new System.Windows.Forms.Padding(4);
            this.dpicker_ngaysddv.Name = "dpicker_ngaysddv";
            this.dpicker_ngaysddv.Size = new System.Drawing.Size(265, 22);
            this.dpicker_ngaysddv.TabIndex = 13;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.hOTELDataSet;
            this.bindingSource1.Position = 0;
            // 
            // hOTELDataSet
            // 
            this.hOTELDataSet.DataSetName = "HOTELDataSet";
            this.hOTELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1317, 480);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tên dịch vụ:";
            // 
            // cbbtendv
            // 
            this.cbbtendv.FormattingEnabled = true;
            this.cbbtendv.Location = new System.Drawing.Point(1433, 479);
            this.cbbtendv.Margin = new System.Windows.Forms.Padding(4);
            this.cbbtendv.Name = "cbbtendv";
            this.cbbtendv.Size = new System.Drawing.Size(287, 24);
            this.cbbtendv.TabIndex = 14;
            // 
            // btn_deleteHD
            // 
            this.btn_deleteHD.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_deleteHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_deleteHD.Location = new System.Drawing.Point(579, 267);
            this.btn_deleteHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deleteHD.Name = "btn_deleteHD";
            this.btn_deleteHD.Size = new System.Drawing.Size(187, 27);
            this.btn_deleteHD.TabIndex = 33;
            this.btn_deleteHD.Text = "Xóa HD";
            this.btn_deleteHD.UseVisualStyleBackColor = false;
            this.btn_deleteHD.Click += new System.EventHandler(this.btn_deleteHD_Click);
            // 
            // bt_inHD
            // 
            this.bt_inHD.BackColor = System.Drawing.Color.LemonChiffon;
            this.bt_inHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inHD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_inHD.Location = new System.Drawing.Point(971, 802);
            this.bt_inHD.Margin = new System.Windows.Forms.Padding(4);
            this.bt_inHD.Name = "bt_inHD";
            this.bt_inHD.Size = new System.Drawing.Size(197, 39);
            this.bt_inHD.TabIndex = 2;
            this.bt_inHD.Text = "In Hoá Đơn";
            this.bt_inHD.UseVisualStyleBackColor = false;
            this.bt_inHD.Click += new System.EventHandler(this.btxem_Click);
            // 
            // frmHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1827, 882);
            this.Controls.Add(this.btn_deleteHD);
            this.Controls.Add(this.btn_editHD);
            this.Controls.Add(this.btn_addHD);
            this.Controls.Add(this.checkbox_find_by_nv);
            this.Controls.Add(this.checkbox_find_by_kh);
            this.Controls.Add(this.checkbox_find_hd);
            this.Controls.Add(this.btn_delete_DV);
            this.Controls.Add(this.btn_delete_DP);
            this.Controls.Add(this.btn_edit_DV);
            this.Controls.Add(this.btn_addDV);
            this.Controls.Add(this.btn_editDP);
            this.Controls.Add(this.btn_addDP);
            this.Controls.Add(this.dgvphong);
            this.Controls.Add(this.dgvdichvu);
            this.Controls.Add(this.dgvhd1);
            this.Controls.Add(this.cbbloaiphong);
            this.Controls.Add(this.cbbgiaphong);
            this.Controls.Add(this.cbbgiadv);
            this.Controls.Add(this.cbbkh);
            this.Controls.Add(this.cbbmap);
            this.Controls.Add(this.cbbtendv);
            this.Controls.Add(this.cbbmadv);
            this.Controls.Add(this.cb_search_nv);
            this.Controls.Add(this.cb_search_kh);
            this.Controls.Add(this.cbbnv);
            this.Controls.Add(this.dpicker_ngaytraphong);
            this.Controls.Add(this.dpicker_ngaysddv);
            this.Controls.Add(this.dpicker_thuephong);
            this.Controls.Add(this.dpicker_ngaylaphd);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_inHD);
            this.Controls.Add(this.btxem);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.dgvhd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHD";
            this.Text = "THÔNG TIN HOÁ ĐƠN";
            this.Load += new System.EventHandler(this.frmHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvhd;
        private System.Windows.Forms.Button btxem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.DateTimePicker dpicker_ngaylaphd;
        private System.Windows.Forms.ComboBox cbbnv;
        private System.Windows.Forms.ComboBox cbbkh;
        private System.Windows.Forms.DataGridView dgvhd1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvdichvu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvphong;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_delete_DP;
        private System.Windows.Forms.Button btn_editDP;
        private System.Windows.Forms.Button btn_addDP;
        private System.Windows.Forms.Button btn_addDV;
        private System.Windows.Forms.Button btn_edit_DV;
        private System.Windows.Forms.Button btn_delete_DV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbmadv;
        private System.Windows.Forms.ComboBox cbbgiadv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbmap;
        private System.Windows.Forms.ComboBox cbbgiaphong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dpicker_thuephong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbbloaiphong;
        private System.Windows.Forms.CheckBox checkbox_find_hd;
        private System.Windows.Forms.CheckBox checkbox_find_by_kh;
        private System.Windows.Forms.CheckBox checkbox_find_by_nv;
        private System.Windows.Forms.ComboBox cb_search_kh;
        private System.Windows.Forms.ComboBox cb_search_nv;
        private System.Windows.Forms.Button btn_addHD;
        private System.Windows.Forms.Button btn_editHD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dpicker_ngaytraphong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dpicker_ngaysddv;
        private System.Windows.Forms.BindingSource bindingSource1;
        private HOTELDataSet hOTELDataSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbtendv;
        private System.Windows.Forms.Button btn_deleteHD;
        private System.Windows.Forms.Button bt_inHD;
    }
}

