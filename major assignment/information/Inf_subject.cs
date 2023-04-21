using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace major_assignment.information
{
    class Inf_subject
    {
        public Inf_subject()
        {

        }

        private int m_subjectId;
        public int subjectId
        {
            get { return m_subjectId; }
            set { m_subjectId = value; }
        }

        private String m_name;
        public String name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        private int m_courseNumber;
        public int courseNumer
        {
            get { return m_courseNumber; }
            set { m_courseNumber = value; }
        }
    }
}
