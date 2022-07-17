namespace QuanLyBanGiay_Ver_ADO
{
    partial class frmControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsTools = new System.Windows.Forms.MenuStrip();
            this.MenuItem_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_QLUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_QLProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_QLOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mnsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsTools
            // 
            this.mnsTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.mnsTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Admin,
            this.MenuItem_Logout});
            this.mnsTools.Location = new System.Drawing.Point(0, 0);
            this.mnsTools.Name = "mnsTools";
            this.mnsTools.Size = new System.Drawing.Size(900, 30);
            this.mnsTools.TabIndex = 0;
            this.mnsTools.Text = "menuStrip1";
            // 
            // MenuItem_Admin
            // 
            this.MenuItem_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_QLUser,
            this.MenuItem_QLProduct,
            this.MenuItem_QLOrders,
            this.MenuItem_Statistic});
            this.MenuItem_Admin.Name = "MenuItem_Admin";
            this.MenuItem_Admin.Size = new System.Drawing.Size(67, 26);
            this.MenuItem_Admin.Text = "Admin";
            // 
            // MenuItem_QLUser
            // 
            this.MenuItem_QLUser.Enabled = false;
            this.MenuItem_QLUser.Name = "MenuItem_QLUser";
            this.MenuItem_QLUser.Size = new System.Drawing.Size(223, 26);
            this.MenuItem_QLUser.Text = "Quản lý người dùng";
            // 
            // MenuItem_QLProduct
            // 
            this.MenuItem_QLProduct.Name = "MenuItem_QLProduct";
            this.MenuItem_QLProduct.Size = new System.Drawing.Size(223, 26);
            this.MenuItem_QLProduct.Text = "Quản lý sản phẩm";
            this.MenuItem_QLProduct.Click += new System.EventHandler(this.MenuItem_QLProduct_Click);
            // 
            // MenuItem_QLOrders
            // 
            this.MenuItem_QLOrders.Name = "MenuItem_QLOrders";
            this.MenuItem_QLOrders.Size = new System.Drawing.Size(223, 26);
            this.MenuItem_QLOrders.Text = "Quản lý đơn hàng";
            this.MenuItem_QLOrders.Click += new System.EventHandler(this.MenuItem_QLOrders_Click);
            // 
            // MenuItem_Statistic
            // 
            this.MenuItem_Statistic.Name = "MenuItem_Statistic";
            this.MenuItem_Statistic.Size = new System.Drawing.Size(223, 26);
            this.MenuItem_Statistic.Text = "Thống kê đơn hàng";
            this.MenuItem_Statistic.Click += new System.EventHandler(this.MenuItem_Statistic_Click);
            // 
            // MenuItem_Logout
            // 
            this.MenuItem_Logout.Name = "MenuItem_Logout";
            this.MenuItem_Logout.Size = new System.Drawing.Size(91, 26);
            this.MenuItem_Logout.Text = "Đăng xuất";
            this.MenuItem_Logout.Click += new System.EventHandler(this.MenuItem_Logout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 694);
            this.pnlMain.TabIndex = 1;
            // 
            // frmControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 724);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnsTools);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mnsTools;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.frmControlForm_Load);
            this.mnsTools.ResumeLayout(false);
            this.mnsTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsTools;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Admin;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_QLUser;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_QLProduct;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Logout;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_QLOrders;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Statistic;
    }
}