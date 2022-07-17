using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyBanGiay_Ver_ADO.BS
{
    internal interface IUsers
    {
        /*
         * Chọn tất cả user trong csdl quản lí bởi super admin
         */
        DataTable getUsers();

        // tìm kiếm user với username
        DataTable getUserByUsername(String username, ref string err);

        // kiểm tra tồn tại user bằng username
        bool hasUserWithUserName(String username, ref string err);

        // kiểm tra tồn tại user bằng email
        bool hasUserWithEmail(String email, ref string err);

        // đăng kí
        bool saveUser(string username, string password, string name, string email, ref string err);

        // xóa mềm user
        bool deleteUser(int id, ref string err);

        // xóa user trong csdl
        bool deleteUserByAdmin(int id, ref string err);

        // update information of product
        bool updateUser(int id, string username, string password, string name, string email, ref string err);

        // thay đổi role của user thực hiện bởi super admin
        bool changeUserRole(String username, String role, ref string err);

        // đăng nhập
        bool login(string username, string password, ref string err);

        // Tìm tên người dùng bằng ID
        DataTable getNameByID(int id);
    }
}
