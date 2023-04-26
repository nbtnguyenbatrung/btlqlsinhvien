
namespace major_assignment.view
{
    partial class Frm_suadiem
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtdiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbmadiem = new System.Windows.Forms.ComboBox();
            this.cmbhv = new System.Windows.Forms.ComboBox();
            this.cmbmh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(56, 151);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(388, 38);
            this.labelX2.TabIndex = 112;
            this.labelX2.Text = "Mã đăng ký học viên với môn học";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(201, 308);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(186, 38);
            this.labelX1.TabIndex = 110;
            this.labelX1.Text = "Môn học";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 109;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(381, 459);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 108;
            this.btnadd.Text = "CẬP NHẬT";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(300, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 37);
            this.label1.TabIndex = 107;
            this.label1.Text = "Thêm môn học cho học viên ";
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX8.Location = new System.Drawing.Point(201, 231);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(186, 38);
            this.labelX8.TabIndex = 105;
            this.labelX8.Text = "Học viên";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(201, 370);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(186, 38);
            this.labelX3.TabIndex = 114;
            this.labelX3.Text = "Điểm";
            // 
            // txtdiem
            // 
            // 
            // 
            // 
            this.txtdiem.Border.Class = "TextBoxBorder";
            this.txtdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtdiem.Location = new System.Drawing.Point(487, 381);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(446, 44);
            this.txtdiem.TabIndex = 115;
            // 
            // cmbmadiem
            // 
            this.cmbmadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmadiem.FormattingEnabled = true;
            this.cmbmadiem.Location = new System.Drawing.Point(487, 151);
            this.cmbmadiem.Name = "cmbmadiem";
            this.cmbmadiem.Size = new System.Drawing.Size(446, 45);
            this.cmbmadiem.TabIndex = 116;
            this.cmbmadiem.SelectedIndexChanged += new System.EventHandler(this.cmbmadiem_SelectedIndexChanged);
            // 
            // cmbhv
            // 
            this.cmbhv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbhv.FormattingEnabled = true;
            this.cmbhv.Location = new System.Drawing.Point(488, 231);
            this.cmbhv.Name = "cmbhv";
            this.cmbhv.Size = new System.Drawing.Size(446, 45);
            this.cmbhv.TabIndex = 117;
            // 
            // cmbmh
            // 
            this.cmbmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmh.FormattingEnabled = true;
            this.cmbmh.Location = new System.Drawing.Point(488, 307);
            this.cmbmh.Name = "cmbmh";
            this.cmbmh.Size = new System.Drawing.Size(446, 45);
            this.cmbmh.TabIndex = 118;
            // 
            // Frm_suadiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 542);
            this.Controls.Add(this.cmbmh);
            this.Controls.Add(this.cmbhv);
            this.Controls.Add(this.cmbmadiem);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelX8);
            this.Name = "Frm_suadiem";
            this.Text = "Frm_suadiem";
            this.Load += new System.EventHandler(this.Frm_suadiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiem;
        private System.Windows.Forms.ComboBox cmbmadiem;
        private System.Windows.Forms.ComboBox cmbhv;
        private System.Windows.Forms.ComboBox cmbmh;
    }
}