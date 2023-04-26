
namespace major_assignment.view
{
    partial class Frm_listmonhoc
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvmh = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvmh
            // 
            this.dgvmh.AllowUserToAddRows = false;
            this.dgvmh.AllowUserToDeleteRows = false;
            this.dgvmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.subjectId,
            this.name,
            this.courseNumber,
            this.teacherName});
            this.dgvmh.Location = new System.Drawing.Point(85, 116);
            this.dgvmh.Name = "dgvmh";
            this.dgvmh.ReadOnly = true;
            this.dgvmh.RowHeadersWidth = 62;
            this.dgvmh.RowTemplate.Height = 28;
            this.dgvmh.Size = new System.Drawing.Size(1012, 398);
            this.dgvmh.TabIndex = 12;
            this.dgvmh.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvgv_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 150;
            // 
            // subjectId
            // 
            this.subjectId.DataPropertyName = "subjectId";
            this.subjectId.HeaderText = "Mã môn học";
            this.subjectId.MinimumWidth = 8;
            this.subjectId.Name = "subjectId";
            this.subjectId.ReadOnly = true;
            this.subjectId.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên môn học";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // courseNumber
            // 
            this.courseNumber.DataPropertyName = "courseNumber";
            this.courseNumber.HeaderText = "Số tín chỉ";
            this.courseNumber.MinimumWidth = 8;
            this.courseNumber.Name = "courseNumber";
            this.courseNumber.ReadOnly = true;
            this.courseNumber.Width = 150;
            // 
            // teacherName
            // 
            this.teacherName.DataPropertyName = "teacherName";
            this.teacherName.HeaderText = "Giáo viên dạy";
            this.teacherName.MinimumWidth = 8;
            this.teacherName.Name = "teacherName";
            this.teacherName.ReadOnly = true;
            this.teacherName.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(433, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh sách môn học";
            // 
            // Frm_listmonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvmh);
            this.Controls.Add(this.label1);
            this.Name = "Frm_listmonhoc";
            this.Text = "Frm_listmonhoc";
            this.Load += new System.EventHandler(this.Frm_listmonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvmh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherName;
    }
}