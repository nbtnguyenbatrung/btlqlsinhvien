using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace major_assignment.component
{
    public partial class Frm_connect : Office2007RibbonForm
    {
        public Frm_connect()
        {
            InitializeComponent();
        }

        private void btntestconnect_Click(object sender, EventArgs e)
        {
            OleDbConnection m_Conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtserver.Text );
            OleDbCommand m_Cmd = new OleDbCommand("SELECT * FROM TB_ACCOUNT", m_Conn);
            OleDbDataReader m_DReader;

            try
            {
                m_Conn.Open();
                m_DReader = m_Cmd.ExecuteReader();
             
                MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OleDbException sqlEx)
            {
                MessageBoxEx.Show(sqlEx.Message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (m_Conn.State == ConnectionState.Open)
                    m_Conn.Close();

                m_Conn.Dispose();
                m_Cmd.Dispose();
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            XML.XMLWriter("connectxml.xml", txtserver.Text, "", "true");
            this.DialogResult = DialogResult.OK;
        }

        private void btncencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
