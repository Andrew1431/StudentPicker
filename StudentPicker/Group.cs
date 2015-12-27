using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPicker
{
    class Group
    {
        private List<Student> students;

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public Group()
        {
            students = new List<Student>();
        }
    }
}
