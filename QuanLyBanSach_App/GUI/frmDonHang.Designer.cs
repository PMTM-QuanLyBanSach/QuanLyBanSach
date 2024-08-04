
namespace GUI
{
    partial class frmDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMain = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDH = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCTDH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDH = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtND = new System.Windows.Forms.DateTimePicker();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSach = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDH2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnThemDH = new System.Windows.Forms.Button();
            this.btnSuaDH = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1442, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMain
            // 
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(97, 24);
            this.btnMain.Text = "Trang chủ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cboKH);
            this.panel1.Controls.Add(this.dtND);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtDH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDH);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 457);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn hàng";
            // 
            // dgvDH
            // 
            this.dgvDH.AllowUserToAddRows = false;
            this.dgvDH.AllowUserToDeleteRows = false;
            this.dgvDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH.Location = new System.Drawing.Point(6, 185);
            this.dgvDH.Name = "dgvDH";
            this.dgvDH.ReadOnly = true;
            this.dgvDH.RowHeadersWidth = 51;
            this.dgvDH.RowTemplate.Height = 24;
            this.dgvDH.Size = new System.Drawing.Size(1146, 269);
            this.dgvDH.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDH2);
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cboSach);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgvCTDH);
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 550);
            this.panel2.TabIndex = 2;
            // 
            // dgvCTDH
            // 
            this.dgvCTDH.AllowUserToAddRows = false;
            this.dgvCTDH.AllowUserToDeleteRows = false;
            this.dgvCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDH.Location = new System.Drawing.Point(3, 192);
            this.dgvCTDH.Name = "dgvCTDH";
            this.dgvCTDH.ReadOnly = true;
            this.dgvCTDH.RowHeadersWidth = 51;
            this.dgvCTDH.RowTemplate.Height = 24;
            this.dgvCTDH.Size = new System.Drawing.Size(1146, 355);
            this.dgvCTDH.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi tiết đơn hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã đơn hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày đặt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng tiền";
            // 
            // txtDH
            // 
            this.txtDH.Location = new System.Drawing.Point(135, 36);
            this.txtDH.Name = "txtDH";
            this.txtDH.Size = new System.Drawing.Size(268, 22);
            this.txtDH.TabIndex = 6;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(611, 104);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(185, 22);
            this.txtTongTien.TabIndex = 8;
            // 
            // dtND
            // 
            this.dtND.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtND.Location = new System.Drawing.Point(611, 34);
            this.dtND.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtND.Name = "dtND";
            this.dtND.Size = new System.Drawing.Size(267, 22);
            this.dtND.TabIndex = 9;
            // 
            // cboKH
            // 
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(135, 104);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(268, 24);
            this.cboKH.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã đơn hàng";
            // 
            // cboSach
            // 
            this.cboSach.FormattingEnabled = true;
            this.cboSach.Location = new System.Drawing.Point(611, 47);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(267, 24);
            this.cboSach.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã sách";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(135, 111);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(185, 22);
            this.txtSoLuong.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Số lượng";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(611, 111);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(185, 22);
            this.txtGiaBan.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(494, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Giá bán";
            // 
            // txtDH2
            // 
            this.txtDH2.Location = new System.Drawing.Point(135, 47);
            this.txtDH2.Name = "txtDH2";
            this.txtDH2.Size = new System.Drawing.Size(268, 22);
            this.txtDH2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1158, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 1004);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReload);
            this.panel4.Controls.Add(this.btnSuaCT);
            this.panel4.Controls.Add(this.btnXoaCT);
            this.panel4.Controls.Add(this.btnThemCT);
            this.panel4.Controls.Add(this.btnSuaDH);
            this.panel4.Controls.Add(this.btnThemDH);
            this.panel4.Controls.Add(this.btnThemKH);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(1179, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 1010);
            this.panel4.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Thao tác";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(15, 34);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(138, 38);
            this.btnThemKH.TabIndex = 5;
            this.btnThemKH.Text = "Thêm khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = true;
            // 
            // btnThemDH
            // 
            this.btnThemDH.Location = new System.Drawing.Point(15, 104);
            this.btnThemDH.Name = "btnThemDH";
            this.btnThemDH.Size = new System.Drawing.Size(138, 38);
            this.btnThemDH.TabIndex = 6;
            this.btnThemDH.Text = "Thêm đơn hàng";
            this.btnThemDH.UseVisualStyleBackColor = true;
            // 
            // btnSuaDH
            // 
            this.btnSuaDH.Location = new System.Drawing.Point(15, 172);
            this.btnSuaDH.Name = "btnSuaDH";
            this.btnSuaDH.Size = new System.Drawing.Size(138, 38);
            this.btnSuaDH.TabIndex = 7;
            this.btnSuaDH.Text = "Sửa đơn hàng";
            this.btnSuaDH.UseVisualStyleBackColor = true;
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(15, 244);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(138, 38);
            this.btnThemCT.TabIndex = 8;
            this.btnThemCT.Text = "Thêm chi tiết";
            this.btnThemCT.UseVisualStyleBackColor = true;
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(15, 317);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(138, 38);
            this.btnXoaCT.TabIndex = 9;
            this.btnXoaCT.Text = "Xóa chi tiết";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Location = new System.Drawing.Point(15, 394);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(138, 38);
            this.btnSuaCT.TabIndex = 10;
            this.btnSuaCT.Text = "Sửa chi tiết";
            this.btnSuaCT.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 470);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(138, 38);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1442, 1055);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDonHang";
            this.Text = "frmDonHang";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCTDH;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.DateTimePicker dtND;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtDH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDH2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnSuaDH;
        private System.Windows.Forms.Button btnThemDH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnReload;
    }
}