namespace QLNhanVien
{
    partial class TableSalary
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
            this.dataSalary = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btExcel = new System.Windows.Forms.Button();
            this.fileExcel = new System.Windows.Forms.SaveFileDialog();
            this.cbNameId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.picReset = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSalary
            // 
            this.dataSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSalary.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalary.Location = new System.Drawing.Point(1, 97);
            this.dataSalary.MultiSelect = false;
            this.dataSalary.Name = "dataSalary";
            this.dataSalary.ReadOnly = true;
            this.dataSalary.RowHeadersWidth = 51;
            this.dataSalary.RowTemplate.Height = 29;
            this.dataSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSalary.Size = new System.Drawing.Size(816, 414);
            this.dataSalary.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Lương Nhân Viên";
            // 
            // btExcel
            // 
            this.btExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcel.Location = new System.Drawing.Point(639, 51);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(94, 29);
            this.btExcel.TabIndex = 2;
            this.btExcel.Text = "File Excel";
            this.btExcel.UseVisualStyleBackColor = false;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // cbNameId
            // 
            this.cbNameId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbNameId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNameId.FormattingEnabled = true;
            this.cbNameId.Location = new System.Drawing.Point(152, 52);
            this.cbNameId.Name = "cbNameId";
            this.cbNameId.Size = new System.Drawing.Size(230, 28);
            this.cbNameId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Tên:";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Location = new System.Drawing.Point(441, 51);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(94, 29);
            this.btSearch.TabIndex = 5;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // picReset
            // 
            this.picReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReset.Image = global::QLNhanVien.Properties.Resources.reset;
            this.picReset.Location = new System.Drawing.Point(570, 52);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(30, 30);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReset.TabIndex = 6;
            this.picReset.TabStop = false;
            this.picReset.Click += new System.EventHandler(this.picReset_Click);
            // 
            // TableSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(819, 513);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNameId);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableSalary";
            this.Load += new System.EventHandler(this.TableSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataSalary;
        private Label label1;
        private Button btExcel;
        private SaveFileDialog fileExcel;
        private ComboBox cbNameId;
        private Label label2;
        private Button btSearch;
        private PictureBox picReset;
    }
}