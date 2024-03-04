using System.Data.SqlClient;
namespace QLNhanVien
{
    public partial class Input : Form
    {
        private List<int> countLT = new List<int>();
        private List<int> countTN = new List<int>();
        private string idNv = "";
        public Input()
        {
            InitializeComponent();                                 
        }
        public Input(string idNv)
        {
            InitializeComponent();
            this.idNv = idNv;
        }
        public int ConvertString(string str)
        {
            int answer = 0;
            string subStr = "";
            for (int i = 5; i < str.Length; i++)
            {
                subStr += str[i];
            }
            answer = subStr[0] - '0';
            if (subStr.Length > 1)
            {
                for (int i = 1; i < subStr.Length; i++)
                {
                    answer *= 10;
                    answer += (subStr[i] - '0');
                }
            }
            return answer;
        } 

        private void btXoa_Click(object sender, EventArgs e)
        {
            btXoa.BackColor = Color.LightSteelBlue;
            btThem.BackColor = Color.White;
            btLammoi.BackColor = Color.White;
            string output = "";
            if (listVDs.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listVDs.SelectedItems.Count; i++)
                {
                    output += listVDs.SelectedItems[i].Text + ", ";
                }
                    SqlConnection cnn = new SqlConnection();
                    ConnectionStringSql.connection(ref cnn);
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand();
                    for (int i = 0; i < listVDs.SelectedItems.Count; i++)
                    {
                        string sql = "delete from nhanvien where manv = '" + listVDs.SelectedItems[i].Text + "'";
                        cmd = new SqlCommand(sql, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = new SqlCommand(sql, cnn);
                        adapter.DeleteCommand.ExecuteNonQuery();
                    }
                    while (listVDs.SelectedItems.Count != 0)
                    {
                        listVDs.Items.RemoveAt(0);
                    }
                    lbNotify.Text = "Xóa thành công " + output + " !!";
                    cmd.Dispose();
                    cnn.Close();
            }
            else
            {
                lbNotify.Text = "Xóa không thành công !!";
            }
           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btThem.BackColor = Color.LightSteelBlue;
            btXoa.BackColor = Color.White;
            btLammoi.BackColor = Color.White;
            btThoat.BackColor = Color.White;
            SqlConnection cnn = new SqlConnection();
            ConnectionStringSql.connection(ref cnn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            string sql = "";
            int flag = listVDs.Items.Count;
            string id = "";
            string cv = "";
            string gender = "";
            int count = 1;
            ListViewItem lvi = new ListViewItem();
            if (rbLetan.Checked)
            {
                while (countLT.Contains(count))
                {
                    count++;
                }
                id = "NV.LT" + count;
                lvi = listVDs.Items.Add(id);
                cv = "Lễ Tân";
                countLT.Add(count);
                countLT.Sort();
            }
            if (rbThungan.Checked)
            {
                while (countTN.Contains(count))
                {
                    count++;
                }
                id = "NV.TN" + count;
                lvi = listVDs.Items.Add(id);
                cv = "Thu Ngân";
                countTN.Add(count);
                countTN.Sort();
            }
            string message = "";
            if (tbName.Text.Length == 0)
            {
                message += "Không được để trống tên !\n";
            }
            else
            {
                if (Fix.eventString(tbName.Text))
                {
                    lvi.SubItems.Add(tbName.Text);
                }
                else
                {
                    message += "Tên không chứa ký tự đặt biệt hoặc số !\n";
                }
            }
            lvi.SubItems.Add(dateT.Value.ToShortDateString());
            if (rbNam.Checked)
            {
                lvi.SubItems.Add(rbNam.Text);
                gender = rbNam.Text;
            }
            if (rbNu.Checked)
            {
                lvi.SubItems.Add(rbNu.Text);
                gender = rbNu.Text;
            }
            if (tbAdd.Text.Length == 0)
            {
                message += "Không để trống địa chỉ! \n";
            }
            else
            {
                lvi.SubItems.Add(tbAdd.Text);
            }
            if (tbSdt.Text.Length == 0)
            {
                message += "Không được để trống số điện thoại !\n";
            }
            else
            {

                if (Fix.KTSDT(tbSdt.Text))
                {
                    lvi.SubItems.Add(tbSdt.Text);
                    if (tbSdt.Text.Length != 10)
                    {
                        message += "Số điện thoại không đủ 10 số !\n";
                    }
                    else if (tbSdt.Text[0] != 48)
                    {
                        message += "Số điện thoại phải bắt đầu bằng số 0 !\n";
                    }
                }
                else
                {
                    message += "Không được nhập ký tự trong số điện thoại !\n";
                }
            }
            if (tbMoney.Text.Length == 0)
            {
                message += "Không được để trống lương !\n";
            }
            else if (Fix.KTSDT(tbMoney.Text))
            {
                lvi.SubItems.Add(tbMoney.Text);
            }
            else
            {
                message += "Không được nhập ký tự trong lương !\n";
            }
            lvi.SubItems.Add(cv);
            if (message.Length == 0)
            {
                string path = "Unknows";
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    path = openFile.FileName;
                }
                sql = "insert into nhanvien values('" + id + "', N'" + tbName.Text + "', '" + dateT.Value.ToString("yyyy-MM-dd") + "', N'" + gender + "', N'" + tbAdd.Text + "', '" + tbSdt.Text + "', '" + tbMoney.Text + "', N'" + cv + "', '" + qltaikhoan.mahoa.ToMD5(dateT.Value.ToString("dd-MM-yyyy")) + "', '" + path + "')";
                cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                lbNotify.Text = "Thêm thành công !";
            }
            else
            {
                if (string.Compare(gender, "lễ tân", true) == 0)
                {
                    countLT.Remove(count);
                }
                if (string.Compare(gender, "thu ngân", true) == 0)
                {
                    countTN.Remove(count);
                }
                listVDs.Items.RemoveAt(flag);
                MessageBox.Show(message + "\nVui lòng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbNotify.Text = "Thêm không thành công !";
            }

            cmd.Dispose();
            cnn.Close();
        }

        private void btLammoi_Click(object sender, EventArgs e)
        {
            btLammoi.BackColor = Color.LightSteelBlue;
            btXoa.BackColor = Color.White;
            btThem.BackColor = Color.White;
            btThoat.BackColor = Color.White;
            tbName.Clear();
            tbAdd.Clear();
            tbSdt.Clear();
            tbMoney.Clear();
        }
        //Sua thong tin
        private void btThoat_Click(object sender, EventArgs e)
        {
            btLammoi.BackColor = Color.White;
            btXoa.BackColor = Color.White;
            btThem.BackColor = Color.White;
            btThoat.BackColor = Color.LightSteelBlue;
            if (listVDs.SelectedItems.Count > 0)
            {
                btXoa.PerformClick();
                btThem.PerformClick();
                lbNotify.Text = "Cập nhật thành công";
            }
        }

        private void Input_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            QLNhanVien.ConnectionStringSql.connection(ref cnn);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select manv from nhanvien", cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0).Contains("NV.LT"))
                {
                    countLT.Add(ConvertString(reader.GetString(0)));
                }
                if (reader.GetString(0).Contains("NV.TN"))
                {
                    countTN.Add(ConvertString(reader.GetString(0)));
                }
            }
            countLT.Sort();
            countTN.Sort();
            reader.Close();
            cmd.Dispose();
            cnn.Close();

        }

