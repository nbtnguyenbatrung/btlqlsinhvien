
namespace major_assignment.view
{
    partial class Frm_giaovien
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
            this.txttengv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmagv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnall = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvmh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmagv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Panel1.Controls.Add(this.txttengv);
            this.splitContainer1.Panel1.Controls.Add(this.txtmagv);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1283, 617);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(174, 411);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(182, 44);
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "HỦY THÊM";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(174, 411);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 44);
            this.btnxoa.TabIndex = 35;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(65, 412);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 43);
            this.btnluu.TabIndex = 34;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Visible = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(174, 345);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(182, 45);
            this.btnedit.TabIndex = 33;
            this.btnedit.Text = "CẬP NHẬT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(65, 345);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 45);
            this.btnadd.TabIndex = 32;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txttengv
            // 
            // 
            // 
            // 
            this.txttengv.Border.Class = "TextBoxBorder";
            this.txttengv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttengv.Location = new System.Drawing.Point(30, 207);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(394, 44);
            this.txttengv.TabIndex = 7;
            // 
            // txtmagv
            // 
            // 
            // 
            // 
            this.txtmagv.Border.Class = "TextBoxBorder";
            this.txtmagv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtmagv.Location = new System.Drawing.Point(30, 85);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.ReadOnly = true;
            this.txtmagv.Size = new System.Drawing.Size(394, 44);
            this.txtmagv.TabIndex = 6;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX2.Location = new System.Drawing.Point(30, 149);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(255, 52);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Tên giáo viên *";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelX1.Location = new System.Drawing.Point(30, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(199, 49);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Mã giáo viên ";
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
            this.splitContainer2.Size = new System.Drawing.Size(852, 617);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(647, 43);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(147, 41);
            this.btnall.TabIndex = 11;
            this.btnall.Text = "Hủy tìm kiếm";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(511, 43);
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
            this.txttk.Location = new System.Drawing.Point(212, 43);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(262, 44);
            this.txttk.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm";
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
            this.STT,
            this.colmagv,
            this.coltengv});
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
            this.dgvmh.RowHeadersWidth = 62;
            this.dgvmh.RowTemplate.Height = 28;
            this.dgvmh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvmh.Size = new System.Drawing.Size(852, 483);
            this.dgvmh.TabIndex = 2;
            this.dgvmh.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvmh_RowHeaderMouseClick);
            this.dgvmh.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvmh_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
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
            // Frm_giaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 617);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_giaovien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_giaovien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_giaovien_Load);
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
        private DevComponents.DotNetBar.Controls.TextBoxX txttengv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmagv;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmagv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltengv;
    }
}