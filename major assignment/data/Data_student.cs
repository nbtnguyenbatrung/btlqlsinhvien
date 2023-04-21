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
    class Data_student
    {
        dataservice m_StudentData = new dataservice();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);

        #region lấy dữ liệu sinh viên đợi được phân mon hoc 
        public DataTable LayDssinhvienall()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT HV.studentId , HV.name " +
                                             "FROM tb_student HV ");
            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        #endregion

        public DataTable LayDsSV()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_student");
            m_StudentData.Load(cmd);
            return m_StudentData;
        }

        public DataTable LayDsSVH(bool checkname, bool checkidkhoa, string name , string idkhoa)
        {
            string sql = "SELECT studentId, name FROM tb_student ";

            if (checkname && checkidkhoa)
            {
                sql += "WHERE departmentId = " + Int64.Parse(idkhoa);
                if (name != "")
                {
                    sql += "AND name LIKE '%" + name + "%' ";
                }
               
            }
            else if (!checkname && checkidkhoa)
            {
                sql += "WHERE departmentId = " + Int64.Parse(idkhoa);
            }
            else if (checkname && !checkidkhoa)
            {
                if (name != "")
                {
                    sql += "WHERE name LIKE '%" + name + "%' ";
                }
            }
            OleDbCommand cmd = new OleDbCommand(sql);
            m_StudentData.Load(cmd);
            return m_StudentData;
        }

        public DataRow ThemDongMoi()
        {
            return m_StudentData.NewRow();
        }

        public void ThemSV(DataRow m_Row)
        {
            m_StudentData.Rows.Add(m_Row);
        }

        public bool LuuSV()
        {
            return m_StudentData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_student WHERE studentId = @id ");
            cmd.Parameters.Add("id", OleDbType.VarChar).Value = id;

            m_StudentData.Load(cmd);
            return m_StudentData;
        }

        public DataTable TimTheoTen(String ten)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_student WHERE name LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", OleDbType.VarWChar).Value = ten;

            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        public DataTable TimTheoKhoa(String idkhoa)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM tb_student WHERE departmentId = @idkhoa ");
            cmd.Parameters.Add("idkhoa", OleDbType.VarWChar).Value = idkhoa;

            m_StudentData.Load(cmd);
            return m_StudentData;
        }

        #region lưu lại sau khi phân lớp 
        public void LuuHVVaoBangPhanLop(String subjectId, String studentId)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tb_student_subject " +
                "(subjectId , studentId) VALUES(@subjectId, @studentId)");
            cmd.Parameters.Add("subjectId", OleDbType.Integer).Value = Int64.Parse(subjectId);
            cmd.Parameters.Add("studentId", OleDbType.Integer).Value = Int64.Parse(studentId);

            m_StudentData.Load(cmd);

        }
        #endregion

        #region lấy danh sách học viên vào trong điểm thi 
        public DataTable LayDshocviencodiem(String idkhoa, String idmh)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT id, S.subjectId AS subjectViewId, S.name AS subjectName ," +
                " PL.point AS point , HV.studentId AS studentViewId , HV.name AS studentName " +
                                            "FROM (tb_student HV INNER JOIN tb_student_subject PL ON HV.studentId = PL.studentId) " +
                                            "INNER JOIN tb_subject S ON s.subjectId = PL.subjectId " +
                                            "WHERE PL.departmentId = @idkhoa AND PL.subjectId = @idmh ");

            cmd.Parameters.Add("idkhoa", OleDbType.Integer).Value = Int64.Parse(idkhoa);
            cmd.Parameters.Add("idmh", OleDbType.Integer).Value = Int64.Parse(idmh);

            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        public DataTable LayDshocviencodiemKhoa(String idkhoa)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT id, S.subjectId AS subjectViewId, S.name AS subjectName ," +
                " PL.point AS point , HV.studentId AS studentViewId , HV.name AS studentName " +
                                            "FROM (tb_student HV INNER JOIN tb_student_subject PL ON HV.studentId = PL.studentId) " +
                                            "INNER JOIN tb_subject S ON s.subjectId = PL.subjectId " +
                                            "WHERE HV.departmentId = @idkhoa ");

            cmd.Parameters.Add("idkhoa", OleDbType.Integer).Value = Int64.Parse(idkhoa);

            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        public DataTable LayDshocviencodiemMonhoc(String idmh)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT id, S.subjectId AS subjectViewId, S.name AS subjectName ," +
                " PL.point AS point , HV.studentId AS studentViewId , HV.name AS studentName " +
                                            "FROM (tb_student HV INNER JOIN tb_student_subject PL ON HV.studentId = PL.studentId) " +
                                            "INNER JOIN tb_subject S ON s.subjectId = PL.subjectId " +
                                            "WHERE PL.subjectId = @idmh ");

            cmd.Parameters.Add("idmh", OleDbType.Integer).Value = Int64.Parse(idmh);

            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        #endregion

        #region lưu lại khen thưởng
        public void LuuHVVaoBangkhenthuong(String studentId, DateTime date)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tb_bonus " +
                "(studentId , fromdate) VALUES(@studentId, '" +
                date.ToString("yyyy-MM-dd") + "')");
            cmd.Parameters.Add("studentId", OleDbType.Integer).Value = Int64.Parse(studentId);

            m_StudentData.Load(cmd);

        }
        #endregion

        #region lưu lại kỷ luật
        public void LuuHVVaoBangkyluat(String studentId, DateTime date)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tb_discipline " +
                "(studentId , fromdate) VALUES(@studentId, '" +
                date.ToString("yyyy-MM-dd") + "')");
            cmd.Parameters.Add("studentId", OleDbType.Integer).Value = Int64.Parse(studentId);

            m_StudentData.Load(cmd);

        }
        #endregion

        #region lấy dữ liệu sinh viên chính sách
        public DataTable LayDssinhvienchinhsach()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT HV.studentId , HV.name " +
                                             "FROM tb_policy INNER JOIN tb_student HV  " +
                                             "ON tb_policy.studentId = HV.studentId ");
            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        #endregion

        #region lưu lại sau khi chinh sach
        public void LuuHVVaoBangchinhsach(String id)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tb_policy (studentId) " +
                                            "VALUES(@id)");
            cmd.Parameters.Add("MAHV", OleDbType.Integer).Value = Int64.Parse(id);

            m_StudentData.Load(cmd);

        }

        public Boolean kiemtra(String id)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(" SELECT * FROM tb_policy WHERE studentId = @id", conn);
            cmd.Parameters.Add("MAHV", OleDbType.Integer).Value = Int64.Parse(id);
            OleDbDataReader reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                reader1.Dispose();
                cmd.Dispose();
                conn.Close();
                return false;

            }
            reader1.Dispose();
            cmd.Dispose();
            conn.Close();
            return true;

        }
        #endregion

        #region lấy dữ liệu sinh viên 
        public DataTable LayDssinhvienView()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT tb_student.studentId AS studentId,tb_student.name AS name, " +
                "tb_student.placeOfBirth AS placeOfBirth ,tb_student.gender AS gender,tb_student.birthday AS birthday," +
                "tb_student.address AS address ,tb_department.departmentId AS departmentId, " +
                " tb_department.name AS departmentName " + 
                "FROM tb_student INNER JOIN tb_department ON tb_student.departmentId = tb_department.departmentId; ");
            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        public DataTable LayNumber(string id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT Count(ID) AS numberSubject " +
                                            "FROM tb_student_subject WHERE studentId="+Int64.Parse(id) + ";");
            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        public DataTable LayNumberDat(string id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT Count(ID) AS numbersubjectdat " +
                                            "FROM tb_student_subject " +
                                            "WHERE point >= 4 AND studentId=" + Int64.Parse(id) + ";");
            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        public DataTable LayNumberKoDat(string id)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT Count(ID) AS numbersubjectkodat " +
                                            "FROM tb_student_subject " +
                                            "WHERE point < 4 AND studentId=" + Int64.Parse(id) + ";");
            m_StudentData.Load(cmd);
            return m_StudentData;
        }
        #endregion
    }
}