        private void listVDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            listVDs.MultiSelect = false;
            try
            {
                if (listVDs.SelectedItems.Count > 0)
                {
                    tbName.Text = listVDs.SelectedItems[0].SubItems[1].Text;
                    tbAdd.Text = listVDs.SelectedItems[0].SubItems[4].Text;
                    tbSdt.Text = listVDs.SelectedItems[0].SubItems[5].Text;
                    tbMoney.Text = listVDs.SelectedItems[0].SubItems[6].Text;
                    if (string.Compare(listVDs.SelectedItems[0].SubItems[3].Text, "Nam", true) == 0)
                    {
                        rbNam.Checked = true;
                    }
                    else
                    {
                        rbNu.Checked = true;
                    }
                    if (string.Compare(listVDs.SelectedItems[0].SubItems[7].Text, "Lễ tân", true) == 0)
                    {
                        rbLetan.Checked = true;
                    }
                    else
                    {
                        rbThungan.Checked = true;
                    }
                    SqlConnection cnn = new SqlConnection();
                    QLNhanVien.ConnectionStringSql.connection(ref cnn);
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("select ngaysinh from nhanvien where manv = '" + listVDs.SelectedItems[0].SubItems[0].Text + "'", cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dateT.Value = reader.GetDateTime(0);
                    }
                    reader.Close();
                    cmd.Dispose();
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listVDs.MultiSelect = true;
            }
        }
    }
}