using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace major_assignment.information
{
    class Inf_teacher
    {
        public Inf_teacher()
        {

        }

        private int m_teacherId;
        public int teacherId
        {
            get { return m_teacherId; }
            set { m_teacherId = value; }
        }

        private String m_name;
        public String name
        {
            get { return m_name; }
            set { m_name = value; }
        }

    }
}
