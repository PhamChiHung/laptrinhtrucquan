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

namespace QLNhanVien
{
    public partial class ManageStaff : Form
    {
        private string idNV = "";
        public ManageStaff()
        {
            InitializeComponent();
        }

        public ManageStaff(string idNv)
        {
            InitializeComponent();
            this.idNV = idNv;
        } 
        private void ManageStaff_Load(object sender, EventArgs e)
        {
            lbInput_Click(sender, e);
            picExit.Visible = false;
            picExit.Hide();
            if (this.idNV.Length != 0)
            {
                SqlConnection cnn = new SqlConnection();
                QLNhanVien.ConnectionStringSql.connection(ref cnn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select manv, hoten, ngaysinh, hinhanh from nhanvien where manv = '" + this.idNV + "'", cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbNameID.Text = (string)reader.GetValue(0) + " - " + (string)reader.GetValue(1);
                    Date.Value = (DateTime)reader.GetValue(2);
                    if (string.Compare((string)reader.GetValue(3), "Unknows", true) != 0)
                    {
                        Bitmap image = new Bitmap((string)reader.GetValue(3));
                        picUser.Image = (Image)image;
                    }
                }
                cmd.Dispose();
                reader.Close();
                cnn.Close();
            }

        }

        private void lbInput_Click(object sender, EventArgs e)
        {
            pnInput.BackColor = Color.White;
            pnOutput.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnAcc.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnSalary.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            QLNhanVien.Input form = new Input(this.idNV);
            pnShow.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnShow.Controls.Add(form);
            form.Show();
        }

        private void lbOuput_Click(object sender, EventArgs e)
        {
            pnInput.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnOutput.BackColor =Color.White;
            pnAcc.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnSalary.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            QLNhanVien.Output form = new Output(this.idNV);
            pnShow.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnShow.Controls.Add(form);
            form.Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            pnInput.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnOutput.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            this.Close();
        }
        //tai khoan nhan vien
        private void label1_Click(object sender, EventArgs e)
        {
            pnInput.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnOutput.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnAcc.BackColor = Color.White;
            pnSalary.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            qltaikhoan.DSTaiKhoan form = new qltaikhoan.DSTaiKhoan();
            pnShow.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnShow.Controls.Add(form);
            form.Show();
        }

        private void lbSalary_Click(object sender, EventArgs e)
        {
            pnInput.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnOutput.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            pnSalary.BackColor = Color.White;
            pnAcc.BackColor = ColorTranslator.FromHtml("255, 222, 89");
            QLNhanVien.TableSalary form = new TableSalary();
            pnShow.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnShow.Controls.Add(form);
            form.Show();
        }
    }
}
