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
using DevComponents.Editors.DateTimeAdv;

namespace major_assignment.control
{
    class Ctr_student
    {
        Data_student m_StudentData = new Data_student();

        #region điều hướng hiển thị cho phân lớp 

        #region hiển thị danh sách học viên chưa được phân lớp 
        public void HienThiDsHocVienall(ListViewEx lV)
        {
            DataTable m_DT = m_StudentData.LayDssinhvienall();

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["studentId"].ToString();
                item.SubItems.Add(Row["name"].ToString());

                lV.Items.Add(item);
            }
        }
        public void HienThiDsHocVientheoma(String id, ListViewEx lV)
        {
            DataTable m_DT = m_StudentData.TimTheoMa(id);

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["studentId"].ToString();
                item.SubItems.Add(Row["name"].ToString());

                lV.Items.Add(item);
            }
        }
        public void HienThiDsHocVientheoten(String name, ListViewEx lV)
        {
            DataTable m_DT = m_StudentData.TimTheoTen(name);

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["studentId"].ToString();
                item.SubItems.Add(Row["name"].ToString());

                lV.Items.Add(item);
            }
        }
        public void HienThiDsHocVientheohoa(String idkhoa, ListViewEx lV)
        {
            DataTable m_DT = m_StudentData.TimTheoKhoa(idkhoa);

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["studentId"].ToString();
                item.SubItems.Add(Row["name"].ToString());

                lV.Items.Add(item);
            }
        }
        #endregion
        #endregion

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_StudentData.LayDsSV();
            comboBox.DisplayMember = "name";
            comboBox.ValueMember = "studentId";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_StudentData.LayDsSV();
            cmbColumn.DisplayMember = "name";
            cmbColumn.ValueMember = "studentId";
            cmbColumn.DataPropertyName = "studentId";
            cmbColumn.HeaderText = "Tên sinh viên ";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtmasv,
                            TextBoxX txttensv,
                            DateTimeInput dtpns,
                            TextBoxX txtnoisinh,
                            TextBoxX txtgt,
                            TextBoxX txtdiachi,
                            ComboBoxEx cmbmak)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_StudentData.LayDsSV();

            txtmasv.DataBindings.Clear();
            txtmasv.DataBindings.Add("Text", bS, "studentId");

            txttensv.DataBindings.Clear();
            txttensv.DataBindings.Add("Text", bS, "name");

            dtpns.DataBindings.Clear();
            dtpns.DataBindings.Add("Text", bS, "birthday");

            txtnoisinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Add("Text", bS, "placeOfBirth");

            txtgt.DataBindings.Clear();
            txtgt.DataBindings.Add("Text", bS, "gender");

            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", bS, "address");

            cmbmak.DataBindings.Clear();
            cmbmak.DataBindings.Add("SelectedValue", bS, "departmentId");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public void HienThiDS(DataGridViewX dGV,
                            BindingNavigator bN,
                            bool checkname,
                            bool checkidkhoa,
                            string name,
                            string idkhoa)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_StudentData.LayDsSVH(checkname, checkidkhoa, name, idkhoa);
            
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_StudentData.ThemDongMoi();
        }

        public void ThemSV(DataRow m_Row)
        {
            m_StudentData.ThemSV(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuSV()
        {
            return m_StudentData.LuuSV();
        }
        #endregion

        #region Tim kiem
        public void TimTheoMa(String m_makh)
        {
            m_StudentData.TimTheoMa(m_makh);
        }

        public void TimTheoTen(String m_tenkh)
        {
            m_StudentData.TimTheoTen(m_tenkh);
        }
        #endregion

        #region lưu học viên sau khi phân lớp 
        public void LuuHVVaoBangPhanLop(ListViewEx hocSinh, String subjectId)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                m_StudentData.LuuHVVaoBangPhanLop(item.SubItems[0].Text.ToString(), subjectId);
            }
        }
        #endregion

        #region hiển thị danh sách học viên có danh sách điểm thi 
        public void HienThiDsHocViencodiem(string idkhoa, string idmonhoc, DataGridView dgv, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_StudentData.LayDshocviencodiem(idkhoa, idmonhoc);
            bN.BindingSource = bS;
            dgv.DataSource = bS;

        }
        public void HienThiDsHocViencodiemkhoa(string idkhoa, DataGridView dgv, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_StudentData.LayDshocviencodiemKhoa(idkhoa);
            bN.BindingSource = bS;
            dgv.DataSource = bS;

        }
        public void HienThiDsHocViencodiemMonHoc(string idmonhoc, DataGridView dgv, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_StudentData.LayDshocviencodiemMonhoc(idmonhoc);
            bN.BindingSource = bS;
            dgv.DataSource = bS;

        }
        #endregion

        #region lưu học viên khen thuong
        public void LuuHVVaoBangkhenthuong(ListViewEx hocSinh,  DateTime date)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                m_StudentData.LuuHVVaoBangkhenthuong(
                    item.SubItems[0].Text.ToString(), date);
            }
        }
        #endregion
        #region lưu học viên ky luat
        public void LuuHVVaoBangkyluat(ListViewEx hocSinh, DateTime date)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                m_StudentData.LuuHVVaoBangkyluat(
                    item.SubItems[0].Text.ToString(), date);
            }
        }
        #endregion

        #region hiển thị danh sách học viên chính sách
        public void HienThiDsHocVienchinhsach(ListViewEx lV)
        {
            DataTable m_DT = m_StudentData.LayDssinhvienchinhsach();

            lV.Items.Clear();
            foreach (DataRow Row in m_DT.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["studentId"].ToString();
                item.SubItems.Add(Row["name"].ToString());

                lV.Items.Add(item);
            }
        }
        #endregion

        #region lưu học viên chinh sach
        public void LuuHVVaochinhsach(ListViewEx hocSinh)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                if (m_StudentData.kiemtra(item.SubItems[0].Text.ToString()))
                {
                    m_StudentData.LuuHVVaoBangchinhsach(item.SubItems[0].Text.ToString());
                }
            }
        }
        #endregion
    }
}
