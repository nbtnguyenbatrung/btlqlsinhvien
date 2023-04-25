
namespace major_assignment.view
{
    partial class Frm_hocvien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbxgt = new System.Windows.Forms.ComboBox();
            this.dtpns = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbkhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtdiachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtnoisinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txttensv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmasv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnall = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvsv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmasv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colplaceOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.splitContainer1.Panel1.Controls.Add(this.cbxgt);
            this.splitContainer1.Panel1.Controls.Add(this.dtpns);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnxoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnluu);
            this.splitContainer1.Panel1.Controls.Add(this.btnedit);
            this.splitContainer1.Panel1.Controls.Add(this.btnadd);
            this.splitContainer1.Panel1.Controls.Add(this.cmbkhoa);
            this.splitContainer1.Panel1.Controls.Add(this.labelX8);
            this.splitContainer1.Panel1.Controls.Add(this.txtdiachi);
            this.splitContainer1.Panel1.Controls.Add(this.labelX7);
            this.splitContainer1.Panel1.Controls.Add(this.labelX6);
            this.splitContainer1.Panel1.Controls.Add(this.txtnoisinh);
            this.splitContainer1.Panel1.Controls.Add(this.labelX5);
            this.splitContainer1.Panel1.Controls.Add(this.labelX4);
            this.splitContainer1.Panel1.Controls.Add(this.txttensv);
            this.splitContainer1.Panel1.Controls.Add(this.txtmasv);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1414, 919);
            this.splitContainer1.SplitterDistance = 470;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbxgt
            // 
            this.cbxgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbxgt.FormattingEnabled = true;
            this.cbxgt.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbxgt.Location = new System.Drawing.Point(22, 501);
            this.cbxgt.Name = "cbxgt";
            this.cbxgt.Size = new System.Drawing.Size(445, 45);
            this.cbxgt.TabIndex = 39;
            // 
            // dtpns
            // 
            this.dtpns.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpns.Location = new System.Drawing.Point(22, 291);
            this.dtpns.Name = "dtpns";
            this.dtpns.Size = new System.Drawing.Size(445, 44);
            this.dtpns.TabIndex = 38;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(197, 865);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(182, 44);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "HỦY THÊM";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(197, 865);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 44);
            this.btnxoa.TabIndex = 36;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(88, 866);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 43);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Visible = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(197, 799);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(182, 45);
            this.btnedit.TabIndex = 34;
            this.btnedit.Text = "CẬP NHẬT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(88, 799);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 45);
            this.btnadd.TabIndex = 33;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.DisplayMember = "Text";
            this.cmbkhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.ItemHeight = 38;
            this.cmbkhoa.Location = new System.Drawing.Point(22, 699);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(445, 44);
            this.cmbkhoa.TabIndex = 31;
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX8.Location = new System.Drawing.Point(22, 655);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(186, 38);
            this.labelX8.TabIndex = 30;
            this.labelX8.Text = "Khoa *";
            // 
            // txtdiachi
            // 
            // 
            // 
            // 
            this.txtdiachi.Border.Class = "TextBoxBorder";
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtdiachi.Location = new System.Drawing.Point(22, 605);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(445, 44);
            this.txtdiachi.TabIndex = 29;
            // 
            // labelX7
            // 
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX7.Location = new System.Drawing.Point(22, 552);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(186, 47);
            this.labelX7.TabIndex = 28;
            this.labelX7.Text = "Quê quán";
            // 
            // labelX6
            // 
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX6.Location = new System.Drawing.Point(22, 443);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(186, 40);
            this.labelX6.TabIndex = 27;
            this.labelX6.Text = "Giới tính";
            // 
            // txtnoisinh
            // 
            // 
            // 
            // 
            this.txtnoisinh.Border.Class = "TextBoxBorder";
            this.txtnoisinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtnoisinh.Location = new System.Drawing.Point(22, 393);
            this.txtnoisinh.Name = "txtnoisinh";
            this.txtnoisinh.Size = new System.Drawing.Size(445, 44);
            this.txtnoisinh.TabIndex = 26;
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX5.Location = new System.Drawing.Point(22, 341);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(186, 44);
            this.labelX5.TabIndex = 25;
            this.labelX5.Text = "Nơi sinh";
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX4.Location = new System.Drawing.Point(22, 227);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(186, 47);
            this.labelX4.TabIndex = 23;
            this.labelX4.Text = "Ngày sinh";
            // 
            // txttensv
            // 
            // 
            // 
            // 
            this.txttensv.Border.Class = "TextBoxBorder";
            this.txttensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttensv.Location = new System.Drawing.Point(22, 177);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(446, 44);
            this.txttensv.TabIndex = 22;
            // 
            // txtmasv
            // 
            // 
            // 
            // 
            this.txtmasv.Border.Class = "TextBoxBorder";
            this.txtmasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtmasv.Location = new System.Drawing.Point(22, 75);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.ReadOnly = true;
            this.txtmasv.Size = new System.Drawing.Size(445, 44);
            this.txtmasv.TabIndex = 21;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX2.Location = new System.Drawing.Point(22, 125);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(229, 46);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Tên sinh viên *";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX1.Location = new System.Drawing.Point(22, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(186, 42);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Mã sinh viên";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.splitContainer2.Panel1.Controls.Add(this.btnall);
            this.splitContainer2.Panel1.Controls.Add(this.btntk);
            this.splitContainer2.Panel1.Controls.Add(this.txttk);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvsv);
            this.splitContainer2.Size = new System.Drawing.Size(940, 919);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(690, 42);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(147, 41);
            this.btnall.TabIndex = 7;
            this.btnall.Text = "Hủy tìm kiếm";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(554, 42);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(95, 41);
            this.btntk.TabIndex = 6;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttk.Location = new System.Drawing.Point(255, 42);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(262, 44);
            this.txttk.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(102, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // dgvsv
            // 
            this.dgvsv.AllowUserToAddRows = false;
            this.dgvsv.AllowUserToResizeColumns = false;
            this.dgvsv.AllowUserToResizeRows = false;
            this.dgvsv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvsv.ColumnHeadersHeight = 34;
            this.dgvsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.colmasv,
            this.coltensv,
            this.colbirthday,
            this.colplaceOfBirth,
            this.colgender,
            this.coladdress,
            this.colkhoa,
            this.departmentName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvsv.Location = new System.Drawing.Point(0, 0);
            this.dgvsv.Name = "dgvsv";
            this.dgvsv.RowHeadersWidth = 62;
            this.dgvsv.RowTemplate.Height = 28;
            this.dgvsv.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvsv.Size = new System.Drawing.Size(940, 753);
            this.dgvsv.TabIndex = 2;
            this.dgvsv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvsv_RowHeaderMouseClick);
            this.dgvsv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvsv_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // colmasv
            // 
            this.colmasv.DataPropertyName = "studentId";
            this.colmasv.HeaderText = "Mã sinh viên";
            this.colmasv.MinimumWidth = 8;
            this.colmasv.Name = "colmasv";
            this.colmasv.ReadOnly = true;
            this.colmasv.Width = 150;
            // 
            // coltensv
            // 
            this.coltensv.DataPropertyName = "name";
            this.coltensv.HeaderText = "Tên sinh viên";
            this.coltensv.MinimumWidth = 8;
            this.coltensv.Name = "coltensv";
            this.coltensv.Width = 300;
            // 
            // colbirthday
            // 
            this.colbirthday.DataPropertyName = "birthday";
            this.colbirthday.HeaderText = "Ngày sinh";
            this.colbirthday.MinimumWidth = 8;
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colbirthday.Width = 150;
            // 
            // colplaceOfBirth
            // 
            this.colplaceOfBirth.DataPropertyName = "placeOfBirth";
            this.colplaceOfBirth.HeaderText = "Nơi sinh";
            this.colplaceOfBirth.MinimumWidth = 8;
            this.colplaceOfBirth.Name = "colplaceOfBirth";
            this.colplaceOfBirth.Width = 150;
            // 
            // colgender
            // 
            this.colgender.DataPropertyName = "gender";
            this.colgender.HeaderText = "Giới tính";
            this.colgender.MinimumWidth = 8;
            this.colgender.Name = "colgender";
            this.colgender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colgender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colgender.Width = 150;
            // 
            // coladdress
            // 
            this.coladdress.DataPropertyName = "address";
            this.coladdress.HeaderText = "Địa chỉ";
            this.coladdress.MinimumWidth = 8;
            this.coladdress.Name = "coladdress";
            this.coladdress.Width = 150;
            // 
            // colkhoa
            // 
            this.colkhoa.DataPropertyName = "departmentId";
            this.colkhoa.HeaderText = "Mã Khoa";
            this.colkhoa.MinimumWidth = 8;
            this.colkhoa.Name = "colkhoa";
            this.colkhoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colkhoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colkhoa.Width = 150;
            // 
            // departmentName
            // 
            this.departmentName.DataPropertyName = "departmentName";
            this.departmentName.HeaderText = "Tên khoa";
            this.departmentName.MinimumWidth = 8;
            this.departmentName.Name = "departmentName";
            this.departmentName.Width = 150;
            // 
            // Frm_hocvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 919);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_hocvien";
            this.Text = "Frm_hocvien";
            this.Load += new System.EventHandler(this.Frm_hocvien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbkhoa;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiachi;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnoisinh;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txttensv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmasv;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvsv;
        private System.Windows.Forms.DateTimePicker dtpns;
        private System.Windows.Forms.ComboBox cbxgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colplaceOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn coladdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentName;
    }
}