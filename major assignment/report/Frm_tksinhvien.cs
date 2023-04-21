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
using major_assignment.report;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace major_assignment.report
{
    public partial class Frm_tksinhvien : Form
    {
        public Frm_tksinhvien()
        {
            InitializeComponent();
            dataservice.OpenConnection();
        }

        #region Fields
        Ctr_student m_studentctrl = new Ctr_student();
        Ctr_department m_departmenttctrl = new Ctr_department();
        OleDbConnection conn = new OleDbConnection(dataservice.m_ConnectString);
        #endregion

        private void Frm_tksinhvien_Load(object sender, EventArgs e)
        {
            m_studentctrl.HienThiDS(dgvoutdate, bindingNavigatoroutdate, false,
                false, txtnamesv.Text.Trim(), cmbkhoa.SelectedText);
            m_departmenttctrl.HienThiComboBox(cmbkhoa);
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            m_studentctrl.HienThiDS(dgvoutdate, bindingNavigatoroutdate, cbxtensv.Checked,
                cbxkhoa.Checked, txtnamesv.Text.Trim(), cmbkhoa.SelectedText);
        }

        private void bindingNavigatorrefresh_Click(object sender, EventArgs e)
        {
            m_studentctrl.HienThiDS(dgvoutdate, bindingNavigatoroutdate, false,
               false, txtnamesv.Text.Trim(), cmbkhoa.SelectedText);
            m_departmenttctrl.HienThiComboBox(cmbkhoa);
        }

        private void bindingNavigatorexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvoutdate.SelectedRows)
            {
                Frm_xuat m_hvchungchi = new Frm_xuat(row.Cells["studentId"].Value.ToString());
                m_hvchungchi.Show();
            }
        }
    }
}
