
namespace major_assignment.view
{
    partial class Frm_teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_teacher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnall = new DevComponents.DotNetBar.ButtonX();
            this.bindingNavigatorcancel = new System.Windows.Forms.ToolStripButton();
            this.btntimkiem = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ctxmenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnthem = new DevComponents.DotNetBar.ButtonItem();
            this.btnxoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnluu = new DevComponents.DotNetBar.ButtonItem();
            this.btnthoat = new DevComponents.DotNetBar.ButtonItem();
            this.dgvmh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colmagv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorgv = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorthem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorxoa = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorsave = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorexit = new System.Windows.Forms.ToolStripButton();
            this.btntk = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbtimkiemten = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txttimkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txttengv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmagv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnnhaplieu = new DevComponents.DotNetBar.ButtonItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorgv)).BeginInit();
            this.bindingNavigatorgv.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnall
            // 
            this.btnall.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnall.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnall.Location = new System.Drawing.Point(40, 285);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(144, 24);
            this.btnall.TabIndex = 5;
            this.btnall.Text = "All";
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // bindingNavigatorcancel
            // 
            this.bindingNavigatorcancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorcancel.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorcancel.Image")));
            this.bindingNavigatorcancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorcancel.Name = "bindingNavigatorcancel";
            this.bindingNavigatorcancel.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorcancel.Text = "làm mới";
            this.bindingNavigatorcancel.Click += new System.EventHandler(this.bindingNavigatorcancel_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Checked = true;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btntimkiem.ImagePaddingHorizontal = 8;
            this.btntimkiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.OptionGroup = "navBar";
            this.btntimkiem.Text = "Tìm kiếm dữ liệu ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khóa học ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contextMenuBar1);
            this.groupBox1.Controls.Add(this.dgvmh);
            this.groupBox1.Controls.Add(this.bindingNavigatorgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(294, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 584);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ctxmenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(388, 243);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(75, 33);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar1.TabIndex = 2;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // ctxmenu
            // 
            this.ctxmenu.AutoExpandOnClick = true;
            this.ctxmenu.ImagePaddingHorizontal = 8;
            this.ctxmenu.Name = "ctxmenu";
            this.ctxmenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnthem,
            this.btnxoa,
            this.btnluu,
            this.btnthoat});
            this.ctxmenu.Text = "menu";
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImagePaddingHorizontal = 8;
            this.btnthem.Name = "btnthem";
            this.btnthem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnthem.Text = "Thêm dữ liệu ";
            this.btnthem.Click += new System.EventHandler(this.bindingNavigatorthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImagePaddingHorizontal = 8;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnxoa.Text = "xóa dữ liệu";
            this.btnxoa.Click += new System.EventHandler(this.bindingNavigatorxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImagePaddingHorizontal = 8;
            this.btnluu.Name = "btnluu";
            this.btnluu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnluu.Text = "Lưu dữ liệu ";
            this.btnluu.Click += new System.EventHandler(this.bindingNavigatorsave_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImagePaddingHorizontal = 8;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlW);
            this.btnthoat.Text = "đóng tab hiện tại ";
            this.btnthoat.Click += new System.EventHandler(this.bindingNavigatorexit_Click);
            // 
            // dgvmh
            // 
            this.dgvmh.AllowUserToAddRows = false;
            this.dgvmh.AllowUserToResizeColumns = false;
            this.dgvmh.AllowUserToResizeRows = false;
            this.dgvmh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvmh.ColumnHeadersHeight = 34;
            this.dgvmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvmh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmagv,
            this.coltengv});
            this.contextMenuBar1.SetContextMenuEx(this.dgvmh, this.ctxmenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvmh.Location = new System.Drawing.Point(3, 55);
            this.dgvmh.Name = "dgvmh";
            this.dgvmh.RowHeadersWidth = 62;
            this.dgvmh.RowTemplate.Height = 28;
            this.dgvmh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvmh.Size = new System.Drawing.Size(828, 526);
            this.dgvmh.TabIndex = 1;
            // 
            // colmagv
            // 
            this.colmagv.DataPropertyName = "teacherId";
            this.colmagv.HeaderText = "Mã giáo viên";
            this.colmagv.MinimumWidth = 8;
            this.colmagv.Name = "colmagv";
            this.colmagv.ReadOnly = true;
            this.colmagv.Width = 150;
            // 
            // coltengv
            // 
            this.coltengv.DataPropertyName = "name";
            this.coltengv.HeaderText = "Tên giáo viên";
            this.coltengv.MinimumWidth = 8;
            this.coltengv.Name = "coltengv";
            this.coltengv.Width = 350;
            // 
            // bindingNavigatorgv
            // 
            this.bindingNavigatorgv.AddNewItem = null;
            this.bindingNavigatorgv.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorgv.DeleteItem = null;
            this.bindingNavigatorgv.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorthem,
            this.bindingNavigatorxoa,
            this.bindingNavigatorsave,
            this.bindingNavigatorexit,
            this.bindingNavigatorcancel});
            this.bindingNavigatorgv.Location = new System.Drawing.Point(3, 22);
            this.bindingNavigatorgv.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorgv.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorgv.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorgv.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorgv.Name = "bindingNavigatorgv";
            this.bindingNavigatorgv.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorgv.Size = new System.Drawing.Size(828, 33);
            this.bindingNavigatorgv.TabIndex = 0;
            this.bindingNavigatorgv.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorthem
            // 
            this.bindingNavigatorthem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorthem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorthem.Image")));
            this.bindingNavigatorthem.Name = "bindingNavigatorthem";
            this.bindingNavigatorthem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorthem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorthem.Text = "Add new";
            this.bindingNavigatorthem.Click += new System.EventHandler(this.bindingNavigatorthem_Click);
            // 
            // bindingNavigatorxoa
            // 
            this.bindingNavigatorxoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorxoa.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorxoa.Image")));
            this.bindingNavigatorxoa.Name = "bindingNavigatorxoa";
            this.bindingNavigatorxoa.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorxoa.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorxoa.Text = "Delete";
            this.bindingNavigatorxoa.Click += new System.EventHandler(this.bindingNavigatorxoa_Click);
            // 
            // bindingNavigatorsave
            // 
            this.bindingNavigatorsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorsave.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorsave.Image")));
            this.bindingNavigatorsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorsave.Name = "bindingNavigatorsave";
            this.bindingNavigatorsave.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorsave.Text = "lưu";
            this.bindingNavigatorsave.Click += new System.EventHandler(this.bindingNavigatorsave_Click);
            // 
            // bindingNavigatorexit
            // 
            this.bindingNavigatorexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorexit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorexit.Image")));
            this.bindingNavigatorexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorexit.Name = "bindingNavigatorexit";
            this.bindingNavigatorexit.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorexit.Text = "thoát";
            this.bindingNavigatorexit.Click += new System.EventHandler(this.bindingNavigatorexit_Click);
            // 
            // btntk
            // 
            this.btntk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntk.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btntk.Location = new System.Drawing.Point(40, 227);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(144, 26);
            this.btntk.TabIndex = 4;
            this.btntk.Text = "Search";
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khóa học ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // ckbtimkiemten
            // 
            this.ckbtimkiemten.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbtimkiemten.Checked = true;
            this.ckbtimkiemten.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbtimkiemten.CheckValue = "Y";
            this.ckbtimkiemten.Location = new System.Drawing.Point(25, 140);
            this.ckbtimkiemten.Name = "ckbtimkiemten";
            this.ckbtimkiemten.Size = new System.Drawing.Size(196, 43);
            this.ckbtimkiemten.TabIndex = 3;
            this.ckbtimkiemten.Text = "Tìm kiếm theo tên ";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.btnall);
            this.navigationPanePanel2.Controls.Add(this.btntk);
            this.navigationPanePanel2.Controls.Add(this.ckbtimkiemten);
            this.navigationPanePanel2.Controls.Add(this.txttimkiem);
            this.navigationPanePanel2.Controls.Add(this.labelX3);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btntimkiem;
            this.navigationPanePanel2.Size = new System.Drawing.Size(292, 506);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // txttimkiem
            // 
            // 
            // 
            // 
            this.txttimkiem.Border.Class = "TextBoxBorder";
            this.txttimkiem.Location = new System.Drawing.Point(12, 70);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(196, 26);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.WatermarkText = "Nhập thông tin tim kiếm ";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(12, 14);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(209, 37);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Nhập thông tin tìm kiếm :";
            // 
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnnhaplieu,
            this.btntimkiem});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 52;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(294, 584);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TabIndex = 6;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(292, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navigationPane1.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "Thông tin chi tiết";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.txttengv);
            this.navigationPanePanel1.Controls.Add(this.txtmagv);
            this.navigationPanePanel1.Controls.Add(this.labelX2);
            this.navigationPanePanel1.Controls.Add(this.labelX1);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnnhaplieu;
            this.navigationPanePanel1.Size = new System.Drawing.Size(292, 530);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // txttengv
            // 
            // 
            // 
            // 
            this.txttengv.Border.Class = "TextBoxBorder";
            this.txttengv.Location = new System.Drawing.Point(12, 164);
            this.txttengv.Name = "txttengv";
            this.txttengv.ReadOnly = true;
            this.txttengv.Size = new System.Drawing.Size(209, 26);
            this.txttengv.TabIndex = 3;
            // 
            // txtmagv
            // 
            // 
            // 
            // 
            this.txtmagv.Border.Class = "TextBoxBorder";
            this.txtmagv.Location = new System.Drawing.Point(11, 70);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.ReadOnly = true;
            this.txtmagv.Size = new System.Drawing.Size(210, 26);
            this.txtmagv.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(11, 114);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(186, 32);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên giáo viên";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(11, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(186, 34);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã giáo viên ";
            // 
            // btnnhaplieu
            // 
            this.btnnhaplieu.Image = ((System.Drawing.Image)(resources.GetObject("btnnhaplieu.Image")));
            this.btnnhaplieu.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnnhaplieu.ImagePaddingHorizontal = 8;
            this.btnnhaplieu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnnhaplieu.Name = "btnnhaplieu";
            this.btnnhaplieu.OptionGroup = "navBar";
            this.btnnhaplieu.Text = "Thông tin chi tiết";
            // 
            // Frm_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1128, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_teacher";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_teacher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorgv)).EndInit();
            this.bindingNavigatorgv.ResumeLayout(false);
            this.bindingNavigatorgv.PerformLayout();
            this.navigationPanePanel2.ResumeLayout(false);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnall;
        private System.Windows.Forms.ToolStripButton bindingNavigatorcancel;
        private DevComponents.DotNetBar.ButtonItem btntimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem ctxmenu;
        private DevComponents.DotNetBar.ButtonItem btnthem;
        private DevComponents.DotNetBar.ButtonItem btnxoa;
        private DevComponents.DotNetBar.ButtonItem btnluu;
        private DevComponents.DotNetBar.ButtonItem btnthoat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvmh;
        private System.Windows.Forms.BindingNavigator bindingNavigatorgv;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorthem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorxoa;
        private System.Windows.Forms.ToolStripButton bindingNavigatorsave;
        private System.Windows.Forms.ToolStripButton bindingNavigatorexit;
        private DevComponents.DotNetBar.ButtonX btntk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbtimkiemten;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txttimkiem;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttengv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmagv;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem btnnhaplieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmagv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltengv;
    }
}