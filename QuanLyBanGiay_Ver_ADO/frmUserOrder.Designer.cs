namespace QuanLyBanGiay_Ver_ADO
{
    partial class frmUserOrder
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlCusInfo = new System.Windows.Forms.Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbCusName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCusName = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlOrderInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTotal = new System.Windows.Forms.Button();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnNameProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.btnOrder = new QuanLyBanGiay_Ver_ADO.CTButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlCusInfo.SuspendLayout();
            this.pnlOrderInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(684, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt hàng";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Aqua;
            this.pnlBody.Controls.Add(this.pnlCusInfo);
            this.pnlBody.Controls.Add(this.pnlOrderInfo);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 55);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(684, 406);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlCusInfo
            // 
            this.pnlCusInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.pnlCusInfo.Controls.Add(this.cmbPayment);
            this.pnlCusInfo.Controls.Add(this.txbEmail);
            this.pnlCusInfo.Controls.Add(this.lbCusName);
            this.pnlCusInfo.Controls.Add(this.label5);
            this.pnlCusInfo.Controls.Add(this.txbCusName);
            this.pnlCusInfo.Controls.Add(this.txbPhone);
            this.pnlCusInfo.Controls.Add(this.label2);
            this.pnlCusInfo.Controls.Add(this.label4);
            this.pnlCusInfo.Controls.Add(this.txbAddress);
            this.pnlCusInfo.Controls.Add(this.label3);
            this.pnlCusInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pnlCusInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlCusInfo.Name = "pnlCusInfo";
            this.pnlCusInfo.Size = new System.Drawing.Size(488, 406);
            this.pnlCusInfo.TabIndex = 11;
            // 
            // txbEmail
            // 
            this.txbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.txbEmail.Location = new System.Drawing.Point(230, 172);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(243, 26);
            this.txbEmail.TabIndex = 5;
            // 
            // lbCusName
            // 
            this.lbCusName.AutoSize = true;
            this.lbCusName.Location = new System.Drawing.Point(17, 61);
            this.lbCusName.Name = "lbCusName";
            this.lbCusName.Size = new System.Drawing.Size(90, 19);
            this.lbCusName.TabIndex = 0;
            this.lbCusName.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phương thức thanh toán";
            // 
            // txbCusName
            // 
            this.txbCusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.txbCusName.Location = new System.Drawing.Point(230, 54);
            this.txbCusName.Name = "txbCusName";
            this.txbCusName.Size = new System.Drawing.Size(243, 26);
            this.txbCusName.TabIndex = 1;
            // 
            // txbPhone
            // 
            this.txbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.txbPhone.Location = new System.Drawing.Point(230, 233);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(243, 26);
            this.txbPhone.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại";
            // 
            // txbAddress
            // 
            this.txbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.txbAddress.Location = new System.Drawing.Point(230, 111);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(243, 26);
            this.txbAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // pnlOrderInfo
            // 
            this.pnlOrderInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.pnlOrderInfo.Controls.Add(this.label6);
            this.pnlOrderInfo.Controls.Add(this.btnOrder);
            this.pnlOrderInfo.Controls.Add(this.panel1);
            this.pnlOrderInfo.Controls.Add(this.btnSize);
            this.pnlOrderInfo.Controls.Add(this.btnNameProduct);
            this.pnlOrderInfo.Controls.Add(this.pictureBox1);
            this.pnlOrderInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrderInfo.Location = new System.Drawing.Point(488, 0);
            this.pnlOrderInfo.Name = "pnlOrderInfo";
            this.pnlOrderInfo.Size = new System.Drawing.Size(196, 406);
            this.pnlOrderInfo.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Controls.Add(this.nmQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 37);
            this.panel1.TabIndex = 4;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(240)))), ((int)(((byte)(208)))));
            this.btnTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTotal.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTotal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnTotal.Location = new System.Drawing.Point(0, 0);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(144, 37);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // nmQuantity
            // 
            this.nmQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.nmQuantity.Location = new System.Drawing.Point(150, 6);
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(43, 26);
            this.nmQuantity.TabIndex = 3;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.ValueChanged += new System.EventHandler(this.nmQuantity_ValueChanged);
            // 
            // btnSize
            // 
            this.btnSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.btnSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSize.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSize.FlatAppearance.BorderSize = 0;
            this.btnSize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnSize.Location = new System.Drawing.Point(0, 213);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(196, 30);
            this.btnSize.TabIndex = 5;
            this.btnSize.Text = "Size";
            this.btnSize.UseVisualStyleBackColor = false;
            // 
            // btnNameProduct
            // 
            this.btnNameProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            this.btnNameProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNameProduct.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnNameProduct.FlatAppearance.BorderSize = 0;
            this.btnNameProduct.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnNameProduct.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNameProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnNameProduct.Location = new System.Drawing.Point(0, 134);
            this.btnNameProduct.Name = "btnNameProduct";
            this.btnNameProduct.Size = new System.Drawing.Size(196, 79);
            this.btnNameProduct.TabIndex = 2;
            this.btnNameProduct.Text = "Name";
            this.btnNameProduct.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QuanLyBanGiay_Ver_ADO.Properties.Resources.dusk;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmbPayment
            // 
            this.cmbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Tiền mặt",
            "Online"});
            this.cmbPayment.Location = new System.Drawing.Point(230, 298);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(243, 27);
            this.cmbPayment.TabIndex = 10;
            this.cmbPayment.Text = "Tiền mặt";
            this.cmbPayment.SelectedIndexChanged += new System.EventHandler(this.cmbPayment_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOrder.BorderRadius = 40;
            this.btnOrder.BorderSize = 0;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnOrder.Location = new System.Drawing.Point(5, 316);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(186, 68);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Size";
            // 
            // frmUserOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUserOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserOrder_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlCusInfo.ResumeLayout(false);
            this.pnlCusInfo.PerformLayout();
            this.pnlOrderInfo.ResumeLayout(false);
            this.pnlOrderInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCusName;
        private System.Windows.Forms.Label lbCusName;
        private System.Windows.Forms.Panel pnlOrderInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Button btnNameProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Panel pnlCusInfo;
        private System.Windows.Forms.ComboBox cmbPayment;
        private CTButton btnOrder;
        private System.Windows.Forms.Label label6;
    }
}