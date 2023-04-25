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
    public partial class Frm_giaovien : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tableTeacher = new DataTable();
        #endregion

        public Frm_giaovien()
        {
            InitializeComponent();
        }

        private void Frm_giaovien_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            loadData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtmagv.Text = "";
            txttengv.Text = "";
            btnedit.Visible = false;
            btnxoa.Visible = false;
            btnluu.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmagv.Text != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "Select teacherId from tb_subject where teacherId=" + txtmagv.Text;

                OleDbDataReader reader1 = m_Command.ExecuteReader();

                if (reader1.Read())
                {
                    MessageBox.Show("Môn học đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thuc hien xoa du lieu
                    reader1.Dispose();
                    m_Command.CommandText = "delete from tb_teacher where teacherId =" + txtmagv.Text;
                    m_Command.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                    loadData();
                    txtmagv.Text = "";
                    txttengv.Text = "";
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu(txttengv.Text) )
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " insert into tb_teacher(name) values('" + txttengv.Text.Trim() +"')";
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
            txtmagv.Text = "";
            txttengv.Text = "";
            btnedit.Visible = true;
            btnxoa.Visible = true;
            btnluu.Visible = false;
            btnHuy.Visible = false;
            loadData();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmagv.Text != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " UPDATE tb_teacher SET name ='" + txttengv.Text.Trim() + "', " +
                    " WHERE subjectId = " + Int64.Parse(txtmagv.Text);
                m_Command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                loadData();
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (txttk.Text.Trim() != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_teacher WHERE name LIKE '%" + txttk.Text.Trim() + "%'";
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                table.Clear();
                m_DataAdapter.Fill(table);
                dgvmh.DataSource = table;
            }
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            loadData();
        }

        private void loadData()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_teacher";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            table.Clear();
            m_DataAdapter.Fill(table);
            dgvmh.DataSource = table;
        }

        private void dgvmh_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow slc_row = dgvmh.Rows[e.RowIndex];
            for (int i = 0; i < slc_row.Cells.Count; i++)
            {
                txtmagv.Text = slc_row.Cells[1].Value.ToString();
                txttengv.Text = slc_row.Cells[2].Value.ToString();
            }
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

        private void dgvmh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvmh.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
