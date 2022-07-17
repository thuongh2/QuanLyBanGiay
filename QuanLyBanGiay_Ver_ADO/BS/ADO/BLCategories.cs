using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay_Ver_ADO.DB;

namespace QuanLyBanGiay_Ver_ADO.BS.ADO
{
    class BLCategories : ICategory
    {
        DBMain db = null;
        public BLCategories()
        {
            db = new DBMain();
        }

        //Xóa mềm
        public bool deleteCategory(int id, ref string err)
        {

            string sqlExcuteScalar = "Select active from category where id =" + id + "'";
            int active = Convert.ToInt32(!db.ExcuteScalar<bool>(sqlExcuteScalar, ref err));

            string sqlString = "Update Category Set active= '" + active +
            "' Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        // Xóa cứng
        public bool deleteCategoryById(int id, ref string err)
        {
            string sqlString = "Delete From Category Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool deleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }
        // Lấy với active == true
        public DataTable getAllCategories()
        {
            string sqlString = "Select * From Category Where active = 'True'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lấy hết
        public DataTable getAllCategoriesByAdmin()
        {
            string sqlString = "Select * From Category";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Thêm mới
        public bool saveCategory(int id, string name, ref string err)
        {
            string sqlString = "Insert Into Category (name, active) Values(N'" +
                        name + "', 1)";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        // Cập nhật
        public bool updateCategory(int id, string name, ref string err)
        {
            string sqlString = "Update Category Set name=N'" + name +
                "' Where id= " + id;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
