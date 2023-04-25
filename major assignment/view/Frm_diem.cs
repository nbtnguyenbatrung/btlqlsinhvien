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
using major_assignment.control;
using DevComponents.DotNetBar;

namespace major_assignment.view
{
    public partial class Frm_diem : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tableKhoa = new DataTable();
        DataTable tableMh = new DataTable();
        #endregion

        public Frm_diem()
        {
            InitializeComponent();
        }

        private void Frm_diem_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            loadData();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu(txtdiemthi.Text.Trim()) && txtmadiem.Text.Trim() != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " UPDATE tb_student_subject SET point= " + txtdiemthi.Text.Trim() +
                    " WHERE ID = " + txtmadiem.Text;
                m_Command.ExecuteNonQuery();

                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo!");


                loadData();
                // Trả tài nguyên
            }
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            string string_sql = "SELECT * FROM tb_student_subject";
            if (cbxmh.Checked && cbxkhoa.Checked)
            {
                string_sql = " SELECT id, S.subjectId AS subjectViewId, S.name AS subjectName ," +
                " PL.point AS point , HV.studentId AS studentViewId , HV.name AS studentName " +
                                            "FROM (tb_student HV INNER JOIN tb_student_subject PL ON HV.studentId = PL.studentId) " +
                                            "INNER JOIN tb_subject S ON s.subjectId = PL.subjectId " +
                                            "WHERE PL.departmentId =" + cmbmakhoa.SelectedValue +" AND PL.subjectId = " + cmbmamh.SelectedValue;
            }
            if (cbxmh.Checked && !cbxkhoa.Checked)
            {
                string_sql = " SELECT id, S.subjectId AS subjectViewId, S.name AS subjectName ," +
                " PL.point AS point , HV.studentId AS studentViewId , HV.name AS studentName " +
                                            "FROM (tb_student HV INNER JOIN tb_student_subject PL ON HV.studentId = PL.studentId) " +
                                            "INNER JOIN tb_subject S ON s.subjectId = PL.subjectId " +
                                            "WHERE PL.subjectId = " + cmbmamh.SelectedValue;
            }
            if (!cbxmh.Checked && cbxkhoa.Checked)
            {
                string_sql = " SELECT id, S.subjectId AS subjectViewId, S.name AS subjectName ," +
                " PL.point AS point , HV.studentId AS studentViewId , HV.name AS studentName " +
                                            "FROM (tb_student HV INNER JOIN tb_student_subject PL ON HV.studentId = PL.studentId) " +
                                            "INNER JOIN tb_subject S ON s.subjectId = PL.subjectId " +
                                            "WHERE HV.departmentId =" + cmbmakhoa.SelectedValue;
            }

            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = string_sql;
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            table.Clear();
            m_DataAdapter.Fill(table);
            dgvdiemthi.DataSource = table;
        }

        private void loadData()
        {
            HienThiComboBox();
            HienThiComboBoxMH();
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = " SELECT id, S.subjectId AS subjectViewId, S.name AS subjectName ," +
                " PL.point AS point , HV.studentId AS studentViewId , HV.name AS studentName " +
                                            "FROM (tb_student HV INNER JOIN tb_student_subject PL ON HV.studentId = PL.studentId) " +
                                            "INNER JOIN tb_subject S ON s.subjectId = PL.subjectId " ;
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            table.Clear();
            m_DataAdapter.Fill(table);
            dgvdiemthi.DataSource = table;
        }

        private void HienThiComboBox()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_department";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            tableKhoa.Clear();
            m_DataAdapter.Fill(tableKhoa);
            cmbmakhoa.DataSource = tableKhoa;
            cmbmakhoa.DisplayMember = "name";
            cmbmakhoa.ValueMember = "departmentId";
        }
        private void HienThiComboBoxMH()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_subject";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            tableMh.Clear();
            m_DataAdapter.Fill(tableMh);
            cmbmamh.DataSource = tableMh;
            cmbmamh.DisplayMember = "name";
            cmbmamh.ValueMember = "subjectId";
        }

        #region kiểm tr trươc khi luu 
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            if (cellString.Trim() == "")
            {
                MessageBoxEx.Show("Giá trị của ô * không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            cbxkhoa.Checked = false;
            cbxmh.Checked = true;

            loadData();
        }

        private void dgvdiemthi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow slc_row = dgvdiemthi.Rows[e.RowIndex];
            for (int i = 0; i < slc_row.Cells.Count; i++)
            {
                txtmadiem.Text = slc_row.Cells[0].Value.ToString();
                txtmamh.Text = slc_row.Cells[1].Value.ToString();
                txttenmh.Text = slc_row.Cells[2].Value.ToString();
                txtmasv.Text = slc_row.Cells[4].Value.ToString();
                txttensv.Text = slc_row.Cells[5].Value.ToString();                
                txtdiemthi.Text = slc_row.Cells[3].Value.ToString();
            }
        }
    }
}
