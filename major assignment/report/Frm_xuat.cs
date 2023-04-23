using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using major_assignment.component;
using major_assignment.data;
using Microsoft.Reporting.WinForms;

namespace major_assignment.report
{
    public partial class Frm_xuat : Form
    {
        string m_studentId;
        Data_student m_StudentData = new Data_student();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        public Frm_xuat(string studentId)
        {
            InitializeComponent();
            m_studentId = studentId;
        }

        private void Frm_xuat_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT tb_student_subject.subjectId, tb_subject.name AS studentName, tb_teacher.name AS teacherName, tb_subject.courseNumber, tb_student_subject.point " +
                        "FROM(tb_student_subject INNER JOIN tb_subject ON tb_student_subject.subjectId = tb_subject.subjectId) " +
                        "INNER JOIN tb_teacher ON tb_subject.teacherId = tb_teacher.teacherId " +
                        "WHERE tb_student_subject.studentId = " + Int64.Parse(m_studentId) + " ;", conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\major assignment\major assignment\report\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            IList<ReportParameter> param = new List<ReportParameter>();
            DataTable m_DT = m_StudentData.LayDssinhvienView();

            String studentId = "";
            String name = "";
            String birthday = "";
            String placeOfBirth = "";
            String gender = "";
            String address = "";
            String departmentId = "";
            String departmentName = "";
            foreach (DataRow Row in m_DT.Rows)
            {
                studentId = Row["studentId"].ToString();
                name = Row["name"].ToString();
                birthday = Row["birthday"].ToString();
                placeOfBirth = Row["placeOfBirth"].ToString();
                gender = Row["gender"].ToString();
                address = Row["address"].ToString();
                departmentId = Row["departmentId"].ToString();
                departmentName = Row["departmentName"].ToString();
            }
            param.Add(new ReportParameter("studentId", studentId));
            param.Add(new ReportParameter("name", name));
            param.Add(new ReportParameter("birthday", birthday));            
            param.Add(new ReportParameter("placeOfBirth", placeOfBirth));
            param.Add(new ReportParameter("gender", gender));
            param.Add(new ReportParameter("address", address));
            param.Add(new ReportParameter("departmentId", departmentId));
            param.Add(new ReportParameter("namedepartment", departmentName));

            DataTable m_DTNUMBER = m_StudentData.LayNumber(m_studentId);
            String numberSubject = "";
            foreach (DataRow Row in m_DTNUMBER.Rows)
            {
                numberSubject = Row["numberSubject"].ToString();
            }
            DataTable m_DTDAT = m_StudentData.LayNumberDat(m_studentId);
            String numbersubjectdat = "";
            foreach (DataRow Row in m_DTDAT.Rows)
            {
                numbersubjectdat = Row["numbersubjectdat"].ToString();
            }
            DataTable m_DTKODAT = m_StudentData.LayNumberKoDat(m_studentId);
            string numbersubjectkodat = "";
            foreach (DataRow Row in m_DTKODAT.Rows)
            {
                numbersubjectkodat = Row["numbersubjectkodat"].ToString();
            }
            param.Add(new ReportParameter("numberSubject", numberSubject));
            param.Add(new ReportParameter("numbersubjectdat", numbersubjectdat));
            param.Add(new ReportParameter("numbersubjectkodat", numbersubjectkodat));
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
            conn.Close();
        }
    }
}
