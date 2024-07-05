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
    public partial class frmPhuCapNhanVien : Form
    {
        ConnectDatabase_QLNS db = new ConnectDatabase_QLNS();
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-V6MCQL7;Initial Catalog=QuanLiNhanSu_Nhom2;Integrated Security=True");
        public frmPhuCapNhanVien()
        {
            InitializeComponent();
        }

        private void frmPhuCapNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSu_Nhom2DataSet.GetEmployeeWithAllowance' table. You can move, or remove it, as needed.
            this.getEmployeeWithAllowanceTableAdapter.Fill(this.quanLiNhanSu_Nhom2DataSet.GetEmployeeWithAllowance);
            // Load dữ liệu cho DataGridView
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetEmployeeWithAllowance()", Con))
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                dgv_PhuCap.DataSource = table;
            }

            // Lấy dữ liệu cho ComboBox MAPC
            string queryMAPC = "SELECT MAPC FROM PHUCAP";
            List<string> listMAPC = new List<string>();
            using (SqlDataReader readerMAPC = db.getDataReader(queryMAPC))
            {
                while (readerMAPC.Read())
                {
                    listMAPC.Add(readerMAPC["MAPC"].ToString());
                }
            }
            cbomapc.DataSource = listMAPC;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các điều khiển trên giao diện
                string maNV = txtmanv.Text;
                string maPC = cbomapc.Text;

                // Tạo đối tượng SqlCommand để gọi stored procedure
                using (SqlCommand cmd = new SqlCommand("ThemPhuCapChoNhanVien", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaPC", maPC);

                    // Mở kết nối đến cơ sở dữ liệu
                    Con.Open();

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    // Đóng kết nối
                    Con.Close();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Thêm phụ cấp cho nhân viên thành công.");

                    // Refresh lại DataGridView
                    LoadDataToDataGridView();
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void LoadDataToDataGridView()
        {
            // Load lại dữ liệu cho DataGridView
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetEmployeeWithAllowance()", Con))
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                dgv_PhuCap.DataSource = table;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các điều khiển trên giao diện
                string maNV = txtmanv.Text;
                string maPC = cbomapc.Text;

                // Tạo đối tượng SqlCommand để gọi stored procedure
                using (SqlCommand cmd = new SqlCommand("XoaPhuCapChoNhanVien", Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaPC", maPC);

                    // Mở kết nối đến cơ sở dữ liệu
                    Con.Open();

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    // Đóng kết nối
                    Con.Close();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Xóa phụ cấp cho nhân viên thành công.");

                    // Refresh lại DataGridView
                    LoadDataToDataGridView();
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void dgv_PhuCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                        // Get the selected row index
            int rowIndex = e.RowIndex;

            // Make sure the row index is valid
            if (rowIndex >= 0 && rowIndex < dgv_PhuCap.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_PhuCap.Rows[rowIndex];

                // Extract the values from the selected row
                string maNV = selectedRow.Cells["mANVDataGridViewTextBoxColumn"].Value.ToString();
                string tenNV = selectedRow.Cells["tENVNDataGridViewTextBoxColumn"].Value.ToString();
                string maPC = selectedRow.Cells["mAPCDataGridViewTextBoxColumn"].Value.ToString();
                string tenPC = selectedRow.Cells["tENPCDataGridViewTextBoxColumn"].Value.ToString();

                // Set the values to the corresponding text boxes or controls on your form
                txtmanv.Text = maNV;
                txttennv.Text = tenNV;
                cbomapc.Text = maPC;
                txttenpc.Text = tenPC;

                LoadTienPhuCap(maNV);
            }
        }

        private void cbomapc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaPC = cbomapc.SelectedItem.ToString();

            // Lấy dữ liệu tương ứng với mã PC từ cơ sở dữ liệu bằng function
            using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetTenPhuCap(@MaPC)", Con))
            {
                cmd.Parameters.AddWithValue("@MaPC", selectedMaPC);
                Con.Open();
                object result = cmd.ExecuteScalar();
                Con.Close();

                if (result != null)
                {
                    txttenpc.Text = result.ToString();
                }
                else
                {
                    txttenpc.Text = string.Empty;
                }
            }
        }
        private void LoadTienPhuCap(string maNV)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.TinhTongTienPhuCap(@MaNV)", Con))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    Con.Open();
                    object result = cmd.ExecuteScalar();
                    Con.Close();

                    // Kiểm tra kết quả trả về từ hàm
                    if (result != null && result != DBNull.Value)
                    {
                        // Hiển thị kết quả lên TextBox txttienpc
                        txttienpc.Text = result.ToString();
                    }
                    else
                    {
                        // Nếu kết quả là null, gán giá trị trống cho TextBox txttienpc
                        txttienpc.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
