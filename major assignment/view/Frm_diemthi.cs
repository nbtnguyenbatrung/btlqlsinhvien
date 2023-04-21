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
    public partial class Frm_diemthi : Form
    {

        #region Fields
        Ctr_subject m_subjectCtrl = new Ctr_subject();
        Ctr_department m_khoactrl = new Ctr_department();
        Ctr_student m_sinhvienCtrl = new Ctr_student();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        public Frm_diemthi()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        private void Frm_diemthi_Load(object sender, EventArgs e)
        {
            m_subjectCtrl.HienThiComboBox(cmbmamh);
            m_khoactrl.HienThiComboBox(cmbmakhoa);
        }

        #region lưu dữ liệu 
        private void bindingNavigatorsave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvdiemthi.SelectedRows)
            {
                conn.Open();
                if (kiemtra(row.Cells["colpoint"].Value.ToString()) )
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE tb_student_subject SET point = "
                        + row.Cells["colpoint"].Value +
                        " where id = " + row.Cells["id"].Value , conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("cập nhật dữ liệu thành công", "Thông báo!");
                    // Trả tài nguyên
                    
                    cmd.Dispose();
                }
                else
                {

                    MessageBox.Show(" điểm nhập vào không hợp lệ ", "Thông báo!");
                }
                conn.Close();
               
            }
        }
        #endregion

        #region thoát 
        private void bindingNavigatorexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region làm mới dữ liệu 
        private void bindingNavigatorrefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        #endregion

        private Boolean kiemtra(String diem)
        {
            long point = Int64.Parse(diem);

            if (point < 0 || point > 10)
                return false;

            return true;
        }
        private void loadData()
        {
            if (cbxmh.Checked && cbxkhoa.Checked)
            {
                m_sinhvienCtrl.HienThiDsHocViencodiem(
                cmbmakhoa.SelectedValue.ToString(),
                cmbmamh.SelectedValue.ToString(),
                dgvdiemthi, bindingNavigatordiemthi);
            }
            if (cbxmh.Checked && !cbxkhoa.Checked)
            {
                m_sinhvienCtrl.HienThiDsHocViencodiemMonHoc(
                cmbmamh.SelectedValue.ToString(),
                dgvdiemthi, bindingNavigatordiemthi);
            }
            if (!cbxmh.Checked && cbxkhoa.Checked)
            {
                m_sinhvienCtrl.HienThiDsHocViencodiemkhoa(
                cmbmakhoa.SelectedValue.ToString(),
                dgvdiemthi, bindingNavigatordiemthi);
            }
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
