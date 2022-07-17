using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay_Ver_ADO.DB;

namespace QuanLyBanGiay_Ver_ADO.BS.ADO
{
    public class BLProducts : IProducts
    {
        DBMain db = null;
        public BLProducts()
        {
            db = new DBMain();
        }

        // Xóa mềm (dành cho admin thường)    
        public bool deleteProduct(int id, ref string err)
        {
            string sqlExcuteScalar = "Select active from products where id =" + id;
            int active = Convert.ToInt32(!db.ExcuteScalar<bool>(sqlExcuteScalar, ref err));

            string sqlString = "Update Products Set active = " + active + " Where id='" + id + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        // Xóa cứng (dành cho super admin)
        public bool deleteProductByAdmin(int id, ref string err)
        {
            string sqlString = "Delete From Products Where id='" + id + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable findProductById(int id, string err)
        {
            string sqlString = "Select * From Products Where id='" + id + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable findProductByName(string name, string err)
        {
            //string sqlString = "Select * From Products Where name=N'" + name + "'";
            //return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            string sqlString = "Select * From Products Where name LIKE N'" + "%" + name + "%" + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lấy sản phẩm bởi danh mục
        public DataTable getProductByCategory(int id)
        {
            string sqlString = "Select * From Products Where category_id='" + id + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lấy sản phẩm bởi khách hàng (active == true)
        public DataTable getProducts()
        {
            string sqlString = "Select * From Products Where active = 'True'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lấy sản phẩm bởi admin
        public DataTable getProductsByAdmin()
        {
            string sqlString = "Select * From Products";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lưu sản phẩm
        public bool saveProduct(int id, string name, string description, double price, string image, int category, ref string err)
        {
            string sqlString = "Insert Into Products Values("+
                        id + ",N'"
                        + name + "',N'" +
                        description + "'," +
                        price + ",'" +
                        image + "','" +
                        category + "','" +
                        1 + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        // Cập nhật sản phẩm
        public bool updateProduct(int id, string name, string description, double price, string image, int category, ref string err)
        {
            string sqlString = "Update Products Set name=N'" + name +
                "', description = N'" + description +
                "', price = '" + price +
                "', image = '" + image +
                "', category_id = " + category +
                " Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
