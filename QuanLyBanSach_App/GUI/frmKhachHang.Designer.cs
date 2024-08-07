
namespace GUI
{
    partial class frmKhachHang
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
            this.tbl_DSKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_makhachhang = new System.Windows.Forms.TextBox();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_themkhachhang = new System.Windows.Forms.Button();
            this.btn_luukhachhang = new System.Windows.Forms.Button();
            this.btn_suakhachhang = new System.Windows.Forms.Button();
            this.btn_xoakhachhang = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DSKH)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_DSKH
            // 
            this.tbl_DSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_DSKH.Location = new System.Drawing.Point(15, 316);
            this.tbl_DSKH.Name = "tbl_DSKH";
            this.tbl_DSKH.RowHeadersWidth = 51;
            this.tbl_DSKH.RowTemplate.Height = 24;
            this.tbl_DSKH.Size = new System.Drawing.Size(991, 291);
            this.tbl_DSKH.TabIndex = 0;
            this.tbl_DSKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_DSKH_CellContentClick);
            this.tbl_DSKH.SelectionChanged += new System.EventHandler(this.tbl_DSKH_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng";
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.Location = new System.Drawing.Point(25, 59);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Size = new System.Drawing.Size(161, 22);
            this.txt_makhachhang.TabIndex = 2;
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(225, 58);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(259, 22);
            this.txt_tenkhachhang.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách hàng";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(25, 117);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(459, 22);
            this.txt_diachi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(25, 193);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(161, 22);
            this.txt_sdt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(201, 193);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(283, 22);
            this.txt_email.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // btn_themkhachhang
            // 
            this.btn_themkhachhang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themkhachhang.Location = new System.Drawing.Point(17, 31);
            this.btn_themkhachhang.Name = "btn_themkhachhang";
            this.btn_themkhachhang.Size = new System.Drawing.Size(208, 49);
            this.btn_themkhachhang.TabIndex = 11;
            this.btn_themkhachhang.Text = "Thêm Khách hàng";
            this.btn_themkhachhang.UseVisualStyleBackColor = true;
            this.btn_themkhachhang.Click += new System.EventHandler(this.btn_themkhachhang_Click);
            // 
            // btn_luukhachhang
            // 
            this.btn_luukhachhang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luukhachhang.Location = new System.Drawing.Point(17, 90);
            this.btn_luukhachhang.Name = "btn_luukhachhang";
            this.btn_luukhachhang.Size = new System.Drawing.Size(208, 49);
            this.btn_luukhachhang.TabIndex = 12;
            this.btn_luukhachhang.Text = "Lưu khách hàng";
            this.btn_luukhachhang.UseVisualStyleBackColor = true;
            this.btn_luukhachhang.Click += new System.EventHandler(this.btn_luukhachhang_Click_1);
            // 
            // btn_suakhachhang
            // 
            this.btn_suakhachhang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suakhachhang.Location = new System.Drawing.Point(240, 32);
            this.btn_suakhachhang.Name = "btn_suakhachhang";
            this.btn_suakhachhang.Size = new System.Drawing.Size(200, 49);
            this.btn_suakhachhang.TabIndex = 13;
            this.btn_suakhachhang.Text = "Sửa khách hàng";
            this.btn_suakhachhang.UseVisualStyleBackColor = true;
            this.btn_suakhachhang.Click += new System.EventHandler(this.btn_suakhachhang_Click_1);
            // 
            // btn_xoakhachhang
            // 
            this.btn_xoakhachhang.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoakhachhang.Location = new System.Drawing.Point(240, 90);
            this.btn_xoakhachhang.Name = "btn_xoakhachhang";
            this.btn_xoakhachhang.Size = new System.Drawing.Size(200, 49);
            this.btn_xoakhachhang.TabIndex = 14;
            this.btn_xoakhachhang.Text = "Xóa khách hàng";
            this.btn_xoakhachhang.UseVisualStyleBackColor = true;
            this.btn_xoakhachhang.Click += new System.EventHandler(this.btn_xoakhachhang_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1018, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel1.Text = "Trang chủ";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_makhachhang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tenkhachhang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 242);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_themkhachhang);
            this.groupBox2.Controls.Add(this.btn_luukhachhang);
            this.groupBox2.Controls.Add(this.btn_suakhachhang);
            this.groupBox2.Controls.Add(this.btn_xoakhachhang);
            this.groupBox2.Location = new System.Drawing.Point(550, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 242);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "hành động";
            // 
            // frmKhachHang
            // 
            this.ClientSize = new System.Drawing.Size(1018, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbl_DSKH);
            this.Name = "frmKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DSKH)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbl_DSKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_makhachhang;
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_themkhachhang;
        private System.Windows.Forms.Button btn_luukhachhang;
        private System.Windows.Forms.Button btn_suakhachhang;
        private System.Windows.Forms.Button btn_xoakhachhang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
