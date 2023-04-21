using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace major_assignment.information
{
     public class Inf_account
    {
        public Inf_account()
        {

        }

        private String m_username;
        public String username
        {
            get { return m_username; }
            set { m_username = value; }
        }

        private String m_password;
        public String password
        {
            get { return m_password; }
            set { m_password = value; }
        }
    }
}
