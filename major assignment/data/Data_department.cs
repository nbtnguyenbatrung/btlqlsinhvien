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
    class Data_department
    {
        dataservice m_DepartmentData = new dataservice();

        public DataTable LayDsKhoa()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_department");
            m_DepartmentData.Load(cmd);
            return m_DepartmentData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DepartmentData.NewRow();
        }

        public void ThemKhoa(DataRow m_Row)
        {
            m_DepartmentData.Rows.Add(m_Row);
        }

        public bool LuuKhoa()
        {
            return m_DepartmentData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(int id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_department WHERE departmentId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_DepartmentData.Load(cmd);
            return m_DepartmentData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_department WHERE name LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_DepartmentData.Load(cmd);
            return m_DepartmentData;
        }
    }
}
