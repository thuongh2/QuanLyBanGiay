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
    public partial class frmSignup : Form
    {

        #region Method
        #endregion

        #region Properties
        string name, username, password, email;
        #endregion

        private void txbName_Leave(object sender, EventArgs e)
        {
            name = txbName.Text.Trim();
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            username = txbUsername.Text.Trim();
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            password = txbPassword.Text.Trim();
        }

        private void frmSignup_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmControlForm.Login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Check email
        private void txbEmail_Leave(object sender, EventArgs e)
        {
            string err = "";
            email = txbEmail.Text.Trim();
            bool is_exist = frmControlForm.managerUsers.hasUserWithEmail(email, ref err);

            if (is_exist || email == "")
            {
                MessageBox.Show("Email đã tồn tại hoặc không hợp lệ! Nhập lại đi!");

                email = "";
                txbEmail.Text = "";
                txbEmail.Focus();
            }
        }

        public frmSignup()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string err = "";
            bool is_success = frmControlForm.managerUsers.saveUser(username, password, name, email, ref err);

            if (is_success)
            {
                DialogResult dialogResult =  MessageBox.Show("Đăng ký thành công!");
                if (dialogResult == DialogResult.OK)
                {
                    frmControlForm.Login();
                    Close();
                }
            }
            else
            {
                MessageBox.Show(err);
            }
        }
    }
}
