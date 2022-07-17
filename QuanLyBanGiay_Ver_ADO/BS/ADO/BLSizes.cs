using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay_Ver_ADO.DB;

namespace QuanLyBanGiay_Ver_ADO.BS.ADO
{
    public class BLSizes : ISizes
    {
        DBMain db = null;
        public BLSizes()
        {
            db = new DBMain();
        }

        // Tạo mới
        public bool createSize(int numberSize, int quantity, int product, ref string err)
        {
            string sqlString = "Insert Into Sizes Values('" +

                        numberSize + "',N'" +
                        quantity + "','" +
                        product + "', 1)";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        // Xóa mềm
        public bool deleteSize(int id, ref string err)
        {
            string sqlExcuteScalar = "Select active from sizes where id =" + id + "'";
            int active = Convert.ToInt32(!db.ExcuteScalar<bool>(sqlExcuteScalar, ref err));

            string sqlString = "Update Sizes Set active= '" + active +
            "' Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        // Xóa cứng
        public bool deleteSizeByAdmin(int id, ref string err)
        {
            string sqlString = "Delete From Sizes Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable getAllSize()
        {
            string sqlString = "Select * From Size";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lấy size bởi ProducId
        public DataTable getSizesByProduct(int productId)
        {
            string sqlString = "Select * From Sizes Where product_id='" + productId + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Cập nhật
        public bool updateSize(int id, int numberSize, int quantity, int product, ref string err)
        {
            string sqlString = "Update Sizes Set number_size='" + numberSize +
                "', quantity = '" + quantity +
                "', product_id = '" + product +
                "' Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
