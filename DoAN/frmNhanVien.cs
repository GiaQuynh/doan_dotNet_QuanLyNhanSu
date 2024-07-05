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

namespace DoAN
{
    public partial class frmNhanVien : Form
    {
        ConnectDatabase_QLNS db = new ConnectDatabase_QLNS();
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-V6MCQL7;Initial Catalog=QuanLiNhanSu_Nhom2;Integrated Security=True");
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // Load dữ liệu cho DataGridView
            using (SqlCommand cmd = new SqlCommand("GetNhanVien", Con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                dgv_NhanVien.DataSource = table;
            }

            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            // Thiết lập DropDownStyle của ComboBox GioiTinh
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            // Chỉ cho phép chọn "Nam" ban đầu
            cboGioiTinh.SelectedIndex = 0;

            // Lấy dữ liệu cho ComboBox MACV
            string queryMACV = "SELECT MACV FROM CHUCVU";
            List<string> listMACV = new List<string>();
            using (SqlDataReader readerMACV = db.getDataReader(queryMACV))
            {
                while (readerMACV.Read())
                {
                    listMACV.Add(readerMACV["MACV"].ToString());
                }
            }
            cbomacv.DataSource = listMACV;

            // Lấy dữ liệu cho ComboBox MAPB
            string queryMAPB = "SELECT MAPB FROM PHONGBAN";
            List<string> listMAPB = new List<string>();
            using (SqlDataReader readerMAPB = db.getDataReader(queryMAPB))
            {
                while (readerMAPB.Read())
                {
                    listMAPB.Add(readerMAPB["MAPB"].ToString());
                }
            }
            cbomapb.DataSource = listMAPB;

            // Lấy dữ liệu cho ComboBox MAHD
            string queryMAHD = "SELECT MAHD FROM HOPDONG";
            List<string> listMAHD = new List<string>();
            using (SqlDataReader readerMAHD = db.getDataReader(queryMAHD))
            {
                while (readerMAHD.Read())
                {
                    listMAHD.Add(readerMAHD["MAHD"].ToString());
                }
            }
            cbomahd.DataSource = listMAHD;
        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];
                txtmanv.Text = row.Cells["mANVDataGridViewTextBoxColumn"].Value.ToString();
                txttennv.Text = row.Cells["tENVNDataGridViewTextBoxColumn"].Value.ToString();
                cboGioiTinh.Text = row.Cells["gIOITINHDataGridViewTextBoxColumn"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["nGAYSINHDataGridViewTextBoxColumn"].Value);
                txtemail.Text = row.Cells["eMAILDataGridViewTextBoxColumn"].Value.ToString();
                txtsdt.Text = row.Cells["sDTDataGridViewTextBoxColumn"].Value.ToString();
                txtcccd.Text = row.Cells["cCCDDataGridViewTextBoxColumn"].Value.ToString();
                cbomacv.Text = row.Cells["mACVDataGridViewTextBoxColumn"].Value.ToString();
                cbomapb.Text = row.Cells["mAPBDataGridViewTextBoxColumn"].Value.ToString();
                cbomahd.Text = row.Cells["mAHDDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra giá trị đã chọn
            string selectedValue = cboGioiTinh.SelectedItem.ToString();

            // Nếu giá trị không phải là "Nam" hoặc "Nữ", đặt lại giá trị là "Nam"
            if (selectedValue != "Nam" && selectedValue != "Nữ")
            {
                cboGioiTinh.SelectedIndex = 0;
            }
        }
        private void LoadData()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetNhanVien", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_NhanVien.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string manv = txtmanv.Text;
                string tenvn = txttennv.Text;
                string gioitinh = cboGioiTinh.SelectedItem.ToString();
                DateTime ngaysinh = dtpNgaySinh.Value;
                string email = txtemail.Text;
                string sdt = txtsdt.Text;
                string cccd = txtcccd.Text;
                string macv = cbomacv.SelectedItem.ToString();
                string mapb = cbomapb.SelectedItem.ToString();
                string mahd = cbomahd.SelectedItem.ToString();
                using (SqlCommand cmd = new SqlCommand("InsertNhanVien", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Manv", manv);
                    cmd.Parameters.AddWithValue("@Tenvn", tenvn);
                    cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@Ngaysinh", ngaysinh);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sdt", sdt);
                    cmd.Parameters.AddWithValue("@Cccd", cccd);
                    cmd.Parameters.AddWithValue("@Macv", macv);
                    cmd.Parameters.AddWithValue("@Mapb", mapb);
                    cmd.Parameters.AddWithValue("@Mahd", mahd);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                        ResetForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại!");
                    }
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            txtemail.Text = "";
            txtsdt.Text = "";
            txtcccd.Text = "";
            cbomacv.SelectedIndex = -1;
            cbomapb.SelectedIndex = -1;
            cbomahd.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string manv = txtmanv.Text;
                using (SqlCommand cmd = new SqlCommand("DeleteNhanVien", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Manv", manv);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        ResetForm();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
                    }
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string manv = txtmanv.Text;
                string tenvn = txttennv.Text;
                string gioitinh = cboGioiTinh.SelectedItem.ToString();
                DateTime ngaysinh = dtpNgaySinh.Value;
                string email = txtemail.Text;
                string sdt = txtsdt.Text;
                string cccd = txtcccd.Text;
                string macv = cbomacv.SelectedItem.ToString();
                string mapb = cbomapb.SelectedItem.ToString();
                string mahd = cbomahd.SelectedItem.ToString();

                using (SqlCommand cmd = new SqlCommand("UpdateNhanVien", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tenvn", tenvn);
                    cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@Ngaysinh", ngaysinh);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sdt", sdt);
                    cmd.Parameters.AddWithValue("@Cccd", cccd);
                    cmd.Parameters.AddWithValue("@Macv", macv);
                    cmd.Parameters.AddWithValue("@Mapb", mapb);
                    cmd.Parameters.AddWithValue("@Mahd", mahd);
                    cmd.Parameters.AddWithValue("@Manv", manv);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thất bại!");
                    }
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = txtmanv.Text;
                using (SqlCommand cmd = new SqlCommand("TimKiemNhanVien", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Manv", manv);

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                    dgv_NhanVien.DataSource = table;

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Tìm kiếm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbomapb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPB = cbomapb.SelectedItem.ToString();

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V6MCQL7;Initial Catalog=QuanLiNhanSu_Nhom2;Integrated Security=True"))
            {
                conn.Open();

                // Gọi function SQL để lấy danh sách nhân viên theo mã phòng ban
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetNhanVienByMaPB(@MaPB)", conn))
                {
                    cmd.Parameters.AddWithValue("@MaPB", maPB);

                    // Sử dụng SqlDataAdapter để lấy dữ liệu từ SqlCommand
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu trên DataGridView
                    dgv_NhanVien.DataSource = dataTable;
                }

                conn.Close();
            }
        }

        private void cbomacv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPB = cbomacv.SelectedItem.ToString();

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V6MCQL7;Initial Catalog=QuanLiNhanSu_Nhom2;Integrated Security=True"))
            {
                conn.Open();

                // Gọi function SQL để lấy danh sách nhân viên theo mã phòng ban
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetNhanVienByMaCV(@MaPB)", conn))
                {
                    cmd.Parameters.AddWithValue("@MaPB", maPB);

                    // Sử dụng SqlDataAdapter để lấy dữ liệu từ SqlCommand
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu trên DataGridView
                    dgv_NhanVien.DataSource = dataTable;
                }

                conn.Close();
            }
        }

        private void cbomahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPB = cbomahd.SelectedItem.ToString();

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V6MCQL7;Initial Catalog=QuanLiNhanSu_Nhom2;Integrated Security=True"))
            {
                conn.Open();

                // Gọi function SQL để lấy danh sách nhân viên theo mã phòng ban
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetNhanVienByMaHD(@MaPB)", conn))
                {
                    cmd.Parameters.AddWithValue("@MaPB", maPB);

                    // Sử dụng SqlDataAdapter để lấy dữ liệu từ SqlCommand
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu trên DataGridView
                    dgv_NhanVien.DataSource = dataTable;
                }

                conn.Close();
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            //DateTime ngaySinh = dtpNgaySinh.Value;
            //using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V6MCQL7;Initial Catalog=QuanLiNhanSu_Nhom2;Integrated Security=True"))
            //{
            //    try
            //    {
            //        conn.Open();

            //        // Tạo câu truy vấn sử dụng function GetNhanVienByNgaySinh
            //        string query = "SELECT * FROM dbo.GetNhanVienByNgaySinh(@NgaySinh)";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh.Date);

            //        // Thực thi câu truy vấn và lấy dữ liệu vào DataTable
            //        DataTable table = new DataTable();
            //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //        adapter.Fill(table);

            //        // Hiển thị dữ liệu lên DataGridView
            //        dgv_NhanVien.DataSource = table;

            //        conn.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi: " + ex.Message);
            //    }
            //}
        }
    }
}