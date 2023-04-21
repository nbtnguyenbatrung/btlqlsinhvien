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
    class Data_teacher
    {
        dataservice m_teacherData = new dataservice();

        public DataTable LayDsGV()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_teacher");
            m_teacherData.Load(cmd);
            return m_teacherData;
        }

        public DataTable LayDsGVByMh(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT GV.teacherId, GV.name FROM tb_subject MH" +
                " INNER JOIN tb_teacher GV  ON " +
                "GV.teacherId = MH.teacherId where subjectid =" + id);
            m_teacherData.Load(cmd);
            return m_teacherData;
        }

        public DataRow ThemDongMoi()
        {
            return m_teacherData.NewRow();
        }

        public void ThemGV(DataRow m_Row)
        {
            m_teacherData.Rows.Add(m_Row);
        }

        public bool LuuGV()
        {
            return m_teacherData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(int id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_teacher WHERE teacherId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_teacherData.Load(cmd);
            return m_teacherData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_teacher WHERE name LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_teacherData.Load(cmd);
            return m_teacherData;
        }
    }
}
