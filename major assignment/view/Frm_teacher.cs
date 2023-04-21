using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using major_assignment.control;
using major_assignment.component;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace major_assignment.view
{
    public partial class Frm_teacher : Form
    {
        public Frm_teacher()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region Fields
        Ctr_teacher m_teacherctrl = new Ctr_teacher();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        #region load 
        private void Frm_teacher_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvmh.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_teacherctrl.ThemDongMoi();
            m_Row["name"] = "";
            m_teacherctrl.ThemGV(m_Row);
            bindingNavigatorgv.BindingSource.MoveLast();
        }

        #endregion

        #region xóa 
        private void bindingNavigatorxoa_Click(object sender, EventArgs e)
        {
            if (dgvmh.RowCount == 0)
                bindingNavigatorxoa.Enabled = false;

            else
            {
                conn.Open();
                string select1 = "Select subjectId from tb_subject where teacherId=" + txtmagv.Text;
                OleDbCommand cmd1 = new OleDbCommand(select1, conn);
                OleDbDataReader reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                    MessageBox.Show("Khoa đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thuc hien xoa du lieu
                    reader1.Dispose();
                    cmd1.Dispose();
                    Console.Write(bindingNavigatorgv.BindingSource.Current);
                    OleDbCommand cmd = new OleDbCommand("delete from tb_teacher where teacherId =" + txtmagv.Text, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                    bindingNavigatorgv.BindingSource.RemoveCurrent();
                    // Trả tài nguyên
                    cmd.Dispose();
                }
                reader1.Dispose();
                cmd1.Dispose();
                conn.Close();

            }
        }
        #endregion

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvmh.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng! hoặc bạn chưa nhấn enter", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion 
        #region lưu 
        private void bindingNavigatorsave_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("coltengv") == true)
            {

                bindingNavigatorPositionItem.Focus();
                m_teacherctrl.LuuGV();
                loadData();
                MessageBox.Show("Cập nhật dữ liệu thành công ", "Thông báo!");
            }
        }
        #endregion

        #region thoát 
        private void bindingNavigatorexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvkhoahoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            TimKiemkhoahoc();
        }

        void TimKiemkhoahoc()
        {
           
            m_teacherctrl.TimTheoTen(txttimkiem.Text);
            
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void bindingNavigatorcancel_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            m_teacherctrl.HienThi(dgvmh, bindingNavigatorgv, txtmagv, txttengv);
        }

       
    }
}
