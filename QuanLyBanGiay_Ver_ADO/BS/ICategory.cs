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
    internal interface ICategory
    {
        // tất cả danh mục có active = true (user)
        DataTable getAllCategories();

        // tất cả danh mục tồn tạo trong csdl
        DataTable getAllCategoriesByAdmin();

        // lưu danh mục
        bool saveCategory(int id, string name, ref string err);

        // cập nhật danh mục
        bool updateCategory(int id, string name, ref string err);

        //xóa danh mục trong csdl (super admin)
        bool deleteCategoryById(int id, ref string err);

        // xóa mềm danh mục (admin)
        bool deleteCategory(int id, ref string err);
    }
}
