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
using DevComponents.DotNetBar;
using major_assignment.component;
using System.Data.OleDb;
using System.Collections;

namespace major_assignment.view
{
    public partial class Frm_student_subject : Office2007Form
    {

        #region Fields
        Ctr_subject m_subjectctrl = new Ctr_subject();
        Ctr_student m_sinhvienCtrl = new Ctr_student();
        Ctr_department m_khoaCtrl = new Ctr_department();
        Ctr_teacher m_teacherCtrl = new Ctr_teacher();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        public Frm_student_subject()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        private void Frm_student_subject_Load(object sender, EventArgs e)
        {
            m_subjectctrl.HienThiComboBox(cbxmh);
            m_khoaCtrl.HienThiComboBox(cbxkhoa);
            m_sinhvienCtrl.HienThiDsHocVienall(lvchuaphan);
            if (cbxmh.SelectedValue != null)
            {
                m_teacherCtrl.HienThiComboBoxByMh(cbxmh.SelectedValue.ToString(), cbxgiaovien);
            }
        }

        #region tìm kiếm 
        private void btnall_Click_1(object sender, EventArgs e)
        {
            m_sinhvienCtrl.HienThiDsHocVienall(lvchuaphan);
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            TimKiemLop();
        }

        void TimKiemLop()
        {
            if (ckbtimma.Checked == true)
            {
                m_sinhvienCtrl.HienThiDsHocVientheoma(txttimma.Text, lvchuaphan);

            }
            else if (ckbtimten.Checked == true)
            {
                m_sinhvienCtrl.HienThiDsHocVientheoten(txttimten.Text, lvchuaphan);
            }else if (ckbtkkhoa.Checked == true)
            {
                m_sinhvienCtrl.HienThiDsHocVientheohoa(cbxkhoa.SelectedValue.ToString(), lvchuaphan);
            }
        }
        #endregion

        #region thoát 
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SelectedIndexChanged event


        private void cmbkhoahoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxmh.SelectedValue != null)
            {
                m_teacherCtrl.HienThiComboBoxByMh(cbxmh.SelectedValue.ToString(), cbxgiaovien);
            }

        }
        #endregion

        #region phân lớp cho học viên 
        private void btnchuyen_Click(object sender, EventArgs e)
        {
            IEnumerator ie = lvchuaphan.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem olditem = (ListViewItem)ie.Current;
                ListViewItem newitem = new ListViewItem();

                newitem.SubItems.Add(olditem.SubItems[1].Text);

                lvphan.Items.Add(newitem);
                lvphan.Items[lvphan.Items.IndexOf(newitem)].Text = olditem.SubItems[0].Text;
            }
        }
        #endregion

        #region xóa học viên khỏi lớp 
        private void btnxoa_Click(object sender, EventArgs e)
        {

            IEnumerator ie = lvphan.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lvphan.Items.Remove(item);
                }
            }

        }
        #endregion

        #region LƯU THÔNG TIN
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cbxmh.SelectedValue != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m_sinhvienCtrl.LuuHVVaoBangPhanLop(lvphan,
                                                 cbxmh.SelectedValue.ToString());
                    lvphan.Items.Clear();
                    MessageBoxEx.Show("Lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
