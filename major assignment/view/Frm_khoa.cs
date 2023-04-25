using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using major_assignment.control;
using major_assignment.component;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace major_assignment.view
{
    public partial class Frm_khoa : Office2007Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        #endregion

        public Frm_khoa()
        {
            
            InitializeComponent();
            
        }

        private void Frm_khoa_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            loadData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            btnedit.Visible = false;
            btnxoa.Visible = false;
            btnluu.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " UPDATE tb_department SET name ='" + txttenkh.Text.Trim() + "'" +
                    "WHERE departmentId = " + Int64.Parse(txtmakh.Text);
                m_Command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                loadData();
            }                
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu(txttenkh.Text))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = " insert into tb_department(name) values('" + txttenkh.Text.Trim() + "')";
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "Select departmentId from tb_student where departmentId=" + txtmakh.Text;

                OleDbDataReader reader1 = m_Command.ExecuteReader();

                if (reader1.Read())
                {
                    MessageBox.Show("Khoa đang được sử dụng không thể xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thuc hien xoa du lieu
                    reader1.Dispose();
                    m_Command.CommandText = "delete from tb_department where departmentId =" + txtmakh.Text;
                    m_Command.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                    loadData();
                    txtmakh.Text = "";
                    txttenkh.Text = "";
                }
            }                
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (txttk.Text.Trim() != "")
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_department WHERE name LIKE '%" + txttk.Text.Trim() + "%'";
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                table.Clear();
                m_DataAdapter.Fill(table);
                dgvkhoa.DataSource = table;
            }
               
        }

        private void loadData()
        {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_department";
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                table.Clear();
                m_DataAdapter.Fill(table);
                dgvkhoa.DataSource = table;             
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            btnedit.Visible = true;
            btnxoa.Visible = true;
            btnluu.Visible = false;
            btnHuy.Visible = false;
            loadData();
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

        private void dgvkhoa_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow slc_row = dgvkhoa.Rows[e.RowIndex];
            for (int i = 0; i < slc_row.Cells.Count; i++)
            {
                txtmakh.Text = slc_row.Cells[1].Value.ToString();
                txttenkh.Text = slc_row.Cells[2].Value.ToString();
            }
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            loadData();
        }

        private void dgvkhoa_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvkhoa.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
