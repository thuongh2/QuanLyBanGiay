namespace QuanLyBanGiay_Ver_ADO
{
    partial class frmAdminStatistic
    {/// <summary>
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnXem = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnShadow = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnNam = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.pnThang = new System.Windows.Forms.Panel();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThang = new System.Windows.Forms.Button();
            this.pnNgay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.pnShadow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnNam.SuspendLayout();
            this.pnThang.SuspendLayout();
            this.pnNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXem.Location = new System.Drawing.Point(766, 56);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(204, 62);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbTong.ForeColor = System.Drawing.Color.Red;
            this.lbTong.Location = new System.Drawing.Point(896, 230);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(25, 26);
            this.lbTong.TabIndex = 13;
            this.lbTong.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 561);
            this.panel1.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 75);
            this.button3.TabIndex = 1;
            this.button3.Text = "Báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 60);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thống kê doanh thu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnShadow
            // 
            this.pnShadow.Controls.Add(this.chart1);
            this.pnShadow.Controls.Add(this.btnXem);
            this.pnShadow.Controls.Add(this.label6);
            this.pnShadow.Controls.Add(this.lbTong);
            this.pnShadow.Controls.Add(this.panel2);
            this.pnShadow.Location = new System.Drawing.Point(166, 2);
            this.pnShadow.Name = "pnShadow";
            this.pnShadow.Size = new System.Drawing.Size(1078, 561);
            this.pnShadow.TabIndex = 17;
            this.pnShadow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnShadow_Paint);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(39, 203);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(779, 349);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(878, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng Doanh Thu: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pnNam);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnNam);
            this.panel2.Controls.Add(this.pnThang);
            this.panel2.Controls.Add(this.btnThang);
            this.panel2.Controls.Add(this.pnNgay);
            this.panel2.Location = new System.Drawing.Point(39, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 171);
            this.panel2.TabIndex = 15;
            // 
            // pnNam
            // 
            this.pnNam.Controls.Add(this.txtYear);
            this.pnNam.Controls.Add(this.label5);
            this.pnNam.Location = new System.Drawing.Point(209, 46);
            this.pnNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnNam.Name = "pnNam";
            this.pnNam.Size = new System.Drawing.Size(310, 100);
            this.pnNam.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(50, 53);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(177, 31);
            this.txtYear.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(46, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập năm";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(87, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Theo ngày";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNam
            // 
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNam.Location = new System.Drawing.Point(412, 6);
            this.btnNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(141, 37);
            this.btnNam.TabIndex = 10;
            this.btnNam.Text = "Theo Năm";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // pnThang
            // 
            this.pnThang.Controls.Add(this.txtThang);
            this.pnThang.Controls.Add(this.label7);
            this.pnThang.Controls.Add(this.txtNam);
            this.pnThang.Controls.Add(this.label3);
            this.pnThang.Controls.Add(this.label4);
            this.pnThang.Location = new System.Drawing.Point(143, 46);
            this.pnThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnThang.Name = "pnThang";
            this.pnThang.Size = new System.Drawing.Size(376, 108);
            this.pnThang.TabIndex = 12;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(41, 45);
            this.txtThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThang.Multiline = true;
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(119, 32);
            this.txtThang.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(170, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "/";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(207, 46);
            this.txtNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNam.Multiline = true;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(111, 32);
            this.txtNam.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(37, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(203, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập năm";
            // 
            // btnThang
            // 
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThang.Location = new System.Drawing.Point(251, 5);
            this.btnThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(145, 37);
            this.btnThang.TabIndex = 9;
            this.btnThang.Text = "Theo Tháng";
            this.btnThang.UseVisualStyleBackColor = true;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // pnNgay
            // 
            this.pnNgay.Controls.Add(this.label1);
            this.pnNgay.Controls.Add(this.label2);
            this.pnNgay.Controls.Add(this.dtpFrom);
            this.pnNgay.Controls.Add(this.dtpTo);
            this.pnNgay.Location = new System.Drawing.Point(53, 50);
            this.pnNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnNgay.Name = "pnNgay";
            this.pnNgay.Size = new System.Drawing.Size(529, 89);
            this.pnNgay.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(288, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ngày";
            // 
            // dtpFrom
            // 
            this.dtpFrom.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dtpFrom.CausesValidation = false;
            this.dtpFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFrom.Location = new System.Drawing.Point(12, 39);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(215, 22);
            this.dtpFrom.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(281, 39);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(233, 22);
            this.dtpTo.TabIndex = 5;
            // 
            // frmAdminStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnShadow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdminStatistic";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.frmAdminStatistic_Load);
            this.panel1.ResumeLayout(false);
            this.pnShadow.ResumeLayout(false);
            this.pnShadow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnNam.ResumeLayout(false);
            this.pnNam.PerformLayout();
            this.pnThang.ResumeLayout(false);
            this.pnThang.PerformLayout();
            this.pnNgay.ResumeLayout(false);
            this.pnNgay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXem;
     //   private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnShadow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Panel pnNam;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnThang;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}