
namespace major_assignment.view
{
    partial class Frm_suahvmh
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbmadiem = new System.Windows.Forms.ComboBox();
            this.cmbhv = new System.Windows.Forms.ComboBox();
            this.cmbmh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(251, 296);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(186, 38);
            this.labelX1.TabIndex = 101;
            this.labelX1.Text = "Môn học";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 100;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(431, 447);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 99;
            this.btnadd.Text = "CẬP NHẬT";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(350, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 37);
            this.label1.TabIndex = 98;
            this.label1.Text = "Thêm môn học cho học viên ";
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX8.Location = new System.Drawing.Point(251, 219);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(186, 38);
            this.labelX8.TabIndex = 96;
            this.labelX8.Text = "Học viên";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(106, 139);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(388, 38);
            this.labelX2.TabIndex = 103;
            this.labelX2.Text = "Mã đăng ký học viên với môn học";
            // 
            // cmbmadiem
            // 
            this.cmbmadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmadiem.FormattingEnabled = true;
            this.cmbmadiem.Location = new System.Drawing.Point(558, 139);
            this.cmbmadiem.Name = "cmbmadiem";
            this.cmbmadiem.Size = new System.Drawing.Size(446, 45);
            this.cmbmadiem.TabIndex = 117;
            this.cmbmadiem.SelectedIndexChanged += new System.EventHandler(this.cmbmadiem_SelectedIndexChanged);
            // 
            // cmbhv
            // 
            this.cmbhv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbhv.FormattingEnabled = true;
            this.cmbhv.Location = new System.Drawing.Point(558, 212);
            this.cmbhv.Name = "cmbhv";
            this.cmbhv.Size = new System.Drawing.Size(446, 45);
            this.cmbhv.TabIndex = 118;
            // 
            // cmbmh
            // 
            this.cmbmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmh.FormattingEnabled = true;
            this.cmbmh.Location = new System.Drawing.Point(558, 296);
            this.cmbmh.Name = "cmbmh";
            this.cmbmh.Size = new System.Drawing.Size(446, 45);
            this.cmbmh.TabIndex = 119;
            // 
            // Frm_suahvmh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 538);
            this.Controls.Add(this.cmbmh);
            this.Controls.Add(this.cmbhv);
            this.Controls.Add(this.cmbmadiem);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX8);
            this.Name = "Frm_suahvmh";
            this.Text = "Frm_suahvmh";
            this.Load += new System.EventHandler(this.Frm_suahvmh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox cmbmadiem;
        private System.Windows.Forms.ComboBox cmbhv;
        private System.Windows.Forms.ComboBox cmbmh;
    }
}