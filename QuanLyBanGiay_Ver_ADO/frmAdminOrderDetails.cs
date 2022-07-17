using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanGiay_Ver_ADO.Report;

namespace QuanLyBanGiay_Ver_ADO
{
    public partial class frmAdminOrderDetails : Form
    {
        public int id;
        public string err;

        public frmAdminOrderDetails()
        {
            InitializeComponent();
        }


        private void frmAdminOrderDetails_Load(object sender, EventArgs e)
        {
            this.txtID.Enabled = false;
            this.txtTen.Enabled = false;
            this.txtNguoi.Enabled = false;
            loadForm();
        }

        private void loadForm()
        {
            DataTable dt = new DataTable();
            string trangthai = "Đã Hủy";

            try
            {
                dt = frmControlForm.managerOrdersDetails.getOrderDetailsById(id);

                txtID.Text = dt.Rows[0][0].ToString();
                txtTen.Text = dt.Rows[0][2].ToString();
                txtNguoi.Text = dt.Rows[0][1].ToString();
                txtSize.Text = dt.Rows[0][3].ToString();
                txtSoLuong.Text = dt.Rows[0][5].ToString();
                txtGia.Text = dt.Rows[0][6].ToString();
                txtTong.Text = dt.Rows[0][7].ToString();
                txtThanhToan.Text = dt.Rows[0][8].ToString();
                txtDate.Text = dt.Rows[0][9].ToString().Substring(0, 10);
                int active = Int32.Parse(dt.Rows[0][10].ToString());

                if (active == 1)
                {
                    trangthai = "Đang giao";
                }
                else if (active == 2)
                {
                    trangthai = "Đã giao";
                }

                cmbTrangThai.Text = trangthai;

                dt = frmControlForm.managerProducts.findProductById(Int32.Parse(txtTen.Text), err);
                txtTenSanPham.Text = dt.Rows[0][1].ToString();

                dt = frmControlForm.managerOrders.getOrderById(Int32.Parse(txtNguoi.Text), ref err);
                txtTenNguoiDat.Text = dt.Rows[0][2].ToString();
                txtDiaChi.Text = dt.Rows[0][3].ToString();
                txtSDT.Text = dt.Rows[0][5].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy sản phẩm");
            }
        }


        private void btnChangeStatus_Click(object sender, EventArgs e)
        {

            string trangthai = cmbTrangThai.Text;
            int active;
            try
            {
                if (trangthai.Equals("Đã Hủy"))
                    active = 0;
                else if (trangthai.Equals("Đang Giao"))
                    active = 1;
                else
                    active = 2;

                frmControlForm.managerOrdersDetails.changeOrderShipment(Int32.Parse(txtID.Text), active, ref err);
                MessageBox.Show("Đơn Hàng " + trangthai);

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thay đổi trạng thái");
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmBills frmHoaDon = new frmBills();
            frmHoaDon.id = Int32.Parse(txtID.Text);
            frmHoaDon.ShowDialog();
        }
    }
}
