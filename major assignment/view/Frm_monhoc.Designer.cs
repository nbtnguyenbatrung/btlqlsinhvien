
namespace major_assignment.view
{
    partial class Frm_monhoc
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbgv = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtcourceNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txttenmh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmamh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnall = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvmh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colteacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnxoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnluu);
            this.splitContainer1.Panel1.Controls.Add(this.btnedit);
            this.splitContainer1.Panel1.Controls.Add(this.btnadd);
            this.splitContainer1.Panel1.Controls.Add(this.cmbgv);
            this.splitContainer1.Panel1.Controls.Add(this.labelX5);
            this.splitContainer1.Panel1.Controls.Add(this.txtcourceNumber);
            this.splitContainer1.Panel1.Controls.Add(this.labelX4);
            this.splitContainer1.Panel1.Controls.Add(this.txttenmh);
            this.splitContainer1.Panel1.Controls.Add(this.txtmamh);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1278, 641);
            this.splitContainer1.SplitterDistance = 426;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(171, 561);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(182, 44);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "HỦY THÊM";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(171, 561);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 44);
            this.btnxoa.TabIndex = 30;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(62, 562);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 43);
            this.btnluu.TabIndex = 29;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Visible = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(171, 495);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(182, 45);
            this.btnedit.TabIndex = 28;
            this.btnedit.Text = "CẬP NHẬT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(62, 495);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 45);
            this.btnadd.TabIndex = 27;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbgv
            // 
            this.cmbgv.DisplayMember = "Text";
            this.cmbgv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbgv.FormattingEnabled = true;
            this.cmbgv.ItemHeight = 38;
            this.cmbgv.Location = new System.Drawing.Point(24, 398);
            this.cmbgv.Name = "cmbgv";
            this.cmbgv.Size = new System.Drawing.Size(399, 44);
            this.cmbgv.TabIndex = 26;
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX5.Location = new System.Drawing.Point(24, 341);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(261, 51);
            this.labelX5.TabIndex = 25;
            this.labelX5.Text = "Giáo viên dạy *";
            // 
            // txtcourceNumber
            // 
            // 
            // 
            // 
            this.txtcourceNumber.Border.Class = "TextBoxBorder";
            this.txtcourceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtcourceNumber.Location = new System.Drawing.Point(24, 291);
            this.txtcourceNumber.Name = "txtcourceNumber";
            this.txtcourceNumber.Size = new System.Drawing.Size(399, 44);
            this.txtcourceNumber.TabIndex = 24;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX4.Location = new System.Drawing.Point(23, 239);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(219, 46);
            this.labelX4.TabIndex = 23;
            this.labelX4.Text = "Số học trình *";
            // 
            // txttenmh
            // 
            // 
            // 
            // 
            this.txttenmh.Border.Class = "TextBoxBorder";
            this.txttenmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttenmh.Location = new System.Drawing.Point(23, 189);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(400, 44);
            this.txttenmh.TabIndex = 22;
            // 
            // txtmamh
            // 
            // 
            // 
            // 
            this.txtmamh.Border.Class = "TextBoxBorder";
            this.txtmamh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtmamh.Location = new System.Drawing.Point(24, 79);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.ReadOnly = true;
            this.txtmamh.Size = new System.Drawing.Size(399, 44);
            this.txtmamh.TabIndex = 21;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX2.Location = new System.Drawing.Point(23, 136);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(210, 47);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Tên môn học *";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX1.Location = new System.Drawing.Point(23, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(219, 49);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Mã môn học ";
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
            this.splitContainer2.Panel2.Controls.Add(this.dgvmh);
            this.splitContainer2.Size = new System.Drawing.Size(848, 641);
            this.splitContainer2.SplitterDistance = 132;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(645, 44);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(147, 41);
            this.btnall.TabIndex = 7;
            this.btnall.Text = "Hủy tìm kiếm";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(509, 44);
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
            this.txttk.Location = new System.Drawing.Point(210, 44);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(262, 44);
            this.txttk.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // dgvmh
            // 
            this.dgvmh.AllowUserToAddRows = false;
            this.dgvmh.AllowUserToDeleteRows = false;
            this.dgvmh.AllowUserToResizeColumns = false;
            this.dgvmh.AllowUserToResizeRows = false;
            this.dgvmh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvmh.ColumnHeadersHeight = 34;
            this.dgvmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvmh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.colmamh,
            this.coltenmh,
            this.colcourse,
            this.colteacherId,
            this.teacherId});
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
            this.dgvmh.Location = new System.Drawing.Point(0, 0);
            this.dgvmh.Name = "dgvmh";
            this.dgvmh.ReadOnly = true;
            this.dgvmh.RowHeadersWidth = 62;
            this.dgvmh.RowTemplate.Height = 28;
            this.dgvmh.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvmh.Size = new System.Drawing.Size(848, 505);
            this.dgvmh.TabIndex = 2;
            this.dgvmh.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvmh_RowHeaderMouseClick);
            this.dgvmh.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvmh_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "subjectId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã môn học";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên môn học";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "courseNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số học trình";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "teacherName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giáo viên dạy";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "teacherName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giáo viên dạy";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 150;
            // 
            // colmamh
            // 
            this.colmamh.DataPropertyName = "subjectId";
            this.colmamh.HeaderText = "Mã môn học";
            this.colmamh.MinimumWidth = 8;
            this.colmamh.Name = "colmamh";
            this.colmamh.ReadOnly = true;
            this.colmamh.Width = 150;
            // 
            // coltenmh
            // 
            this.coltenmh.DataPropertyName = "name";
            this.coltenmh.HeaderText = "Tên môn học";
            this.coltenmh.MinimumWidth = 8;
            this.coltenmh.Name = "coltenmh";
            this.coltenmh.ReadOnly = true;
            this.coltenmh.Width = 350;
            // 
            // colcourse
            // 
            this.colcourse.DataPropertyName = "courseNumber";
            this.colcourse.HeaderText = "Số học trình";
            this.colcourse.MinimumWidth = 8;
            this.colcourse.Name = "colcourse";
            this.colcourse.ReadOnly = true;
            this.colcourse.Width = 150;
            // 
            // colteacherId
            // 
            this.colteacherId.DataPropertyName = "teacherName";
            this.colteacherId.HeaderText = "Giáo viên dạy";
            this.colteacherId.MinimumWidth = 8;
            this.colteacherId.Name = "colteacherId";
            this.colteacherId.ReadOnly = true;
            this.colteacherId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colteacherId.Width = 150;
            // 
            // teacherId
            // 
            this.teacherId.DataPropertyName = "teacherId";
            this.teacherId.HeaderText = "Mã giáo viên";
            this.teacherId.MinimumWidth = 8;
            this.teacherId.Name = "teacherId";
            this.teacherId.ReadOnly = true;
            this.teacherId.Width = 150;
            // 
            // Frm_monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 641);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_monhoc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_monhoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_monhoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvmh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbgv;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcourceNumber;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenmh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmamh;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colteacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherId;
    }
}