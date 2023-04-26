
namespace major_assignment.view
{
    partial class Frm_xoagiaovien
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
            this.cmbmagv = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttengv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cmbmagv
            // 
            this.cmbmagv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbmagv.FormattingEnabled = true;
            this.cmbmagv.Location = new System.Drawing.Point(334, 167);
            this.cmbmagv.Name = "cmbmagv";
            this.cmbmagv.Size = new System.Drawing.Size(445, 45);
            this.cmbmagv.TabIndex = 96;
            this.cmbmagv.SelectedIndexChanged += new System.EventHandler(this.cmbmagv_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(22, 155);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(171, 41);
            this.labelX1.TabIndex = 95;
            this.labelX1.Text = "Mã giáo viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 94;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(192, 348);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 93;
            this.btnadd.Text = "XÓA";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(252, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 92;
            this.label1.Text = "Xóa giáo viên";
            // 
            // txttengv
            // 
            // 
            // 
            // 
            this.txttengv.Border.Class = "TextBoxBorder";
            this.txttengv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttengv.Location = new System.Drawing.Point(337, 249);
            this.txttengv.Name = "txttengv";
            this.txttengv.Size = new System.Drawing.Size(442, 44);
            this.txttengv.TabIndex = 91;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(22, 240);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(255, 52);
            this.labelX2.TabIndex = 90;
            this.labelX2.Text = "Tên giáo viên";
            // 
            // Frm_xoagiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbmagv);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttengv);
            this.Controls.Add(this.labelX2);
            this.Name = "Frm_xoagiaovien";
            this.Text = "Frm_xoagiaovien";
            this.Load += new System.EventHandler(this.Frm_xoagiaovien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmagv;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttengv;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}