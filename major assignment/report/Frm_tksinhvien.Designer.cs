﻿
namespace major_assignment.report
{
    partial class Frm_tksinhvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_tksinhvien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnxuat = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorexit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorrefresh = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.ctxmenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnrefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnimportexcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnexportexcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnsave = new DevComponents.DotNetBar.ButtonItem();
            this.btnthoat = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbkhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxkhoa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtnamesv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbxtensv = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btntk = new DevComponents.DotNetBar.ButtonX();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.dgvoutdate = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bindingNavigatoroutdate = new System.Windows.Forms.BindingNavigator(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvoutdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatoroutdate)).BeginInit();
            this.bindingNavigatoroutdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnxuat
            // 
            this.btnxuat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnxuat.Image = ((System.Drawing.Image)(resources.GetObject("btnxuat.Image")));
            this.btnxuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(34, 33);
            this.btnxuat.Text = "xuất phiếu";
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // bindingNavigatorexit
            // 
            this.bindingNavigatorexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorexit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorexit.Image")));
            this.bindingNavigatorexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorexit.Name = "bindingNavigatorexit";
            this.bindingNavigatorexit.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorexit.Text = "exit";
            this.bindingNavigatorexit.Click += new System.EventHandler(this.bindingNavigatorexit_Click);
            // 
            // bindingNavigatorrefresh
            // 
            this.bindingNavigatorrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorrefresh.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorrefresh.Image")));
            this.bindingNavigatorrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorrefresh.Name = "bindingNavigatorrefresh";
            this.bindingNavigatorrefresh.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorrefresh.Text = "Làm mới dữ liệu ";
            this.bindingNavigatorrefresh.Click += new System.EventHandler(this.bindingNavigatorrefresh_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // ctxmenu
            // 
            this.ctxmenu.AutoExpandOnClick = true;
            this.ctxmenu.ImagePaddingHorizontal = 8;
            this.ctxmenu.Name = "ctxmenu";
            this.ctxmenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnrefresh,
            this.btnimportexcel,
            this.btnexportexcel,
            this.btnsave,
            this.btnthoat});
            this.ctxmenu.Text = "Menu";
            // 
            // btnrefresh
            // 
            this.btnrefresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImagePaddingHorizontal = 8;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnrefresh.Text = "làm mới dữ liệu ";
            // 
            // btnimportexcel
            // 
            this.btnimportexcel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnimportexcel.ImagePaddingHorizontal = 8;
            this.btnimportexcel.Name = "btnimportexcel";
            this.btnimportexcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
            this.btnimportexcel.Text = "import excel";
            // 
            // btnexportexcel
            // 
            this.btnexportexcel.ImagePaddingHorizontal = 8;
            this.btnexportexcel.Name = "btnexportexcel";
            this.btnexportexcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlE);
            this.btnexportexcel.Text = "export excel ";
            // 
            // btnsave
            // 
            this.btnsave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImagePaddingHorizontal = 8;
            this.btnsave.Name = "btnsave";
            this.btnsave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnsave.Text = "lưu dữ liệu ";
            // 
            // btnthoat
            // 
            this.btnthoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImagePaddingHorizontal = 8;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlW);
            this.btnthoat.Text = "thoát";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmbkhoa);
            this.groupPanel1.Controls.Add(this.cbxkhoa);
            this.groupPanel1.Controls.Add(this.txtnamesv);
            this.groupPanel1.Controls.Add(this.cbxtensv);
            this.groupPanel1.Controls.Add(this.btntk);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1123, 139);
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
            this.groupPanel1.TabIndex = 16;
            this.groupPanel1.Text = "Danh sách sách được mượn quá han";
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.DisplayMember = "Text";
            this.cmbkhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.ItemHeight = 20;
            this.cmbkhoa.Location = new System.Drawing.Point(449, 69);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(200, 26);
            this.cmbkhoa.TabIndex = 18;
            // 
            // cbxkhoa
            // 
            this.cbxkhoa.BackColor = System.Drawing.Color.Transparent;
            this.cbxkhoa.Location = new System.Drawing.Point(311, 69);
            this.cbxkhoa.Name = "cbxkhoa";
            this.cbxkhoa.Size = new System.Drawing.Size(112, 29);
            this.cbxkhoa.TabIndex = 17;
            this.cbxkhoa.Text = "Tên khoa :";
            // 
            // txtnamesv
            // 
            // 
            // 
            // 
            this.txtnamesv.Border.Class = "TextBoxBorder";
            this.txtnamesv.Location = new System.Drawing.Point(449, 27);
            this.txtnamesv.Name = "txtnamesv";
            this.txtnamesv.Size = new System.Drawing.Size(196, 26);
            this.txtnamesv.TabIndex = 16;
            this.txtnamesv.WatermarkText = "Nhập thông tin tim kiếm ";
            // 
            // cbxtensv
            // 
            this.cbxtensv.BackColor = System.Drawing.Color.Transparent;
            this.cbxtensv.Checked = true;
            this.cbxtensv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxtensv.CheckValue = "Y";
            this.cbxtensv.Location = new System.Drawing.Point(311, 24);
            this.cbxtensv.Name = "cbxtensv";
            this.cbxtensv.Size = new System.Drawing.Size(112, 29);
            this.cbxtensv.TabIndex = 15;
            this.cbxtensv.Text = "Tên độc giả :";
            // 
            // btntk
            // 
            this.btntk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntk.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btntk.Location = new System.Drawing.Point(718, 50);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(138, 26);
            this.btntk.TabIndex = 13;
            this.btntk.Text = "Tìm Kiếm";
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ctxmenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(177, 236);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(75, 33);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar1.TabIndex = 19;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // dgvoutdate
            // 
            this.dgvoutdate.AllowUserToAddRows = false;
            this.dgvoutdate.AllowUserToResizeRows = false;
            this.dgvoutdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvoutdate.BackgroundColor = System.Drawing.Color.White;
            this.dgvoutdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvoutdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.name});
            this.contextMenuBar1.SetContextMenuEx(this.dgvoutdate, this.ctxmenu);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvoutdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvoutdate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvoutdate.Location = new System.Drawing.Point(0, 178);
            this.dgvoutdate.Name = "dgvoutdate";
            this.dgvoutdate.RowHeadersWidth = 62;
            this.dgvoutdate.RowTemplate.Height = 28;
            this.dgvoutdate.Size = new System.Drawing.Size(1123, 344);
            this.dgvoutdate.TabIndex = 18;
            // 
            // bindingNavigatoroutdate
            // 
            this.bindingNavigatoroutdate.AddNewItem = null;
            this.bindingNavigatoroutdate.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatoroutdate.DeleteItem = null;
            this.bindingNavigatoroutdate.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatoroutdate.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatoroutdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorrefresh,
            this.bindingNavigatorexit,
            this.btnxuat});
            this.bindingNavigatoroutdate.Location = new System.Drawing.Point(9, 142);
            this.bindingNavigatoroutdate.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatoroutdate.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatoroutdate.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatoroutdate.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatoroutdate.Name = "bindingNavigatoroutdate";
            this.bindingNavigatoroutdate.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatoroutdate.Size = new System.Drawing.Size(382, 38);
            this.bindingNavigatoroutdate.TabIndex = 17;
            this.bindingNavigatoroutdate.Text = "bindingNavigator1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học viên ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên học viên ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "point";
            this.dataGridViewTextBoxColumn6.HeaderText = "Điểm thi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIEMNGHE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Điểm nghe ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIEMTONG";
            this.dataGridViewTextBoxColumn5.HeaderText = "Điểm tổng ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIEMDOC";
            this.dataGridViewTextBoxColumn4.HeaderText = "Điểm đọc ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // studentId
            // 
            this.studentId.DataPropertyName = "studentId";
            this.studentId.HeaderText = "Mã sinh viên";
            this.studentId.MinimumWidth = 8;
            this.studentId.Name = "studentId";
            this.studentId.ReadOnly = true;
            this.studentId.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên sinh viên";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // Frm_tksinhvien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1123, 522);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.bindingNavigatoroutdate);
            this.Controls.Add(this.dgvoutdate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_tksinhvien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xuất điểm sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_tksinhvien_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvoutdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatoroutdate)).EndInit();
            this.bindingNavigatoroutdate.ResumeLayout(false);
            this.bindingNavigatoroutdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripButton btnxuat;
        private System.Windows.Forms.ToolStripButton bindingNavigatorexit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorrefresh;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem ctxmenu;
        private DevComponents.DotNetBar.ButtonItem btnrefresh;
        private DevComponents.DotNetBar.ButtonItem btnimportexcel;
        private DevComponents.DotNetBar.ButtonItem btnexportexcel;
        private DevComponents.DotNetBar.ButtonItem btnsave;
        private DevComponents.DotNetBar.ButtonItem btnthoat;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnamesv;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxtensv;
        private DevComponents.DotNetBar.ButtonX btntk;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvoutdate;
        private System.Windows.Forms.BindingNavigator bindingNavigatoroutdate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxkhoa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}