using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace major_assignment.information
{
   public class Inf_department
    {
        public Inf_department()
        {

        }

        private int m_departmentId;
        public int departmentId
        {
            get { return m_departmentId; }
            set { m_departmentId = value; }
        }

        private String m_name;
        public String name
        {
            get { return m_name; }
            set { m_name = value; }
        }
    }
}
