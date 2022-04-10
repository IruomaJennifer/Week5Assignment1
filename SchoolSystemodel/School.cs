using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemodel
{
    internal class School
    {
        public List<Student> Students { get; set; }
        public string Name { get; set; }
        public string SchoolCategory { get; set; }//kindergarten,middle school,high school or elementary
        public List<Teacher> Teachers { get; set; }
        public List<Class> Grades { get; set; }//grades 1...12

        void EnrollInCompetiton() 
        {

        }
        void PayStaff()
        {

        }
    }
}
