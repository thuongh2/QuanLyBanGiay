using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanGiay_Ver_ADO.BS.ADO;

namespace QuanLyBanGiay_Ver_ADO
{
    public partial class frmControlForm : Form
    {

        #region Properties
        static Form login = new frmLogin();
        private Form user_product = null;
        public static BLUsers managerUsers = new BLUsers();
        public static BLProducts managerProducts = new BLProducts();
        public static BLSizes managerSizes = new BLSizes();
        public static BLOrdersDetails managerOrdersDetails = new BLOrdersDetails();
        public static BLOrders managerOrders = new BLOrders();
        public static string Role = "";
        public static bool is_show = true;
        public static int current_user_id = 0;
        public static Timer ControlTimer = new Timer();
        #endregion
        #region Open Child Form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        public frmControlForm()
        {
            InitializeComponent();
            login.ShowDialog();

            ControlTimer = new Timer();
            ControlTimer.Interval = 1;
            ControlTimer.Tick += ControlTimer_Tick;

            if (current_user_id != 0)
            {
                user_product = new frmMain_User();
                user_product.TopLevel = false;
                user_product.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(user_product);
                user_product.SendToBack();
                user_product.Show();
            }
        }

        //Hien form signup an from login
        static public void Signup()
        {
            Form signup = new frmSignup();
            login.Hide();
            signup.ShowDialog();
        }

        // Hien form login
        static public void Login()
        {
            login.Visible = true;
        }

        private void frmControlForm_Load(object sender, EventArgs e)
        {
            ControlTimer.Start();
        }

        private void MenuItem_QLProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAdmin_Products());
        }

        private void MenuItem_Logout_Click(object sender, EventArgs e)
        {
            login = new frmLogin();
            login.Show();
            //pnlMain.Controls.Clear();
            is_show = false;
            ControlTimer.Start();
        }

        private void ControlTimer_Tick(object sender, EventArgs e)
        {
            this.Visible = is_show;
            if (is_show)
            {
                ControlTimer.Stop();
            }

            if (Role.Equals("ADMIN"))
                MenuItem_Admin.Enabled = true;
            else
                MenuItem_Admin.Enabled = false;
        }

        private void MenuItem_QLOrders_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAdminOrders());
        }
        private void MenuItem_Statistic_Click(object sender, EventArgs e)
        {
            frmAdminStatistic frm = new frmAdminStatistic();
            frm.Show();
        }
    }
}
