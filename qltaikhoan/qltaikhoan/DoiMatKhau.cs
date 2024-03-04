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

namespace qltaikhoan
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-VO4Q3H8\PHU;Initial Catalog=QLKS;Integrated Security=True");
        private void btdoimatkhau_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from Nhanvien where manv = N'" + txttendangnhap.Text.ToUpper() + "' and Matkhau = N'" + txtmatkhaucu.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtmatkhaumoi.Text == txtnhaplaimatkhau.Text)
                {
                    if (txtmatkhaumoi.Text.Length > 6)
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("update Nhanvien set Matkhau = N'" + qltaikhoan.mahoa.ToMD5(txtmatkhaumoi.Text) + "' where manv = N'" + txttendangnhap.Text.ToUpper() + "'", cn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        errorProvider1.SetError(txtmatkhaumoi, "Độ dài mật khẩu không đủ !");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtmatkhaumoi, "Bạn chưa điền mật khẩu !");
                    errorProvider1.SetError(txtnhaplaimatkhau, "Mật khẩu nhập lại chưa đúng !");
                }
            }
            else
            {
                errorProvider1.SetError(txttendangnhap, "Tên người dùng không đúng !");
                errorProvider1.SetError(txtmatkhaucu, "Mật khẩu cũ không đúng !");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbHien1_Click(object sender, EventArgs e)
        {
            pbHien1.Hide();
            pbAn1.Show();
            txtmatkhaumoi.PasswordChar = '\0';   
        }

        private void pbAn1_Click(object sender, EventArgs e)
        {
            pbHien1.Show();
            pbAn1.Hide();
            txtmatkhaumoi.PasswordChar = '*';
        }

        private void pbAn2_Click(object sender, EventArgs e)
        {
            pbHien2.Show();
            pbAn2.Hide();
            txtnhaplaimatkhau.PasswordChar = '*';
        }

        private void pbHien2_Click(object sender, EventArgs e)
        {
            pbHien2.Hide();
            pbAn2.Show();
            txtnhaplaimatkhau.PasswordChar = '\0';
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            pbAn1.Hide();
            pbAn2.Hide();
            pbHien1.Show();
            pbHien2.Show();
        }
    }
}
