using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyBanGiay_Ver_ADO.Report
{
    public partial class frmBills : Form
    {
        public int id;

        public frmBills()
        {
            InitializeComponent();
        }

        private void frmBills_Load(object sender, EventArgs e)
        {
            if(id > 0)
            {
                this.hoaDonTableAdapter.Fill(this.dataSet1.HoaDon, this.id);
            }
            this.reportViewer1.RefreshReport();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.HoaDon' table. You can move, or remove it, as needed.
            //this.hoaDonTableAdapter.FillByEmail(this.dataSet1.HoaDon, email);

            string find = txtPhone.Text;
            string sPhonePattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            string sMailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            if (find != "")
            {
                if (Regex.IsMatch(find.Trim(), sMailPattern))
                {
                    this.hoaDonTableAdapter.FillByEmail(this.dataSet1.HoaDon, find);
                }
                else if (Regex.IsMatch(find.Trim(), sPhonePattern))
                {
                    this.hoaDonTableAdapter.FillByPhone(this.dataSet1.HoaDon, find);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn đặt hàng");
                }
            }
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
