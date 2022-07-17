using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay_Ver_ADO.DB;

namespace QuanLyBanGiay_Ver_ADO.BS.ADO
{
    public class BLUsers : IUsers
    {

        DBMain db = null;
        public BLUsers()
        {
            db = new DBMain();
        }

        public bool changeUserRole(string username, string role, ref string err)
        {
            string sqlString = "Update Users Set role= '" + role +
            "' Where username='" + username + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool deleteUser(int id, ref string err)
        {
            string sqlExcuteScalar = "Select active from users where id =" + id + "'";
            bool active = db.ExcuteScalar<bool>(sqlExcuteScalar, ref err);

            string sqlString = "Update Users Set active= '" + !active +
            "' Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool deleteUserByAdmin(int id, ref string err)
        {
            string sqlString = "Delete From Users Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable getUserByUsername(string username, ref string err)
        {
            string sqlString = "Select * From Users Where active = 'True' and username = N'" + username + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable getUsers()
        {
            string sqlString = "Select * From Users";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool hasUserWithEmail(string email, ref string err)
        {
            string sqlString = "Select * From Users Where active = 'True' and email = N'" + email + "'";
            return db.checkExist(sqlString, CommandType.Text);
        }

        public bool hasUserWithUserName(string username, ref string err)
        {
            string sqlString = "Select * From Users Where active = 'True' and username = N'" + username + "'";
            return db.checkExist(sqlString, CommandType.Text);
        }

        public bool login(string username, string password, ref string err)
        {
            string sqlString = "Select * From Users Where active = 'True' and username = N'"
                + username + "' password = '" + password + "'";
            return db.checkExist(sqlString, CommandType.Text);
        }

        public bool saveUser(string username, string password, string name, string email, ref string err)
        {
            if (hasUserWithUserName(username, ref err) || hasUserWithEmail(email, ref err))
            {
                err = "Tài khoản đã tồn tại";
                return false;
            }

            string role = "USER";

            string sqlString = "Insert Into Users Values('" +

                        username + "','" +
                        password + "','" +
                        name + "','" +
                        email + "','" +
                        role + "','" +
                        1 + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool updateUser(int id, string username, string password, string name, string email, ref string err)
        {
            string sqlString = "Update Users Set username=N'" + username + "', password = '"
                + password + "', name = N'" + name + "',email = '" + email +
                "' Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable getNameByID(int id)
        {
            string sqlString = $"Select * from users where id = {id} and active = 1";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text); 
        }
    }
}
