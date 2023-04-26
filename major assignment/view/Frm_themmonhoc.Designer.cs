
namespace major_assignment.view
{
    partial class Frm_themmonhoc
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
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenmh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtcourcenumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbmagv = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 86;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(179, 373);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 85;
            this.btnadd.Text = "THÊM";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 84;
            this.label1.Text = "Thêm môn học";
            // 
            // txttenmh
            // 
            // 
            // 
            // 
            this.txttenmh.Border.Class = "TextBoxBorder";
            this.txttenmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttenmh.Location = new System.Drawing.Point(334, 106);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(442, 44);
            this.txttenmh.TabIndex = 83;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(12, 106);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(255, 52);
            this.labelX2.TabIndex = 82;
            this.labelX2.Text = "Tên môn học";
            // 
            // txtcourcenumber
            // 
            // 
            // 
            // 
            this.txtcourcenumber.Border.Class = "TextBoxBorder";
            this.txtcourcenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtcourcenumber.Location = new System.Drawing.Point(334, 176);
            this.txtcourcenumber.Name = "txtcourcenumber";
            this.txtcourcenumber.Size = new System.Drawing.Size(442, 44);
            this.txtcourcenumber.TabIndex = 88;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(12, 169);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(255, 52);
            this.labelX1.TabIndex = 87;
            this.labelX1.Text = "Số tín chỉ";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(12, 237);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(255, 52);
            this.labelX3.TabIndex = 89;
            this.labelX3.Text = "Giáo viên";
            // 
            // cmbmagv
            // 
            this.cmbmagv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmagv.FormattingEnabled = true;
            this.cmbmagv.Location = new System.Drawing.Point(334, 244);
            this.cmbmagv.Name = "cmbmagv";
            this.cmbmagv.Size = new System.Drawing.Size(445, 45);
            this.cmbmagv.TabIndex = 90;
            // 
            // Frm_themmonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbmagv);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtcourcenumber);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenmh);
            this.Controls.Add(this.labelX2);
            this.Name = "Frm_themmonhoc";
            this.Text = "Frm_themmonhoc";
            this.Load += new System.EventHandler(this.Frm_themmonhoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttenmh;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcourcenumber;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox cmbmagv;
    }
}