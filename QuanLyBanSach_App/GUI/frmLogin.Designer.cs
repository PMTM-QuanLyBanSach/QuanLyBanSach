
namespace GUI
{
    partial class frmLogin
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labPass = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(217, 171);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 28);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(84, 171);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(105, 28);
            this.btnDN.TabIndex = 10;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(84, 124);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(207, 22);
            this.txtPass.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(84, 56);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 22);
            this.txtUsername.TabIndex = 8;
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Location = new System.Drawing.Point(80, 105);
            this.labPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(68, 17);
            this.labPass.TabIndex = 7;
            this.labPass.Text = "Mật Khẩu";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Location = new System.Drawing.Point(80, 36);
            this.labUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(112, 17);
            this.labUsername.TabIndex = 6;
            this.labUsername.Text = "Tên Người Dùng";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 293);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labUsername);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Label labUsername;
    }
}