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
    public partial class Frm_xoakhoa : Form
    {
        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        DataTable tabledocgia = new DataTable();
        #endregion
        public Frm_xoakhoa()
        {
            InitializeComponent();
        }

        private void Frm_xoakhoa_Load(object sender, EventArgs e)
        {
            string m_ConnectString = dataservice.ConnectionStringNew();
            m_Connection = new OleDbConnection(m_ConnectString);
            m_Connection.Open();
            HienThiComboBox();
        }
        private void HienThiComboBox()
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = "SELECT * FROM tb_department";
            m_Command.ExecuteNonQuery();
            m_DataAdapter.SelectCommand = m_Command;
            m_DataAdapter.Fill(table);
            cmbmakhoa.DataSource = table;
            cmbmakhoa.DisplayMember = "name";
            cmbmakhoa.ValueMember = "departmentId";
        }

        private void cmbmakhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmakhoa.SelectedValue != null &&
                !cmbmakhoa.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                m_Command = m_Connection.CreateCommand();
                m_Command.CommandText = "SELECT * FROM tb_department WHERE departmentId=" + cmbmakhoa.SelectedValue;
                m_Command.ExecuteNonQuery();
                m_DataAdapter.SelectCommand = m_Command;
                tabledocgia.Clear();
                m_DataAdapter.Fill(tabledocgia);
                txttenkhoa.Text = tabledocgia.Rows[0]["name"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            m_Command.CommandText = "delete from tb_department where departmentId =" + cmbmakhoa.SelectedValue;
            m_Command.ExecuteNonQuery();
            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
            HienThiComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
