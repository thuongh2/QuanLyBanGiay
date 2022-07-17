namespace QuanLyBanGiay_Ver_ADO
{
    partial class frmProductDetails
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.btnDescription = new System.Windows.Forms.Button();
            this.pnlSize = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOrder = new QuanLyBanGiay_Ver_ADO.CTButton();
            this.btnName = new QuanLyBanGiay_Ver_ADO.CTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new QuanLyBanGiay_Ver_ADO.CTButton();
            this.btnPrice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.pnlDescription.SuspendLayout();
            this.pnlSize.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlOrder);
            this.pnlMain.Controls.Add(this.pnlDescription);
            this.pnlMain.Controls.Add(this.pnlSize);
            this.pnlMain.Controls.Add(this.pnlHead);
            this.pnlMain.Controls.Add(this.pnlImage);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(720, 600);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.pnlOrder.Controls.Add(this.label3);
            this.pnlOrder.Controls.Add(this.btnOrder);
            this.pnlOrder.Controls.Add(this.nmQuantity);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrder.Location = new System.Drawing.Point(410, 315);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(310, 65);
            this.pnlOrder.TabIndex = 2;
            // 
            // nmQuantity
            // 
            this.nmQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.nmQuantity.Location = new System.Drawing.Point(108, 18);
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(52, 26);
            this.nmQuantity.TabIndex = 0;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.ValueChanged += new System.EventHandler(this.nmQuantity_ValueChanged);
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.White;
            this.pnlDescription.Controls.Add(this.btnDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDescription.Location = new System.Drawing.Point(410, 380);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(310, 220);
            this.pnlDescription.TabIndex = 2;
            // 
            // btnDescription
            // 
            this.btnDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.btnDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDescription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.btnDescription.FlatAppearance.BorderSize = 0;
            this.btnDescription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.btnDescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.btnDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.btnDescription.Location = new System.Drawing.Point(0, 0);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(310, 220);
            this.btnDescription.TabIndex = 1;
            this.btnDescription.Text = "Description";
            this.btnDescription.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDescription.UseVisualStyleBackColor = false;
            // 
            // pnlSize
            // 
            this.pnlSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.pnlSize.Controls.Add(this.button6);
            this.pnlSize.Controls.Add(this.button7);
            this.pnlSize.Controls.Add(this.button8);
            this.pnlSize.Controls.Add(this.button9);
            this.pnlSize.Controls.Add(this.button10);
            this.pnlSize.Controls.Add(this.button5);
            this.pnlSize.Controls.Add(this.button4);
            this.pnlSize.Controls.Add(this.button3);
            this.pnlSize.Controls.Add(this.button2);
            this.pnlSize.Controls.Add(this.button1);
            this.pnlSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSize.Location = new System.Drawing.Point(410, 138);
            this.pnlSize.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Size = new System.Drawing.Size(310, 177);
            this.pnlSize.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Enabled = false;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.button6.Location = new System.Drawing.Point(250, 104);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 9;
            this.button6.Text = "45";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnSize_Click);
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.Enabled = false;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(190, 104);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "44";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnSize_Click);
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(130, 104);
            this.button8.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "43";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnSize_Click);
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.Enabled = false;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(70, 104);
            this.button9.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 6;
            this.button9.Text = "42";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnSize_Click);
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.Enabled = false;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(10, 104);
            this.button10.Margin = new System.Windows.Forms.Padding(10, 20, 5, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 5;
            this.button10.Text = "41";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnSize_Click);
            this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(250, 18);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "40";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnSize_Click);
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(190, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "39";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnSize_Click);
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(130, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "38";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnSize_Click);
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(70, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "37";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSize_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 20, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "36";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSize_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_MouseMove);
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.White;
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Controls.Add(this.btnPrice);
            this.pnlHead.Controls.Add(this.btnBack);
            this.pnlHead.Controls.Add(this.pnlName);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.pnlHead.Location = new System.Drawing.Point(410, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(310, 138);
            this.pnlHead.TabIndex = 2;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.White;
            this.pnlName.Controls.Add(this.btnName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlName.Location = new System.Drawing.Point(0, 0);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(180, 138);
            this.pnlName.TabIndex = 3;
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.pnlImage.Controls.Add(this.label2);
            this.pnlImage.Controls.Add(this.pictureBox1);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(410, 600);
            this.pnlImage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanGiay_Ver_ADO.Properties.Resources.dusk;
            this.pictureBox1.Location = new System.Drawing.Point(70, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOrder.BorderRadius = 52;
            this.btnOrder.BorderSize = 0;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnOrder.Location = new System.Drawing.Point(180, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(127, 52);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.btnName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.btnName.BorderColor = System.Drawing.Color.White;
            this.btnName.BorderRadius = 30;
            this.btnName.BorderSize = 5;
            this.btnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnName.FlatAppearance.BorderSize = 0;
            this.btnName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.btnName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnName.Location = new System.Drawing.Point(0, 0);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(180, 138);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Name";
            this.btnName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.btnName.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giá";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 20;
            this.btnBack.BorderSize = 0;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnBack.Location = new System.Drawing.Point(180, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Trở về";
            this.btnBack.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(122)))), ((int)(((byte)(95)))));
            this.btnPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(122)))), ((int)(((byte)(95)))));
            this.btnPrice.FlatAppearance.BorderSize = 0;
            this.btnPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(122)))), ((int)(((byte)(95)))));
            this.btnPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(122)))), ((int)(((byte)(95)))));
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnPrice.Location = new System.Drawing.Point(180, 82);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(130, 56);
            this.btnPrice.TabIndex = 8;
            this.btnPrice.Text = "Giá";
            this.btnPrice.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thêm hình nhỏ khi Click vào\r\nthì chuyển hình lớn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng:";
            // 
            // frmProductDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(720, 600);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductDetails";
            this.Text = "frmProductDetails";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.pnlDescription.ResumeLayout(false);
            this.pnlSize.ResumeLayout(false);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Panel pnlSize;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private CTButton btnOrder;
        private CTButton btnName;
        private System.Windows.Forms.Label label1;
        private CTButton btnBack;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}