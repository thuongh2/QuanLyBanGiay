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
    internal interface IOrders
    {
        // lấy tất cả thông tin khách hàng
        DataTable getAllOrdersByAdmin();

        // lưu thông tin khách hàng mới
        bool saveOrders(string name, string address, string email, string phone, ref string err);

        // cập nhật thông tin khách hàng
        bool updateOrders(int id, string name, double amount, string address, string email, string phone, ref string err);

        //soft delete
        bool deleteOrdersById(int id, ref string err);

        // xóa thông tin hách hàng bởi admin
        bool deleteOrders(int id, ref string err);

        // tìm kiếm thông tin khách hàng bằng tên
        DataTable findOrderByName(string name, ref string err);

        // tìm kiếm thông tin khách hàng bằng email
        DataTable findOrderByEmail(string email, ref string err);

        DataTable getOrderById(int id, ref string err);

        DataTable saveAndGetIDOrders(string name, string address, string email, string phone, ref string err);
    }
}
