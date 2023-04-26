using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using major_assignment.component;
using DevComponents.DotNetBar;
using System.Data.OleDb;
namespace major_assignment.view
{
    public partial class main : Form
    {
        #region Fields
        private static OleDbConnection m_Connection1;
        Frm_connect m_Connection = null;
        #endregion
        public main()
        {
            InitializeComponent();
        }


        private void main_Load(object sender, EventArgs e)
        {
            if (dataservice.OpenConnection())
            {
            }
            else
            {
                khoaToolStripMenuItem.Enabled = false;
                mônHọcToolStripMenuItem.Enabled = false;
                giáoViênToolStripMenuItem.Enabled = false;
                họcViênToolStripMenuItem.Enabled = false;
                đăngKýHọcToolStripMenuItem.Enabled = false;
                điểmThiToolStripMenuItem.Enabled = false;
                ReConnection(true);
            }
        }

        #region Kết nối lại CSDL
        public void ReConnection(Boolean check)
        {
            if (check)
                MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new Frm_connect();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                if (checkConnect())
                {
                    khoaToolStripMenuItem.Enabled = true;
                    mônHọcToolStripMenuItem.Enabled = true;
                    giáoViênToolStripMenuItem.Enabled = true;
                    họcViênToolStripMenuItem.Enabled = true;
                    đăngKýHọcToolStripMenuItem.Enabled = true;
                    điểmThiToolStripMenuItem.Enabled = true;
                }
                else
                {
                    ReConnection(true);
                }
            }
            else
                return;
        }
        #endregion

        private bool checkConnect()
        {
            try
            {
                string m_ConnectString = dataservice.ConnectionStringNew();
                m_Connection1 = new OleDbConnection(m_ConnectString);
                m_Connection1.Open();
                return true;
            }
            catch
            {
                m_Connection1.Close();
                return false;
            }
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listkhoa f = new Frm_listkhoa();
            f.Show();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_themkhoa f = new Frm_themkhoa();
            f.Show();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_suakhoa f = new Frm_suakhoa();
            f.Show();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_xoakhoa f = new Frm_xoakhoa();
            f.Show();
        }

        private void danhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listmonhoc f = new Frm_listmonhoc();
            f.Show();
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_themmonhoc f = new Frm_themmonhoc();
            f.Show();
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_suamonhoc f = new Frm_suamonhoc();
            f.Show();
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_xoamonhoc f = new Frm_xoamonhoc();
            f.Show();
        }

        private void danhSáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_listgiaovien f = new Frm_listgiaovien();
            f.Show();
        }

        private void thêmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_themgiaovien f = new Frm_themgiaovien();
            f.Show();
        }

        private void sửaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_suagiaovien f = new Frm_suagiaovien();
            f.Show();
        }

        private void xóaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_xoagiaovien f = new Frm_xoagiaovien();
            f.Show();
        }

        private void danhSáchToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_listhocvien f = new Frm_listhocvien();
            f.Show();
        }

        private void thêmToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_themhocvien f = new Frm_themhocvien();
            f.Show();
        }

        private void sửaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_suahocvien f = new Frm_suahocvien();
            f.Show();
        }

        private void xóaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_xoahocvien f = new Frm_xoahocvien();
            f.Show();
        }

        private void danhSáchToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_listhvmh f = new Frm_listhvmh();
            f.Show();
        }

        private void thêmToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_themhvmh f = new Frm_themhvmh();
            f.Show();
        }

        private void sửaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_suahvmh f = new Frm_suahvmh();
            f.Show();
        }

        private void xóaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_xoahvmh f = new Frm_xoahvmh();
            f.Show();
        }

        private void cậpNhậtĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_suadiem f = new Frm_suadiem();
            f.Show();
        }
    }
}
