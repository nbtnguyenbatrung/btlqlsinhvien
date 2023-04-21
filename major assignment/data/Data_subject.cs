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
    class Data_subject
    {
        dataservice m_SubjectData = new dataservice();

        public DataTable LayDsMH()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_subject");
            m_SubjectData.Load(cmd);
            return m_SubjectData;
        }

        public DataRow ThemDongMoi()
        {
            return m_SubjectData.NewRow();
        }

        public void ThemMH(DataRow m_Row)
        {
            m_SubjectData.Rows.Add(m_Row);
        }

        public bool LuuMH()
        {
            return m_SubjectData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(int id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_subject WHERE subjectId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_SubjectData.Load(cmd);
            return m_SubjectData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_subject WHERE name LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_SubjectData.Load(cmd);
            return m_SubjectData;
        }
    }
}
