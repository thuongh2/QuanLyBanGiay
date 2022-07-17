using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanGiay_Ver_ADO
{
    public partial class frmLogin : Form
    {
        #region Properties
        string username, password;  
        bool login_success = false;
        #endregion
        public frmLogin()
        {
            username = password = "";
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmControlForm.Signup();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Visible = false;
            if (!login_success) Application.Exit();

            else
            {
                frmControlForm.is_show = true;
                frmControlForm.ControlTimer.Start();
            }
        }
        private void txbUsername_Leave(object sender, EventArgs e)
        {
            username = txbUsername.Text.Trim();
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            password = txbPassword.Text.Trim();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txbUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string err = "";
            bool exist = frmControlForm.managerUsers.hasUserWithUserName(username, ref err);
            if (exist)
            {
                DataTable user = frmControlForm.managerUsers.getUserByUsername(username, ref err);
                if (password.Equals(user.Rows[0][2].ToString()))
                {
                    login_success = true;
                    frmControlForm.current_user_id = Int32.Parse(user.Rows[0][0].ToString());
                    frmControlForm.Role = user.Rows[0][5].ToString();
                    Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng!");
                    txbPassword.Text = "";
                    txbPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                txbPassword.Text = txbUsername.Text = "";
                txbUsername.Focus();
            }
        }
    }
}
