﻿
namespace major_assignment.view
{
    partial class Frm_policy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_policy));
            this.btnchuyen = new DevComponents.DotNetBar.ButtonX();
            this.cbxkhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ckbtkkhoa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btntk = new DevComponents.DotNetBar.ButtonX();
            this.btnall = new DevComponents.DotNetBar.ButtonX();
            this.txttimten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttimma = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ckbtimten = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckbtimma = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.colhotencu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmasvcu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.lvchuaphan = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.btnluu = new DevComponents.DotNetBar.ButtonX();
            this.lvphan = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colmasvmoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhotenmoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnchuyen
            // 
            this.btnchuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnchuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnchuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnchuyen.Image")));
            this.btnchuyen.Location = new System.Drawing.Point(19, 208);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(75, 75);
            this.btnchuyen.TabIndex = 0;
            this.btnchuyen.Tooltip = "xếp lớp ";
            this.btnchuyen.Click += new System.EventHandler(this.btnchuyen_Click);
            // 
            // cbxkhoa
            // 
            this.cbxkhoa.DisplayMember = "Text";
            this.cbxkhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxkhoa.FormattingEnabled = true;
            this.cbxkhoa.ItemHeight = 20;
            this.cbxkhoa.Location = new System.Drawing.Point(245, 77);
            this.cbxkhoa.Name = "cbxkhoa";
            this.cbxkhoa.Size = new System.Drawing.Size(186, 26);
            this.cbxkhoa.TabIndex = 14;
            this.cbxkhoa.WatermarkText = "--chọn khoa";
            // 
            // ckbtkkhoa
            // 
            this.ckbtkkhoa.BackColor = System.Drawing.Color.Transparent;
            this.ckbtkkhoa.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbtkkhoa.Location = new System.Drawing.Point(28, 77);
            this.ckbtkkhoa.Name = "ckbtkkhoa";
            this.ckbtkkhoa.Size = new System.Drawing.Size(182, 32);
            this.ckbtkkhoa.TabIndex = 13;
            this.ckbtkkhoa.Text = "Lọc theo khoa :";
            // 
            // btntk
            // 
            this.btntk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntk.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btntk.Location = new System.Drawing.Point(83, 115);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(138, 26);
            this.btntk.TabIndex = 12;
            this.btntk.Text = "Tìm Kiếm";
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btnall
            // 
            this.btnall.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnall.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnall.Location = new System.Drawing.Point(266, 115);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(135, 30);
            this.btnall.TabIndex = 11;
            this.btnall.Text = "Hiển thị toàn bộ";
            this.btnall.Click += new System.EventHandler(this.btnall_Click_1);
            // 
            // txttimten
            // 
            // 
            // 
            // 
            this.txttimten.Border.Class = "TextBoxBorder";
            this.txttimten.Location = new System.Drawing.Point(245, 44);
            this.txttimten.Name = "txttimten";
            this.txttimten.Size = new System.Drawing.Size(186, 26);
            this.txttimten.TabIndex = 9;
            this.txttimten.WatermarkText = "Nhập tên cần tìm ";
            // 
            // txttimma
            // 
            // 
            // 
            // 
            this.txttimma.Border.Class = "TextBoxBorder";
            this.txttimma.Location = new System.Drawing.Point(245, 12);
            this.txttimma.Name = "txttimma";
            this.txttimma.Size = new System.Drawing.Size(186, 26);
            this.txttimma.TabIndex = 8;
            this.txttimma.WatermarkText = "Nhập mã cần tìm ";
            // 
            // ckbtimten
            // 
            this.ckbtimten.BackColor = System.Drawing.Color.Transparent;
            this.ckbtimten.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbtimten.Location = new System.Drawing.Point(28, 44);
            this.ckbtimten.Name = "ckbtimten";
            this.ckbtimten.Size = new System.Drawing.Size(182, 32);
            this.ckbtimten.TabIndex = 7;
            this.ckbtimten.Text = "Tìm kiếm theo tên hv :";
            // 
            // ckbtimma
            // 
            this.ckbtimma.BackColor = System.Drawing.Color.Transparent;
            this.ckbtimma.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbtimma.Checked = true;
            this.ckbtimma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbtimma.CheckValue = "Y";
            this.ckbtimma.Location = new System.Drawing.Point(28, 12);
            this.ckbtimma.Name = "ckbtimma";
            this.ckbtimma.Size = new System.Drawing.Size(158, 26);
            this.ckbtimma.TabIndex = 6;
            this.ckbtimma.Text = "Tìm kiếm mã hv :";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cbxkhoa);
            this.groupPanel1.Controls.Add(this.ckbtkkhoa);
            this.groupPanel1.Controls.Add(this.btntk);
            this.groupPanel1.Controls.Add(this.btnall);
            this.groupPanel1.Controls.Add(this.txttimten);
            this.groupPanel1.Controls.Add(this.txttimma);
            this.groupPanel1.Controls.Add(this.ckbtimten);
            this.groupPanel1.Controls.Add(this.ckbtimma);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(857, 185);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Tìm kiếm  ";
            // 
            // colhotencu
            // 
            this.colhotencu.Text = "Họ và tên ";
            this.colhotencu.Width = 150;
            // 
            // colmasvcu
            // 
            this.colmasvcu.Text = "Mã sinh viên ";
            this.colmasvcu.Width = 220;
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(19, 323);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 72);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Tooltip = "xóa khỏi lớp ";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // lvchuaphan
            // 
            // 
            // 
            // 
            this.lvchuaphan.Border.Class = "ListViewBorder";
            this.lvchuaphan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmasvcu,
            this.colhotencu});
            this.lvchuaphan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvchuaphan.FullRowSelect = true;
            this.lvchuaphan.GridLines = true;
            this.lvchuaphan.Location = new System.Drawing.Point(0, 185);
            this.lvchuaphan.Name = "lvchuaphan";
            this.lvchuaphan.Size = new System.Drawing.Size(857, 441);
            this.lvchuaphan.SmallImageList = this.imageList1;
            this.lvchuaphan.TabIndex = 2;
            this.lvchuaphan.UseCompatibleStateImageBehavior = false;
            this.lvchuaphan.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvphan);
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 626);
            this.splitContainer1.SplitterDistance = 962;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvchuaphan);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 626);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 185);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnchuyen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(857, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 626);
            this.panel2.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(19, 525);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 69);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Tooltip = "Đóng tab ";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(19, 430);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 72);
            this.btnluu.TabIndex = 2;
            this.btnluu.Tooltip = "Lưu dữ liệu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // lvphan
            // 
            // 
            // 
            // 
            this.lvphan.Border.Class = "ListViewBorder";
            this.lvphan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmasvmoi,
            this.colhotenmoi});
            this.lvphan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvphan.FullRowSelect = true;
            this.lvphan.GridLines = true;
            this.lvphan.Location = new System.Drawing.Point(0, 185);
            this.lvphan.Name = "lvphan";
            this.lvphan.Size = new System.Drawing.Size(958, 441);
            this.lvphan.SmallImageList = this.imageList1;
            this.lvphan.TabIndex = 1;
            this.lvphan.UseCompatibleStateImageBehavior = false;
            this.lvphan.View = System.Windows.Forms.View.Details;
            // 
            // colmasvmoi
            // 
            this.colmasvmoi.Text = "Mã sinh viên";
            this.colmasvmoi.Width = 244;
            // 
            // colhotenmoi
            // 
            this.colhotenmoi.Text = "Họ và tên ";
            this.colhotenmoi.Width = 150;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(958, 185);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "Thông tin sinh viên diện chính sách và ưu tiên";
            // 
            // Frm_policy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 626);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_policy";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diện chính sách ưu tiên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_policy_Load);
            this.groupPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnchuyen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxkhoa;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbtkkhoa;
        private DevComponents.DotNetBar.ButtonX btntk;
        private DevComponents.DotNetBar.ButtonX btnall;
        private DevComponents.DotNetBar.Controls.TextBoxX txttimten;
        private DevComponents.DotNetBar.Controls.TextBoxX txttimma;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbtimten;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbtimma;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.ColumnHeader colhotencu;
        private System.Windows.Forms.ColumnHeader colmasvcu;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.Controls.ListViewEx lvchuaphan;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private DevComponents.DotNetBar.ButtonX btnluu;
        private DevComponents.DotNetBar.Controls.ListViewEx lvphan;
        private System.Windows.Forms.ColumnHeader colmasvmoi;
        private System.Windows.Forms.ColumnHeader colhotenmoi;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}