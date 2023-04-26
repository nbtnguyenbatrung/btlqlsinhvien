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
    public partial class Frm_themhocvien : Form
    {

        #region Fields
        private static OleDbConnection m_Connection;
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter = new OleDbDataAdapter();
        DataTable table = new DataTable();
        #endregion

        public Frm_themhocvien()
        {
            InitializeComponent();
        }

        private void Frm_themhocvien_Load(object sender, EventArgs e)
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
            cmbkhoa.DataSource = table;
            cmbkhoa.DisplayMember = "name";
            cmbkhoa.ValueMember = "departmentId";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            m_Command = m_Connection.CreateCommand();
            m_Command.CommandText = " insert into tb_student(name,birthday,placeOfBirth,gender,address,departmentId) " +
                "values('" + txttensv.Text.Trim() +
                "','" + dtpns.Value.ToString() + "','" + txtnoisinh.Text.Trim() + "','" +
                txtgt.Text.Trim() + "','" + txtdiachi.Text.Trim() + "'," + cmbkhoa.SelectedValue + ")";
            m_Command.ExecuteNonQuery();

            MessageBox.Show("Thêm học viên thành công", "Thông báo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
