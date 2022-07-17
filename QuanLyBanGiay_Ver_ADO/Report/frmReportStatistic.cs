using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay_Ver_ADO.Report
{
    public partial class frmReportStatistic : Form
    {
        public frmReportStatistic()
        {
            InitializeComponent();
        }

        private void frmReportStatistic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ThongKe' table. You can move, or remove it, as needed.
            this.thongKeTableAdapter.Fill(this.dataSet1.ThongKe);

            this.reportViewer2.RefreshReport();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (this.txtNam.Text != "" && this.txtThang.Text != "")
            {
                thongKeDoanhSo(Int32.Parse(this.txtThang.Text), Int32.Parse(this.txtNam.Text));
            }
            else if (this.txtNam.Text != "" && this.txtThang.Text == "")
            {
                thongKeDoanhSo(Int32.Parse(this.txtNam.Text));
            }
        }

        public void thongKeDoanhSo(int month, int year)
        {
            this.thongKeTableAdapter.FillBy(this.dataSet1.ThongKe, year, month);

            this.lbTitle.Text = "Báo cáo doanh số bán hàng " + month + "/ " + year;

            this.reportViewer2.RefreshReport();

        }

        public void thongKeDoanhSo(int year)
        {
            this.thongKeTableAdapter.FillByYear(this.dataSet1.ThongKe, year);

            this.lbTitle.Text = "Báo cáo doanh số bán hàng năm " + year;

            this.reportViewer2.RefreshReport();

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
