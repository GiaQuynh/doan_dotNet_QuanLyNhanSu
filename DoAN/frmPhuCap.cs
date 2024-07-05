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
    public partial class frmPhuCap : Form
    {
        ConnectDatabase_QLNS db = new ConnectDatabase_QLNS();
        public frmPhuCap()
        {
            InitializeComponent();
        }

        public void reset()
        {
            string str = "EXEC Select_PhuCap";
            SqlDataReader reader = db.getDataReader(str);
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_PhuCap.DataSource = table;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            string str = "EXEC Select_PhuCap";
            SqlDataReader reader = db.getDataReader(str);
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_PhuCap.DataSource = table;
        }

        private void dgv_PhuCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelect = e.RowIndex;
            DataGridViewRow data = dgv_PhuCap.Rows[indexSelect];
            txtmapc.Text = data.Cells[0].Value.ToString();
            txttenpc.Text = data.Cells[1].Value.ToString();
            txttienpc.Text = data.Cells[2].Value.ToString();
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Them_PhuCap '" + txtmapc.Text + "' , '" + txttenpc.Text + "' , " + float.Parse(txttienpc.Text);
                db.GetNonQuery(str);
                reset();
                MessageBox.Show("Thêm Nhân Viên Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("Thêm Nhân Viên Thất Bại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Xoa_PhuCap '" + txtmapc.Text + "'";
                db.GetNonQuery(str);
                reset();
                MessageBox.Show("Xóa Nhân Viên Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("Xóa Nhân Viên Thất Bại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Sua_PhuCap '" + txtmapc.Text + "' , '" + txttenpc.Text + "' , " + float.Parse(txttienpc.Text);
                db.GetNonQuery(str);
                reset();
                MessageBox.Show("Xóa Nhân Viên Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("Xóa Nhân Viên Thất Bại!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult KQ;
            KQ = MessageBox.Show("Bạn Có muốn Thoát Khỏi Hệ Thống Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (KQ == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_Moi_Click(object sender, EventArgs e)
        {
            txtmapc.Text = string.Empty;
            txttenpc.Text = string.Empty;
            txttienpc.Text = string.Empty;
        }
    }
}
