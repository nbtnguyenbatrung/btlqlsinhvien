using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using major_assignment.data;
using major_assignment.component;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using System.Data;

namespace major_assignment.control
{
    class Ctr_teacher
    {
        Data_teacher m_teacherData = new Data_teacher();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_teacherData.LayDsGV();
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "teacherId";
        }
        public void HienThiComboBoxByMh(String id, ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_teacherData.LayDsGVByMh(id);
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "teacherId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_teacherData.LayDsGV();
            cmbColumn.DisplayMember = "name";
            cmbColumn.ValueMember = "teacherId";
            cmbColumn.DataPropertyName = "teacherId";
            cmbColumn.HeaderText = "Tên giáo viên ";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtmagv,
                            TextBoxX txttengv)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_teacherData.LayDsGV();

            txtmagv.DataBindings.Clear();
            txtmagv.DataBindings.Add("Text", bS, "teacherId");

            txttengv.DataBindings.Clear();
            txttengv.DataBindings.Add("Text", bS, "name");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_teacherData.ThemDongMoi();
        }

        public void ThemGV(DataRow m_Row)
        {
            m_teacherData.ThemGV(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuGV()
        {
            return m_teacherData.LuuGV();
        }
        #endregion

        #region Tim kiem
        public void TimTheoMa(int m_makh)
        {
            m_teacherData.TimTheoMa(m_makh);
        }

        public void TimTheoTen(String m_tenkh)
        {
            m_teacherData.TimTheoTen(m_tenkh);
        }
        #endregion
    }
}
