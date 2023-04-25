
namespace major_assignment.view
{
    partial class Frm_hocvien_monhoc
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
            this.btnadd = new System.Windows.Forms.Button();
            this.txtmadk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbxmonhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbhocvien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnall = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvsv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmasv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnxoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnluu);
            this.splitContainer1.Panel1.Controls.Add(this.btnadd);
            this.splitContainer1.Panel1.Controls.Add(this.txtmadk);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.cbxmonhoc);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbhocvien);
            this.splitContainer1.Panel1.Controls.Add(this.labelX8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1376, 681);
            this.splitContainer1.SplitterDistance = 458;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(173, 427);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(182, 44);
            this.btnHuy.TabIndex = 42;
            this.btnHuy.Text = "HỦY THÊM";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(173, 492);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 44);
            this.btnxoa.TabIndex = 41;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(64, 493);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 43);
            this.btnluu.TabIndex = 40;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Visible = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(64, 426);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 45);
            this.btnadd.TabIndex = 38;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtmadk
            // 
            // 
            // 
            // 
            this.txtmadk.Border.Class = "TextBoxBorder";
            this.txtmadk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtmadk.Location = new System.Drawing.Point(10, 81);
            this.txtmadk.Name = "txtmadk";
            this.txtmadk.ReadOnly = true;
            this.txtmadk.Size = new System.Drawing.Size(445, 44);
            this.txtmadk.TabIndex = 37;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX2.Location = new System.Drawing.Point(14, 37);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(186, 38);
            this.labelX2.TabIndex = 36;
            this.labelX2.Text = "Mã đăng ký";
            // 
            // cbxmonhoc
            // 
            this.cbxmonhoc.DisplayMember = "Text";
            this.cbxmonhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbxmonhoc.FormattingEnabled = true;
            this.cbxmonhoc.ItemHeight = 38;
            this.cbxmonhoc.Location = new System.Drawing.Point(10, 320);
            this.cbxmonhoc.Name = "cbxmonhoc";
            this.cbxmonhoc.Size = new System.Drawing.Size(445, 44);
            this.cbxmonhoc.TabIndex = 35;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX1.Location = new System.Drawing.Point(14, 265);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(186, 38);
            this.labelX1.TabIndex = 34;
            this.labelX1.Text = "Môn học *";
            // 
            // cmbhocvien
            // 
            this.cmbhocvien.DisplayMember = "Text";
            this.cmbhocvien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbhocvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbhocvien.FormattingEnabled = true;
            this.cmbhocvien.ItemHeight = 38;
            this.cmbhocvien.Location = new System.Drawing.Point(10, 201);
            this.cmbhocvien.Name = "cmbhocvien";
            this.cmbhocvien.Size = new System.Drawing.Size(445, 44);
            this.cmbhocvien.TabIndex = 33;
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX8.Location = new System.Drawing.Point(12, 145);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(186, 38);
            this.labelX8.TabIndex = 32;
            this.labelX8.Text = "Học viên *";
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
            this.splitContainer2.Size = new System.Drawing.Size(914, 681);
            this.splitContainer2.SplitterDistance = 112;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(634, 34);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(147, 41);
            this.btnall.TabIndex = 11;
            this.btnall.Text = "Hủy tìm kiếm";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(498, 34);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(95, 41);
            this.btntk.TabIndex = 10;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttk.Location = new System.Drawing.Point(199, 34);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(262, 44);
            this.txttk.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 8;
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
            this.ID,
            this.colmasv,
            this.coltensv,
            this.subjectId,
            this.subjectName});
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
            this.dgvsv.Size = new System.Drawing.Size(914, 565);
            this.dgvsv.TabIndex = 3;
            this.dgvsv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvsv_RowHeaderMouseClick);
            this.dgvsv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvsv_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã đăng ký";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studentId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sinh viên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "studentName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên sinh viên";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subjectId";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã môn học";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "subjectName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên môn học";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã đăng ký";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
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
            this.coltensv.DataPropertyName = "studentName";
            this.coltensv.HeaderText = "Tên sinh viên";
            this.coltensv.MinimumWidth = 8;
            this.coltensv.Name = "coltensv";
            this.coltensv.Width = 300;
            // 
            // subjectId
            // 
            this.subjectId.DataPropertyName = "subjectId";
            this.subjectId.HeaderText = "Mã môn học";
            this.subjectId.MinimumWidth = 8;
            this.subjectId.Name = "subjectId";
            this.subjectId.Width = 150;
            // 
            // subjectName
            // 
            this.subjectName.DataPropertyName = "subjectName";
            this.subjectName.HeaderText = "Tên môn học";
            this.subjectName.MinimumWidth = 8;
            this.subjectName.Name = "subjectName";
            this.subjectName.Width = 150;
            // 
            // Frm_hocvien_monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 681);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_hocvien_monhoc";
            this.Text = "Frm_hocvien_monhoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_hocvien_monhoc_Load);
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
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxmonhoc;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbhocvien;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmadk;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnadd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmasv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
    }
}