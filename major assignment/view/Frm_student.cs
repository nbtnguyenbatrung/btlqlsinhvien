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
    public partial class Frm_student : Office2007Form
    {

        #region Fields
        Ctr_student m_studentctrl = new Ctr_student();
        Ctr_department m_khoactrl = new Ctr_department();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        public Frm_student()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region load 
        private void Frm_student_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region thêm 
        private void bindingNavigatorthem_Click(object sender, EventArgs e)
        {
            if (dgvsv.RowCount == 0)
                bindingNavigatorxoa.Enabled = true;

            DataRow m_Row = m_studentctrl.ThemDongMoi();
            m_Row["name"] = "";
            m_Row["address"] = "";
            m_Row["gender"] = "nam";
            m_Row["placeOfBirth"] = "";
            m_Row["birthday"] = DateTime.Today;
            
            m_studentctrl.ThemSV(m_Row);
            bindingNavigatorsv.BindingSource.MoveLast();
        }

        #endregion

        #region xóa 
        private void bindingNavigatorxoa_Click(object sender, EventArgs e)
        {
            if (dgvsv.RowCount == 0)
                bindingNavigatorxoa.Enabled = false;

            else
            {
                if (txtmasv.Text != "")
                {
                    conn.Open();
                    string select1 = "Select subjectId from tb_student_subject where studentId=" + txtmasv.Text;
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
                        Console.Write(bindingNavigatorsv.BindingSource.Current);
                        OleDbCommand cmd = new OleDbCommand("delete from tb_student where studentId =" + txtmasv.Text, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                        bindingNavigatorsv.BindingSource.RemoveCurrent();
                        // Trả tài nguyên
                        cmd.Dispose();
                    }
                    reader1.Dispose();
                    cmd1.Dispose();
                    conn.Close();
                }
                else
                {
                    bindingNavigatorsv.BindingSource.RemoveCurrent();
                }                  

            }
        }
        #endregion

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvsv.Rows)
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
            if (KiemTraTruocKhiLuu("coltensv") == true )
            {

                bindingNavigatorPositionItem.Focus();
                m_studentctrl.LuuSV();
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
            
             m_studentctrl.TimTheoTen(txttimkiem.Text);
            
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
            m_khoactrl.HienThiComboBox(cmbkhoa);
            m_khoactrl.HienThiDataGridViewComboBoxColumn(colkhoa);
            m_studentctrl.HienThi(dgvsv, bindingNavigatorsv, txtmasv, txttensv, dtpns,
                txtnoisinh, txtgt, txtdiachi, cmbkhoa);
        }

        private void cmbmakh_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
