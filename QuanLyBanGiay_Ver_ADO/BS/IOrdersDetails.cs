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
    internal interface IOrdersDetails
    {
        // lấy tất cả các đơn hàng bởi admin
        DataTable getOrderDetails();

        // lấy tất đơn hàng có mã sản phẩm (admin)
        DataTable getOrderDetailsByProduct(int productId);

        // tìm kiếm đơn hàng bằng số điện thoại
        DataTable findOrderByPhone(string phoneNumber);

        // người dùng xem đơn hàng của mình (user)
        DataTable getOrderDetailsByUser(String username);

        // đặt hàng, cần truyền vào mã sản phẩm, mã người đùng, mã người đặt hàng, số lượng, kích thước
        // giá, phương thức thanh toán
        bool createOrderDetail(int orderId, int productId, int userId, int size,
                                    int quantity, double price, string payment, ref string err);
        // cập nhật đơn hàng
        bool updateOrderDetail(int id, int orderId, int productId, int userId, int size,
                                    int quantity, double price, string payment, ref string err);

        // xóa đơn hàng (admin)
        bool deleteOrderDetail(int id, ref string err);

        // xóa đơn hàng bởi người dùng, xóa mềm
        bool deleteOrderDetailByUser(int id, ref string err);

        /* CHỨC NĂNG THỐNG KÊ (tổng đơn hàng, tổng tiền, ....) */

        // thống kê đơn hàng từ ngày đến ngày
        DataTable findOrderByDate(DateTime fromDate, DateTime toDate);

        // thống kê sản phẩm trong tháng             
        DataTable findOrderByMonth(DateTime month);

        // thống kê sản phẩm trong năm
        DataTable findOrderByYear(DateTime month);

        // cho người tìm kiếm chi tiết hóa đơn bằng email
        DataTable getOrderDetailsByEmail(string email);

        // thay đổi tình trạng đơn hàng (admin)
        bool changeOrderShipment(int id, int active, ref string err);

        DataTable getOrderDetailsById(int id);

    }
}
