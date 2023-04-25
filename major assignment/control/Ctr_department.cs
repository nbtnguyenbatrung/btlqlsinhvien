using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using major_assignment.information;
using major_assignment.data;
using major_assignment.component;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using System.Data;

namespace major_assignment.control
{
    class Ctr_department
    {
        Data_department m_DepartmentData = new Data_department();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_DepartmentData.LayDsKhoa();
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "departmentId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_DepartmentData.LayDsKhoa();
            cmbColumn.DisplayMember = "name";
            cmbColumn.ValueMember = "departmentId";
            cmbColumn.DataPropertyName = "departmentId";
            cmbColumn.HeaderText = "Tên khoa ";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtmakh,
                            TextBoxX txttenkh)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_DepartmentData.LayDsKhoa();

            txtmakh.DataBindings.Clear();
            txtmakh.DataBindings.Add("Text", bS, "departmentId");

            txttenkh.DataBindings.Clear();
            txttenkh.DataBindings.Add("Text", bS, "name");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public void HienThi(DataGridViewX dGV,
                            TextBoxX txtmakh,
                            TextBoxX txttenkh)
        {

            BindingSource bS = new BindingSource();
            bS.DataSource = m_DepartmentData.LayDsKhoa();

            txtmakh.DataBindings.Clear();
            txtmakh.DataBindings.Add("Text", bS, "departmentId");

            txttenkh.DataBindings.Clear();
            txttenkh.DataBindings.Add("Text", bS, "name");
            dGV.DataSource = null;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_DepartmentData.ThemDongMoi();
        }

        public void Themkhoa(DataRow m_Row)
        {
            m_DepartmentData.ThemKhoa(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool Luukhoa()
        {
            return m_DepartmentData.LuuKhoa();
        }
        #endregion

        #region Tim kiem
        public void TimTheoMa(int m_makh)
        {
            m_DepartmentData.TimTheoMa(m_makh);
        }

        public void TimTheoTen(String m_tenkh)
        {
            m_DepartmentData.TimTheoTen(m_tenkh);
        }
        #endregion
    }
}
