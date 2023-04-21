using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using major_assignment.information;
using major_assignment.view;
using major_assignment.report;

namespace major_assignment.component
{
    #region uti
    public static class uti
    {
        public static Inf_account NguoiDung;
        public static String DatabaseName;
    }
    #endregion

    #region Các hàm xử lý tập tin XML
    public class XML
    {
        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch
            {
                MessageBoxEx.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xmlR;
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(username);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(password);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
    }
    #endregion

    #region ThamSo
    public static class ThamSo
    {
        #region Fields

        public static Frm_connect m_FrmConnection = null;
        public static Frm_department m_FrmDepartment = null;
        public static Frm_subject m_FrmSubbject = null;
        public static Frm_teacher m_FrmTeacher = null;
        public static Frm_student m_FrmStudent = null;
        public static Frm_student_subject m_FrmStudentSubject = null;
        public static Frm_diemthi m_FrmDiemThi = null;
        public static Frm_bonus m_FrmBonus = null;
        public static Frm_discipline m_FrmDiscipline = null;
        public static Frm_policy m_FrmPolicy = null;
        public static Frm_tksinhvien m_FrmTksinhvien = null;
        #endregion

        #region show form 

        public static void ShowFormKhoa()
        {

            if (m_FrmDepartment == null || m_FrmDepartment.IsDisposed)
            {
                try
                {
                    m_FrmDepartment = new Frm_department();
                    m_FrmDepartment.MdiParent = Frm_main.ActiveForm;
                    m_FrmDepartment.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmDepartment.Activate();
        }
        public static void ShowFormMh()
        {

            if (m_FrmSubbject == null || m_FrmSubbject.IsDisposed)
            {
                try
                {
                    m_FrmSubbject = new Frm_subject();
                    m_FrmSubbject.MdiParent = Frm_main.ActiveForm;
                    m_FrmSubbject.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmSubbject.Activate();
        }
        public static void ShowFormGV()
        {

            if (m_FrmTeacher == null || m_FrmTeacher.IsDisposed)
            {
                try
                {
                    m_FrmTeacher = new Frm_teacher();
                    m_FrmTeacher.MdiParent = Frm_main.ActiveForm;
                    m_FrmTeacher.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmTeacher.Activate();
        }
        public static void ShowFormSV()
        {

            if (m_FrmStudent == null || m_FrmStudent.IsDisposed)
            {
                try
                {
                    m_FrmStudent = new Frm_student();
                    m_FrmStudent.MdiParent = Frm_main.ActiveForm;
                    m_FrmStudent.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmStudent.Activate();
        }
        public static void ShowFormSS()
        {

            if (m_FrmStudentSubject == null || m_FrmStudentSubject.IsDisposed)
            {
                try
                {
                    m_FrmStudentSubject = new Frm_student_subject();
                    m_FrmStudentSubject.MdiParent = Frm_main.ActiveForm;
                    m_FrmStudentSubject.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmStudentSubject.Activate();
        }
        public static void ShowFormDT()
        {

            if (m_FrmDiemThi == null || m_FrmDiemThi.IsDisposed)
            {
                try
                {
                    m_FrmDiemThi = new Frm_diemthi();
                    m_FrmDiemThi.MdiParent = Frm_main.ActiveForm;
                    m_FrmDiemThi.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmDiemThi.Activate();
        }
        public static void ShowFormBonus()
        {

            if (m_FrmBonus == null || m_FrmBonus.IsDisposed)
            {
                try
                {
                    m_FrmBonus = new Frm_bonus();
                    m_FrmBonus.MdiParent = Frm_main.ActiveForm;
                    m_FrmBonus.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmBonus.Activate();
        }
        public static void ShowFormDiscipline()
        {

            if (m_FrmDiscipline == null || m_FrmDiscipline.IsDisposed)
            {
                try
                {
                    m_FrmDiscipline = new Frm_discipline();
                    m_FrmDiscipline.MdiParent = Frm_main.ActiveForm;
                    m_FrmDiscipline.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmDiscipline.Activate();
        }
        public static void ShowFormPolicy()
        {

            if (m_FrmPolicy == null || m_FrmPolicy.IsDisposed)
            {
                try
                {
                    m_FrmPolicy = new Frm_policy();
                    m_FrmPolicy.MdiParent = Frm_main.ActiveForm;
                    m_FrmPolicy.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmPolicy.Activate();
        }
        public static void ShowFormTksinhvien()
        {

            if (m_FrmTksinhvien == null || m_FrmTksinhvien.IsDisposed)
            {
                try
                {
                    m_FrmTksinhvien = new Frm_tksinhvien();
                    m_FrmTksinhvien.MdiParent = Frm_main.ActiveForm;
                    m_FrmTksinhvien.Show();
                }
                catch
                {

                }

            }
            else
                m_FrmTksinhvien.Activate();
        }
        #endregion
    }
    #endregion
}
