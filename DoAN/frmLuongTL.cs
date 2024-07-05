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
    public partial class frmLuongTL : Form
    {
        ConnectDatabase_QLNS db = new ConnectDatabase_QLNS();
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-V6MCQL7;Initial Catalog=QuanLiNhanSu_Nhom2;Integrated Security=True");
        public frmLuongTL()
        {
            InitializeComponent();
        }
        private void frmLuongTL_Load(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM LayThongTinNhanVien()", Con))
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                dgv_Luong.DataSource = table;
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
                        txtTongPC.Text = result.ToString(); 
                    }
                    else
                    {
                        // Nếu kết quả là null, gán giá trị trống cho TextBox txttienpc
                        txtTongPC.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void dgv_Luong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Luong.Rows[e.RowIndex];

                // Retrieve the values from the clicked row
                string maNV = row.Cells["mANVDataGridViewTextBoxColumn"].Value.ToString();
                string tenNV = row.Cells["tENVNDataGridViewTextBoxColumn"].Value.ToString();
                string maCV = row.Cells["mACVDataGridViewTextBoxColumn"].Value.ToString();
                string luongCB = row.Cells["lUONGCBDataGridViewTextBoxColumn"].Value.ToString();
                string ngayNL = row.Cells["nGAYNLDataGridViewTextBoxColumn"].Value.ToString();
                string soNgayNghi = row.Cells["sONGAYNGHIDataGridViewTextBoxColumn"].Value.ToString();
                string loai = row.Cells["lOAIDataGridViewTextBoxColumn"].Value.ToString();
                string luongTL = row.Cells["lUONGTLDataGridViewTextBoxColumn"].Value.ToString();
                string tongPhuCap = row.Cells["tONGPHUCAPDataGridViewTextBoxColumn"].Value.ToString();

                // Populate the values into the text boxes and combo box
                txtmanv.Text = maNV;
                txttennv.Text = tenNV;
                cbomacv.Text = maCV;
                txtLuongCB.Text = luongCB;
                dtpNgayNL.Value = DateTime.Parse(ngayNL);
                txtSoNN.Text = soNgayNghi;
                txtXepLoai.Text = loai;
                txtLuongTL.Text = luongTL;
                txtTongPC.Text = tongPhuCap;

                LoadTienPhuCap(maNV);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }
    }
}
