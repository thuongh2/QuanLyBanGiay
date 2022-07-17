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
    internal interface ISizes
    {
        // lấy tất cả size (..., chức năng thống kê hàng tồn kho)
        DataTable getAllSize();
        // lấy size của sản phẩm để người dùng chọn lựa
        DataTable getSizesByProduct(int productId);
        // lưu size theo mã sản phẩm
        bool createSize(int numberSize, int quantity, int product, ref string err);
        // cập nhật size của sản phẩm
        bool updateSize(int id, int numberSize, int quantity, int product, ref string err);
        // xóa mềm sản phẩm (admin)
        bool deleteSize(int id, ref string err);
        // xóa cứng sản phẩm (super admin)
        bool deleteSizeByAdmin(int id, ref string err);
    }
}
