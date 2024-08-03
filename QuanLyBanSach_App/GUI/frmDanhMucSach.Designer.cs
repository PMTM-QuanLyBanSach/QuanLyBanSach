
namespace GUI
{
    partial class frmDanhMucSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucSach));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMain = new System.Windows.Forms.ToolStripButton();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1132, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMain
            // 
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(97, 28);
            this.btnMain.Text = "Trang chủ";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Location = new System.Drawing.Point(43, 217);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(1026, 375);
            this.dgvDanhMuc.TabIndex = 1;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(43, 69);
            this.txtMaDM.Multiline = true;
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(189, 32);
            this.txtMaDM.TabIndex = 4;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(303, 69);
            this.txtTenDM.Multiline = true;
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(235, 32);
            this.txtTenDM.TabIndex = 5;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(631, 69);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(85, 32);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(43, 141);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 35);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(193, 141);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 35);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(337, 141);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 35);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(506, 141);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Tải lại";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên danh mục";
            // 
            // frmDanhMucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtTenDM);
            this.Controls.Add(this.txtMaDM);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDanhMucSach";
            this.Text = "frmDanhMucSach";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMain;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}