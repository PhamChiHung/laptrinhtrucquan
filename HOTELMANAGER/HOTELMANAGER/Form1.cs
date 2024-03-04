using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HOTELMANAGER
{
    public partial class frmHD : Form
    {
        SqlConnection cn = new SqlConnection();
        string ketnoi = "Data Source=DESKTOP-VO4Q3H8\\PHU;Initial Catalog=QLKS;Integrated Security=True";
        SqlDataAdapter da;
        string SQL;
        DataTable dt;
      
        public static string mahd;

        private void frmHD_Load(object sender, EventArgs e)
        {

            ketnoicsdl();
            loaddulieuhd();
            load_Data_Combobox("select * from khachhang", cbbkh, "hoten", "makhachhang");
            load_Data_Combobox("select * from nhanvien", cbbnv, "hoten", "manv");
            load_Data_Combobox("select * from dichvu", cbbmadv, "madichvu", "madichvu");
            load_Data_Combobox("select * from dichvu", cbbtendv, "tendichvu", "tendichvu");
            load_Data_Combobox("select * from phong", cbbmap, "maphong", "maphong");
            checkbox1_CheckedChanged(sender, e);
        }

        private void ketnoicsdl()
        {
            cn = new SqlConnection(ketnoi);
            cn.Open();
        }

        public frmHD()
        {
            InitializeComponent();
            Height = 730;
            Width = 1400;
            MaximizeBox = false;
            MinimizeBox = false;
            
        }

        private void loaddulieuhd()
        {

            try {
                ketnoicsdl();
                SQL = "Select Hoadon.mahoadon as MaHD, Khachhang.hoten as HotenKH,Nhanvien.hoten as HotenNV,Hoadon.ngaylaphd as NgaylapHD," +
                    "(dichvu.giadichvu*count(chitietdichvu.mahoadon)+(phong.giaphong*(DAY(DAY(chitietthue.ngaytraphong) - DAY(Chitietthue.ngaylapphongthue))-1))) as ThanhTien" +
                    "\r\nfrom khachhang inner join Hoadon on khachhang.makhachhang = hoadon.makhachhang " +
                    "inner join Nhanvien on Nhanvien.manv = Hoadon.manv " +
                    "inner join chitietthue on Hoadon.mahoadon = chitietthue.mahoadon " +
                    "inner join Phong on chitietthue.maphong = phong.maphong inner join chitietdichvu on Hoadon.mahoadon = chitietdichvu.mahoadon " +
                    "inner join dichvu on chitietdichvu.madichvu = dichvu.madichvu\r\ngroup by dichvu.giadichvu,chitietdichvu.mahoadon," +
                    "Hoadon.mahoadon,Khachhang.hoten,Nhanvien.hoten,Hoadon.ngaylaphd,phong.giaphong,chitietthue.ngaytraphong,Chitietthue.ngaylapphongthue\r\n";
                da = new SqlDataAdapter(SQL, cn);
                dt = new DataTable();
                da.Fill(dt);

                dgvhd1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Load dữ liệu không thành công");
            }
        }
      
        private void load_Data_Combobox(string sql,ComboBox cmb, string name_display, string value_display)
        {
            try
            {
                ketnoicsdl();
               
                da = new SqlDataAdapter(sql, cn);
                dt = new DataTable();
                da.Fill(dt);

                cmb.DataSource = dt;
                cmb.DisplayMember = name_display;
                cmb.ValueMember = value_display;
            }
            catch
            {
                MessageBox.Show("Load dữ liệu không thành công");
            }
        }
    
        private void btxem_Click(object sender, EventArgs e)
        {
            loaddulieuhd();

            cn.Close();
            cn.Dispose();
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_find_hd.Checked == true)
            {
                checkbox_find_by_kh.Visible = true;
                checkbox_find_by_nv.Visible = true;

                cb_search_kh.Visible = true;
                cb_search_nv.Visible = true;
                load_Data_Combobox("select * from khachhang",cb_search_kh, "hoten", "makhachhang");
                  load_Data_Combobox("select * from nhanvien", cb_search_nv, "hoten", "manv");
            }
            else
            {
                checkbox_find_by_kh.Visible = false;
                checkbox_find_by_nv.Visible = false;
                cb_search_kh.Visible = false;
                cb_search_nv.Visible = false;
                loaddulieuhd();
            }
        }

        private void Load_Data_DVPhong()
        {
            ketnoicsdl();
            SQL = @"Select hoadon.mahoadon as MaHD,phong.maphong as MaPhong,Ngaylapphongthue,Ngaytraphong,
                Loaiphong as LoaiPhong,giaphong as GiaPhong,(DAY(DAY(chitietthue.ngaytraphong) - DAY(Chitietthue.ngaylapphongthue))-1) as SoNgayThue,
                phong.giaphong*(DAY(DAY(chitietthue.ngaytraphong) - DAY(Chitietthue.ngaylapphongthue))-1) as ThanhtienPhong
                from Hoadon inner join chitietthue on Hoadon.mahoadon = chitietthue.mahoadon inner join Phong on chitietthue.maphong = phong.maphong
                where Hoadon.mahoadon = N'" + txt_mahd.Text.Trim() + "'";

            da = new SqlDataAdapter(SQL, cn);
            dt = new DataTable();
            da.Fill(dt);
            dgvphong.DataSource = dt;
        }

        private void Load_Data_DichVu()
        {
            ketnoicsdl();
            SQL = @"Select hoadon.mahoadon as MaHD,Dichvu.madichvu as MaDV,Dichvu.tendichvu as TenDV,Dichvu.giadichvu as GiaDV,
                    Chitietdichvu.ngaysudung as NgaySdDv, dichvu.giadichvu*count(chitietdichvu.mahoadon) as ThanhtienDV 
                    from Hoadon inner join Chitietdichvu on Hoadon.mahoadon = Chitietdichvu.mahoadon 
                    inner join Dichvu on Dichvu.madichvu = Chitietdichvu.madichvu 
                    where Hoadon.mahoadon = N'" + txt_mahd.Text.Trim() + "'" 
                    + "group by hoadon.mahoadon,Dichvu.madichvu,Dichvu.tendichvu,Dichvu.giadichvu,Chitietdichvu.ngaysudung,dichvu.giadichvu,chitietdichvu.mahoadon";
            da = new SqlDataAdapter(SQL, cn);
            dt = new DataTable();
            da.Fill(dt);
            dgvdichvu.DataSource = dt;
        }

        private void dgvhd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = dgvhd1.CurrentRow.Index;
            txt_mahd.Text = dgvhd1[0, dong].Value.ToString();
            dpicker_ngaylaphd.Value = DateTime.Parse(dgvhd1[3, dong].Value.ToString());
            cbbnv.Text = dgvhd1[2, dong].Value.ToString();
            cbbkh.Text = dgvhd1[1, dong].Value.ToString();
            Load_Data_DVPhong();
            Load_Data_DichVu();
            cn.Close();
            cn.Dispose();
        }

        private void dgvphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = dgvphong.CurrentRow.Index;

            cbbmap.Text = dgvphong[1, dong].Value.ToString();
            dpicker_thuephong.Value = DateTime.Parse(dgvphong[2, dong].Value.ToString());
            cbbgiaphong.Text = dgvphong[5, dong].Value.ToString();
            cbbloaiphong.Text = dgvphong[4, dong].Value.ToString();
            dpicker_ngaytraphong.Value = DateTime.Parse(dgvphong[3, dong].Value.ToString());
        }

        private void dgvdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int dong;
            dong = dgvdichvu.CurrentRow.Index;
            cbbmadv.Text = dgvdichvu[1, dong].Value.ToString();
            cbbtendv.Text = dgvdichvu[2, dong].Value.ToString();
            cbbgiadv.Text = dgvdichvu[3, dong].Value.ToString();
            dpicker_ngaysddv.Value = DateTime.Parse(dgvdichvu[4, dong].Value.ToString());
        }
   
        private void cb_search_kh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               SQL = "Select Hoadon.mahoadon as MaHD, Khachhang.hoten as HotenKH,Nhanvien.hoten as HotenNV,Hoadon.ngaylaphd as NgaylapHD," +
                    "(dichvu.giadichvu*count(chitietdichvu.mahoadon)+(phong.giaphong*(DAY(DAY(chitietthue.ngaytraphong) - DAY(Chitietthue.ngaylapphongthue))-1))) as ThanhTien" +
                    "\r\nfrom khachhang inner join Hoadon on khachhang.makhachhang = hoadon.makhachhang " +
                    "inner join Nhanvien on Nhanvien.manv = Hoadon.manv " +
                    "inner join chitietthue on Hoadon.mahoadon = chitietthue.mahoadon " +
                    "inner join Phong on chitietthue.maphong = phong.maphong inner join chitietdichvu on Hoadon.mahoadon = chitietdichvu.mahoadon " +
                    "inner join dichvu on chitietdichvu.madichvu = dichvu.madichvu " +
                    "where Khachhang.makhachhang='" + cb_search_kh.GetItemText(cb_search_kh.SelectedValue) + "'" +
                    "\r\ngroup by dichvu.giadichvu,chitietdichvu.mahoadon," +
                    "Hoadon.mahoadon,Khachhang.hoten,Nhanvien.hoten,Hoadon.ngaylaphd,phong.giaphong,chitietthue.ngaytraphong,Chitietthue.ngaylapphongthue ";
                da = new SqlDataAdapter(SQL, cn);
                dt = new DataTable();
                da.Fill(dt);

                dgvhd1.DataSource = dt;
            }
            catch( SqlException err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void checkbox_find_by_nv_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SQL = "Select Hoadon.mahoadon as MaHD, Khachhang.hoten as HotenKH,Nhanvien.hoten as HotenNV,Hoadon.ngaylaphd as NgaylapHD," +
                      "(dichvu.giadichvu*count(chitietdichvu.mahoadon)+(phong.giaphong*(DAY(DAY(chitietthue.ngaytraphong) - DAY(Chitietthue.ngaylapphongthue))-1))) as ThanhTien" +
                      "\r\nfrom khachhang inner join Hoadon on khachhang.makhachhang = hoadon.makhachhang " +
                      "inner join Nhanvien on Nhanvien.manv = Hoadon.manv " +
                      "inner join chitietthue on Hoadon.mahoadon = chitietthue.mahoadon " +
                      "inner join Phong on chitietthue.maphong = phong.maphong inner join chitietdichvu on Hoadon.mahoadon = chitietdichvu.mahoadon " +
                      "inner join dichvu on chitietdichvu.madichvu = dichvu.madichvu " +
                      "where Nhanvien.hoten like N'%" + cb_search_nv.Text.Trim()+ "%'" +
                      "\r\ngroup by dichvu.giadichvu,chitietdichvu.mahoadon," +
                      "Hoadon.mahoadon,Khachhang.hoten,Nhanvien.hoten,Hoadon.ngaylaphd,phong.giaphong,chitietthue.ngaytraphong,Chitietthue.ngaylapphongthue ";



                //SQL = "Select Hoadon.mahoadon as MaHD,Khachhang.hoten as HotenKH,Nhanvien.hoten as HotenNV,ngaylaphd as NgaylapHD, (solansudung*giadichvu) +(slphongthue*giaphong*DAY(DAY(Hoadon.ngaylaphd) - DAY(Chitietthue.ngaylapphongthue)) ) as ThanhTien\r\nfrom Khachhang inner join Hoadon on khachhang.makhachhang = hoadon.makhachhang inner join Nhanvien on Nhanvien.manv = Hoadon.manv  inner join Chitietdichvu on Hoadon.mahoadon = Chitietdichvu.mahoadon inner join Dichvu on Dichvu.madichvu = Chitietdichvu.madichvu inner join chitietthue on Hoadon.mahoadon = chitietthue.mahoadon inner join Phong on chitietthue.maphong = phong.maphong where hoadon.manv = nhanvien.manv and nhanvien.manv ='" + comboBox9.SelectedValue.ToString() + "'";
                da = new SqlDataAdapter(SQL, cn);
                dt = new DataTable();
                da.Fill(dt);

                dgvhd1.DataSource = dt;
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cb_search_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SQL = "Select Hoadon.mahoadon as MaHD, Khachhang.hoten as HotenKH,Nhanvien.hoten as HotenNV,Hoadon.ngaylaphd as NgaylapHD," +
                      "(dichvu.giadichvu*count(chitietdichvu.mahoadon)+(phong.giaphong*(DAY(DAY(chitietthue.ngaytraphong) - DAY(Chitietthue.ngaylapphongthue))-1))) as ThanhTien" +
                      "\r\nfrom khachhang inner join Hoadon on khachhang.makhachhang = hoadon.makhachhang " +
                      "inner join Nhanvien on Nhanvien.manv = Hoadon.manv " +
                      "inner join chitietthue on Hoadon.mahoadon = chitietthue.mahoadon " +
                      "inner join Phong on chitietthue.maphong = phong.maphong inner join chitietdichvu on Hoadon.mahoadon = chitietdichvu.mahoadon " +
                      "inner join dichvu on chitietdichvu.madichvu = dichvu.madichvu " +
                      "where Nhanvien.manv='" + cb_search_nv.GetItemText(cb_search_nv.SelectedValue) + "'" +
                      "\r\ngroup by dichvu.giadichvu,chitietdichvu.mahoadon," +
                      "Hoadon.mahoadon,Khachhang.hoten,Nhanvien.hoten,Hoadon.ngaylaphd,phong.giaphong,chitietthue.ngaytraphong,Chitietthue.ngaylapphongthue ";


                da = new SqlDataAdapter(SQL, cn);
                dt = new DataTable();
                da.Fill(dt);

                dgvhd1.DataSource = dt;
            }
            catch( SqlException err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void check_find_by_kh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SQL = "Select Hoadon.mahoadon as MaHD, Khachhang.hoten as HotenKH,Nhanvien.hoten as HotenNV,Hoadon.ngaylaphd as NgaylapHD," +
                      "(dichvu.giadichvu*count(chitietdichvu.mahoadon)+(phong.giaphong*(DAY(DAY(chitietthue.ngaytraphong) - DAY(Chitietthue.ngaylapphongthue))-1))) as ThanhTien" +
                      "\r\nfrom khachhang inner join Hoadon on khachhang.makhachhang = hoadon.makhachhang " +
                      "inner join Nhanvien on Nhanvien.manv = Hoadon.manv " +
                      "inner join chitietthue on Hoadon.mahoadon = chitietthue.mahoadon " +
                      "inner join Phong on chitietthue.maphong = phong.maphong inner join chitietdichvu on Hoadon.mahoadon = chitietdichvu.mahoadon " +
                      "inner join dichvu on chitietdichvu.madichvu = dichvu.madichvu " +
                      "where Khachhang.hoten like N'%" + cb_search_kh.Text.Trim() + "%'" +
                      "\r\ngroup by dichvu.giadichvu,chitietdichvu.mahoadon," +
                      "Hoadon.mahoadon,Khachhang.hoten,Nhanvien.hoten,Hoadon.ngaylaphd,phong.giaphong,chitietthue.ngaytraphong,Chitietthue.ngaylapphongthue ";

                da = new SqlDataAdapter(SQL, cn);
                dt = new DataTable();
                da.Fill(dt);

                dgvhd1.DataSource = dt;
                
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cbbmap_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoicsdl();
            string sql = "select *from phong where maphong ='"+cbbmap.Text.Trim()+"'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbloaiphong.Text = reader.GetValue(1).ToString();
                cbbgiaphong.Text = reader.GetValue(2).ToString();
            }
                
            reader.Close();
        }

        private void cbbmadv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoicsdl();
            string sql = "select *from dichvu where madichvu ='" + cbbmadv.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbbtendv.Text = reader.GetValue(1).ToString();
                cbbgiadv.Text = reader.GetValue(2).ToString();
            }

            reader.Close();
        }

        private void btn_deleteHD_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            try
            {
                DialogResult q = MessageBox.Show("Bạn Có Muốn Hóa dơn Có mã là : "  +txt_mahd.Text+ "  Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q.Equals(DialogResult.Yes))
                {
                    SqlCommand cmd1 = new SqlCommand("delete from chitietthue where  mahoadon='" + txt_mahd.Text.Trim() + "'", cn);
                    SqlCommand cmd2 = new SqlCommand("delete from Chitietdichvu where  mahoadon='" + txt_mahd.Text.Trim() + "'", cn);
                    SqlCommand cmd3 = new SqlCommand("delete from Hoadon where  mahoadon='" + txt_mahd.Text.Trim() + "'", cn);
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                }
                
            }
            catch( SqlException er)
            {
                MessageBox.Show(er.Message);
            }
            frmHD_Load(sender, e);
        }

        private void btn_delete_DP_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            try
            {
                DialogResult q = MessageBox.Show("Bạn Có Muốn Xoá Hóa Đơn Có Mã Phòng Là : " + cbbmap.Text.Trim() + "  Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q.Equals(DialogResult.Yes))
                {
                    SqlCommand cmd1 = new SqlCommand("delete from chitietthue where maphong ='"+cbbmap.Text.Trim()+"'  and mahoadon='" + txt_mahd.Text.Trim() + "'", cn);
                   
                    cmd1.ExecuteNonQuery();
                 
                }

            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }

            Load_Data_DVPhong();
        }

        private void btn_delete_DV_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            try
            {
                DialogResult q = MessageBox.Show("Bạn Có Muốn Xoá Hóa Đơn Có Mã Dịch Vụ Là : " + cbbmadv.Text.Trim() + "  Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q.Equals(DialogResult.Yes))
                {
                   
                    SqlCommand cmd2 = new SqlCommand("delete from Chitietdichvu where  madichvu='"+cbbmadv.Text.Trim()+"' and mahoadon='" + txt_mahd.Text.Trim() + "'", cn);
                   
                    
                    cmd2.ExecuteNonQuery();
               
                }

            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }
       
            Load_Data_DichVu();
        }

        private void btn_editHD_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            int tongngaythue = (int)(dpicker_ngaytraphong.Value - dpicker_thuephong.Value).TotalDays;
            double thanhtien = tongngaythue * double.Parse(cbbgiaphong.Text.Trim())+ double.Parse(cbbgiadv.Text.Trim());
            txt_mahd.Enabled = false;
            string sql_hd = "update hoadon set ngaylaphd= '" + dpicker_ngaylaphd.Value + "', manv= '"+cbbnv.GetItemText(cbbnv.SelectedValue)+"',makhachhang= '"+cbbkh.GetItemText(cbbkh.SelectedValue)+"', thanhtien ='"+thanhtien+"' where mahoadon='"+txt_mahd.Text.Trim()+"'";

            SqlCommand cmd2 = new SqlCommand(sql_hd, cn);
            cmd2.ExecuteNonQuery();

            string sql_ctdv = "update chitietdichvu set ngaysudung ='"+dpicker_ngaysddv.Value+"', madichvu='"+cbbmadv.Text.Trim()+"' where mahoadon='"+txt_mahd.Text.Trim()+"'";
            SqlCommand cmd1 = new SqlCommand(sql_ctdv, cn);
            cmd1.ExecuteNonQuery();

            string sql_ctthue = "update chitietthue set ngaylapphongthue ='" + dpicker_thuephong.Value + "', ngaytraphong='" +dpicker_ngaytraphong.Value + "',maphong='"+cbbmap.Text.Trim()+"' where mahoadon='" + txt_mahd.Text.Trim() + "'";
            SqlCommand cmd3 = new SqlCommand(sql_ctthue, cn);
            cmd3.ExecuteNonQuery();
            frmHD_Load(sender,e);
        }

        private void btn_editDP_Click(object sender, EventArgs e)
        {
            string sql_ctthue = "update chitietthue set ngaylapphongthue ='" + dpicker_thuephong.Value + "', ngaytraphong='" + dpicker_ngaytraphong.Value + "',maphong='" + cbbmap.Text.Trim() + "' where mahoadon='" + txt_mahd.Text.Trim() + "'";
            SqlCommand cmd3 = new SqlCommand(sql_ctthue, cn);
            cmd3.ExecuteNonQuery();
            Load_Data_DVPhong();
        }

        private void btn_edit_DV_Click(object sender, EventArgs e)
        {
            string sql_ctdv = "update chitietdichvu set ngaysudung ='" + dpicker_ngaysddv.Value + "', madichvu='" + cbbmadv.Text.Trim() + "' where mahoadon='" + txt_mahd.Text.Trim() + "'";
            SqlCommand cmd1 = new SqlCommand(sql_ctdv, cn);
            cmd1.ExecuteNonQuery();
            Load_Data_DichVu();
        }

        private void btn_addHD_Click(object sender, EventArgs e)
        {
        }

        private void btn_addDP_Click(object sender, EventArgs e)
        {

        }

        private void btn_addDV_Click(object sender, EventArgs e)
        {
        }
    }
}
