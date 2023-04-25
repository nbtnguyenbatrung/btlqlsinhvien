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

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_khoa f = new Frm_khoa();
            //set data config
            f.TopLevel = false;
            //xóa trắng panel1
            panel1.Controls.Clear();
            //add form vào panel1
            panel1.Controls.Add(f);
            //resize form theo panel1
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            //show  form
            f.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_monhoc f = new Frm_monhoc();
            //set data config
            f.TopLevel = false;
            //xóa trắng panel1
            panel1.Controls.Clear();
            //add form vào panel1
            panel1.Controls.Add(f);
            //resize form theo panel1
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            //show  form
            f.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_giaovien f = new Frm_giaovien();
            //set data config
            f.TopLevel = false;
            //xóa trắng panel1
            panel1.Controls.Clear();
            //add form vào panel1
            panel1.Controls.Add(f);
            //resize form theo panel1
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            //show  form
            f.Show();
        }

        private void họcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_hocvien f = new Frm_hocvien();
            //set data config
            f.TopLevel = false;
            //xóa trắng panel1
            panel1.Controls.Clear();
            //add form vào panel1
            panel1.Controls.Add(f);
            //resize form theo panel1
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            //show  form
            f.Show();
        }

        private void đăngKýHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_hocvien_monhoc f = new Frm_hocvien_monhoc();
            //set data config
            f.TopLevel = false;
            //xóa trắng panel1
            panel1.Controls.Clear();
            //add form vào panel1
            panel1.Controls.Add(f);
            //resize form theo panel1
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            //show  form
            f.Show();
        }

        private void điểmThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_diem f = new Frm_diem();
            //set data config
            f.TopLevel = false;
            //xóa trắng panel1
            panel1.Controls.Clear();
            //add form vào panel1
            panel1.Controls.Add(f);
            //resize form theo panel1
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            //show  form
            f.Show();
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
    }
}
