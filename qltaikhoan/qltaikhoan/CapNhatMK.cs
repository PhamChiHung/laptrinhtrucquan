using OfficeOpenXml.Packaging.Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace qltaikhoan
{
    public partial class CapNhatMK : Form
    {
        public CapNhatMK()
        {
            InitializeComponent();
        }
        private string id = " ";
        public CapNhatMK(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void CapNhatMK_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            connectDB.connectDatabase(ref cnn);
            cnn.Open();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("select hoten,chucvu from Nhanvien where manv = '"+ id + "' ", cnn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbHoTen.Text = reader.GetValue(0).ToString();
                lbChucvu.Text = reader.GetValue(1).ToString();
            }
            reader.Close();
            cmd.Dispose();
            cnn.Close();
        }

        private void pbHien1_Click(object sender, EventArgs e)
        {
            if (tbMK1.PasswordChar == '\0')
            {
                pbAn1.BringToFront();
                tbMK1.PasswordChar = '*';
            }
        }

        private void pbAn1_Click(object sender, EventArgs e)
        {
            if (tbMK1.PasswordChar == '*')
            {
                pbHien1.BringToFront();
                tbMK1.PasswordChar = '\0';
            }
        }

        private void pbAn2_Click(object sender, EventArgs e)
        {
            if (tbMK2.PasswordChar == '*')
            {
                pbHien2.BringToFront();
                tbMK2.PasswordChar = '\0';
            }
        }

        private void pbHien2_Click(object sender, EventArgs e)
        {
            if (tbMK2.PasswordChar == '\0')
            {
                pbAn2.BringToFront();
                tbMK2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbMK1.Text.Length!=0 && tbMK2.Text.Length!=0)&&(tbMK1.Text == tbMK2.Text))
            {
                if (tbMK1.Text.Length > 6 && tbMK2.Text.Length > 6)
                {
                    SqlConnection cnn = new SqlConnection();
                    connectDB.connectDatabase(ref cnn);
                    cnn.Open();
                    SqlDataAdapter adpter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("update nhanvien set MatKhau='" + qltaikhoan.mahoa.ToMD5(tbMK1.Text) + "'where manv = '" + this.id + "' ", cnn);
                    adpter.UpdateCommand = new SqlCommand("update nhanvien set MatKhau='" + qltaikhoan.mahoa.ToMD5(tbMK1.Text) + "'where manv = '" + this.id + "' ", cnn);
                    adpter.UpdateCommand.ExecuteNonQuery();
                    cmd.Dispose();
                    cnn.Close();
                    MessageBox.Show("Cập Nhật Mật Khẩu Thành Công !", "Thông Báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Độ dài mật khẩu không đủ !");
                }
            }
            else
            {
                MessageBox.Show("Không Được Để Trống Hoặc Mật Khẩu Không Trùng Khớp !\n" + "Vui Lòng Nhập lại !" ,"Thông Báo");
            }
        }
    }
}

