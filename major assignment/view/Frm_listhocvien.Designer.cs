
namespace major_assignment.view
{
    partial class Frm_listhocvien
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
            this.dgvhv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvhv
            // 
            this.dgvhv.AllowUserToAddRows = false;
            this.dgvhv.AllowUserToDeleteRows = false;
            this.dgvhv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.studentId,
            this.name,
            this.birthday,
            this.placeOfBirth,
            this.gender,
            this.address,
            this.departmentName});
            this.dgvhv.Location = new System.Drawing.Point(14, 112);
            this.dgvhv.Name = "dgvhv";
            this.dgvhv.ReadOnly = true;
            this.dgvhv.RowHeadersWidth = 62;
            this.dgvhv.RowTemplate.Height = 28;
            this.dgvhv.Size = new System.Drawing.Size(1319, 388);
            this.dgvhv.TabIndex = 15;
            this.dgvhv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvmh_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 150;
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên học viên";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "Ngày sinh";
            this.birthday.MinimumWidth = 8;
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Width = 150;
            // 
            // placeOfBirth
            // 
            this.placeOfBirth.DataPropertyName = "placeOfBirth";
            this.placeOfBirth.HeaderText = "Nơi sinh";
            this.placeOfBirth.MinimumWidth = 8;
            this.placeOfBirth.Name = "placeOfBirth";
            this.placeOfBirth.ReadOnly = true;
            this.placeOfBirth.Width = 150;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Giới tính";
            this.gender.MinimumWidth = 8;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 150;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // departmentName
            // 
            this.departmentName.HeaderText = "Khoa";
            this.departmentName.MinimumWidth = 8;
            this.departmentName.Name = "departmentName";
            this.departmentName.ReadOnly = true;
            this.departmentName.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(531, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Danh sách học viên";
            // 
            // Frm_listhocvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvhv);
            this.Controls.Add(this.label1);
            this.Name = "Frm_listhocvien";
            this.Text = "Frm_listhocvien";
            this.Load += new System.EventHandler(this.Frm_listhocvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvhv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentName;
    }
}