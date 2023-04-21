using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace major_assignment.information
{
    class Inf_student
    {
        public Inf_student()
        {

        }

        private int m_studentId;
        public int studentId
        {
            get { return m_studentId; }
            set { m_studentId = value; }
        }

        private String m_name;
        public String name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        private DateTime m_birthday;
        public DateTime birthday
        {
            get { return m_birthday; }
            set { m_birthday = value; }
        }

        private String m_placeOfBirth;
        public String placeOfBirth
        {
            get { return m_placeOfBirth; }
            set { m_placeOfBirth = value; }
        }

        private String m_gender;
        public String gender
        {
            get { return m_gender; }
            set { m_gender = value; }
        }

        private String m_address;
        public String address
        {
            get { return m_address; }
            set { m_address = value; }
        }

        public Inf_department m_department;
        public Inf_department department
        {
            get { return m_department; }
            set { m_department = value; }
        }
    }
}
