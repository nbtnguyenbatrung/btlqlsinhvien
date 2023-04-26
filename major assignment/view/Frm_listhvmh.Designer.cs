
namespace major_assignment.view
{
    partial class Frm_listhvmh
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
            this.dgvhvmh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhvmh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvhvmh
            // 
            this.dgvhvmh.AllowUserToAddRows = false;
            this.dgvhvmh.AllowUserToDeleteRows = false;
            this.dgvhvmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhvmh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.studentId,
            this.studentName,
            this.subjectId,
            this.subjectName});
            this.dgvhvmh.Location = new System.Drawing.Point(12, 108);
            this.dgvhvmh.Name = "dgvhvmh";
            this.dgvhvmh.ReadOnly = true;
            this.dgvhvmh.RowHeadersWidth = 62;
            this.dgvhvmh.RowTemplate.Height = 28;
            this.dgvhvmh.Size = new System.Drawing.Size(1306, 372);
            this.dgvhvmh.TabIndex = 18;
            this.dgvhvmh.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvhv_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(466, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách học viên";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã đăng ký";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // studentId
            // 
            this.studentId.DataPropertyName = "studentId";
            this.studentId.HeaderText = "Mã học viên";
            this.studentId.MinimumWidth = 8;
            this.studentId.Name = "studentId";
            this.studentId.ReadOnly = true;
            this.studentId.Width = 150;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentName";
            this.studentName.HeaderText = "Tên học viên";
            this.studentName.MinimumWidth = 8;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Width = 150;
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
            // subjectName
            // 
            this.subjectName.DataPropertyName = "subjectName";
            this.subjectName.HeaderText = "Tên môn học";
            this.subjectName.MinimumWidth = 8;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            this.subjectName.Width = 150;
            // 
            // Frm_listhvmh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvhvmh);
            this.Controls.Add(this.label1);
            this.Name = "Frm_listhvmh";
            this.Text = "Frm_listhvmh";
            this.Load += new System.EventHandler(this.Frm_listhvmh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhvmh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvhvmh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
    }
}