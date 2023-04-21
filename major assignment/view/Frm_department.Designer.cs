
namespace major_assignment.view
{
    partial class Frm_department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_department));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnxoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnthoat = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorkhoa = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorcancel = new System.Windows.Forms.ToolStripButton();
            this.btnluu = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new DevComponents.DotNetBar.ButtonItem();
            this.dgvkhoa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnall = new DevComponents.DotNetBar.ButtonX();
            this.btntk = new DevComponents.DotNetBar.ButtonX();
            this.ckbtimkiemten = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txttimkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btntimkiem = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txttenkh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmakh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnnhaplieu = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ctxmenu = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorkhoa)).BeginInit();
            this.bindingNavigatorkhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
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
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImagePaddingHorizontal = 8;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlW);
            this.btnthoat.Text = "đóng tab hiện tại ";
            this.btnthoat.Click += new System.EventHandler(this.bindingNavigatorexit_Click);
            // 
            // bindingNavigatorkhoa
            // 
            this.bindingNavigatorkhoa.AddNewItem = null;
            this.bindingNavigatorkhoa.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorkhoa.DeleteItem = null;
            this.bindingNavigatorkhoa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorkhoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorkhoa.Location = new System.Drawing.Point(3, 22);
            this.bindingNavigatorkhoa.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorkhoa.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorkhoa.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorkhoa.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorkhoa.Name = "bindingNavigatorkhoa";
            this.bindingNavigatorkhoa.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorkhoa.Size = new System.Drawing.Size(828, 33);
            this.bindingNavigatorkhoa.TabIndex = 0;
            this.bindingNavigatorkhoa.Text = "bindingNavigator1";
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
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImagePaddingHorizontal = 8;
            this.btnluu.Name = "btnluu";
            this.btnluu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnluu.Text = "Lưu dữ liệu ";
            this.btnluu.Click += new System.EventHandler(this.bindingNavigatorsave_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khóa học ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
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
            // dgvkhoa
            // 
            this.dgvkhoa.AllowUserToAddRows = false;
            this.dgvkhoa.AllowUserToResizeColumns = false;
            this.dgvkhoa.AllowUserToResizeRows = false;
            this.dgvkhoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvkhoa.ColumnHeadersHeight = 34;
            this.dgvkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmakh,
            this.coltenkh});
            this.contextMenuBar1.SetContextMenuEx(this.dgvkhoa, this.ctxmenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvkhoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvkhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvkhoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvkhoa.Location = new System.Drawing.Point(3, 55);
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.RowHeadersWidth = 62;
            this.dgvkhoa.RowTemplate.Height = 28;
            this.dgvkhoa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvkhoa.Size = new System.Drawing.Size(828, 526);
            this.dgvkhoa.TabIndex = 1;
            this.dgvkhoa.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvkhoa_DataError);
            // 
            // colmakh
            // 
            this.colmakh.DataPropertyName = "departmentId";
            this.colmakh.HeaderText = "Mã khoa";
            this.colmakh.MinimumWidth = 8;
            this.colmakh.Name = "colmakh";
            this.colmakh.ReadOnly = true;
            this.colmakh.Width = 150;
            // 
            // coltenkh
            // 
            this.coltenkh.DataPropertyName = "name";
            this.coltenkh.HeaderText = "Tên khoa";
            this.coltenkh.MinimumWidth = 8;
            this.coltenkh.Name = "coltenkh";
            this.coltenkh.Width = 350;
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
            this.navigationPane1.TabIndex = 0;
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
            this.navigationPane1.TitlePanel.Text = "Tìm kiếm dữ liệu ";
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
            // ckbtimkiemten
            // 
            this.ckbtimkiemten.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbtimkiemten.Checked = true;
            this.ckbtimkiemten.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbtimkiemten.CheckValue = "Y";
            this.ckbtimkiemten.Location = new System.Drawing.Point(25, 140);
            this.ckbtimkiemten.Name = "ckbtimkiemten";
            this.ckbtimkiemten.Size = new System.Drawing.Size(196, 38);
            this.ckbtimkiemten.TabIndex = 3;
            this.ckbtimkiemten.Text = "Tìm kiếm theo tên ";
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
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.txttenkh);
            this.navigationPanePanel1.Controls.Add(this.txtmakh);
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
            // txttenkh
            // 
            // 
            // 
            // 
            this.txttenkh.Border.Class = "TextBoxBorder";
            this.txttenkh.Location = new System.Drawing.Point(12, 164);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.ReadOnly = true;
            this.txttenkh.Size = new System.Drawing.Size(209, 26);
            this.txttenkh.TabIndex = 3;
            // 
            // txtmakh
            // 
            // 
            // 
            // 
            this.txtmakh.Border.Class = "TextBoxBorder";
            this.txtmakh.Location = new System.Drawing.Point(11, 70);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.ReadOnly = true;
            this.txtmakh.Size = new System.Drawing.Size(210, 26);
            this.txtmakh.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(11, 114);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(186, 32);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên khóa học *";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(11, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(186, 34);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã khóa học *";
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.contextMenuBar1);
            this.groupBox1.Controls.Add(this.dgvkhoa);
            this.groupBox1.Controls.Add(this.bindingNavigatorkhoa);
            this.groupBox1.Location = new System.Drawing.Point(299, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 584);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khoa";
            // 
            // contextMenuBar1
            // 
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
            // Frm_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1128, 584);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_department";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.khoahoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorkhoa)).EndInit();
            this.bindingNavigatorkhoa.ResumeLayout(false);
            this.bindingNavigatorkhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel2.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnxoa;
        private DevComponents.DotNetBar.ButtonItem btnthoat;
        private System.Windows.Forms.BindingNavigator bindingNavigatorkhoa;
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
        private DevComponents.DotNetBar.ButtonItem btnluu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevComponents.DotNetBar.ButtonItem btnthem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvkhoa;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem ctxmenu;
        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonX btnall;
        private DevComponents.DotNetBar.ButtonX btntk;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbtimkiemten;
        private DevComponents.DotNetBar.Controls.TextBoxX txttimkiem;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonItem btntimkiem;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenkh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmakh;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonItem btnnhaplieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorcancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenkh;
    }
}