using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using QuanLyBanGiay_Ver_ADO.ColorForApp;

namespace QuanLyBanGiay_Ver_ADO
{
    public partial class frmMain_User : Form
    {
        #region Properties
        DataTable dtProducts = null;

        public static Timer timer = new Timer();
        private Button activeBtn = null;
        private TableLayoutPanel tbProducts = null;
        #endregion
        #region Method
        private void LoadData()
        {
            try
            {
                dtProducts = new DataTable();
                dtProducts.Clear();

                dtProducts = frmControlForm.managerProducts.getProducts();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Products. Lỗi rồi!!!");
            }
        }
        private void ShowProduct()
        {
            tbProducts.Controls.Clear();
            tbProducts.RowCount = dtProducts.Rows.Count;
            tbProducts.ColumnCount = 2;
            if(dtProducts.Rows.Count <= 4)
                tbProducts.AutoScroll = false;
            else tbProducts.AutoScroll = true;
            foreach (DataRow row in dtProducts.Rows)
            {
                Form form = new frmProduct(row[1].ToString(), row[4].ToString(), Double.Parse(row[3].ToString()), Int32.Parse(row[0].ToString()));
                addProducts(form);
            }
        }

        private void ShowProductByCategory(int category_id)
        {
            dtProducts.Clear();
            dtProducts = frmControlForm.managerProducts.getProductByCategory(category_id);
            ShowProduct();
        }
        private void ShowProductByName(string name)
        {
            string err = "";
            dtProducts.Clear();
            try
            {
                dtProducts = frmControlForm.managerProducts.findProductByName(name, err);
                ShowProduct();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi! Không kiếm được :((");
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            ShowProductByCategory(Int32.Parse(btn.Tag.ToString()));


            if (activeBtn != null)
                unHighLightBtn(activeBtn);
            activeBtn = btn;
            HighLightBtn(activeBtn);

        }
        #endregion


        #region Highlight
        private void HighLightBtn(Button btn)
        {
            btn.BackColor = ThemeColor.PrimaryColorDark;
            btn.ForeColor = ThemeColor.SecondaryColor;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void unHighLightBtn(Button btn)
        {
            btn.BackColor = ThemeColor.PrimaryLightColor;
            btn.ForeColor = ThemeColor.PrimaryColorDark;
            btn.Font = new Font(btn.Font, FontStyle.Regular);
        }
        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (activeBtn == btn)
            {
                btn.FlatAppearance.MouseOverBackColor = ThemeColor.PrimaryColorDark;
            }
            else
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(189, 224, 254);
            }
        }

        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (activeBtn == btn)
            {
                btn.FlatAppearance.MouseDownBackColor = ThemeColor.PrimaryColorDark;
            }
            else
            {
                btn.FlatAppearance.MouseDownBackColor = ThemeColor.PrimaryLightColor;
            }
        }
        #endregion
        public frmMain_User()
        {
            InitializeComponent();
        }

        private void addProducts(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tbProducts.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowProductByName(txbSearch.Text.Trim());
            if(activeBtn != null)
                unHighLightBtn(activeBtn);
        }

        private void frmMain_User_Load(object sender, EventArgs e)
        {
            tbProducts = new TableLayoutPanel();

            tbProducts.Dock = DockStyle.Fill;
            tbProducts.RowCount = 2;
            tbProducts.ColumnCount = 2;
            tbProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tbProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tbProducts.RowStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tbProducts.RowStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tbProducts.BackColor = ThemeColor.PrimaryColorDark;
            pnlShowProduct.Controls.Add(tbProducts);
            pnlShowProduct.Tag = tbProducts;
            tbProducts.BringToFront();
            tbProducts.Show();

            LoadData();
            ShowProduct();

            timer.Interval = 1;
            timer.Start();
            timer.Tick += Timer_Tick;

            btnUsername.Text = frmControlForm.managerUsers.getNameByID(frmControlForm.current_user_id).Rows[0][3].ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (frmProduct.details_clicked)
            {
                tbProducts.Controls.Clear();
                tbProducts.ColumnCount = 1;
                tbProducts.RowCount = 1;
                tbProducts.AutoScroll = false;
                Form form = new frmProductDetails(frmProduct.currentID);
                addProducts(form);

                frmProduct.details_clicked = false;
                timer.Stop();
            }

            if (frmProductDetails.is_close)
            {
                frmProductDetails.is_close = false;
                timer.Stop();
                LoadData();
                ShowProduct();
            }
        }

    }
}
