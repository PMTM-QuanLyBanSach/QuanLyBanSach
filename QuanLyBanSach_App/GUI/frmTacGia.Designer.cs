
namespace GUI
{
    partial class frmTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMain = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1060, 27);
            this.toolStrip1.TabIndex = 13;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã tác giả";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(485, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 35);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Tải lại";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(316, 138);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 35);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(172, 138);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 35);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 138);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 35);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(610, 66);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(85, 32);
            this.btnLoc.TabIndex = 17;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(282, 66);
            this.txtTenTG.Multiline = true;
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(235, 32);
            this.txtTenTG.TabIndex = 16;
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(22, 66);
            this.txtMaTG.Multiline = true;
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(189, 32);
            this.txtMaTG.TabIndex = 15;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToDeleteRows = false;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Location = new System.Drawing.Point(22, 214);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.RowHeadersWidth = 51;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.Size = new System.Drawing.Size(1026, 375);
            this.dgvTacGia.TabIndex = 14;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 639);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtTenTG);
            this.Controls.Add(this.txtMaTG);
            this.Controls.Add(this.dgvTacGia);
            this.Name = "frmTacGia";
            this.Text = "frmTacGia";
            this.Load += new System.EventHandler(this.frmTacGia_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.DataGridView dgvTacGia;
    }
}