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
    public partial class Frm_xoamonhoc : Form
    {
        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tablemh = new DataTable();
        DataTable tabledocgia = new DataTable();
        #endregion
        public Frm_xoamonhoc()
        {
            InitializeComponent();
        }

        private void Frm_xoamonhoc_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            HienThiComboBox();
            HienThiComboBoxGV();
        }
        private void HienThiComboBox()
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
        private void HienThiComboBoxGV()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_teacher";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            m_DataAdapter.Fill(table);
            cmbmagv.DataSource = table;
            cmbmagv.DisplayMember = "name";
            cmbmagv.ValueMember = "teacherId";
        }

        private void cmbmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmh.SelectedValue != null &&
                !cmbmh.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_subject WHERE subjectId=" + cmbmh.SelectedValue;
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                tabledocgia.Clear();
                m_DataAdapter.Fill(tabledocgia);
                txttenmh.Text = tabledocgia.Rows[0]["name"].ToString();
                txtcourcenumber.Text = tabledocgia.Rows[0]["courseNumber"].ToString();
                cmbmagv.SelectedValue = tabledocgia.Rows[0]["teacherId"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "Select subjectId from tb_student_subject where subjectId=" + cmbmh.SelectedValue;

            OleDbDataReader reader1 = m_Command.ExecuteReader();

            if (reader1.Read())
            {
                MessageBox.Show("Môn học đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu
                reader1.Dispose();
                m_Command.CommandText = "delete from tb_subject where subjectId =" + cmbmh.SelectedValue;
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
