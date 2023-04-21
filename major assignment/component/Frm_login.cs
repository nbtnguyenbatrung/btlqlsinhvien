using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace major_assignment.component
{
    public partial class Frm_login : Office2007Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

       

        private void txtdangnhap_TextChanged(object sender, EventArgs e)
        {
            if (this.txtdangnhap.Text != "")
            {
                this.lblusererror.Text = "";
            }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
