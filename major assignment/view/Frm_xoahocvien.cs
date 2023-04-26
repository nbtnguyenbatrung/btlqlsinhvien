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
    public partial class Frm_xoahocvien : Form
    {
        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tablekhoa = new DataTable();
        DataTable tableselect = new DataTable();
        #endregion
        public Frm_xoahocvien()
        {
            InitializeComponent();
        }

        private void Frm_xoahocvien_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            HienThiComboBox();
            HienThiComboBoxKHOA();
        }
        private void HienThiComboBox()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_student";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            m_DataAdapter.Fill(table);
            cmbmahv.DataSource = table;
            cmbmahv.DisplayMember = "name";
            cmbmahv.ValueMember = "studentId";
        }
        private void HienThiComboBoxKHOA()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_department";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            m_DataAdapter.Fill(tablekhoa);
            cmbkhoa.DataSource = tablekhoa;
            cmbkhoa.DisplayMember = "name";
            cmbkhoa.ValueMember = "departmentId";
        }

        private void cmbmahv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmahv.SelectedValue != null &&
                !cmbmahv.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_student WHERE studentId=" + cmbmahv.SelectedValue;
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                tableselect.Clear();
                m_DataAdapter.Fill(tableselect);
                txttensv.Text = tableselect.Rows[0]["name"].ToString();
                txtdiachi.Text = tableselect.Rows[0]["address"].ToString();
                txtnoisinh.Text = tableselect.Rows[0]["placeOfBirth"].ToString();
                cmbkhoa.SelectedValue = tableselect.Rows[0]["departmentId"].ToString();
                dtpns.Value = DateTime.Parse(tableselect.Rows[0]["birthday"].ToString());
                txtgt.Text = tableselect.Rows[0]["gender"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "Select subjectId from tb_student_subject where studentId=" + cmbmahv.SelectedValue;

            OleDbDataReader reader1 = m_Command.ExecuteReader();

            if (reader1.Read())
            {
                MessageBox.Show("Học viên đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu
                reader1.Dispose();
                m_Command.CommandText = "delete from tb_student where studentId =" + cmbmahv.SelectedValue;
                m_Command.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
