using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanGiay_Ver_ADO.DB
{
    class DBMain
    {
        string ConnStr = "Data Source=DESKTOP-CLJH20Q\\THUONG;Initial Catalog=QuanLiBanGiay;Integrated Security=True";
        //string ConnStr = "Data Source=DESKTOP-R3KUSE1\\LOCSON;Initial Catalog=QuanLiBanGiay;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }

        // Thực hiện truy vấn trả về DataTable
        public DataTable ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thực hiện câu truy vấn insert, update, delete
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool flag = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                flag = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return flag;
        }
        // câu truy vấn kiêm tra tồn tại
        public bool checkExist(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Truy vấn lấy ra một giá trị
        public T ExcuteScalar<T>(string sql, ref string err)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = sql;
            comm.CommandType = CommandType.Text;


            try
            {
                var res = comm.ExecuteScalar();
                return (T)Convert.ChangeType(res, typeof(T));
            }
            catch
            {
                err = "Không thể thực thi";
                return (T)Convert.ChangeType(false, typeof(T));
            }
        }
    }
}
