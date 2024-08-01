
namespace GUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómNgườiDùngdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiDùngVàoNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.nhómNgườiDùngdToolStripMenuItem,
            this.mànHìnhToolStripMenuItem,
            this.thêmNgườiDùngVàoNhómToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            this.ngườiDùngToolStripMenuItem.Click += new System.EventHandler(this.ngườiDùngToolStripMenuItem_Click);
            // 
            // nhómNgườiDùngdToolStripMenuItem
            // 
            this.nhómNgườiDùngdToolStripMenuItem.Name = "nhómNgườiDùngdToolStripMenuItem";
            this.nhómNgườiDùngdToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.nhómNgườiDùngdToolStripMenuItem.Text = "Nhóm người dùng";
            this.nhómNgườiDùngdToolStripMenuItem.Click += new System.EventHandler(this.nhómNgườiDùngToolStripMenuItem_Click);
            // 
            // mànHìnhToolStripMenuItem
            // 
            this.mànHìnhToolStripMenuItem.Name = "mànHìnhToolStripMenuItem";
            this.mànHìnhToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.mànHìnhToolStripMenuItem.Text = "Màn hình";
            this.mànHìnhToolStripMenuItem.Click += new System.EventHandler(this.mànHìnhToolStripMenuItem_Click);
            // 
            // thêmNgườiDùngVàoNhómToolStripMenuItem
            // 
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Name = "thêmNgườiDùngVàoNhómToolStripMenuItem";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Text = "Thêm người dùng vào nhóm";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Click += new System.EventHandler(this.thêmNgườiDùngVàoNhómToolStripMenuItem_Click);
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            this.phânQuyềnToolStripMenuItem.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómNgườiDùngdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mànHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDùngVàoNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
    }
}