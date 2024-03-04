namespace qltaikhoan
{
    partial class DSTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxhoten = new System.Windows.Forms.ComboBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btfile = new System.Windows.Forms.Button();
            this.pbreset = new System.Windows.Forms.PictureBox();
            this.fileExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDS
            // 
            this.tbDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbDS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDS.Location = new System.Drawing.Point(4, 120);
            this.tbDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDS.MultiSelect = false;
            this.tbDS.Name = "tbDS";
            this.tbDS.ReadOnly = true;
            this.tbDS.RowHeadersWidth = 51;
            this.tbDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbDS.Size = new System.Drawing.Size(806, 227);
            this.tbDS.TabIndex = 1;
            this.tbDS.DoubleClick += new System.EventHandler(this.tbDS_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên - Mã Nhân Viên :";
            // 
            // cbxhoten
            // 
            this.cbxhoten.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxhoten.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxhoten.FormattingEnabled = true;
            this.cbxhoten.Location = new System.Drawing.Point(209, 62);
            this.cbxhoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxhoten.Name = "cbxhoten";
            this.cbxhoten.Size = new System.Drawing.Size(285, 24);
            this.cbxhoten.TabIndex = 3;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(502, 59);
            this.bttimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(88, 28);
            this.bttimkiem.TabIndex = 4;
            this.bttimkiem.Text = "Tìm Kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(4, 355);
            this.btsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(100, 28);
            this.btsua.TabIndex = 6;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btfile
            // 
            this.btfile.Location = new System.Drawing.Point(710, 355);
            this.btfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btfile.Name = "btfile";
            this.btfile.Size = new System.Drawing.Size(100, 28);
            this.btfile.TabIndex = 7;
            this.btfile.Text = "File Excel";
            this.btfile.UseVisualStyleBackColor = true;
            this.btfile.Click += new System.EventHandler(this.btfile_Click);
            // 
            // pbreset
            // 
            this.pbreset.Image = global::qltaikhoan.Properties.Resources.reset;
            this.pbreset.Location = new System.Drawing.Point(665, 56);
            this.pbreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbreset.Name = "pbreset";
            this.pbreset.Size = new System.Drawing.Size(61, 30);
            this.pbreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbreset.TabIndex = 5;
            this.pbreset.TabStop = false;
            this.pbreset.Click += new System.EventHandler(this.pbreset_Click);
            // 
            // DSTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(819, 395);
            this.Controls.Add(this.btfile);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.pbreset);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.cbxhoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DSTaiKhoan";
            this.Text = "DSTaiKhoan";
            this.Load += new System.EventHandler(this.DSTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxhoten;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.PictureBox pbreset;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btfile;
        private System.Windows.Forms.SaveFileDialog fileExcel;
    }
}