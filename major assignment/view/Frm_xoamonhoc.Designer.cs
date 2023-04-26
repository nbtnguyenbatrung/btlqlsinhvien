
namespace major_assignment.view
{
    partial class Frm_xoamonhoc
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
            this.cmbmh = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbmagv = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtcourcenumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenmh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cmbmh
            // 
            this.cmbmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmh.FormattingEnabled = true;
            this.cmbmh.Location = new System.Drawing.Point(339, 91);
            this.cmbmh.Name = "cmbmh";
            this.cmbmh.Size = new System.Drawing.Size(445, 45);
            this.cmbmh.TabIndex = 112;
            this.cmbmh.SelectedIndexChanged += new System.EventHandler(this.cmbmh_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX4.Location = new System.Drawing.Point(17, 85);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(255, 52);
            this.labelX4.TabIndex = 111;
            this.labelX4.Text = "Mã môn học";
            // 
            // cmbmagv
            // 
            this.cmbmagv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmagv.FormattingEnabled = true;
            this.cmbmagv.Location = new System.Drawing.Point(339, 294);
            this.cmbmagv.Name = "cmbmagv";
            this.cmbmagv.Size = new System.Drawing.Size(445, 45);
            this.cmbmagv.TabIndex = 110;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(17, 287);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(255, 52);
            this.labelX3.TabIndex = 109;
            this.labelX3.Text = "Giáo viên";
            // 
            // txtcourcenumber
            // 
            // 
            // 
            // 
            this.txtcourcenumber.Border.Class = "TextBoxBorder";
            this.txtcourcenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtcourcenumber.Location = new System.Drawing.Point(339, 226);
            this.txtcourcenumber.Name = "txtcourcenumber";
            this.txtcourcenumber.Size = new System.Drawing.Size(442, 44);
            this.txtcourcenumber.TabIndex = 108;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(17, 219);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(255, 52);
            this.labelX1.TabIndex = 107;
            this.labelX1.Text = "Số tín chỉ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 106;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(177, 375);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 105;
            this.btnadd.Text = "CẬP NHẬT";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(237, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 104;
            this.label1.Text = "Xóa môn học";
            // 
            // txttenmh
            // 
            // 
            // 
            // 
            this.txttenmh.Border.Class = "TextBoxBorder";
            this.txttenmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttenmh.Location = new System.Drawing.Point(339, 156);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(442, 44);
            this.txttenmh.TabIndex = 103;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(17, 156);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(255, 52);
            this.labelX2.TabIndex = 102;
            this.labelX2.Text = "Tên môn học";
            // 
            // Frm_xoamonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbmh);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cmbmagv);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtcourcenumber);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenmh);
            this.Controls.Add(this.labelX2);
            this.Name = "Frm_xoamonhoc";
            this.Text = "Frm_xoamonhoc";
            this.Load += new System.EventHandler(this.Frm_xoamonhoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmh;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox cmbmagv;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcourcenumber;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenmh;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}