
namespace GUI
{
    partial class frmPhanQuyen
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvNND = new System.Windows.Forms.DataGridView();
            this.dgvPQ = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPQ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(30, 24);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 43);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // dgvNND
            // 
            this.dgvNND.AllowUserToAddRows = false;
            this.dgvNND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNND.Location = new System.Drawing.Point(30, 159);
            this.dgvNND.Name = "dgvNND";
            this.dgvNND.RowHeadersWidth = 51;
            this.dgvNND.RowTemplate.Height = 24;
            this.dgvNND.Size = new System.Drawing.Size(479, 500);
            this.dgvNND.TabIndex = 1;
            // 
            // dgvPQ
            // 
            this.dgvPQ.AllowUserToAddRows = false;
            this.dgvPQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPQ.Location = new System.Drawing.Point(629, 159);
            this.dgvPQ.Name = "dgvPQ";
            this.dgvPQ.RowHeadersWidth = 51;
            this.dgvPQ.RowTemplate.Height = 24;
            this.dgvPQ.Size = new System.Drawing.Size(606, 500);
            this.dgvPQ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách quyền chức năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách nhóm người dùng";
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPQ);
            this.Controls.Add(this.dgvNND);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvNND;
        private System.Windows.Forms.DataGridView dgvPQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}