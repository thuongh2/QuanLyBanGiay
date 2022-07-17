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
    public partial class frmProduct : Form
    {
        #region field
        public int id;
        private string name, image;
        private double price;
        public static bool details_clicked = false;
        public static int currentID = 0;
        #endregion
        public frmProduct()
        {
            InitializeComponent();
            name = image = "";
            price = 9999;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            name = name.Trim();
            string price_text = price.ToString() + "$";
            btnPrice.Text = price_text;
            btnName.Text = name; 
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            details_clicked = true;
            currentID = id;
            frmMain_User.timer.Start();
        }

        public frmProduct(string name, string image, double price, int id_product)
        {
            InitializeComponent();
            this.name = name;
            this.image = image;
            this.price = price;
            id = id_product;
        }
    }
}
