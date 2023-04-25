
namespace major_assignment.view
{
    partial class Frm_khoa
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
            this.txttenkh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmakh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnall = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvkhoa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmakh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnxoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnluu);
            this.splitContainer1.Panel1.Controls.Add(this.btnedit);
            this.splitContainer1.Panel1.Controls.Add(this.btnadd);
            this.splitContainer1.Panel1.Controls.Add(this.txttenkh);
            this.splitContainer1.Panel1.Controls.Add(this.txtmakh);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1232, 561);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(203, 411);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(182, 44);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "HỦY THÊM";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(203, 411);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 44);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(94, 412);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 43);
            this.btnluu.TabIndex = 10;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Visible = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(203, 345);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(182, 45);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "CẬP NHẬT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(94, 345);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 45);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txttenkh
            // 
            // 
            // 
            // 
            this.txttenkh.Border.Class = "TextBoxBorder";
            this.txttenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttenkh.Location = new System.Drawing.Point(29, 206);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(367, 44);
            this.txttenkh.TabIndex = 7;
            // 
            // txtmakh
            // 
            // 
            // 
            // 
            this.txtmakh.Border.Class = "TextBoxBorder";
            this.txtmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtmakh.Location = new System.Drawing.Point(28, 70);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.ReadOnly = true;
            this.txtmakh.Size = new System.Drawing.Size(368, 44);
            this.txtmakh.TabIndex = 6;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX2.Location = new System.Drawing.Point(28, 141);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(236, 44);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Tên khóa học *";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX1.Location = new System.Drawing.Point(28, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(236, 46);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Mã khóa học *";
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
            this.splitContainer2.Panel1.Controls.Add(this.btnall);
            this.splitContainer2.Panel1.Controls.Add(this.btntk);
            this.splitContainer2.Panel1.Controls.Add(this.txttk);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvkhoa);
            this.splitContainer2.Size = new System.Drawing.Size(818, 561);
            this.splitContainer2.SplitterDistance = 83;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(600, 23);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(147, 41);
            this.btnall.TabIndex = 3;
            this.btnall.Text = "Hủy tìm kiếm";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(464, 23);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(95, 41);
            this.btntk.TabIndex = 2;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttk.Location = new System.Drawing.Point(165, 23);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(262, 44);
            this.txttk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.AllowUserToAddRows = false;
            this.dgvkhoa.AllowUserToDeleteRows = false;
            this.dgvkhoa.AllowUserToResizeColumns = false;
            this.dgvkhoa.AllowUserToResizeRows = false;
            this.dgvkhoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvkhoa.ColumnHeadersHeight = 34;
            this.dgvkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.colmakh,
            this.coltenkh});
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
            this.dgvkhoa.Location = new System.Drawing.Point(0, 0);
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.ReadOnly = true;
            this.dgvkhoa.RowHeadersWidth = 62;
            this.dgvkhoa.RowTemplate.Height = 28;
            this.dgvkhoa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvkhoa.Size = new System.Drawing.Size(818, 474);
            this.dgvkhoa.TabIndex = 2;
            this.dgvkhoa.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvkhoa_RowHeaderMouseClick);
            this.dgvkhoa.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvkhoa_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "departmentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khoa";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khoa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 150;
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
            this.coltenkh.ReadOnly = true;
            this.coltenkh.Width = 350;
            // 
            // Frm_khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 561);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_khoa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_khoa_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.TextBox txttk;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenkh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmakh;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvkhoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenkh;
    }
}