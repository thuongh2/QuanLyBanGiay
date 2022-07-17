using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay_Ver_ADO.DB;

namespace QuanLyBanGiay_Ver_ADO.BS.ADO
{
    public class BLOrders : IOrders
    {
        DBMain db = null;
        public BLOrders()
        {
            db = new DBMain();
        }

        public bool deleteOrders(int id, ref string err)
        {
            string sqlExcuteScalar = "Select active from orders where id =" + id;
            int active = Convert.ToInt32(!db.ExcuteScalar<bool>(sqlExcuteScalar, ref err));

            string sqlString = "Update Orders Set active= '" + active +
            "' Where id='" + id + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        // Xóa cứng
        public bool deleteOrdersById(int id, ref string err)
        {
            string sqlString = "Delete From Orders Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        public DataTable findOrderByEmail(string email, ref string err)
        {
            String sql = "Select * From Orders Where customer_email ='" + email + "'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Tìm đơn hàng theo tên
        public DataTable findOrderByName(string name, ref string err)
        {
            String sql = "Select * From Orders Where customer_name='" + name + "'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        // Lấy tất cả hóa đơn bởi admin
        public DataTable getAllOrdersByAdmin()
        {
            string sqlString = "Select * From Orders";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Thêm đơn hàng
        public bool saveOrders(string name, string address, string email, string phone, ref string err)
        {
            string sqlString = "Insert Into Orders Values(0," +
                        "N'" +
                        name + "',N'" +
                        address + "','" +
                        email + "','" +
                        phone +
                        "',1)";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        // Cập nhật thông tin đơn hàng
        public bool updateOrders(int id, string name, double amount, string address, string email, string phone, ref string err)
        {
            string sqlString = "Update Orders Set customer_name=N'" + name +
                "', customer_address = N'" + address +
                "', customer_email = '" + email +
                "', customer_phone = '" + phone +
                "', amount = '" + amount +
                "' Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable getOrderById(int id, ref string err)
        {
            string sqlString = $"Select * from orders where id = {id} and active = 1";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        //Thêm một dòng mới  và trả về bảng chứa id dòng đó
        public DataTable saveAndGetIDOrders(string name, string address, string email, string phone, ref string err)
        {
            string sqlString = "Insert Into Orders " +
                "Output Inserted.id " +
                "Values(0," +
                        "N'" +
                        name + "',N'" +
                        address + "','" +
                        email + "','" +
                        phone +
                        "',1)";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
