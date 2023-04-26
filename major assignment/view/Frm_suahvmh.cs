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
    public partial class Frm_suahvmh : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tabledocgia = new DataTable();
        DataTable tablemh = new DataTable();
        DataTable tablehv = new DataTable();
        #endregion

        public Frm_suahvmh()
        {
            InitializeComponent();
        }

        private void Frm_suahvmh_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            HienThiComboBox();
            HienThiComboBoxMH();
            HienThiComboBoxHV();
        }
        private void HienThiComboBox()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT id, ID & ' - ' & tb_student.name & ' - ' & tb_subject.name AS nameDiem " +
                    "FROM(tb_student_subject INNER JOIN tb_student ON tb_student_subject.studentId = tb_student.studentId) " +
                    "INNER JOIN tb_subject ON tb_student_subject.subjectId = tb_subject.subjectId;";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            m_DataAdapter.Fill(table);
            cmbmadiem.DataSource = table;
            cmbmadiem.DisplayMember = "nameDiem";
            cmbmadiem.ValueMember = "id";
        }
        private void HienThiComboBoxHV()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_student";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            m_DataAdapter.Fill(tablehv);
            cmbhv.DataSource = tablehv;
            cmbhv.DisplayMember = "name";
            cmbhv.ValueMember = "studentId";
        }
        private void HienThiComboBoxMH()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_subject";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            m_DataAdapter.Fill(tablemh);
            cmbmh.DataSource = tablemh;
            cmbmh.DisplayMember = "name";
            cmbmh.ValueMember = "subjectId";
        }
        private void cmbmadiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbmadiem.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_student_subject WHERE id=" + cmbmadiem.SelectedValue;
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                tabledocgia.Clear();
                m_DataAdapter.Fill(tabledocgia);
                cmbhv.SelectedValue = tabledocgia.Rows[0]["studentId"].ToString();
                cmbmh.SelectedValue = tabledocgia.Rows[0]["subjectId"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = " UPDATE tb_student_subject SET studentId =" + cmbhv.SelectedValue +
                " subjectId = " + cmbmh.SelectedValue +
                "WHERE id = " + cmbmadiem.SelectedValue;
            m_Command.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
