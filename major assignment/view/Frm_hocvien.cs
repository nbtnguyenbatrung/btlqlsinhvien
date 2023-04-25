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
    public partial class Frm_hocvien : Form
    {


        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tableDepartment = new DataTable();
        #endregion

        public Frm_hocvien()
        {
            InitializeComponent();
        }

        private void Frm_hocvien_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            loadData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txttensv.Text = "";
            txtdiachi.Text = "";
            txtnoisinh.Text = "";
            cbxgt.SelectedValue = "Nam";
            dtpns.Value = DateTime.Today;
            btnedit.Visible = false;
            btnxoa.Visible = false;
            btnluu.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " UPDATE tb_student SET name ='" + txttensv.Text.Trim() + "', " +
                    "birthday='" + dtpns.Value.ToString() + "', placeOfBirth='" + txtnoisinh.Text.Trim() + "'," +
                    "gender='" + cbxgt.Text + "',address='" +txtdiachi.Text.Trim() +"'," +
                    "departmentId=" + cmbkhoa.SelectedValue +
                    " WHERE studentId = " + Int64.Parse(txtmasv.Text);
                m_Command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                loadData();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu(txttensv.Text) && KiemTraTruocKhiLuu(cmbkhoa.Text))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " insert into tb_student(name,birthday,placeOfBirth,gender,address,departmentId) " +
                    "values('" + txttensv.Text.Trim() +
                    "','" + dtpns.Value.ToString() + "','" + txtnoisinh.Text.Trim() + "','" +
                    cbxgt.Text + "','" + txtdiachi.Text.Trim() + "'," + cmbkhoa.SelectedValue + ")";
                m_Command.ExecuteNonQuery();

                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo!");


                loadData();
                // Trả tài nguyên

                btnedit.Visible = true;
                btnxoa.Visible = true;
                btnluu.Visible = false;
                btnHuy.Visible = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txttensv.Text = "";
            txtdiachi.Text = "";
            txtnoisinh.Text = "";
            cbxgt.Text = "Nam";
            dtpns.Value = DateTime.Today;
            btnedit.Visible = true;
            btnxoa.Visible = true;
            btnluu.Visible = false;
            btnHuy.Visible = false;
            loadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "Select subjectId from tb_student_subject where subjectId=" + txtmasv.Text;

                OleDbDataReader reader1 = m_Command.ExecuteReader();

                if (reader1.Read())
                {
                    MessageBox.Show("Môn học đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thuc hien xoa du lieu
                    reader1.Dispose();
                    m_Command.CommandText = "delete from tb_student where studentId =" + txtmasv.Text;
                    m_Command.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                    loadData();
                    txttensv.Text = "";
                    txtdiachi.Text = "";
                    txtnoisinh.Text = "";
                    cbxgt.SelectedValue = "Nam";
                    dtpns.Value = DateTime.Today;
                }
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (txttk.Text.Trim() != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT tb_student.studentId AS studentId , tb_student.name AS name," +
                "tb_student.birthday AS birthday,tb_student.placeOfBirth AS placeOfBirth ," +
                "tb_student.gender AS gender, tb_student.address AS address, " +
                "tb_department.departmentId AS departmentId, tb_department.name AS departmentName  FROM " +
                "tb_student INNER JOIN tb_department ON tb_student.departmentId = tb_department.departmentId" +
                " WHERE tb_student.name LIKE '%" + txttk.Text.Trim() + "%'";
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

        private void dgvsv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow slc_row = dgvsv.Rows[e.RowIndex];
            for (int i = 0; i < slc_row.Cells.Count; i++)
            {
                txtmasv.Text = slc_row.Cells[1].Value.ToString();
                txttensv.Text = slc_row.Cells[2].Value.ToString();
                dtpns.Value = DateTime.Parse(slc_row.Cells[3].Value.ToString());
                txtnoisinh.Text = slc_row.Cells[4].Value.ToString();
                cbxgt.Text = slc_row.Cells[5].Value.ToString();
                txtdiachi.Text = slc_row.Cells[6].Value.ToString();
                cmbkhoa.SelectedValue = slc_row.Cells[7].Value.ToString();
            }
        }

        private void loadData()
        {
            HienThiComboBox();
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT tb_student.studentId AS studentId , tb_student.name AS name," +
                "tb_student.birthday AS birthday,tb_student.placeOfBirth AS placeOfBirth ," +
                "tb_student.gender AS gender, tb_student.address AS address, " +
                "tb_department.departmentId AS departmentId, tb_department.name AS departmentName  FROM " +
                "tb_student INNER JOIN tb_department ON tb_student.departmentId = tb_department.departmentId ";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            table.Clear();
            m_DataAdapter.Fill(table);
            dgvsv.DataSource = table;
        }

        private void HienThiComboBox()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_department";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            tableDepartment.Clear();
            m_DataAdapter.Fill(tableDepartment);
            cmbkhoa.DataSource = tableDepartment;
            cmbkhoa.DisplayMember = "name";
            cmbkhoa.ValueMember = "departmentId";
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

        private void dgvsv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvsv.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
