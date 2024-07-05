using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAN
{
    class ConnectDatabase_QLNS
    {
        SqlConnection Con;

        //Khởi tạo mặc định, Kết mối đến cơ sơ dữ liệu
        public ConnectDatabase_QLNS()
        {
            string strConnect = "Data Source=DESKTOP-V6MCQL7;Initial Catalog=QuanLiNhanSu_Nhom2;Integrated Security=True";
            Con = new SqlConnection(strConnect);
        }
        //Mở kết nối
        public void Open()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
        }
        //Đóng kết nối 
        public void Close()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }

        //Thực hiện câu lệnh thêm xóa sửa trong csdl => Dùng try catch để gọi hảm nếu hàm lỗi sẽ trả vẻ catch
        public void GetNonQuery(string sql, params SqlParameter[] parameters)
        {
                Open();
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
                Close();
        }

        //Trả về Table dạng truy vấn 
        public DataTable getDataTable(string sql)
        {
            Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            da.Fill(table);
            Con.Close();
            return table;
        }

        //Đọc dữ liệu từ DB
        public SqlDataReader getDataReader(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            return reader;
        }

        public int getSLNV(string sql)
        {
            int scalarResult = 0;

            try
            {
                Open();

                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int.TryParse(result.ToString(), out scalarResult);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

            return scalarResult;
        }

    }
}
