
namespace GUI
{
    partial class frmQL_NhanVien
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
            this.dgv_listNV = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listNV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_listNV
            // 
            this.dgv_listNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listNV.Location = new System.Drawing.Point(532, 12);
            this.dgv_listNV.Name = "dgv_listNV";
            this.dgv_listNV.RowHeadersWidth = 51;
            this.dgv_listNV.RowTemplate.Height = 24;
            this.dgv_listNV.Size = new System.Drawing.Size(474, 595);
            this.dgv_listNV.TabIndex = 0;
            this.dgv_listNV.SelectionChanged += new System.EventHandler(this.dgv_listNV_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1018, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel1.Text = "Trang chủ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = " Mã nhân viên";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(15, 74);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(462, 22);
            this.txt_manv.TabIndex = 3;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(15, 150);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(462, 22);
            this.txt_tennv.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = " Tên nhân viên";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(15, 224);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(462, 22);
            this.txt_sdt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = " Số điện thoại ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(15, 305);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(462, 22);
            this.txt_diachi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = " Địa chỉ";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(15, 369);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(462, 22);
            this.txt_email.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = " Email";
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Location = new System.Drawing.Point(15, 430);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Size = new System.Drawing.Size(462, 22);
            this.txt_chucvu.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chức vụ";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(62, 486);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(146, 48);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = " Thêm mới";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(286, 486);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(146, 48);
            this.btn_luu.TabIndex = 15;
            this.btn_luu.Text = " Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(65, 549);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(146, 48);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = " Sửa ";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(286, 549);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(146, 48);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = " Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // frmQL_NhanVien
            // 
            this.ClientSize = new System.Drawing.Size(1018, 619);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_chucvu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_listNV);
            this.Name = "frmQL_NhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQL_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listNV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listNV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
    }
}
