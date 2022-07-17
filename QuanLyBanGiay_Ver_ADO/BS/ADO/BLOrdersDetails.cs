using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanGiay_Ver_ADO.DB;

namespace QuanLyBanGiay_Ver_ADO.BS.ADO
{
    public class BLOrdersDetails : IOrdersDetails
    {
        const int ACTIVE_DELETE = 0;
        const int ACTIVE_SHIPMENT = 1;
        const int ACTIVE_DONE = 2;

        DBMain db = null;
        public BLOrdersDetails()
        {
            db = new DBMain();
        }

        public bool changeOrderShipment(int id, int active, ref string err)
        {
            string sqlUpdateActive = "UPDATE Order_Details SET active = " + active + " WHERE id= " + id;

            return db.MyExecuteNonQuery(sqlUpdateActive, CommandType.Text, ref err);

        }

        public bool createOrderDetail(int orderId, int productId, int userId, int size,
            int quantity, double price, string payment, ref string err)
        {
            string sqlCheckSize = "Select quantity from sizes where product_id = " + productId +" and number_size = " + size;
            int quantityCheck = db.ExcuteScalar<int>(sqlCheckSize, ref err);

            string sqlCheckAmount = "Select amount from orders where id = " + orderId;
            double amountCheck = db.ExcuteScalar<double>(sqlCheckAmount, ref err);

            if (quantityCheck < quantity)
            {
                err = "Không đủ hàng trong kho";
                return false;
            }


            string sqlInsertOrder = "INSERT INTO Order_Details VALUES("+ orderId + ", "
                                                                       + productId + ", "
                                                                       + size + ","
                                                                       + userId + ", "
                                                                       + quantity + ", "
                                                                       + price + ", "
                                                                       + quantity * price + ", N'" // giá của toàn bộ đơn hàng
                                                                       + payment + "', '"
                                                                       + DateTime.Now.ToString("yyyyMMdd") + "', "
                                                                       + ACTIVE_SHIPMENT + ")";

            string sqlUpdateSize = "UPDATE SIZES SET quantity= " + (quantityCheck - quantity) + " WHERE product_id= " + productId;
            string sqlUpdateAmount = "UPDATE ORDERS SET amount= " + (amountCheck + quantity * price) + " WHERE id= " + orderId;

            if (db.MyExecuteNonQuery(sqlInsertOrder, CommandType.Text, ref err) == false)
            {
                err = "Không thể đặt hàng";
                return false;
            }
            if (db.MyExecuteNonQuery(sqlUpdateSize, CommandType.Text, ref err) == false)
            {
                err = "Lỗi khi cập nhật số lượng size";
                return false;
            }
            if (db.MyExecuteNonQuery(sqlUpdateAmount, CommandType.Text, ref err) == false)
            {
                err = "Lỗi khi cập nhật tổng thanh toán";
                return false;
            }


            return true;
        }

        public bool deleteOrderDetail(int id, ref string err)
        {
            string sqlString = "Delete From Order_Details Where id='" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        // Nếu người dùng đã xóa thì không được hoàn tác
        public bool deleteOrderDetailByUser(int id, ref string err)
        {
            string sqlProductCheck = "Select product_id from Order_Details where id = " + id;
            var productCheck = db.ExcuteScalar<int>(sqlProductCheck, ref err);

            string sqlQuantityCheck = "Select quantity from Order_Details where id = " + id;
            var quanCheck = db.ExcuteScalar<int>(sqlQuantityCheck, ref err);

            string sqlCheckSize = "Select quantity from sizes where product_id = " + productCheck;
            int quantityCheck = db.ExcuteScalar<int>(sqlCheckSize, ref err);


            string sqlString = "Update Order_Details Set active= '" + ACTIVE_DELETE +
            "' Where id='" + id + "'";

            string sqlUpdateSize = "UPDATE SIZES SET quantity= " + (quantityCheck + quanCheck) + " WHERE product_id= " + productCheck;

            if (db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err) == false)
            {
                err = "Không thể xóa sản phẩm";
                return false;
            }

            if (db.MyExecuteNonQuery(sqlUpdateSize, CommandType.Text, ref err) == false)
            {
                err = "Không cập nhật số lượng hàng";
                return false;
            }

            return true;
        }

