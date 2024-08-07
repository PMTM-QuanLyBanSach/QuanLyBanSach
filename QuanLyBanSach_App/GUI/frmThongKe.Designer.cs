
namespace GUI
{
    partial class frmThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_donhang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donhang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(399, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // cbo_thang
            // 
            this.cbo_thang.FormattingEnabled = true;
            this.cbo_thang.Location = new System.Drawing.Point(17, 109);
            this.cbo_thang.Name = "cbo_thang";
            this.cbo_thang.Size = new System.Drawing.Size(238, 24);
            this.cbo_thang.TabIndex = 1;
            this.cbo_thang.SelectedIndexChanged += new System.EventHandler(this.cbo_thang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Theo Tháng";
            // 
            // dgv_donhang
            // 
            this.dgv_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_donhang.Location = new System.Drawing.Point(302, 95);
            this.dgv_donhang.Name = "dgv_donhang";
            this.dgv_donhang.RowHeadersWidth = 51;
            this.dgv_donhang.RowTemplate.Height = 24;
            this.dgv_donhang.Size = new System.Drawing.Size(668, 392);
            this.dgv_donhang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(11, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng doanh thu: ";
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongtien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_tongtien.Location = new System.Drawing.Point(12, 214);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(87, 29);
            this.lbl_tongtien.TabIndex = 5;
            this.lbl_tongtien.Text = "0 VND";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 28);
            this.toolStripLabel1.Text = "Trang chủ";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // frmThongKe
            // 
            this.ClientSize = new System.Drawing.Size(982, 499);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_donhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_thang);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donhang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_donhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
