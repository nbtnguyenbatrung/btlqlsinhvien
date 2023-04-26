
namespace major_assignment.view
{
    partial class Frm_listkhoa
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
            this.dgvkhoa = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.AllowUserToAddRows = false;
            this.dgvkhoa.AllowUserToDeleteRows = false;
            this.dgvkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.departmentId,
            this.name});
            this.dgvkhoa.Location = new System.Drawing.Point(14, 112);
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.ReadOnly = true;
            this.dgvkhoa.RowHeadersWidth = 62;
            this.dgvkhoa.RowTemplate.Height = 28;
            this.dgvkhoa.Size = new System.Drawing.Size(773, 352);
            this.dgvkhoa.TabIndex = 6;
            this.dgvkhoa.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvsach_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 150;
            // 
            // departmentId
            // 
            this.departmentId.DataPropertyName = "departmentId";
            this.departmentId.HeaderText = "Mã khoa";
            this.departmentId.MinimumWidth = 8;
            this.departmentId.Name = "departmentId";
            this.departmentId.ReadOnly = true;
            this.departmentId.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên khoa";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(196, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách khoa";
            // 
            // Frm_listkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvkhoa);
            this.Controls.Add(this.label1);
            this.Name = "Frm_listkhoa";
            this.Text = "Frm_listkhoa";
            this.Load += new System.EventHandler(this.Frm_listkhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvkhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}