
namespace major_assignment.view
{
    partial class Frm_listgiaovien
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
            this.dgvgv = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvgv
            // 
            this.dgvgv.AllowUserToAddRows = false;
            this.dgvgv.AllowUserToDeleteRows = false;
            this.dgvgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.teacherId,
            this.name});
            this.dgvgv.Location = new System.Drawing.Point(14, 112);
            this.dgvgv.Name = "dgvgv";
            this.dgvgv.ReadOnly = true;
            this.dgvgv.RowHeadersWidth = 62;
            this.dgvgv.RowTemplate.Height = 28;
            this.dgvgv.Size = new System.Drawing.Size(773, 393);
            this.dgvgv.TabIndex = 9;
            this.dgvgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvkhoa_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 150;
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
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên giáo viên";
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
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách giáo viên";
            // 
            // Frm_listgiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvgv);
            this.Controls.Add(this.label1);
            this.Name = "Frm_listgiaovien";
            this.Text = "Frm_listgiaovien";
            this.Load += new System.EventHandler(this.Frm_listgiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}