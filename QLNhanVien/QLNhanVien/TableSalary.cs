using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QLNhanVien
{
    public partial class TableSalary : Form
    {
        public TableSalary()
        {
            InitializeComponent();
        }
        private DataTable table = new DataTable();
        private void TableSalary_Load(object sender, EventArgs e)
        {
            cbNameId.Text = "Họ tên - Mã nhân viên";
            table.Columns.Add("Mã nhân viên", typeof(string));
            table.Columns.Add("Họ tên", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(DateTime));
            table.Columns.Add("Giới tính", typeof(string));
            table.Columns.Add("Chức vụ", typeof(string));
            table.Columns.Add("Lương", typeof(Double));
            SqlConnection cnn = new SqlConnection();
            QLNhanVien.ConnectionStringSql.connection(ref cnn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select manv, hoten, ngaysinh, gioitinh, chucvu, luong from nhanvien", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataRow dataRow = table.NewRow();
                dataRow["Mã nhân viên"] = (string)reader.GetValue(0);
                dataRow["Họ tên"] = (string)reader.GetValue(1);
                dataRow["Ngày sinh"] = (DateTime)reader.GetValue(2);
                dataRow["Giới tính"] = (string)reader.GetValue(3);
                dataRow["Chức vụ"] = (string)reader.GetValue(4);
                dataRow["Lương"] = (Double)reader.GetValue(5);
                table.Rows.Add(dataRow);
                cbNameId.Items.Add((string)reader.GetValue(1) + " - " + (string)reader.GetValue(0));
            }
            reader.Close();
            dataSalary.DataSource = table;
            cmd.Dispose();
            cnn.Close();
            dataSalary.Columns[3].Width = 100;
            dataSalary.Columns[1].Width = 150;
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            fileExcel = new SaveFileDialog();
            fileExcel.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            if (fileExcel.ShowDialog() == DialogResult.OK)
            {
                filePath = fileExcel.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Xuất Excel không thành công!", "Thông báo");
                return;
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage p = new ExcelPackage())
            {
                // đặt tên người tạo file
                p.Workbook.Properties.Author = "Hori";

                // đặt tiêu đề cho file
                p.Workbook.Properties.Title = "Unknows";

                //Tạo một sheet để làm việc trên đó
                p.Workbook.Worksheets.Add("Nhân Viên Sheet");

                // lấy sheet vừa add ra để thao tác
                ExcelWorksheet ws = p.Workbook.Worksheets[0];

                // đặt tên cho sheet
                ws.Name = "Nhân viên sheet";
                // fontsize mặc định cho cả sheet
                ws.Cells.Style.Font.Size = 11;
                // font family mặc định cho cả sheet
                ws.Cells.Style.Font.Name = "Calibri";
                // Tạo danh sách các column header
                string[] arrColumnHeader = {"Mã nhân viên","Họ tên","Ngày sinh","Giới tính","Chức vụ",
                                    "Lương (VND)"};
                // lấy ra số lượng cột cần dùng dựa vào số lượng header
                var countColHeader = arrColumnHeader.Count();

                // merge các column lại từ column 1 đến số column header
                // gán giá trị cho cell vừa merge là danh sach nhan vien khach san
                ws.Cells[1, 1].Value = "Danh Sách Lương Nhân Viên";
                ws.Cells[1, 1].Style.Font.Size = 16;
                ws.Cells[1, 1].Style.Border.Top.Style =
                    ws.Cells[1, 1].Style.Border.Bottom.Style
                   = ws.Cells[1, 1].Style.Border.Right.Style
                  = ws.Cells[1, 1].Style.Border.Left.Style = ws.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.None;
                ws.Cells[1, 1, 1, countColHeader].Merge = true;
                // in đậm
                ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                // căn giữa
                ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Cells[2, 1].Value = "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                ws.Cells[2, 1].Style.Font.Size = 11;
                ws.Cells[2, 1].Style.Border.Top.Style =
                    ws.Cells[2, 1].Style.Border.Bottom.Style
                   = ws.Cells[2, 1].Style.Border.Right.Style
                  = ws.Cells[2, 1].Style.Border.Left.Style = ws.Cells[2, 1].Style.Border.Top.Style = ExcelBorderStyle.None;
                int colIndex = 1;
                int rowIndex = 3;
                for (int i = 1; i <= countColHeader; i++)
                {
                    ws.Column(i).Style.Border.Top.Style
                                    = ws.Column(i).Style.Border.Bottom.Style
                                    = ws.Column(i).Style.Border.Left.Style
                                    = ws.Column(i).Style.Border.Right.Style
                                    = ExcelBorderStyle.Thin;
                }
                //tạo các header từ column header đã tạo từ bên trên
                foreach (var item in arrColumnHeader)
                {
                    var cell = ws.Cells[rowIndex, colIndex];
                    //set màu thành gray
                    var fill = cell.Style.Fill;
                    fill.PatternType = ExcelFillStyle.Solid;
                    fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    //căn chỉnh các border
                    var border = cell.Style.Border;
                    border.Bottom.Style =
                        border.Top.Style =
                        border.Left.Style =
                        border.Right.Style = ExcelBorderStyle.Thin;

                    //gán giá trị
                    cell.Value = item;
                    colIndex++;
                }
                ws.Column(1).Width = 12;
                ws.Column(2).Width = 19;
                ws.Column(3).Width = 12;
                ws.Column(4).Width = 8;
                ws.Column(5).Width = 8.5;
                ws.Column(6).Width = 12;
                DataRow[] result = table.Select();
                foreach (DataRow row in result)
                {
                    colIndex = 1;

                    // rowIndex tương ứng từng dòng dữ liệu
                    rowIndex++;

                    //gán giá trị cho từng cell                      
                    ws.Cells[rowIndex, colIndex++].Value = row[0];
                    ws.Cells[rowIndex, colIndex++].Value = row[1];
                    DateTime date = (DateTime)row[2];
                    ws.Cells[rowIndex, colIndex++].Value = date.ToShortDateString();
                    ws.Cells[rowIndex, colIndex++].Value = row[3];
                    ws.Cells[rowIndex, colIndex++].Value = row[4];
                    ws.Cells[rowIndex, colIndex++].Value = row[5];
                }
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
            }
            MessageBox.Show("Xuất Excel thành công!", "Thông báo");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if(cbNameId.SelectedItem != null)
            {
                table.Clear();
                SqlConnection cnn = new SqlConnection();
                QLNhanVien.ConnectionStringSql.connection(ref cnn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select manv, hoten, ngaysinh, gioitinh, chucvu, luong from nhanvien where manv = '" + cbNameId.SelectedItem.ToString().Substring(cbNameId.SelectedItem.ToString().LastIndexOf('-') + 2) + "'", cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["Mã nhân viên"] = (string)reader.GetValue(0);
                    dataRow["Họ tên"] = (string)reader.GetValue(1);
                    dataRow["Ngày sinh"] = (DateTime)reader.GetValue(2);
                    dataRow["Giới tính"] = (string)reader.GetValue(3);
                    dataRow["Chức vụ"] = (string)reader.GetValue(4);
                    dataRow["Lương"] = (Double)reader.GetValue(5);
                    table.Rows.Add(dataRow);
                    cbNameId.Items.Add((string)reader.GetValue(1) + " - " + (string)reader.GetValue(0));
                }
                reader.Close();
                cmd.Dispose();
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên này !","Thông báo");
            }
        }

        private void picReset_Click(object sender, EventArgs e)
        {
            table.Columns.Clear();
            table.Clear();
            cbNameId.Items.Clear();
            TableSalary_Load(sender, e);
        }
    }
}
