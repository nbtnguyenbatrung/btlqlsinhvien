using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using major_assignment.component;
using System.Data.OleDb;

namespace major_assignment.data
{
    public class Data_account
    {
        dataservice m_NguoiDungData = new dataservice();

        public DataTable LayDsNguoiDung()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_account");
            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }

        public DataTable LayDsNguoiDung(String m_Username)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_account WHERE username = @ten");
            cmd.Parameters.Add("ten", OleDbType.VarChar).Value = m_Username;

            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.NewRow();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.Rows.Add(m_Row);
        }

        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.ExecuteNoneQuery() > 0;
        }

        public void ChangePassword(String userName, String newPassword)
        {
            m_NguoiDungData.ChangePassword(userName, newPassword);
        }
    }
}
