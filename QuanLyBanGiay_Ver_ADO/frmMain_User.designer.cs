namespace QuanLyBanGiay_Ver_ADO
{
    partial class frmMain_User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.btnUsername = new System.Windows.Forms.Button();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new QuanLyBanGiay_Ver_ADO.CTButton();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCategory4 = new System.Windows.Forms.Button();
            this.btnCategory3 = new System.Windows.Forms.Button();
            this.btnCategory2 = new System.Windows.Forms.Button();
            this.btnCategory1 = new System.Windows.Forms.Button();
            this.pnlShowProduct = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlUserName.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.pnlUserName);
            this.panel1.Controls.Add(this.pnlIcon);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 100);
            this.panel1.TabIndex = 0;
            // 
            // pnlUserName
            // 
            this.pnlUserName.Controls.Add(this.btnUsername);
            this.pnlUserName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserName.Location = new System.Drawing.Point(61, 0);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(173, 100);
            this.pnlUserName.TabIndex = 4;
            // 
            // btnUsername
            // 
            this.btnUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsername.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnUsername.FlatAppearance.BorderSize = 0;
            this.btnUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsername.Location = new System.Drawing.Point(0, 0);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(173, 100);
            this.btnUsername.TabIndex = 3;
            this.btnUsername.Text = "UserName";
            this.btnUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsername.UseVisualStyleBackColor = true;
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.pictureBox1);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(61, 100);
            this.pnlIcon.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanGiay_Ver_ADO.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(7, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 30;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSearch.Location = new System.Drawing.Point(672, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(325, 39);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(340, 31);
            this.txbSearch.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.btnCategory4);
            this.panel3.Controls.Add(this.btnCategory3);
            this.panel3.Controls.Add(this.btnCategory2);
            this.panel3.Controls.Add(this.btnCategory1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 600);
            this.panel3.TabIndex = 3;
            // 
            // btnCategory4
            // 
            this.btnCategory4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnCategory4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory4.FlatAppearance.BorderSize = 0;
            this.btnCategory4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory4.Location = new System.Drawing.Point(0, 240);
            this.btnCategory4.Name = "btnCategory4";
            this.btnCategory4.Size = new System.Drawing.Size(180, 80);
            this.btnCategory4.TabIndex = 4;
            this.btnCategory4.Tag = "5";
            this.btnCategory4.Text = "Giày thể thao nữ";
            this.btnCategory4.UseVisualStyleBackColor = false;
            this.btnCategory4.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnCategory4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnCategory3
            // 
            this.btnCategory3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnCategory3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory3.FlatAppearance.BorderSize = 0;
            this.btnCategory3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory3.Location = new System.Drawing.Point(0, 160);
            this.btnCategory3.Name = "btnCategory3";
            this.btnCategory3.Size = new System.Drawing.Size(180, 80);
            this.btnCategory3.TabIndex = 2;
            this.btnCategory3.Tag = "3";
            this.btnCategory3.Text = "Giày thể thao nam";
            this.btnCategory3.UseVisualStyleBackColor = false;
            this.btnCategory3.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnCategory3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnCategory2
            // 
            this.btnCategory2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnCategory2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory2.FlatAppearance.BorderSize = 0;
            this.btnCategory2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory2.Location = new System.Drawing.Point(0, 80);
            this.btnCategory2.Name = "btnCategory2";
            this.btnCategory2.Size = new System.Drawing.Size(180, 80);
            this.btnCategory2.TabIndex = 1;
            this.btnCategory2.Tag = "2";
            this.btnCategory2.Text = "Giày nữ";
            this.btnCategory2.UseVisualStyleBackColor = false;
            this.btnCategory2.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.btnCategory2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // btnCategory1
            // 
            this.btnCategory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnCategory1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnCategory1.FlatAppearance.BorderSize = 0;
            this.btnCategory1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnCategory1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.btnCategory1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory1.Location = new System.Drawing.Point(0, 0);
            this.btnCategory1.Name = "btnCategory1";
            this.btnCategory1.Size = new System.Drawing.Size(180, 80);
            this.btnCategory1.TabIndex = 0;
            this.btnCategory1.Tag = "1";
            this.btnCategory1.Text = "Dép nam";
            this.btnCategory1.UseVisualStyleBackColor = false;
            this.btnCategory1.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            this.btnCategory1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // pnlShowProduct
            // 
            this.pnlShowProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowProduct.Location = new System.Drawing.Point(180, 100);
            this.pnlShowProduct.Name = "pnlShowProduct";
            this.pnlShowProduct.Size = new System.Drawing.Size(720, 600);
            this.pnlShowProduct.TabIndex = 5;
            // 
            // frmMain_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pnlShowProduct);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain_User";
            this.Load += new System.EventHandler(this.frmMain_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUserName.ResumeLayout(false);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCategory3;
        private System.Windows.Forms.Button btnCategory2;
        private System.Windows.Forms.Button btnCategory1;
        private System.Windows.Forms.Button btnCategory4;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.Button btnUsername;
        private CTButton btnSearch;
        private System.Windows.Forms.Panel pnlShowProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlIcon;
    }
}