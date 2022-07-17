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
    public partial class frmAdminStatistic : Form
    {
        private int check = 1;
        string err;
        public frmAdminStatistic()
        {
            InitializeComponent();
        }

        private void pnShadow_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (check == 1)
            {
                DateTime fromDate = this.dtpFrom.Value.Date;
                DateTime toDate = this.dtpTo.Value.Date;

                if (fromDate > toDate)
                {
                    MessageBox.Show("Chọn sai ngày");
                    return;
                }

                dataTable = frmControlForm.managerOrdersDetails.findOrderByDate(fromDate, toDate);

            }
            else if (check == 2)
            {
                try
                {
                    DateTime date = new DateTime(Convert.ToInt32(txtNam.Text), Convert.ToInt32(txtThang.Text), 1);


                    dataTable = frmControlForm.managerOrdersDetails.findOrderByMonth(date);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng");
                    return;

                }
            }
            else
            {
                try
                {

                    DateTime date = new DateTime(Convert.ToInt32(txtYear.Text), 1, 1);

                    dataTable = frmControlForm.managerOrdersDetails.findOrderByYear(date);
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy đơn hàng");
                    return;
                }
            }

            chart1.DataSource = dataTable;
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            Decimal TotalPrice = Convert.ToDecimal(dataTable.Compute("SUM(TongTien)", string.Empty));
            this.lbTong.Text = TotalPrice.ToString() + "VNĐ";

            chart1.Series["Series1"].XValueMember = "Ngay";
            chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series["Series1"].YValueMembers = "TongTien";
            chart1.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }

        private void frmAdminStatistic_Load(object sender, EventArgs e)
        {
            pnNgay.Visible = true;
            pnThang.Visible = false;
            pnNam.Visible = false;
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            pnNgay.Visible = false;
            pnThang.Visible = true;
            pnNam.Visible = false;
            this.check = 2;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            pnNam.Visible = true;
            pnNgay.Visible = false;
            pnThang.Visible = false;
            this.check = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnNgay.Visible = true;
            pnThang.Visible = false;
            pnNam.Visible = false;
            this.check = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReportStatistic frm = new frmReportStatistic();
            frm.ShowDialog();
        }
    }
}
