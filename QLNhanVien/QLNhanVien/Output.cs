using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QLNhanVien
{
    public partial class Output : Form
    {
        private DataTable table = new DataTable();
        private string idNv = "";
        public Output()
        {
            InitializeComponent();

        }
        public Output(string idNv)
        {
            InitializeComponent();
            this.idNv = idNv;
        }
        private void btLoc_Click(object sender, EventArgs e)
        {
            btLoc.BackColor = Color.LightSteelBlue;
            btQuaylai.BackColor = Color.White;
            btThoat.BackColor = Color.White;
            btSua.BackColor = Color.White;
            btXoa.BackColor = Color.White;
            btSearch.BackColor = Color.White;
            btIn.BackColor = Color.White;
            table.Clear();
            string[] gender = { "", "" };
            if (cbNam.Checked == true)
            {
                gender[0] = "Nam";
            }
            if (cbNu.Checked == true)
            {
                gender[1] = "Nữ";
            }
            string[] cv = { "", "" };
            if (cboxLetan.Checked == true)
            {
                cv[0] = "Lễ Tân";
            }
            if (cboxThungan.Checked == true)
            {
                cv[1] = "Thu Ngân";
            }
            if (numMin.Value > numMax.Value)
            {
                MessageBox.Show("Khoảng tuổi không hợp lý !!");
            }
            string sql = "";
            SqlConnection cnn = new SqlConnection();
            ConnectionStringSql.connection(ref cnn);
            cnn.Open();
            SqlCommand cmd;
            if ((cbNam.Checked == true || cbNu.Checked == true) && ((int)numMax.Value == 0) && (cboxLetan.Checked == false && cboxThungan.Checked == false) && (string.Compare(cboxAdd.Text, "địa chỉ", true) == 0))
            {
                sql = "select * from nhanvien where  gioitinh in (N'" + gender[0] + "', N'" + gender[1] + "')";
            }
            if ((cbNam.Checked == true || cbNu.Checked == true) && ((int)numMax.Value != 0) && (cboxLetan.Checked == false && cboxThungan.Checked == false) && (string.Compare(cboxAdd.Text, "địa chỉ", true) == 0))
            {
                if ((int)numMax.Value < 18)
                {
                    MessageBox.Show("Tuổi phải từ 18 trở lên !!");

                }
                else
                {
                    sql = "select * from nhanvien where  gioitinh in (N'" + gender[0] + "', N'" + gender[1] + "') and (year(getdate()) - year(ngaysinh) >= '" + (int)numMin.Value + "' and year(getdate()) - year(ngaysinh) <= '" + (int)numMax.Value + "')";
                }
            }
            if ((cbNam.Checked == true || cbNu.Checked == true) && ((int)numMax.Value == 0) && (cboxLetan.Checked == true || cboxThungan.Checked == true) && (string.Compare(cboxAdd.Text, "địa chỉ", true) == 0))
            {
                sql = "select * from nhanvien where  gioitinh in (N'" + gender[0] + "', N'" + gender[1] + "') and chucvu in (N'" + cv[0] + "', N'" + cv[1] + "')";
            }
            if ((cbNam.Checked == true || cbNu.Checked == true) && ((int)numMax.Value == 0) && (cboxLetan.Checked == false && cboxThungan.Checked == false) && (string.Compare(cboxAdd.Text, "địa chỉ", true) != 0))
            {
                if (cboxAdd.SelectedItem != null)
                {
                    sql = "select * from nhanvien where  gioitinh in (N'" + gender[0] + "', N'" + gender[1] + "') and quequan = N'" + cboxAdd.SelectedItem.ToString() + "'";
                }
            }
            if ((cbNam.Checked == true || cbNu.Checked == true) && ((int)numMax.Value == 0) && (cboxLetan.Checked == true || cboxThungan.Checked == true) && (string.Compare(cboxAdd.Text, "địa chỉ", true) != 0))

            {
                if (cboxAdd.SelectedItem != null)
                {
                    sql = "select * from nhanvien where  gioitinh in (N'" + gender[0] + "', N'" + gender[1] + "') and chucvu in (N'" + cv[0] + "', N'" + cv[1] + "') and quequan = N'" + cboxAdd.SelectedItem.ToString() + "'";
                }
            }
            if ((cbNam.Checked == true || cbNu.Checked == true) && ((int)numMax.Value != 0) && (cboxLetan.Checked == true || cboxThungan.Checked == true) && (string.Compare(cboxAdd.Text, "địa chỉ", true) == 0))
            {
                if ((int)numMax.Value < 18)
                {
                    MessageBox.Show("Tuổi phải từ 18 trở lên !!");

                }
                else
                {
                    sql = "select * from nhanvien where  gioitinh in (N'" + gender[0] + "', N'" + gender[1] + "') and (year(getdate()) - year(ngaysinh) >= '" + (int)numMin.Value + "' and year(getdate()) - year(ngaysinh) <= '" + (int)numMax.Value + "') and chucvu in (N'" + cv[0] + "', N'" + cv[1] + "')";
                }
            }
            if ((cbNam.Checked == true || cbNu.Checked == true) && ((int)numMax.Value != 0) && (cboxLetan.Checked == false && cboxThungan.Checked == false) && (string.Compare(cboxAdd.Text, "địa chỉ", true) != 0))
            {
                if (cboxAdd.SelectedItem != null)
                {
                    if ((int)numMax.Value < 18)
                    {
                        MessageBox.Show("Tuổi phải từ 18 trở lên !!");
                    }
                    else
                    {
                        sql = "select * from nhanvien where  gioitinh in (N'" + gender[0] + "', N'" + gender[1] + "') and (year(getdate()) - year(ngaysinh) >= '" + (int)numMin.Value + "' and year(getdate()) - year(ngaysinh) <= '" + (int)numMax.Value + "') and quequan = N'" + cboxAdd.SelectedItem.ToString() + "'";
                    }
                }
            }
            if ((cbNam.Checked == true || cbNu.Checked == true) && ((int)numMax.Value != 0) && (cboxLetan.Checked == true || cboxThungan.Checked == true) && (string.Compare(cboxAdd.Text, "địa chỉ", true) != 0))
            {
                if (cboxAdd.SelectedItem != null)
                {
                    if ((int)numMax.Value < 18)
                    {
                        MessageBox.Show("Tuổi phải từ 18 trở lên !!");

                    }
                    else
                    {
                        sql = "select * from nhanvien where  gioitinh in (N'" + gender[0] + "', N'" + gender[1] + "') and (year(getdate()) - year(ngaysinh) >= '" + (int)numMin.Value + "' and year(getdate()) - year(ngaysinh) <= '" + (int)numMax.Value + "') and chucvu in (N'" + cv[0] + "', N'" + cv[1] + "') and quequan = N'" + cboxAdd.SelectedItem.ToString() + "'";
                    }
                }
            }
            if ((cbNam.Checked == false && cbNu.Checked == false) && ((int)numMax.Value != 0) && (cboxLetan.Checked == false && cboxThungan.Checked == false) && (string.Compare(cboxAdd.Text, "địa chỉ", true) == 0))
            {
                if ((int)numMax.Value < 18)
                {
                    MessageBox.Show("Tuổi phải từ 18 trở lên !!");

                }
                else
                {
                    sql = "select * from nhanvien where  (year(getdate()) - year(ngaysinh) >= '" + (int)numMin.Value + "' and year(getdate()) - year(ngaysinh) <= '" + (int)numMax.Value + "')";
                }
            }
            if ((cbNam.Checked == false && cbNu.Checked == false) && ((int)numMax.Value != 0) && (cboxLetan.Checked == true || cboxThungan.Checked == true) && (string.Compare(cboxAdd.Text, "địa chỉ", true) == 0))
            {
                if ((int)numMax.Value < 18)
                {
                    MessageBox.Show("Tuổi phải từ 18 trở lên !!");

                }
                else
                {
                    sql = "select * from nhanvien where  (year(getdate()) - year(ngaysinh) >= '" + (int)numMin.Value + "' and year(getdate()) - year(ngaysinh) <= '" + (int)numMax.Value + "') and chucvu in (N'" + cv[0] + "', N'" + cv[1] + "')";
                }
            }
            if ((cbNam.Checked == false && cbNu.Checked == false) && ((int)numMax.Value != 0) && (cboxLetan.Checked == false && cboxThungan.Checked == false) && (string.Compare(cboxAdd.Text, "địa chỉ", true) != 0))
            {
                if (cboxAdd.SelectedItem != null)
                {
                    if ((int)numMax.Value < 18)
                    {
                        MessageBox.Show("Tuổi phải từ 18 trở lên !!");

                    }
                    else
                    {
                        sql = "select * from nhanvien where  (year(getdate()) - year(ngaysinh) >= '" + (int)numMin.Value + "' and year(getdate()) - year(ngaysinh) <= '" + (int)numMax.Value + "') and quequan = N'" + cboxAdd.SelectedItem.ToString() + "'";
                    }
                }
            }
            if ((cbNam.Checked == false && cbNu.Checked == false) && ((int)numMax.Value != 0) && (cboxLetan.Checked == true || cboxThungan.Checked == true) && (string.Compare(cboxAdd.Text, "địa chỉ", true) != 0))
            {
                if (cboxAdd.SelectedItem != null)
                {
                    if ((int)numMax.Value < 18)
                    {
                        MessageBox.Show("Tuổi phải từ 18 trở lên !!");

                    }
                    else
                    {
                        sql = "select * from nhanvien where  (year(getdate()) - year(ngaysinh) >= '" + (int)numMin.Value + "' and year(getdate()) - year(ngaysinh) <= '" + (int)numMax.Value + "') and chucvu in (N'" + cv[0] + "', N'" + cv[1] + "') and quequan = N'" + cboxAdd.SelectedItem.ToString() + "'";
                    }
                }
            }
            if ((cbNam.Checked == false && cbNu.Checked == false) && ((int)numMax.Value == 0) && (cboxLetan.Checked == true || cboxThungan.Checked == true) && (string.Compare(cboxAdd.Text, "địa chỉ", true) == 0))
            {
                if (cboxAdd.SelectedItem != null)
                {
                    sql = "select * from nhanvien where  chucvu in (N'" + cv[0] + "', N'" + cv[1] + "')";
                }
            }
            if ((cbNam.Checked == false && cbNu.Checked == false) && ((int)numMax.Value == 0) && (cboxLetan.Checked == true || cboxThungan.Checked == true) && (string.Compare(cboxAdd.Text, "địa chỉ", true) != 0))
            {
                if (cboxAdd.SelectedItem != null)
                {
                    sql = "select * from nhanvien where  chucvu in (N'" + cv[0] + "', N'" + cv[1] + "') and quequan = N'" + cboxAdd.SelectedItem.ToString() + "'";
                }
            }
            if ((cbNam.Checked == false && cbNu.Checked == false) && ((int)numMax.Value == 0) && (cboxLetan.Checked == false && cboxThungan.Checked == false) && (string.Compare(cboxAdd.Text, "địa chỉ", true) != 0))
            {
                if (cboxAdd.SelectedItem != null)
                {
                    sql = "select * from nhanvien where  quequan = N'" + cboxAdd.SelectedItem.ToString() + "'";
                }
            }
            if (sql.Length > 0)
            {
                cmd = new SqlCommand(sql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (string.Compare((string)reader.GetValue(0), "NV.QL", true) != 0)
                    {
                        DataRow newRows = table.NewRow();
                        newRows["Mã nhân viên"] = (string)reader.GetValue(0);
                        newRows["Họ tên"] = (string)reader.GetValue(1);
                        newRows["Ngày sinh"] = (DateTime)reader.GetValue(2);
                        newRows["Giới tính"] = (string)reader.GetValue(3);
                        newRows["Địa chỉ"] = (string)reader.GetValue(4);
                        newRows["Liên lạc"] = (string)reader.GetValue(5);
                        newRows["Lương"] = (Double)reader.GetValue(6);
                        newRows["Chức vụ"] = (string)reader.GetValue(7);
                        table.Rows.Add(newRows);
                    }
                }
                cmd.Dispose();
                reader.Close();
            }
            cnn.Close();
            dtVDs.DataSource = table;
            MessageBox.Show("Có " + (dtVDs.Rows.Count - 1) + " nhân viên thỏa điều kiện !", "Thông báo");
        }

        private void btQuaylai_Click(object sender, EventArgs e)
        {
            btLoc.BackColor = Color.White;
            btQuaylai.BackColor = Color.LightSteelBlue;
            btThoat.BackColor = Color.White;
            btSua.BackColor = Color.White;
            btXoa.BackColor = Color.White;
            btSearch.BackColor = Color.White;
            btIn.BackColor = Color.White;
            table.Columns.Clear();
            table.Clear();
            cboxAdd.Items.Clear();
            cBoxNameId.Items.Clear();
            Output_Load(sender, e);
        }
        //thoat
        private void button3_Click(object sender, EventArgs e)
        {
            //btXoa.BackColor = Color.White;
            //btLoc.BackColor = Color.White;
            //btQuaylai.BackColor = Color.White;
            //btThoat.BackColor = Color.LightSteelBlue;
            //btSua.BackColor = Color.White;
            //DialogResult dialog = MessageBox.Show("Bạn có muốn thoát !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (dialog == DialogResult.OK)
            //{
            //    this.Close();
            //}

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btXoa.BackColor = Color.White;
            btLoc.BackColor = Color.White;
            btQuaylai.BackColor = Color.White;
            btThoat.BackColor = Color.White;
            btSua.BackColor = Color.LightSteelBlue;
            btSearch.BackColor = Color.White;
            btIn.BackColor = Color.White;
            Cursor = Cursors.Hand;
            if (dtVDs.SelectedRows.Count > 0)
            {
                new Update(dtVDs.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();
                table.Columns.Clear();
                table.Clear();
                cboxAdd.Items.Clear();
                cBoxNameId.Items.Clear();
                Output_Load(sender, e);
            }
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            btXoa.BackColor = Color.LightSteelBlue;
            btLoc.BackColor = Color.White;
            btQuaylai.BackColor = Color.White;
            btThoat.BackColor = Color.White;
            btSua.BackColor = Color.White;
            btSearch.BackColor = Color.White;
            btIn.BackColor = Color.White;
            if (dtVDs.SelectedRows.Count > 0)
            {
                string value1 = dtVDs.SelectedRows[0].Cells[0].Value.ToString();
                string value2 = dtVDs.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dialog = MessageBox.Show("Bạn có chắc " + value1 + " - " + value2 + " ra khỏi hệ thống !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dtVDs.SelectedRows)
                    {
                        dtVDs.Rows.RemoveAt(row.Index);
                    }
                    SqlConnection cnn = new SqlConnection();
                    ConnectionStringSql.connection(ref cnn);
                    cnn.Open();
                    SqlCommand cmd;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    //cmd = new SqlCommand("update hoadon set manv = '" + "NV.QL" + "'where manv = '" + value1 + "'",cnn);
                    //adapter.UpdateCommand = new SqlCommand("update hoadon set manv = '" + "NV.QL" + "'where manv = '" + value1 + "'", cnn);
                    //adapter.UpdateCommand.ExecuteNonQuery();
                    string sql = "delete from nhanvien where manv = '" + value1 + "'";
                    cmd = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand = new SqlCommand(sql, cnn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    cmd.Dispose();
                    cnn.Close();
                }
            }
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void Output_Load(object sender, EventArgs e)
        {
            btThoat.Hide();
            cboxAdd.Text = "Địa chỉ";
            table.Columns.Add("Mã nhân viên", typeof(String));
            table.Columns.Add("Họ tên", typeof(String));
            table.Columns.Add("Ngày sinh", typeof(DateTime));
            table.Columns.Add("Giới tính", typeof(String));
            table.Columns.Add("Địa chỉ", typeof(String));
            table.Columns.Add("Liên lạc", typeof(String));
            table.Columns.Add("Lương", typeof(Double));
            table.Columns.Add("Chức vụ", typeof(String));
            SqlConnection cnn = new SqlConnection();
            ConnectionStringSql.connection(ref cnn);
            cnn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("select * from nhanvien", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                DataRow newRows = table.NewRow();
                newRows["Mã nhân viên"] = (string)reader.GetValue(0);
                newRows["Họ tên"] = (string)reader.GetValue(1);
                newRows["Ngày sinh"] = (DateTime)reader.GetValue(2);
                newRows["Giới tính"] = (string)reader.GetValue(3);
                newRows["Địa chỉ"] = (string)reader.GetValue(4);
                newRows["Liên lạc"] = (string)reader.GetValue(5);
                newRows["Lương"] = (Double)reader.GetValue(6);
                newRows["Chức vụ"] = (string)reader.GetValue(7);
                table.Rows.Add(newRows);
                cBoxNameId.Items.Add((string)reader.GetValue(1) + " - " + (string)reader.GetValue(0));
            }
            reader.Close();
            cmd = new SqlCommand("select distinct quequan from nhanvien", cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboxAdd.Items.Add((string)reader.GetValue(0));
            }
            reader.Close();
            cBoxNameId.Text = "Họ tên - Mã nhân viên";
            cmd.Dispose();
            cnn.Close();
            dtVDs.DataSource = table;
            dtVDs.Columns[1].Width = 180;
            dtVDs.Columns[3].Width = 100;
        }
        //Xuat file Excel
        private void btIn_Click(object sender, EventArgs e)
        {
            btXoa.BackColor = Color.White;
            btLoc.BackColor = Color.White;
            btQuaylai.BackColor = Color.White;
            btThoat.BackColor = Color.White;
            btSua.BackColor = Color.White;
            btSearch.BackColor = Color.White;
            btIn.BackColor = Color.LightSteelBlue;
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
                string[] arrColumnHeader = {"Mã nhân viên","Họ tên","Ngày sinh","Giới tính", "Địa chỉ","Liên lạc",
                                    "Lương (VND)","Chức vụ"};
                // lấy ra số lượng cột cần dùng dựa vào số lượng header
                var countColHeader = arrColumnHeader.Count();

                // merge các column lại từ column 1 đến số column header
                // gán giá trị cho cell vừa merge là danh sach nhan vien khach san
                ws.Cells[1, 1].Value = "Danh Sách Nhân Viên Khách Sạn";
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
                ws.Column(5).Width = 9.5;
                ws.Column(6).Width = 12;
                ws.Column(7).Width = 12;
                ws.Column(8).Width = 8.5;
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
                    ws.Cells[rowIndex, colIndex++].Value = row[6];
                    ws.Cells[rowIndex, colIndex++].Value = row[7];

                }
                //Lưu file lại
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(filePath, bin);
            }
            MessageBox.Show("Xuất Excel thành công!", "Thông báo");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            btXoa.BackColor = Color.White;
            btLoc.BackColor = Color.White;
            btQuaylai.BackColor = Color.White;
            btThoat.BackColor = Color.White;
            btSua.BackColor = Color.White;
            btSearch.BackColor = Color.LightSteelBlue;
            btIn.BackColor = Color.White;
            try
            {
                if (cBoxNameId.SelectedItem != null)
                {
                    table.Clear();
                    SqlConnection cnn = new SqlConnection();
                    QLNhanVien.ConnectionStringSql.connection(ref cnn);
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("select * from nhanvien where manv = '" + cBoxNameId.SelectedItem.ToString().Substring(cBoxNameId.SelectedItem.ToString().LastIndexOf('-') + 2) + "'", cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DataRow newRows = table.NewRow();
                        newRows["Mã nhân viên"] = (string)reader.GetValue(0);
                        newRows["Họ tên"] = (string)reader.GetValue(1);
                        newRows["Ngày sinh"] = (DateTime)reader.GetValue(2);
                        newRows["Giới tính"] = (string)reader.GetValue(3);
                        newRows["Địa chỉ"] = (string)reader.GetValue(4);
                        newRows["Liên lạc"] = (string)reader.GetValue(5);
                        newRows["Lương"] = (Double)reader.GetValue(6);
                        newRows["Chức vụ"] = (string)reader.GetValue(7);
                        table.Rows.Add(newRows);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtVDs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(dtVDs.SelectedRows.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Bạn muốn: \n Xóa [Yes] or Sửa [No]", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    btXoa.PerformClick();
                }
                else if (dialog == DialogResult.No)
                {
                    btSua.PerformClick();
                }
            }
        }
    }
}
