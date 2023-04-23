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
    public partial class Frm_department : Office2007Form
    {

        #region Fields
        Ctr_department m_khoactrl = new Ctr_department();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        public Frm_department()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region load 
        private void khoahoc_Load(object sender, EventArgs e)
        {
            m_khoactrl.HienThi(dgvkhoa, bindingNavigatorkhoa, txtmakh, txttenkh);
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvkhoa.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_khoactrl.ThemDongMoi();
            m_Row["name"] = "";
            m_khoactrl.Themkhoa(m_Row);
            bindingNavigatorkhoa.BindingSource.MoveLast();
        }

        #endregion

        #region xóa 
        private void bindingNavigatorxoa_Click(object sender, EventArgs e)
        {
            if (dgvkhoa.RowCount == 0)
                bindingNavigatorxoa.Enabled = false;

            else
            {

                if (txtmakh.Text != "")
                { 
                    conn.Open();
                    string select1 = "Select departmentId from tb_student where departmentId=" + txtmakh.Text;
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
                        Console.Write(bindingNavigatorkhoa.BindingSource.Current);
                        OleDbCommand cmd = new OleDbCommand("delete from tb_department where departmentId =" + txtmakh.Text, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                        bindingNavigatorkhoa.BindingSource.RemoveCurrent();
                        // Trả tài nguyên
                        cmd.Dispose();
                    }
                    reader1.Dispose();
                    cmd1.Dispose();
                    conn.Close();
                }
                else
                {
                    bindingNavigatorkhoa.BindingSource.RemoveCurrent();
                }
                   

            }
        }
        #endregion

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvkhoa.Rows)
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
            if (KiemTraTruocKhiLuu("coltenkh") == true)
            {

                bindingNavigatorPositionItem.Focus();
                m_khoactrl.Luukhoa();
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
            
                m_khoactrl.TimTheoTen(txttimkiem.Text);
            
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
            m_khoactrl.HienThi(dgvkhoa, bindingNavigatorkhoa, txtmakh, txttenkh);
        }

        private void dgvkhoa_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
