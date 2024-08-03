
namespace GUI
{
    partial class frmThemNDVaoNhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNDVaoNhom));
            this.dgvND = new System.Windows.Forms.DataGridView();
            this.dgvNND = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNND = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMain = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNND)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvND
            // 
            this.dgvND.AllowUserToAddRows = false;
            this.dgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvND.Location = new System.Drawing.Point(45, 166);
            this.dgvND.Name = "dgvND";
            this.dgvND.RowHeadersWidth = 51;
            this.dgvND.RowTemplate.Height = 24;
            this.dgvND.Size = new System.Drawing.Size(429, 498);
            this.dgvND.TabIndex = 0;
            // 
            // dgvNND
            // 
            this.dgvNND.AllowUserToAddRows = false;
            this.dgvNND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNND.Location = new System.Drawing.Point(612, 166);
            this.dgvNND.Name = "dgvNND";
            this.dgvNND.RowHeadersWidth = 51;
            this.dgvNND.RowTemplate.Height = 24;
            this.dgvNND.Size = new System.Drawing.Size(595, 498);
            this.dgvNND.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(502, 328);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = ">>";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(502, 382);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhóm người dùng";
            // 
            // cboNND
            // 
            this.cboNND.FormattingEnabled = true;
            this.cboNND.Location = new System.Drawing.Point(790, 86);
            this.cboNND.Name = "cboNND";
            this.cboNND.Size = new System.Drawing.Size(298, 24);
            this.cboNND.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMain});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1244, 31);
            this.toolStrip1.TabIndex = 6;
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
            // frmThemNDVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 737);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboNND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNND);
            this.Controls.Add(this.dgvND);
            this.Name = "frmThemNDVaoNhom";
            this.Text = "frmThemNDVaoNhom";
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNND)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvND;
        private System.Windows.Forms.DataGridView dgvNND;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNND;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMain;
    }
}