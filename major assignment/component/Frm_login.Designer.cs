
namespace major_assignment.component
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnhuybo = new DevComponents.DotNetBar.ButtonX();
            this.btndangnhap = new DevComponents.DotNetBar.ButtonX();
            this.lblpasserror = new System.Windows.Forms.Label();
            this.lblusererror = new System.Windows.Forms.Label();
            this.txtmatkhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdangnhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnhuybo);
            this.groupPanel1.Controls.Add(this.btndangnhap);
            this.groupPanel1.Controls.Add(this.lblpasserror);
            this.groupPanel1.Controls.Add(this.lblusererror);
            this.groupPanel1.Controls.Add(this.txtmatkhau);
            this.groupPanel1.Controls.Add(this.txtdangnhap);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.reflectionImage1);
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(177, 188);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(664, 294);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "Thông tin đăng nhập ";
            // 
            // btnhuybo
            // 
            this.btnhuybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnhuybo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnhuybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuybo.Location = new System.Drawing.Point(357, 205);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(141, 41);
            this.btnhuybo.TabIndex = 8;
            this.btnhuybo.Text = "HỦY BỎ ";
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btndangnhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(157, 205);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(160, 41);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "ĐĂNG NHẬP";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // lblpasserror
            // 
            this.lblpasserror.AutoSize = true;
            this.lblpasserror.ForeColor = System.Drawing.Color.Red;
            this.lblpasserror.Location = new System.Drawing.Point(313, 157);
            this.lblpasserror.Name = "lblpasserror";
            this.lblpasserror.Size = new System.Drawing.Size(0, 25);
            this.lblpasserror.TabIndex = 6;
            // 
            // lblusererror
            // 
            this.lblusererror.AutoSize = true;
            this.lblusererror.ForeColor = System.Drawing.Color.Red;
            this.lblusererror.Location = new System.Drawing.Point(308, 85);
            this.lblusererror.Name = "lblusererror";
            this.lblusererror.Size = new System.Drawing.Size(0, 25);
            this.lblusererror.TabIndex = 7;
            // 
            // txtmatkhau
            // 
            // 
            // 
            // 
            this.txtmatkhau.Border.Class = "TextBoxBorder";
            this.txtmatkhau.Location = new System.Drawing.Point(308, 120);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(289, 30);
            this.txtmatkhau.TabIndex = 4;
            this.txtmatkhau.WatermarkText = "Mat khẩu ";
            // 
            // txtdangnhap
            // 
            // 
            // 
            // 
            this.txtdangnhap.Border.Class = "TextBoxBorder";
            this.txtdangnhap.Location = new System.Drawing.Point(308, 48);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(289, 30);
            this.txtdangnhap.TabIndex = 3;
            this.txtdangnhap.WatermarkText = "Tên đăng nhập";
            this.txtdangnhap.TextChanged += new System.EventHandler(this.txtdangnhap_TextChanged);
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(132, 119);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(146, 28);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Mật khẩu :";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(132, 49);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(146, 26);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên đăng nhập :";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(20, 22);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(93, 225);
            this.reflectionImage1.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(91, 73);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(686, 61);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "QUẢN LÝ HỌC VIÊN TRUNG TÂM ";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 555);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_login";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnhuybo;
        private DevComponents.DotNetBar.ButtonX btndangnhap;
        public System.Windows.Forms.Label lblpasserror;
        public System.Windows.Forms.Label lblusererror;
        public DevComponents.DotNetBar.Controls.TextBoxX txtmatkhau;
        public DevComponents.DotNetBar.Controls.TextBoxX txtdangnhap;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}