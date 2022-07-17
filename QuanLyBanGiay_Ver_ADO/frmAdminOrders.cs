using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using QuanLyBanGiay_Ver_ADO.Report;

namespace QuanLyBanGiay_Ver_ADO
{
    public partial class frmAdminOrders : Form
    {
        DataTable dtOrdersDetails = null;
        private string err;
        private bool isAdd;
        public frmAdminOrders()
        {
            InitializeComponent();
        }

        private void changeButton(bool check)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = check;
            btnLuu.Enabled = check;
            btnChiTiet.Enabled = check;
            txtID.Enabled = false;

        }

        private void frmAdminOrders_Load(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void loadOrders()
        {
            try
            {
                changeButton(false);


                dtOrdersDetails = new DataTable();
                dtOrdersDetails.Clear();

                dtOrdersDetails = frmControlForm.managerOrdersDetails.getOrderDetails();

                dgvOrders.DataSource = dtOrdersDetails;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Orders. Lỗi rồi!!!");
            }
        }


        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvOrders.CurrentCell.RowIndex;

            txtID.Text = dgvOrders.Rows[r].Cells[0].Value.ToString().Trim();
            txtTen.Text = dgvOrders.Rows[r].Cells[2].Value.ToString().Trim();
            txtNguoi.Text = dgvOrders.Rows[r].Cells[1].Value.ToString().Trim();
            txtSize.Text = dgvOrders.Rows[r].Cells[3].Value.ToString().Trim();
            txtSoLuong.Text = dgvOrders.Rows[r].Cells[5].Value.ToString().Trim();
            txtGia.Text = dgvOrders.Rows[r].Cells[6].Value.ToString().Trim();
            txtTong.Text = dgvOrders.Rows[r].Cells[7].Value.ToString().Trim();
            txtThanhToan.Text = dgvOrders.Rows[r].Cells[8].Value.ToString().Trim();

            this.changeButton(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            changeButton(true);
            this.isAdd = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                int r = dgvOrders.CurrentCell.RowIndex;
                int orderId = Int32.Parse(dgvOrders.Rows[r].Cells[1].Value.ToString());
                int productId = Int32.Parse(dgvOrders.Rows[r].Cells[2].Value.ToString());
                int userId = Int32.Parse(dgvOrders.Rows[r].Cells[4].Value.ToString());

                bool flag = frmControlForm.managerOrdersDetails.updateOrderDetail(Int32.Parse(txtID.Text), orderId, productId, userId, Int32.Parse(txtSize.Text),
                    Int32.Parse(txtSoLuong.Text), Double.Parse(txtGia.Text), txtThanhToan.Text, ref err);

                if (flag)
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.loadOrders();
                }
                else
                {
                    MessageBox.Show(err);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvOrders_CellClick(null, null);
            int r = dgvOrders.CurrentCell.RowIndex;
            int id;
            bool is_valid = Int32.TryParse(dgvOrders.Rows[r].Cells[0].Value.ToString().Trim(), out id);
            string err = "";

            if (is_valid)
            {
                DialogResult ans;
                ans = MessageBox.Show($"Bạn có muốn xóa sản phẩm có ID là {id} không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ans == DialogResult.OK)
                {
                    try
                    {
                        if (frmControlForm.managerOrdersDetails.deleteOrderDetailByUser(Int32.Parse(txtID.Text), ref err))
                        {

                            MessageBox.Show("Đã xóa xong!");
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không xóa được. Lỗi rồi!");
                    }
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string find = txtTimKiem.Text;
            string sPhonePattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            string sMailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            if (find != "")
            {
                if (Regex.IsMatch(find.Trim(), sMailPattern))
                {
                    this.dgvOrders.DataSource = frmControlForm.managerOrdersDetails.getOrderDetailsByEmail(find);
                }
                else if (Regex.IsMatch(find.Trim(), sPhonePattern))
                {
                    this.dgvOrders.DataSource = frmControlForm.managerOrdersDetails.findOrderByPhone(find);
                }
                else
                {
                    this.dgvOrders.DataSource = frmControlForm.managerOrdersDetails.getOrderDetailsByUser(find);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            this.loadOrders();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmAdminOrderDetails frm = new frmAdminOrderDetails();
            frm.id = Int32.Parse(txtID.Text);
            frm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmControlForm.is_show = true;
            frmControlForm.ControlTimer.Start();
            Close();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmBills frm = new frmBills();
            frm.ShowDialog();
        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnHoaDon_Click(object sender, EventArgs e)
        //{
        //    frmListHoaDon frmList = new frmListHoaDon();
        //    frmList.Show();
        //}
    }
}
