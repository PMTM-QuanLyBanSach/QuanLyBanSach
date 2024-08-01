
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
            this.components = new System.ComponentModel.Container();
            this.btnXoaND = new System.Windows.Forms.Button();
            this.btnThemND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qL_NhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.qL_NguoiDungNhomNguoiDung_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungNhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.qL_NguoiDungTableAdapter1 = new DAL.dsQLBSTableAdapters.QL_NguoiDungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaND
            // 
            this.btnXoaND.Location = new System.Drawing.Point(562, 355);
            this.btnXoaND.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaND.Name = "btnXoaND";
            this.btnXoaND.Size = new System.Drawing.Size(100, 28);
            this.btnXoaND.TabIndex = 12;
            this.btnXoaND.Text = "<<<";
            this.btnXoaND.UseVisualStyleBackColor = true;
            // 
            // btnThemND
            // 
            this.btnThemND.Location = new System.Drawing.Point(562, 295);
            this.btnThemND.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemND.Name = "btnThemND";
            this.btnThemND.Size = new System.Drawing.Size(100, 28);
            this.btnThemND.TabIndex = 11;
            this.btnThemND.Text = ">>>";
            this.btnThemND.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhóm người dùng:";
            // 
            // qL_NhomNguoiDungComboBox
            // 
            this.qL_NhomNguoiDungComboBox.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.qL_NhomNguoiDungComboBox.DisplayMember = "TenNhom";
            this.qL_NhomNguoiDungComboBox.FormattingEnabled = true;
            this.qL_NhomNguoiDungComboBox.Location = new System.Drawing.Point(825, 128);
            this.qL_NhomNguoiDungComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.qL_NhomNguoiDungComboBox.Name = "qL_NhomNguoiDungComboBox";
            this.qL_NhomNguoiDungComboBox.Size = new System.Drawing.Size(175, 24);
            this.qL_NhomNguoiDungComboBox.TabIndex = 9;
            this.qL_NhomNguoiDungComboBox.ValueMember = "MaNhom";
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            // 
            // qL_NguoiDungNhomNguoiDung_DKDataGridView
            // 
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.DataSource = this.qL_NguoiDungNhomNguoiDung_DKBindingSource;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Location = new System.Drawing.Point(685, 200);
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Name = "qL_NguoiDungNhomNguoiDung_DKDataGridView";
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.Size = new System.Drawing.Size(461, 271);
            this.qL_NguoiDungNhomNguoiDung_DKDataGridView.TabIndex = 8;
            // 
            // qL_NguoiDungNhomNguoiDung_DKBindingSource
            // 
            this.qL_NguoiDungNhomNguoiDung_DKBindingSource.DataMember = "QL_NguoiDungNhomNguoiDung_DK";
            // 
            // qL_NguoiDungBindingSource
            // 
            this.qL_NguoiDungBindingSource.DataMember = "QL_NguoiDung";
            // 
            // qL_NguoiDungNhomNguoiDungBindingSource
            // 
            this.qL_NguoiDungNhomNguoiDungBindingSource.DataMember = "QL_NguoiDungNhomNguoiDung";
            // 
            // qL_NguoiDungDataGridView
            // 
            this.qL_NguoiDungDataGridView.AutoGenerateColumns = false;
            this.qL_NguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NguoiDungDataGridView.DataSource = this.qL_NguoiDungBindingSource;
            this.qL_NguoiDungDataGridView.Location = new System.Drawing.Point(74, 200);
            this.qL_NguoiDungDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.qL_NguoiDungDataGridView.Name = "qL_NguoiDungDataGridView";
            this.qL_NguoiDungDataGridView.RowHeadersWidth = 51;
            this.qL_NguoiDungDataGridView.Size = new System.Drawing.Size(459, 271);
            this.qL_NguoiDungDataGridView.TabIndex = 7;
            // 
            // qL_NguoiDungTableAdapter1
            // 
            this.qL_NguoiDungTableAdapter1.ClearBeforeFill = true;
            // 
            // frmThemNDVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 642);
            this.Controls.Add(this.btnXoaND);
            this.Controls.Add(this.btnThemND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qL_NhomNguoiDungComboBox);
            this.Controls.Add(this.qL_NguoiDungNhomNguoiDung_DKDataGridView);
            this.Controls.Add(this.qL_NguoiDungDataGridView);
            this.Name = "frmThemNDVaoNhom";
            this.Text = "frmThemNDVaoNhom";
            this.Load += new System.EventHandler(this.FrmThemNDVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDung_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungNhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NguoiDungDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaND;
        private System.Windows.Forms.Button btnThemND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox qL_NhomNguoiDungComboBox;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private System.Windows.Forms.DataGridView qL_NguoiDungNhomNguoiDung_DKDataGridView;
        private System.Windows.Forms.BindingSource qL_NguoiDungNhomNguoiDung_DKBindingSource;
        private System.Windows.Forms.BindingSource qL_NguoiDungBindingSource;
        private System.Windows.Forms.BindingSource qL_NguoiDungNhomNguoiDungBindingSource;
        private System.Windows.Forms.DataGridView qL_NguoiDungDataGridView;
        private DAL.dsQLBSTableAdapters.QL_NguoiDungTableAdapter qL_NguoiDungTableAdapter1;
    }
}