        public DataTable findOrderByDate(DateTime fromDate, DateTime toDate)
        {
            string sqlString = "Select date_order as Ngay, sum(amount) as TongTien From Order_Details where date_order >= '" + fromDate
                + "' and date_order <= '" + toDate + "' group by date_order";

            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable findOrderByMonth(DateTime month)
        {
            string sqlString = "Select date_order as Ngay, sum(amount) as TongTien From Order_Details where MONTH(date_order) = '" + month.Month + "' and YEAR(date_order) = '" + month.Year + "' group by date_order";

            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable findOrderByPhone(string phoneNumber)
        {
            string sqlString = "SELECT order_details.id, order_details.order_id, order_details.product_id, order_details.size, order_details.users_id," +
                " order_details.quantity, order_details.price, order_details.amount," +
                " order_details.payment, order_details.date_order, order_details.active" +
                " FROM order_details INNER JOIN orders ON order_details.order_id = orders.id " +
                "WHERE(orders.customer_phone = '" + phoneNumber + "')";

            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable findOrderByYear(DateTime month)
        {
            string sqlString = "Select date_order as Ngay, sum(amount) as TongTien From Order_Details where YEAR(date_order) = '" + month.Year + "'group by date_order";

            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lấy tất cả 
        public DataTable getOrderDetails()
        {
            string sqlString = "Select * From order_details";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lấy bởi email
        public DataTable getOrderDetailsByEmail(string email)
        {
            string sqlString = "SELECT order_details.id, order_details.order_id, order_details.product_id, order_details.size, order_details.users_id," +
                " order_details.quantity, order_details.price, order_details.amount," +
                " order_details.payment, order_details.date_order, order_details.active" +
                " FROM order_details INNER JOIN orders ON order_details.order_id = orders.id "+
                "WHERE(orders.customer_email = '" + email + "')";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable getOrderDetailsById(int id)
        {
            string sqlString = $"Select * From order_details where id = {id}";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        // Lấy bởi product
        public DataTable getOrderDetailsByProduct(int productId)
        {
            string sqlString = "Select * From order_details Where product_id = '" + productId + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable getOrderDetailsByUser(string username)
        {
            string sqlString = "Select * From order_details Where email = '" + username + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool updateOrderDetail(int id, int orderId, int productId, int userId, int size, int quantity, double price, string payment, ref string err)
        {
            string sqlCheckSize = "Select quantity from sizes where product_id = " + productId + " and number_size = " + size;
            int quantityCheck = db.ExcuteScalar<int>(sqlCheckSize, ref err);

            string sqlCheckOrders = "Select quantity from Order_Details where id = " + id;
            int quantityOCheck = db.ExcuteScalar<int>(sqlCheckOrders, ref err);

            string sqlCheckAmount = "Select amount from orders where id = " + orderId;
            double amountCheck = db.ExcuteScalar<double>(sqlCheckAmount, ref err);

            if (quantity > quantityCheck + quantityOCheck)
            {
                err = "Không đủ hàng trong kho";
                return false;
            }

            int quantityNew = quantityOCheck + quantityCheck - quantity;
            double amountChange = amountCheck - (quantityOCheck * price) + (quantity * price);


            string sqlInsertOrder = "UPDATE Order_Details SET order_id= "
                                                                       + orderId + ", product_id = "
                                                                       + productId + ", size = "
                                                                       + size + ", Users_id = "
                                                                       + userId + ", quantity = "
                                                                       + quantity + ", price = "
                                                                       + price + ", amount = "
                                                                       + quantity * price + ",payment = N'" // giá của toàn bộ đơn hàng
                                                                       + payment + "', date_order = '"
                                                                       + DateTime.Now.ToString("yyyyMMdd") + "', active = "
                                                                       + ACTIVE_SHIPMENT +" WHERE id = " +id;

            string sqlUpdateSize = "UPDATE SIZES SET quantity= " + quantityNew + " WHERE product_id= " + productId;
            string sqlUpdateAmount = "UPDATE ORDERS SET amount= " + amountChange + " WHERE id= " + orderId;

            if (db.MyExecuteNonQuery(sqlInsertOrder, CommandType.Text, ref err) == false)
            {
                err = "Không cập nhật thể đặt hàng";
                return false;
            }
            if (db.MyExecuteNonQuery(sqlUpdateSize, CommandType.Text, ref err) == false)
            {
                err = "Lỗi khi cập nhật số lượng size";
                return false;
            }
            if (db.MyExecuteNonQuery(sqlUpdateAmount, CommandType.Text, ref err) == false)
            {
                err = "Lỗi khi cập nhật tổng thanh toán";
                return false;
            }


            return false;
        }
    }
}