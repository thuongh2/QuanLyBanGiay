
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;

namespace QuanLyBanGiay_Ver_ADO
{
    public partial class frmAdmin_Products : Form
    {
        #region Properties
        DataTable dtProducts = null;
        bool isAdd = false;
        #endregion

        public frmAdmin_Products()
        {
            InitializeComponent();
        }

        #region Method
        private void ResetTextBox()
        {
            foreach (var control in pnlnfor.Controls)
            {
                if (control is TextBox)
                {
                    TextBox tbx = control as TextBox;
                    tbx.ResetText();
                }
            }
        }

        private void DisableButton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void EnableButton(Button btn)
        {

            btn.Enabled = true;
            
            if (btn.Tag != null)
            {
                btn.BackColor = Color.FromArgb(230, 57, 70);
            }
            else
                btn.BackColor = Color.FromArgb(168, 218, 220);
        }

        private void ResetInforPanel()
        {
            ResetTextBox();
            ChangeZeroNumericUpdown();
            cmbCategory.Text = "Danh Mục";
        }
        private void ChangeZeroNumericUpdown()
        {
            foreach (var control in pnlSizes.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown nmu = control as NumericUpDown;
                    nmu.Value = 0;
                }
            }
        }

        private void ChangeSizeQuantity(int size, int quantity)
        {
            foreach (var control in pnlSizes.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown nmu = control as NumericUpDown;
                    if (Int32.Parse(nmu.Tag.ToString()) == size)
                        nmu.Value = quantity;
                }
            }
        }

        private List<KeyValuePair<int, int>> GetSizeList()
        {
            var myList = new List<KeyValuePair<int, int>>();
            foreach (var control in pnlSizes.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown nmu = control as NumericUpDown;
                    if (nmu.Value != 0)
                    {
                        int size = Int32.Parse(nmu.Tag.ToString());
                        myList.Add(new KeyValuePair<int, int>(size, (int)nmu.Value));
                    }
                }
            }
            return myList;
        }
        void LoadData()
        {
            ResetInforPanel();
            // Disable button
            DisableButton(btnSave);
            DisableButton(btnCancel);

            pnlMain.Enabled = false;
            // Enable button
            EnableButton(btnAdd);
            EnableButton(btnEdit);
            EnableButton(btnDel);
            EnableButton(btnBack);
            try
            {
                dtProducts = new DataTable();
                dtProducts.Clear();

                dtProducts = frmControlForm.managerProducts.getProductsByAdmin();

                dtgvProducts.DataSource = dtProducts;

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Products. Lỗi rồi!!!");
            }
        }
        #endregion

        private void frmAdmin_Products_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            ResetInforPanel();
            txbID.Enabled = true;
            pnlMain.Enabled = true;

            EnableButton(btnCancel);
            EnableButton(btnSave);
            //btnCancel.Enabled = true;
            //btnSave.Enabled = true;

            DisableButton(btnAdd);
            DisableButton(btnDel);
            DisableButton(btnEdit);
            //btnAdd.Enabled = false;
            //btnDel.Enabled = false;
            //btnEdit.Enabled = false;
            txbID.Focus();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetInforPanel();

            EnableButton(btnAdd);
            EnableButton(btnEdit);
            EnableButton(btnDel);
            EnableButton(btnBack);
            //btnAdd.Enabled = true;
            //btnEdit.Enabled = true;
            //btnDel.Enabled = true;
            //btnBack.Enabled = true;

            DisableButton(btnSave);
            DisableButton(btnCancel);
            DisableButton(btnCancel);
            //btnSave.Enabled = false;
            //btnCancel.Enabled = false;
            pnlMain.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isAdd = false;
            dtgvProducts_CellClick(null, null);
            pnlMain.Enabled = true;
            EnableButton(btnSave);
            EnableButton(btnCancel);
            //btnSave.Enabled = true;
            //btnCancel.Enabled = true;

            DisableButton(btnAdd);
            DisableButton(btnEdit);
            DisableButton(btnDel);
            DisableButton(btnBack);
            //btnAdd.Enabled = false;
            //btnEdit.Enabled = false;
            //btnDel.Enabled = false;
            //btnBack.Enabled = false;

            txbID.Enabled = false;
            txbName.Focus();
        }

        private void dtgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dtgvProducts.CurrentCell.RowIndex;

            txbID.Text = dtgvProducts.Rows[r].Cells[0].Value.ToString().Trim();
            txbName.Text = dtgvProducts.Rows[r].Cells[1].Value.ToString().Trim();
            txbDescription.Text = dtgvProducts.Rows[r].Cells[2].Value.ToString().Trim();
            txbPrice.Text = dtgvProducts.Rows[r].Cells[3].Value.ToString().Trim();

            // Chon danh muc cho san pham theo ID cua danh muc
            int categoryIndex, id;
            Int32.TryParse(dtgvProducts.Rows[r].Cells[5].Value.ToString().Trim(), out categoryIndex);
            cmbCategory.SelectedIndex = categoryIndex - 1;

            //Bo check tat ca cac size
            ChangeZeroNumericUpdown();
            // Lay size dang co
            Int32.TryParse(txbID.Text.Trim(), out id);
            DataTable s = frmControlForm.managerSizes.getSizesByProduct(id);
            for (int i = 0; i < s.Rows.Count; i++)
            {
                int size = (int)s.Rows[i][1];
                ChangeSizeQuantity(size, (int)s.Rows[i][2]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmControlForm.is_show = true;
            frmControlForm.ControlTimer.Start();
            Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            EnableButton(btnBack);
            //btnBack.Enabled = true;

            if (!txbID.Text.Equals(""))
            {
                if (isAdd)
                {
                    try
                    {
                        string name, description, image, err = ""; ;
                        int id, category_id;
                        id = Int32.Parse(txbID.Text.Trim());
                        bool exist_ID = frmControlForm.managerProducts.findProductById(id, err).Rows.Count != 0;
                        if (exist_ID)
                        {
                            MessageBox.Show("Không thêm được. ID đã tồn tại!");
                            txbID.ResetText();
                            txbID.Focus();
                        }
                        else
                        {
                            double price = double.Parse(txbPrice.Text.Trim()); ;
                            name = txbName.Text.Trim();
                            description = txbDescription.Text.Trim();
                            image = txbImage.Text.Trim();
                            category_id = cmbCategory.SelectedIndex + 1;
                            frmControlForm.managerProducts.saveProduct(id, name, description, price, image, category_id, ref err);

                            // Luu size
                            List<KeyValuePair<int, int>> list_size = GetSizeList();
                            foreach (KeyValuePair<int, int> pair in list_size)
                            {
                                frmControlForm.managerSizes.createSize(pair.Key, pair.Value, id, ref err);
                            }
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
                else
                {
                    try
                    {
                        string name, description, image, err = "";
                        int id, category_id;
                        double price = double.Parse(txbPrice.Text.Trim()); ;
                        name = txbName.Text.Trim();
                        description = txbDescription.Text.Trim();
                        image = txbImage.Text.Trim();
                        id = Int32.Parse(txbID.Text.Trim());
                        category_id = cmbCategory.SelectedIndex + 1;
                        frmControlForm.managerProducts.updateProduct(id, name, description, price, image, category_id, ref err);

                        //Cap nhat size
                        DataTable tbSize =  frmControlForm.managerSizes.getSizesByProduct(id);
                        var numberSize = new Dictionary<int, int>();
                        for (int i = 0; i < tbSize.Rows.Count; i++)
                        {
                            numberSize.Add((int)tbSize.Rows[i][1], (int)tbSize.Rows[i][0]);
                        }

                        var list_size = GetSizeList();
                        foreach (var size in list_size)
                        {
                            if (numberSize.ContainsKey(size.Key))
                            {
                                frmControlForm.managerSizes.updateSize(numberSize[size.Key], size.Key, size.Value, id, ref err);
                            }
                            else
                            {
                                frmControlForm.managerSizes.createSize(size.Key, size.Value, id, ref err);
                            }
                        }
                        LoadData();
                        MessageBox.Show("Đã sửa xong!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Lỗi rồi! Không sửa được!");
                    }
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            dtgvProducts_CellClick(null, null);
            int r = dtgvProducts.CurrentCell.RowIndex;
            int id;
            bool is_valid = Int32.TryParse(dtgvProducts.Rows[r].Cells[0].Value.ToString().Trim(), out id);
            string err = "";

            if (is_valid)
            {
                DialogResult ans;
                ans = MessageBox.Show($"Bạn có muốn xóa sản phẩm có ID là {id} không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ans == DialogResult.OK)
                {
                    try
                    {
                        //Xoa size
                        DataTable tbSize = frmControlForm.managerSizes.getSizesByProduct(id);
                        for (int i = 0; i < tbSize.Rows.Count; i++)
                        {
                            frmControlForm.managerSizes.deleteSizeByAdmin((int)tbSize.Rows[i][0], ref err);
                        }

                        frmControlForm.managerProducts.deleteProductByAdmin(id, ref err);


                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
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
    }
}
