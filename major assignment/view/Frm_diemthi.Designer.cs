
namespace major_assignment.view
{
    partial class Frm_diemthi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_diemthi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigatorexit = new System.Windows.Forms.ToolStripButton();
            this.dgvdiemthi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmasv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.ctxmenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnrefresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnimportexcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnexportexcel = new DevComponents.DotNetBar.ButtonItem();
            this.btnsave = new DevComponents.DotNetBar.ButtonItem();
            this.btnthoat = new DevComponents.DotNetBar.ButtonItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bindingNavigatorsave = new System.Windows.Forms.ToolStripButton();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnloc = new DevComponents.DotNetBar.ButtonX();
            this.cbxkhoa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxmh = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmbmakhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbmamh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bindingNavigatordiemthi = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorrefresh = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatordiemthi)).BeginInit();
            this.bindingNavigatordiemthi.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorexit
            // 
            this.bindingNavigatorexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorexit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorexit.Image")));
            this.bindingNavigatorexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorexit.Name = "bindingNavigatorexit";
            this.bindingNavigatorexit.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorexit.Text = "exit";
            this.bindingNavigatorexit.Click += new System.EventHandler(this.bindingNavigatorexit_Click);
            // 
            // dgvdiemthi
            // 
            this.dgvdiemthi.AllowUserToAddRows = false;
            this.dgvdiemthi.AllowUserToResizeRows = false;
            this.dgvdiemthi.BackgroundColor = System.Drawing.Color.White;
            this.dgvdiemthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colmamh,
            this.coltenmh,
            this.colmasv,
            this.colhoten,
            this.colpoint});
            this.contextMenuBar1.SetContextMenuEx(this.dgvdiemthi, this.ctxmenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdiemthi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdiemthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdiemthi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvdiemthi.Location = new System.Drawing.Point(0, 202);
            this.dgvdiemthi.Name = "dgvdiemthi";
            this.dgvdiemthi.RowHeadersWidth = 62;
            this.dgvdiemthi.RowTemplate.Height = 28;
            this.dgvdiemthi.Size = new System.Drawing.Size(1123, 320);
            this.dgvdiemthi.TabIndex = 6;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã điểm";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // colmamh
            // 
            this.colmamh.DataPropertyName = "subjectViewId";
            this.colmamh.HeaderText = "Mã môn học";
            this.colmamh.MinimumWidth = 8;
            this.colmamh.Name = "colmamh";
            this.colmamh.ReadOnly = true;
            this.colmamh.Width = 150;
            // 
            // coltenmh
            // 
            this.coltenmh.DataPropertyName = "subjectName";
            this.coltenmh.HeaderText = "Tên môn học";
            this.coltenmh.MinimumWidth = 8;
            this.coltenmh.Name = "coltenmh";
            this.coltenmh.ReadOnly = true;
            this.coltenmh.Width = 150;
            // 
            // colmasv
            // 
            this.colmasv.DataPropertyName = "studentViewId";
            this.colmasv.HeaderText = "Mã sinh viên ";
            this.colmasv.MinimumWidth = 8;
            this.colmasv.Name = "colmasv";
            this.colmasv.ReadOnly = true;
            this.colmasv.Width = 150;
            // 
            // colhoten
            // 
            this.colhoten.DataPropertyName = "studentName";
            this.colhoten.HeaderText = "Tên sinh viên ";
            this.colhoten.MinimumWidth = 8;
            this.colhoten.Name = "colhoten";
            this.colhoten.ReadOnly = true;
            this.colhoten.Width = 150;
            // 
            // colpoint
            // 
            this.colpoint.DataPropertyName = "point";
            this.colpoint.HeaderText = "Điểm thi";
            this.colpoint.MinimumWidth = 8;
            this.colpoint.Name = "colpoint";
            this.colpoint.Width = 150;
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ctxmenu});
            this.contextMenuBar1.Location = new System.Drawing.Point(499, 308);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(75, 33);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.contextMenuBar1.TabIndex = 7;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bindingNavigatorsave
            // 
            this.bindingNavigatorsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorsave.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorsave.Image")));
            this.bindingNavigatorsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorsave.Name = "bindingNavigatorsave";
            this.bindingNavigatorsave.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorsave.Text = "save";
            this.bindingNavigatorsave.Click += new System.EventHandler(this.bindingNavigatorsave_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnloc);
            this.groupPanel1.Controls.Add(this.cbxkhoa);
            this.groupPanel1.Controls.Add(this.cbxmh);
            this.groupPanel1.Controls.Add(this.cmbmakhoa);
            this.groupPanel1.Controls.Add(this.cmbmamh);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 38);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1123, 164);
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
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "Danh sách điểm thi của môn học sinh viên ";
            // 
            // btnloc
            // 
            this.btnloc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnloc.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnloc.Location = new System.Drawing.Point(718, 52);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(138, 26);
            this.btnloc.TabIndex = 13;
            this.btnloc.Text = "Lọc";
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // cbxkhoa
            // 
            this.cbxkhoa.Location = new System.Drawing.Point(275, 79);
            this.cbxkhoa.Name = "cbxkhoa";
            this.cbxkhoa.Size = new System.Drawing.Size(75, 23);
            this.cbxkhoa.TabIndex = 5;
            this.cbxkhoa.Text = "Khoa :";
            // 
            // cbxmh
            // 
            this.cbxmh.BackColor = System.Drawing.Color.Transparent;
            this.cbxmh.Checked = true;
            this.cbxmh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxmh.CheckValue = "Y";
            this.cbxmh.Location = new System.Drawing.Point(275, 30);
            this.cbxmh.Name = "cbxmh";
            this.cbxmh.Size = new System.Drawing.Size(112, 29);
            this.cbxmh.TabIndex = 4;
            this.cbxmh.Text = "Môn học :";
            // 
            // cmbmakhoa
            // 
            this.cmbmakhoa.DisplayMember = "Text";
            this.cmbmakhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmakhoa.FormattingEnabled = true;
            this.cmbmakhoa.ItemHeight = 20;
            this.cmbmakhoa.Location = new System.Drawing.Point(402, 76);
            this.cmbmakhoa.Name = "cmbmakhoa";
            this.cmbmakhoa.Size = new System.Drawing.Size(243, 26);
            this.cmbmakhoa.TabIndex = 3;
            // 
            // cmbmamh
            // 
            this.cmbmamh.DisplayMember = "Text";
            this.cmbmamh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmamh.FormattingEnabled = true;
            this.cmbmamh.ItemHeight = 20;
            this.cmbmamh.Location = new System.Drawing.Point(402, 30);
            this.cmbmamh.Name = "cmbmamh";
            this.cmbmamh.Size = new System.Drawing.Size(243, 26);
            this.cmbmamh.TabIndex = 1;
            // 
            // bindingNavigatordiemthi
            // 
            this.bindingNavigatordiemthi.AddNewItem = null;
            this.bindingNavigatordiemthi.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatordiemthi.DeleteItem = null;
            this.bindingNavigatordiemthi.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatordiemthi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorsave,
            this.bindingNavigatorexit});
            this.bindingNavigatordiemthi.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatordiemthi.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatordiemthi.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatordiemthi.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatordiemthi.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatordiemthi.Name = "bindingNavigatordiemthi";
            this.bindingNavigatordiemthi.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatordiemthi.Size = new System.Drawing.Size(1123, 38);
            this.bindingNavigatordiemthi.TabIndex = 5;
            this.bindingNavigatordiemthi.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorrefresh
            // 
            this.bindingNavigatorrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorrefresh.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorrefresh.Image")));
            this.bindingNavigatorrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorrefresh.Name = "bindingNavigatorrefresh";
            this.bindingNavigatorrefresh.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorrefresh.Text = "Làm mới dữ liệu ";
            this.bindingNavigatorrefresh.Click += new System.EventHandler(this.bindingNavigatorrefresh_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học viên ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HOTEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên học viên ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIEMNGHE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Điểm nghe ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIEMDOC";
            this.dataGridViewTextBoxColumn4.HeaderText = "Điểm đọc ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "point";
            this.dataGridViewTextBoxColumn6.HeaderText = "Điểm thi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // Frm_diemthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1123, 522);
            this.Controls.Add(this.dgvdiemthi);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.bindingNavigatordiemthi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_diemthi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diểm thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_diemthi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatordiemthi)).EndInit();
            this.bindingNavigatordiemthi.ResumeLayout(false);
            this.bindingNavigatordiemthi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorexit;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdiemthi;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem ctxmenu;
        private DevComponents.DotNetBar.ButtonItem btnrefresh;
        private DevComponents.DotNetBar.ButtonItem btnimportexcel;
        private DevComponents.DotNetBar.ButtonItem btnexportexcel;
        private DevComponents.DotNetBar.ButtonItem btnsave;
        private DevComponents.DotNetBar.ButtonItem btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorsave;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbmakhoa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbmamh;
        private System.Windows.Forms.BindingNavigator bindingNavigatordiemthi;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorrefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxmh;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxkhoa;
        private DevComponents.DotNetBar.ButtonX btnloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpoint;
    }
}