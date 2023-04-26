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
    public partial class Frm_listmonhoc : Form
    {
        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        #endregion
        public Frm_listmonhoc()
        {
            InitializeComponent();
        }

        private void Frm_listmonhoc_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadData()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT tb_subject.subjectId AS subjectId , tb_subject.name AS name," +
                "tb_subject.courseNumber AS courseNumber,tb_teacher.name AS teacherName  FROM " +
                "tb_subject INNER JOIN tb_teacher ON tb_subject.teacherId = tb_teacher.teacherId ";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            table.Clear();
            m_DataAdapter.Fill(table);
            dgvmh.DataSource = table;
        }

        private void dgvgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvmh.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
