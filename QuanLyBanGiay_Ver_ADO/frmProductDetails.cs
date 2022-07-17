using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanGiay_Ver_ADO.ColorForApp;

namespace QuanLyBanGiay_Ver_ADO
{
    public partial class frmProductDetails : Form
    {
        #region Properties
        public static bool is_close = false;
        private int id, size, quantity;
        private double price;
        private string name, description, image;
        private Button activeBtn = null;
        private List<int> sizes = null;
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
        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            btnName.Text = name.Trim();
            btnDescription.Text = description.Trim();
            btnPrice.Text = price.ToString() + "$";
            size = 0;
            quantity = 1;
            foreach (var control in pnlSize.Controls)
            {
                if (control is Button)
                {
                    Button btn = control as Button;
                    int size = Int32.Parse(btn.Text);
                    if (sizes.Contains(size))
                    {
                        btn.Enabled = true;
                        btn.ForeColor = ThemeColor.PrimaryColorDark;
                        btn.BackColor = ThemeColor.PrimaryLightColor;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            is_close = true;
            frmMain_User.timer.Start();
            Close();
        }

        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)nmQuantity.Value;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Enabled)
            {
                this.size = Int32.Parse(btn.Text);

                if (activeBtn != null)
                    unHighLightBtn(activeBtn);
                activeBtn = btn;
                HighLightBtn(activeBtn);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (size == 0)
                MessageBox.Show("Vui lòng chọn size!");
            else
            {
                frmUserOrder order = new frmUserOrder(id, name, image, price, quantity, size);
                order.ShowDialog();
            }
        }

        public frmProductDetails()
        {
            InitializeComponent();
            name = description = image = "";
        }

        public frmProductDetails(int ID)
        {
            InitializeComponent();
            id = ID;
            string err = "";
            DataTable dtProduct = frmControlForm.managerProducts.findProductById(id, err);
            name = dtProduct.Rows[0][1].ToString();
            description = dtProduct.Rows[0][2].ToString();
            //image = dtProduct.Rows[0][4].ToString(); //Chuc nang load hinh làm sau
            price = Double.Parse(dtProduct.Rows[0][3].ToString());

            DataTable dtSizes = frmControlForm.managerSizes.getSizesByProduct(id);
            sizes = new List<int>();
            foreach (DataRow row in dtSizes.Rows)
            {
                sizes.Add(Int32.Parse(row[1].ToString()));
            }
        }
    }
}
