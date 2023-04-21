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
    public partial class Frm_policy : Form
    {

        #region Fields
        Ctr_student m_sinhvienCtrl = new Ctr_student();
        Ctr_department m_khoaCtrl = new Ctr_department();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        public Frm_policy()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        private void Frm_policy_Load(object sender, EventArgs e)
        {
            m_khoaCtrl.HienThiComboBox(cbxkhoa);
            m_sinhvienCtrl.HienThiDsHocVienall(lvchuaphan);
            m_sinhvienCtrl.HienThiDsHocVienchinhsach(lvphan);
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
            }
            else if (ckbtkkhoa.Checked == true)
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

        #region phân lớp cho học viên 
        private void btnchuyen_Click(object sender, EventArgs e)
        {
            IEnumerator ie = lvchuaphan.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem olditem = (ListViewItem)ie.Current;
                ListViewItem newitem = new ListViewItem();

                bool state = false;

                foreach (ListViewItem item in lvphan.Items)
                {
                    if (item.SubItems[0].Text == olditem.SubItems[0].Text)
                    {
                        MessageBoxEx.Show("Sinh viên " + item.SubItems[1].Text + " hiện đang nằm trong diện chính sách ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                newitem.SubItems.Add(olditem.SubItems[1].Text);

                lvphan.Items.Add(newitem);
                lvphan.Items[lvphan.Items.IndexOf(newitem)].Text = olditem.SubItems[0].Text;

            Cont:
                if (state == true)
                    break;
            }
        }
        #endregion

        #region LƯU THÔNG TIN
        private void btnluu_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_sinhvienCtrl.LuuHVVaochinhsach(lvphan);
                MessageBoxEx.Show("Lưu thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                conn.Open();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand("delete from tb_policy where studentId =" + Int64.Parse(item.SubItems[0].Text.ToString()), conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                    lvphan.Items.Remove(item);
                    // Trả tài nguyên
                    cmd.Dispose();
                }
                conn.Close();
            }

        }
        #endregion
    }
}
