
namespace GUI
{
    partial class frmManHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMain = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.dgvManHinh = new System.Windows.Forms.DataGridView();
            this.txtTMH = new System.Windows.Forms.TextBox();
            this.txtMMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMain,
            this.btnThem,
            this.btnXoa,
            this.btnSua});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(999, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMain
            // 
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(97, 24);
            this.btnMain.Text = "Trang chủ";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 24);
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 24);
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 24);
            this.btnSua.Text = "Sửa";
            // 
            // dgvManHinh
            // 
            this.dgvManHinh.AllowUserToAddRows = false;
            this.dgvManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManHinh.Location = new System.Drawing.Point(100, 172);
            this.dgvManHinh.Name = "dgvManHinh";
            this.dgvManHinh.RowHeadersWidth = 51;
            this.dgvManHinh.RowTemplate.Height = 24;
            this.dgvManHinh.Size = new System.Drawing.Size(797, 507);
            this.dgvManHinh.TabIndex = 6;
            // 
            // txtTMH
            // 
            this.txtTMH.Location = new System.Drawing.Point(328, 107);
            this.txtTMH.Name = "txtTMH";
            this.txtTMH.Size = new System.Drawing.Size(319, 22);
            this.txtTMH.TabIndex = 11;
            // 
            // txtMMH
            // 
            this.txtMMH.Location = new System.Drawing.Point(328, 59);
            this.txtMMH.Name = "txtMMH";
            this.txtMMH.Size = new System.Drawing.Size(319, 22);
            this.txtMMH.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên màn hình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã màn hình";
            // 
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 688);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvManHinh);
            this.Controls.Add(this.txtTMH);
            this.Controls.Add(this.txtMMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmManHinh";
            this.Text = "frmManHinh";
            this.Load += new System.EventHandler(this.frmManHinh_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMain;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.DataGridView dgvManHinh;
        private System.Windows.Forms.TextBox txtTMH;
        private System.Windows.Forms.TextBox txtMMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}