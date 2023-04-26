using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using major_assignment.component;

namespace major_assignment.view
{
    public partial class Frm_listhvmh : Form
    {
        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        #endregion
        public Frm_listhvmh()
        {
            InitializeComponent();
        }

        private void Frm_listhvmh_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            loadData();
        }
        private void loadData()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT tb_student.studentId AS studentId , tb_student.name AS studentName," +
                "tb_subject.subjectId AS subjectId,tb_subject.name AS subjectName ," +
                "tb_student_subject.ID AS id FROM " +
                "(tb_student INNER JOIN tb_student_subject ON tb_student.studentId = tb_student_subject.studentId) " +
                "INNER JOIN tb_subject ON tb_subject.subjectId = tb_student_subject.subjectId";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            table.Clear();
            m_DataAdapter.Fill(table);
            dgvhvmh.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvhv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvhvmh.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
