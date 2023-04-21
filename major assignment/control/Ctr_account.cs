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
    class Ctr_account
    {
        Data_account m_NguoiDungData = new Data_account();
        Inf_account m_NguoiDungInfo = new Inf_account();

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_NguoiDungData.LayDsNguoiDung();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.ThemDongMoi();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.ThemNguoiDung(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.LuuNguoiDung();
        }
        #endregion

        #region Dang nhap
        public int DangNhap(string m_Username, string m_Password)
        {
            DataTable m_DT = m_NguoiDungData.LayDsNguoiDung(m_Username);

            if (m_DT.Rows.Count == 0)
                return 0;

            String m_SysPass = m_DT.Rows[0]["password"].ToString();

            if (m_SysPass != m_Password)
                return 1;
            else
            {
                m_NguoiDungInfo.username = m_DT.Rows[0]["username"].ToString();

                uti.NguoiDung = m_NguoiDungInfo;
                return 2;
            }
        }
        #endregion

        #region Doi mat khau
        public void ChangePassword(String userName, String newPassword)
        {
            m_NguoiDungData.ChangePassword(userName, newPassword);
        }
        #endregion
    }
}
