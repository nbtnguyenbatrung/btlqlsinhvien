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
    public partial class Frm_hocvien_monhoc : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tableStudent = new DataTable();
        DataTable tableSubject = new DataTable();
        #endregion
        public Frm_hocvien_monhoc()
        {
            InitializeComponent();
        }

        private void Frm_hocvien_monhoc_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            loadData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtmadk.Text = "";
            btnxoa.Visible = false;
            btnluu.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu(cbxmonhoc.Text) && KiemTraTruocKhiLuu(cmbhocvien.Text))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " insert into tb_student_subject(subjectId,studentId) " +
                    "values(" + cbxmonhoc.SelectedValue + "," + cmbhocvien.SelectedValue + ")";
                m_Command.ExecuteNonQuery();

                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo!");


                loadData();
                // Trả tài nguyên

                btnxoa.Visible = true;
                btnluu.Visible = false;
                btnHuy.Visible = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnxoa.Visible = true;
            btnluu.Visible = false;
            btnHuy.Visible = false;
            loadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmadk.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thuc hien xoa du lieu
                    m_Command.CommandText = "delete from tb_student_subject where ID =" + txtmadk.Text;
                    m_Command.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                    loadData();         
                }
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (txttk.Text.Trim() != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT tb_student.studentId AS studentId , tb_student.name AS studentName," +
                "tb_subject.subjectId AS subjectId,tb_subject.name AS subjectName ," +
                "tb_student_subject.ID AS id FROM " +
                "(tb_student INNER JOIN tb_student_subject ON tb_student.studentId = tb_student_subject.studentId) " +
                "INNER JOIN tb_subject ON tb_subject.subjectId = tb_student_subject.subjectId" +
                " WHERE tb_student.name LIKE '%" + txttk.Text.Trim() + "%' or" +
                " tb_subject.name LIKE '%" + txttk.Text.Trim() + "%' ";
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                table.Clear();
                m_DataAdapter.Fill(table);
                dgvsv.DataSource = table;
            }
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            loadData();
        }

        private void loadData()
        {
            HienThiComboBoxStudent();
            HienThiComboBoxSubject();
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
            dgvsv.DataSource = table;
        }

        private void HienThiComboBoxStudent()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_student";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            tableStudent.Clear();
            m_DataAdapter.Fill(tableStudent);
            cmbhocvien.DataSource = tableStudent;
            cmbhocvien.DisplayMember = "name";
            cmbhocvien.ValueMember = "studentId";
        }
        private void HienThiComboBoxSubject()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_subject";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            tableSubject.Clear();
            m_DataAdapter.Fill(tableSubject);
            cbxmonhoc.DataSource = tableSubject;
            cbxmonhoc.DisplayMember = "name";
            cbxmonhoc.ValueMember = "subjectId";
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

        private void dgvsv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow slc_row = dgvsv.Rows[e.RowIndex];
            for (int i = 0; i < slc_row.Cells.Count; i++)
            {
                txtmadk.Text = slc_row.Cells[1].Value.ToString();
                cmbhocvien.SelectedValue = slc_row.Cells[3].Value.ToString();
                cbxmonhoc.SelectedValue = slc_row.Cells[5].Value.ToString();
            }
        }

        private void dgvsv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvsv.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
