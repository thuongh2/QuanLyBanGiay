using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay_Ver_ADO
{
    public partial class frmUserOrder : Form
    {
        string name, image, payment;
        double price;
        int quantity, product_id, size, order_id;
        string err;

        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {
            double Total = price * Int32.Parse(nmQuantity.Value.ToString());
            btnTotal.Text = Total.ToString() + "$";
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            payment = cmbPayment.Items[cmbPayment.SelectedIndex].ToString();
        }

        private bool IsValidInput()
        {
            foreach (var control in pnlCusInfo.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txb = control as TextBox;
                    if (txb.Text.Equals(""))
                        return false;
                }
            }
            return true;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                try
                {
                    //frmControlForm.managerOrders.saveOrders(txbCusName.Text, txbAddress.Text, txbEmail.Text, txbPhone.Text, ref err);
                    DataTable dt = frmControlForm.managerOrders.saveAndGetIDOrders(txbCusName.Text, txbAddress.Text, txbEmail.Text, txbPhone.Text, ref err);
                    order_id = Int32.Parse(dt.Rows[0][0].ToString());
                    bool is_success = frmControlForm.managerOrdersDetails.createOrderDetail(order_id, product_id, frmControlForm.current_user_id, size, quantity, price, payment, ref err);
                    if (is_success)
                    {
                        MessageBox.Show("Đặt hàng thành công");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(err);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm đặt hàng được! Lỗi rồi!");
                }
            }
            else
            {
                MessageBox.Show("Thông tin khách hàng không đúng");
            }
        }

        private void frmUserOrder_Load(object sender, EventArgs e)
        {
            btnNameProduct.Text = name.Trim();
            btnSize.Text = size.ToString();
            nmQuantity.Value = quantity;
            double Total = price * Int32.Parse(nmQuantity.Value.ToString());
            btnTotal.Text = Total.ToString() + "$";
        }

        public frmUserOrder()
        {
            InitializeComponent();
            name = image = "";
            price = 0;
        }
        public frmUserOrder(int product_id, string name, string image, double price, int quantity, int size)
        {
            InitializeComponent();
            this.product_id = product_id;
            this.name = name;
            this.image = image;
            this.price = price;
            this.quantity = quantity;
            this.size = size;
            payment = "Tiền mặt";
        }
    }
}
