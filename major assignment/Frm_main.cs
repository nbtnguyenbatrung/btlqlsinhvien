using DevComponents.DotNetBar;
using major_assignment.component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using major_assignment.control;

namespace major_assignment
{
    public partial class Frm_main : Office2007RibbonForm
    {
        #region Fields
        Frm_connect m_Connection = null;
        Frm_login m_FrmLogin = null;
        Ctr_account m_NguoiDungCtrl = new Ctr_account();
        #endregion

        #region Main
        #region Constructor
        public Frm_main()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void Frm_main_Load(object sender, EventArgs e)
        {
            Default();
            if (dataservice.OpenConnection())
            {
                /*DangNhap();*/
            }
            else
            {
                ReConnection(true);
            }
        }
        #endregion

        #region Kết nối lại CSDL
        public void ReConnection(Boolean check)
        {
            if (check)
                MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new Frm_connect();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                return;
        }
        #endregion

        private void Frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult TL;
            TL = MessageBoxEx.Show("Bạn Có Muốn Thoát khỏi hệ thống không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (TL == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        #endregion

        #region Giao diện mặc định
        public void Default()
        {
           
            btndangnhapcontext.Enabled = true;
            btnthoat.Enabled = true;
            btnthoatcontext.Enabled = true;
   
            btndangxuatcontext.Enabled = false;
            btndoimatkhaucontext.Enabled = false;
            btnsaoluu.Enabled = true;
        }

        #endregion

        #region Form show
        #region Menu start

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                m_FrmLogin = new Frm_login();

            m_FrmLogin.txtdangnhap.Text = "";
            m_FrmLogin.txtmatkhau.Text = "";
            m_FrmLogin.lblusererror.Text = "";
            m_FrmLogin.lblpasserror.Text = "";

            DangNhap();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = " ";
            Default();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            /*if (m_FrmDoiMatKhau == null || m_FrmDoiMatKhau.IsDisposed)
                m_FrmDoiMatKhau = new doimatkhau();

            m_FrmDoiMatKhau.txtoldpass.Text = "";
            m_FrmDoiMatKhau.txtnewpass.Text = "";
            m_FrmDoiMatKhau.txtrenpass.Text = "";
            m_FrmDoiMatKhau.lbloldpasserror.Text = "";
            m_FrmDoiMatKhau.lblnewpasserror.Text = "";
            m_FrmDoiMatKhau.lblrenpasserror.Text = "";

            DoiMatKhau();*/
        }
        private void btnqlnguoidung_Click(object sender, EventArgs e)
        {
            /*if (m_FrmNguoiDung == null || m_FrmNguoiDung.IsDisposed)
            {
                m_FrmNguoiDung = new nguoidung();
                m_FrmNguoiDung.MdiParent = this;
                m_FrmNguoiDung.Show();
            }
            else
                m_FrmNguoiDung.Activate();*/
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsaoluu_Click(object sender, EventArgs e)
        {
            ReConnection(false);
        }
       
        #endregion

        #endregion

        #region DangNhap
        public void DangNhap()
        {
        Cont:
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                m_FrmLogin = new Frm_login();

            if (m_FrmLogin.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmLogin.txtdangnhap.Text == "")
                {
                    m_FrmLogin.lblpasserror.Text = "";
                    m_FrmLogin.lblusererror.Text = "Bạn chưa nhập tên!";
                    goto Cont;
                }

                if (m_FrmLogin.txtmatkhau.Text == "")
                {
                    m_FrmLogin.lblusererror.Text = "";
                    m_FrmLogin.lblpasserror.Text = "Bạn chưa nhập mật khẩu!";
                    goto Cont;
                }

                int ketQua = m_NguoiDungCtrl.DangNhap(m_FrmLogin.txtdangnhap.Text, m_FrmLogin.txtmatkhau.Text);

                switch (ketQua)
                {
                    case 0:
                        m_FrmLogin.lblpasserror.Text = "";
                        m_FrmLogin.lblusererror.Text = "Người dùng này không tồn tại!";
                        goto Cont;
                    case 1:
                        m_FrmLogin.lblusererror.Text = "";
                        m_FrmLogin.lblpasserror.Text = "Mật khẩu không hợp lệ!";
                        goto Cont;
                    case 2:
                        lblTenNguoiDung.Text = uti.NguoiDung.username;
                        IsButton();
                        break;
                }
            }
            else
                return;
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền BGH
        public void IsButton()
        {
            //False
            btndangnhapcontext.Enabled = false;

            //True
            btndangxuatcontext.Enabled = true;
            btndoimatkhaucontext.Enabled = true;
            btnsaoluu.Enabled = true;
            btnthoat.Enabled = true;
            btnthoatcontext.Enabled = true;
        }
        #endregion

        private void btnkhoahoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormKhoa();
        }

        private void btnlophoc_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormMh();
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormGV();
        }

        private void btnhocvien_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormSV();
        }

        private void btnphanlop_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormSS();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDT();
        }

        private void btnbonus_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormBonus();
        }

        private void bntdiscipline_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormDiscipline();
        }

        private void btnpolicy_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormPolicy();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            ThamSo.ShowFormTksinhvien();
        }
    }
}
