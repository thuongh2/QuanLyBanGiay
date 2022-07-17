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
    internal interface IProducts
    {
        // lấy tất cả sản phẩm bởi user (active == true) 
        DataTable getProducts();

        // lấy tất cả sản phẩm bởi admin
        DataTable getProductsByAdmin();
        // lưu sản phẩm
        bool saveProduct(int id, string name, string description, double price, string image, int category, ref string err);

        // cập nhật sản phẩm
        bool updateProduct(int id, string name, string description, double price, string image, int category, ref string err);

        // xóa sản phẩm soft delete
        bool deleteProduct(int id, ref string err);

        // xóa sản phẩm 
        bool deleteProductByAdmin(int id, ref string err);

        // lấy sản phẩm bởi danh mục
        DataTable getProductByCategory(int id);

        // tìm kiếm sản phẩm bằng id
        DataTable findProductById(int id, string err);

        // tìm kiếm sản phẩm bằng tên
        DataTable findProductByName(string name, string err);

    }
}
