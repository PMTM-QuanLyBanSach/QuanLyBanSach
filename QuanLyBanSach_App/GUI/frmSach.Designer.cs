
namespace GUI
{
    partial class frmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMain = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTenSH = new System.Windows.Forms.TextBox();
            this.txtMaSH = new System.Windows.Forms.TextBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDM = new System.Windows.Forms.ComboBox();
            this.cboTon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTG = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSLK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGB = new System.Windows.Forms.TextBox();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1175, 27);
            this.toolStrip1.TabIndex = 24;
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
            this.label2.Location = new System.Drawing.Point(313, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã sách";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(485, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 35);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Tải lại";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(316, 203);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 35);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(172, 203);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 35);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 203);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 35);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(955, 204);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(85, 34);
            this.btnLoc.TabIndex = 28;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // txtTenSH
            // 
            this.txtTenSH.Location = new System.Drawing.Point(316, 62);
            this.txtTenSH.Multiline = true;
            this.txtTenSH.Name = "txtTenSH";
            this.txtTenSH.Size = new System.Drawing.Size(235, 32);
            this.txtTenSH.TabIndex = 27;
            // 
            // txtMaSH
            // 
            this.txtMaSH.Location = new System.Drawing.Point(122, 62);
            this.txtMaSH.Multiline = true;
            this.txtMaSH.Name = "txtMaSH";
            this.txtMaSH.Size = new System.Drawing.Size(109, 32);
            this.txtMaSH.TabIndex = 26;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(22, 279);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(1115, 375);
            this.dgvSach.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Danh mục";
            // 
            // cboDM
            // 
            this.cboDM.FormattingEnabled = true;
            this.cboDM.Location = new System.Drawing.Point(619, 62);
            this.cboDM.Name = "cboDM";
            this.cboDM.Size = new System.Drawing.Size(190, 24);
            this.cboDM.TabIndex = 36;
            // 
            // cboTon
            // 
            this.cboTon.FormattingEnabled = true;
            this.cboTon.Location = new System.Drawing.Point(716, 209);
            this.cboTon.Name = "cboTon";
            this.cboTon.Size = new System.Drawing.Size(190, 24);
            this.cboTon.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tồn";
            // 
            // cboTG
            // 
            this.cboTG.FormattingEnabled = true;
            this.cboTG.Location = new System.Drawing.Point(887, 62);
            this.cboTG.Name = "cboTG";
            this.cboTG.Size = new System.Drawing.Size(190, 24);
            this.cboTG.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(884, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tác giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Số lượng kho";
            // 
            // txtSLK
            // 
            this.txtSLK.Location = new System.Drawing.Point(122, 137);
            this.txtSLK.Multiline = true;
            this.txtSLK.Name = "txtSLK";
            this.txtSLK.Size = new System.Drawing.Size(235, 32);
            this.txtSLK.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Giá bán";
            // 
            // txtGB
            // 
            this.txtGB.Location = new System.Drawing.Point(416, 137);
            this.txtGB.Multiline = true;
            this.txtGB.Name = "txtGB";
            this.txtGB.Size = new System.Drawing.Size(109, 32);
            this.txtGB.TabIndex = 43;
            // 
            // btnThemDM
            // 
            this.btnThemDM.Location = new System.Drawing.Point(619, 111);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(127, 32);
            this.btnThemDM.TabIndex = 45;
            this.btnThemDM.Text = "Thêm danh mục";
            this.btnThemDM.UseVisualStyleBackColor = true;
            // 
            // btnThemTG
            // 
            this.btnThemTG.Location = new System.Drawing.Point(887, 111);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(106, 32);
            this.btnThemTG.TabIndex = 46;
            this.btnThemTG.Text = "Thêm tác giả";
            this.btnThemTG.UseVisualStyleBackColor = true;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 718);
            this.Controls.Add(this.btnThemTG);
            this.Controls.Add(this.btnThemDM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSLK);
            this.Controls.Add(this.cboTG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.txtTenSH);
            this.Controls.Add(this.txtMaSH);
            this.Controls.Add(this.dgvSach);
            this.Name = "frmSach";
            this.Text = "frmSach";
            this.Load += new System.EventHandler(this.frmSach_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
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
        private System.Windows.Forms.TextBox txtTenSH;
        private System.Windows.Forms.TextBox txtMaSH;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDM;
        private System.Windows.Forms.ComboBox cboTon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSLK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGB;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnThemTG;
    }
}