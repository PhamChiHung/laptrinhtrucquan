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
using System.IO;

namespace qltaikhoan
{
    public partial class DSTaiKhoan : Form
    {
        public DSTaiKhoan()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private void DSTaiKhoan_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("HỌ TÊN", typeof(String));
            dt.Columns.Add("NGÀY SINH", typeof(DateTime));
            dt.Columns.Add("CHỨC VỤ", typeof(String));
            dt.Columns.Add("TÊN ĐĂNG NHẬP", typeof(String));
            dt.Columns.Add("MẬT KHẨU", typeof(String));
            SqlConnection cnn = new SqlConnection();
            connectDB.connectDatabase(ref cnn);
            cnn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("select manv,hoten,ngaysinh,chucvu,matkhau from  Nhanvien ", cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DataRow dr = dt.NewRow();
                dr["HỌ TÊN"] = reader.GetValue(1).ToString();
                dr["NGÀY SINH"] = (DateTime)reader.GetValue(2);
                dr["CHỨC VỤ"] = reader.GetValue(3).ToString();
                dr["TÊN ĐĂNG NHẬP"] = reader.GetValue(0).ToString();
                dr["MẬT KHẨU"] = reader.GetValue(4).ToString();
                cbxhoten.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                dt.Rows.Add(dr);
            }

            reader.Close();
            cmd.Dispose();
            cnn.Close();
            tbDS.DataSource = dt;
            tbDS.Columns[0].Width = 80;
            tbDS.Columns[1].Width = 160;
            tbDS.Columns[2].Width = 120;
            tbDS.Columns[3].Width = 150;
            tbDS.Columns[4].Width = 150;
            cbxhoten.Text = "Họ Tên Nhân Viên";
        }
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            if (cbxhoten.SelectedItem != null)
            {
                string name = cbxhoten.SelectedItem.ToString();
                dt.Clear();
                SqlConnection cnn = new SqlConnection();
                connectDB.connectDatabase(ref cnn);
                cnn.Open();
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand("select manv,hoten,ngaysinh,chucvu,matkhau from  Nhanvien where manv = '" + name.Substring(0, name.LastIndexOf('-') - 1) + "'", cnn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["HỌ TÊN"] = reader.GetValue(1).ToString();
                    dr["NGÀY SINH"] = (DateTime)reader.GetValue(2);
                    dr["CHỨC VỤ"] = reader.GetValue(3).ToString();
                    dr["TÊN ĐĂNG NHẬP"] = reader.GetValue(0).ToString();
                    dr["MẬT KHẨU"] = reader.GetValue(4).ToString();
                    cbxhoten.Items.Add(reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString());
                    dt.Rows.Add(dr);
                }

                reader.Close();
                cmd.Dispose();
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Không tồn tại nhân viên này !");
            }
        }
        private void btfile_Click(object sender, EventArgs e)
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
                MessageBox.Show("Đường dẫn không hợp lệ");
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
                string[] arrColumnHeader = {  "Họ tên","Ngày sinh", "Chức vụ", "Tên đăng nhập", "Mật khẩu" };
                // lấy ra số lượng cột cần dùng dựa vào số lượng header
                var countColHeader = arrColumnHeader.Count();

                // merge các column lại từ column 1 đến số column header
                // gán giá trị cho cell vừa merge là danh sach nhan vien khach san
                ws.Cells[1, 1].Value = "Danh Sách Tài Khoản Nhân Viên";
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

                int colIndex = 1;
                int rowIndex = 2;
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
                ws.Column(1).Width = 25;
                ws.Column(2).Width = 23;
                ws.Column(3).Width = 12;
                ws.Column(4).Width = 13.3;
                ws.Column(5).Width = 16.3;
                DataRow[] result = dt.Select();
                foreach (DataRow row in result)
                {
                    colIndex = 1;

                    // rowIndex tương ứng từng dòng dữ liệu
                    rowIndex++;

                    //gán giá trị cho từng cell                      
                    ws.Cells[rowIndex, colIndex++].Value = row[0];
                    ws.Cells[rowIndex, colIndex++].Value = row[1].ToString();
                    ws.Cells[rowIndex, colIndex++].Value = row[2];
                    ws.Cells[rowIndex, colIndex++].Value = row[3];
                    ws.Cells[rowIndex, colIndex++].Value = row[4];


                }
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
            }
            MessageBox.Show("Xuất Excel thành công!", "Thông báo");
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            if(tbDS.SelectedRows.Count > 0)
            {
                new CapNhatMK(tbDS.SelectedRows[0].Cells[3].Value.ToString()).ShowDialog();
                dt.Columns.Clear();
                dt.Clear();
                DSTaiKhoan_Load(sender, e);
            }
        }
        private void pbreset_Click(object sender, EventArgs e)
        {
            cbxhoten.Items.Clear();
            dt.Columns.Clear();
            dt.Clear();
            DSTaiKhoan_Load(sender, e);
        }
        private void tbDS_DoubleClick(object sender, EventArgs e)
        {
            new CapNhatMK(tbDS.SelectedRows[0].Cells[3].Value.ToString()).ShowDialog();
            dt.Columns.Clear();
            dt.Clear();
            DSTaiKhoan_Load(sender, e);
        }
    }
}
