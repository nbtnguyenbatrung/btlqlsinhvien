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
    class Ctr_subject
    {
        Data_subject m_SubjectData = new Data_subject();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_SubjectData.LayDsMH();
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "subjectId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_SubjectData.LayDsMH();
            cmbColumn.DisplayMember = "name";
            cmbColumn.ValueMember = "subjectId";
            cmbColumn.DataPropertyName = "subjectId";
            cmbColumn.HeaderText = "Tên môn học ";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtmakh,
                            TextBoxX txttenkh,
                            TextBoxX txtcourceNumber,
                            ComboBoxEx cmbmagv)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_SubjectData.LayDsMH();

            txtmakh.DataBindings.Clear();
            txtmakh.DataBindings.Add("Text", bS, "subjectId");

            txttenkh.DataBindings.Clear();
            txttenkh.DataBindings.Add("Text", bS, "name");

            txtcourceNumber.DataBindings.Clear();
            txtcourceNumber.DataBindings.Add("Text", bS, "courseNumber");

            cmbmagv.DataBindings.Clear();
            cmbmagv.DataBindings.Add("SelectedValue", bS, "teacherId");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_SubjectData.ThemDongMoi();
        }

        public void ThemMH(DataRow m_Row)
        {
            m_SubjectData.ThemMH(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuMH()
        {
            return m_SubjectData.LuuMH();
        }
        #endregion

        #region Tim kiem
        public void TimTheoMa(int m_makh)
        {
            m_SubjectData.TimTheoMa(m_makh);
        }

        public void TimTheoTen(String m_tenkh)
        {
            m_SubjectData.TimTheoTen(m_tenkh);
        }
        #endregion
    }
}
