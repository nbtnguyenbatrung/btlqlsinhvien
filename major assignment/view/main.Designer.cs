
namespace major_assignment.view
{
    partial class main
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
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoaToolStripMenuItem,
            this.mônHọcToolStripMenuItem,
            this.giáoViênToolStripMenuItem,
            this.họcViênToolStripMenuItem,
            this.đăngKýHọcToolStripMenuItem,
            this.điểmThiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.khoaToolStripMenuItem.Text = "khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.mônHọcToolStripMenuItem.Text = "môn học";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // giáoViênToolStripMenuItem
            // 
            this.giáoViênToolStripMenuItem.Name = "giáoViênToolStripMenuItem";
            this.giáoViênToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.giáoViênToolStripMenuItem.Text = "giáo viên";
            this.giáoViênToolStripMenuItem.Click += new System.EventHandler(this.giáoViênToolStripMenuItem_Click);
            // 
            // họcViênToolStripMenuItem
            // 
            this.họcViênToolStripMenuItem.Name = "họcViênToolStripMenuItem";
            this.họcViênToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.họcViênToolStripMenuItem.Text = "học viên";
            this.họcViênToolStripMenuItem.Click += new System.EventHandler(this.họcViênToolStripMenuItem_Click);
            // 
            // đăngKýHọcToolStripMenuItem
            // 
            this.đăngKýHọcToolStripMenuItem.Name = "đăngKýHọcToolStripMenuItem";
            this.đăngKýHọcToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.đăngKýHọcToolStripMenuItem.Text = "đăng ký học";
            this.đăngKýHọcToolStripMenuItem.Click += new System.EventHandler(this.đăngKýHọcToolStripMenuItem_Click);
            // 
            // điểmThiToolStripMenuItem
            // 
            this.điểmThiToolStripMenuItem.Name = "điểmThiToolStripMenuItem";
            this.điểmThiToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.điểmThiToolStripMenuItem.Text = "điểm thi";
            this.điểmThiToolStripMenuItem.Click += new System.EventHandler(this.điểmThiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 417);
            this.panel1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmThiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}